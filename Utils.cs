using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VideoAndSubJoinerV2 {
    internal class Utils {

        public const string MKV_MP4_AVI_FILTER = "Matroska video files (*.mkv)|*.mkv|MPEG Layer 4 files (*.mp4)|*.mp4|AVI files (*.avi)|*.avi|All files (*.*)|*.*";
        public const string ASS_FILTER = "Advanced SubStation Alpha files(*.ass)|*.ass";
        public const string MKV_FILTER = "Matroska video files (*.mkv)|*.mkv";
        public const string TEMPORARY_SUBTITLE_FILE = "tempass.ass";
        public const string BATCH_FILE = "convert.cmd";

        private Utils() {
        }
        public static DialogResult OpenDialogWithFilter(string filter, out string filePath) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = filter
            };
            DialogResult result = openFileDialog.ShowDialog();
            filePath = openFileDialog.FileName;
            return result;
        }
        public static DialogResult SaveDialogWithFilter(string filter, out string filePath) {
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                FileName = "output.mkv",
                Filter = filter
            };
            DialogResult result = saveFileDialog.ShowDialog();
            filePath = saveFileDialog.FileName;
            return result;
        }
        public static void ShowInfoMessage(string InfoMessage) => MessageBox.Show(InfoMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public static void ShowErrorMessage(string ErrorMessage) => MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public static DialogResult ShowYesNoMessage(string InfoMessage) => MessageBox.Show(InfoMessage, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }
}