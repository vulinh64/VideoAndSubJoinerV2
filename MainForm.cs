using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoAndSubJoinerV2 {
    public partial class MainForm : Form {
        public MainForm() => InitializeComponent();
        private void ButtonExit_Click(object sender, EventArgs e) => DoExit();
        private void ButtonExecute_Click(object sender, EventArgs e) => DoExecute();
        private void LinkLabelBrowseVideo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => DoBrowseVideo();
        private void LinkLabelBrowseSutitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => DoBrowseSubtitle();
        private void TextVideoPath_MouseClick(object sender, MouseEventArgs e) => DoBrowseVideo();
        private void TextSubtitlePath_Click(object sender, EventArgs e) => DoBrowseSubtitle();
        private void CheckBoxHWAccel_Click(object sender, EventArgs e) => CheckBoxHWAccel.ForeColor = CheckBoxHWAccel.Checked ? Color.Yellow : Color.White;
        private void LinkLabelCrazyFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => DoVisitFacebook();
        private void LinkLabelCrazyYouTube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => DoVisitYouTube();
        private void DoBrowseVideo() {
            if (Utils.OpenDialogWithFilter(Utils.MKV_MP4_AVI_FILTER, out string videoFilePath).Equals(DialogResult.OK)) {
                TextVideoPath.Text = videoFilePath;
            }
        }
        private void DoBrowseSubtitle() {
            if (Utils.OpenDialogWithFilter(Utils.ASS_FILTER, out string subtitleFilePath).Equals(DialogResult.OK)) {
                TextSubtitlePath.Text = subtitleFilePath;
            }
        }
        private void DoExecute() {
            if (!(IsInfoValid && IsCreateTempSubFileSuccess && IsCreateBatchFileSuccess)) {
                return;
            }
            ProcessStartInfo processStartInfo = new ProcessStartInfo {
                UseShellExecute = true
            };
            if (Utils.ShowYesNoMessage("Batch file created successfully. Do you want to run it now?").Equals(DialogResult.Yes)) {
                processStartInfo.WorkingDirectory = $@"{Application.StartupPath}Working";
                processStartInfo.FileName = Utils.BATCH_FILE;
            } else {
                processStartInfo.FileName = $@"{Application.StartupPath}Working";
                Utils.ShowInfoMessage($"Please run {Utils.BATCH_FILE} directly or edit it with a text editor.");
            }
            Process.Start(processStartInfo);
            DoExit();
        }
        private void DoExit() => Application.Exit();
        private void DoVisitFacebook() {
            ProcessStartInfo processStartInfo = new ProcessStartInfo {
                UseShellExecute = true,
                FileName = "https://facebook.com/CrazyTankersVN"
            };
            Process.Start(processStartInfo);
        }
        private void DoVisitYouTube() {
            ProcessStartInfo processStartInfo = new ProcessStartInfo {
                UseShellExecute = true,
                FileName = "https://youtube.com/c/CrazyTankersVN"
            };
            Process.Start(processStartInfo);
        }
        private bool IsInfoValid => !(IsTextBoxEmpty(TextVideoPath, "You must specify video file path!")
                    || IsTextBoxEmpty(TextSubtitlePath, "You must specify subtitle video path!")
                    || IsTextBoxNotPositiveNumeric(TextConstantRateFactor, "Constant Rate Factor must be a positive number!")
                    || IsTextBoxNotPositiveNumeric(TextAudioSampleRate, "Audio Sample Rate must be a positive number!")
                    || IsTextBoxNotPositiveNumeric(TextVideoBitrate, "Video Bitrate must be a positive number!")
                    || IsTextBoxNotPositiveNumeric(TextAudioBitrate, "Audio Bitrate must be a positive number"));
        private bool IsCreateTempSubFileSuccess {
            get {
                try {
                    System.IO.File.Copy(TextSubtitlePath.Text, $@"{Application.StartupPath}\Working\{Utils.TEMPORARY_SUBTITLE_FILE}", true);
                    return true;
                } catch (Exception ex) {
                    Utils.ShowErrorMessage($"Cannot create temporarily subtitle file.\n\nReason: {ex.Message}");
                    return false;
                }
            }
        }
        private bool IsCreateBatchFileSuccess {
            get {
                if (!Utils.SaveDialogWithFilter(Utils.MKV_FILTER, out string outputFilePath).Equals(DialogResult.OK)) {
                    return false;
                }
                StringBuilder cmd = new StringBuilder();
                cmd.Append("ffmpeg")
                   .Append(" -y -i ")
                   .Append("\"")
                   .Append(TextVideoPath.Text)
                   .Append("\"")
                   .Append(" -crf 10 ")
                   .Append("-b:v ")
                   .Append(TextVideoBitrate.Text)
                   .Append("k ")
                   .Append(" -c:v libx264 ")
                   .Append("-ar ")
                   .Append(TextAudioSampleRate.Text)
                   .Append(" -b:a ")
                   .Append(TextAudioBitrate.Text)
                   .Append("k ")
                   .Append("-c:a flac ")
                   .Append("-vf ")
                   .Append("\"subtitles='")
                   .Append(Utils.TEMPORARY_SUBTITLE_FILE)
                   .Append("'\" ")
                   .Append("\"")
                   .Append(outputFilePath)
                   .Append("\"");
                if (CheckBoxHWAccel.Checked) {
                    cmd.Append(" -hwaccel auto");
                }
                try {
                    System.IO.File.WriteAllLines(Application.StartupPath + @"\Working\" + Utils.BATCH_FILE, new string[] {
                        "@echo off",
                        cmd.ToString(),
                        $"del {Utils.TEMPORARY_SUBTITLE_FILE}",
                        $"del {Utils.BATCH_FILE}"
                    });
                } catch (Exception ex) {
                    Utils.ShowErrorMessage($"Failed to create temporary batch file.\n\nReason: {ex.Message}");
                    return false;
                }
                return true;
            }
        }
        private bool IsTextBoxEmpty(TextBox textBox, string errorMessage) {
            if (textBox.Text.Trim().Equals(string.Empty)) {
                Utils.ShowErrorMessage(errorMessage);
                textBox.Focus();
                return true;
            }
            return false;
        }
        private bool IsTextBoxNotPositiveNumeric(TextBox textBox, string errorMessage) {
            try {
                if (int.Parse(textBox.Text) > 0) {
                    return false;
                }
                Utils.ShowErrorMessage(errorMessage);
                textBox.Focus();
                return true;
            } catch (Exception ex) {
                Utils.ShowErrorMessage($"{errorMessage}\n\nAdditional info: {ex.Message}");
                return true;
            }
        }
    }
}