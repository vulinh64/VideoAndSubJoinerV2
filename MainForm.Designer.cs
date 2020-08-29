namespace VideoAndSubJoinerV2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LinkLabelBrowseSutitle = new System.Windows.Forms.LinkLabel();
            this.TextSubtitlePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkLabelBrowseVideo = new System.Windows.Forms.LinkLabel();
            this.TextVideoPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckBoxHWAccel = new System.Windows.Forms.CheckBox();
            this.TextAudioBitrate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextVideoBitrate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextAudioSampleRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextConstantRateFactor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LinkLabelCrazyFacebook = new System.Windows.Forms.LinkLabel();
            this.LinkLabelCrazyYouTube = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LinkLabelBrowseSutitle);
            this.groupBox1.Controls.Add(this.TextSubtitlePath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LinkLabelBrowseVideo);
            this.groupBox1.Controls.Add(this.TextVideoPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video and Subtitle Path";
            // 
            // LinkLabelBrowseSutitle
            // 
            this.LinkLabelBrowseSutitle.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.LinkLabelBrowseSutitle.AutoSize = true;
            this.LinkLabelBrowseSutitle.ForeColor = System.Drawing.Color.White;
            this.LinkLabelBrowseSutitle.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkLabelBrowseSutitle.Location = new System.Drawing.Point(462, 54);
            this.LinkLabelBrowseSutitle.Name = "LinkLabelBrowseSutitle";
            this.LinkLabelBrowseSutitle.Size = new System.Drawing.Size(115, 15);
            this.LinkLabelBrowseSutitle.TabIndex = 4;
            this.LinkLabelBrowseSutitle.TabStop = true;
            this.LinkLabelBrowseSutitle.Text = "Browse subtitle file...";
            this.LinkLabelBrowseSutitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelBrowseSutitle_LinkClicked);
            // 
            // TextSubtitlePath
            // 
            this.TextSubtitlePath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextSubtitlePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSubtitlePath.ForeColor = System.Drawing.Color.White;
            this.TextSubtitlePath.Location = new System.Drawing.Point(105, 51);
            this.TextSubtitlePath.Name = "TextSubtitlePath";
            this.TextSubtitlePath.ReadOnly = true;
            this.TextSubtitlePath.Size = new System.Drawing.Size(347, 23);
            this.TextSubtitlePath.TabIndex = 3;
            this.TextSubtitlePath.Click += new System.EventHandler(this.TextSubtitlePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subtitle file path";
            // 
            // LinkLabelBrowseVideo
            // 
            this.LinkLabelBrowseVideo.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.LinkLabelBrowseVideo.AutoSize = true;
            this.LinkLabelBrowseVideo.ForeColor = System.Drawing.Color.White;
            this.LinkLabelBrowseVideo.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkLabelBrowseVideo.Location = new System.Drawing.Point(462, 25);
            this.LinkLabelBrowseVideo.Name = "LinkLabelBrowseVideo";
            this.LinkLabelBrowseVideo.Size = new System.Drawing.Size(105, 15);
            this.LinkLabelBrowseVideo.TabIndex = 2;
            this.LinkLabelBrowseVideo.TabStop = true;
            this.LinkLabelBrowseVideo.Text = "Browse video file...";
            this.LinkLabelBrowseVideo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelBrowseVideo_LinkClicked);
            // 
            // TextVideoPath
            // 
            this.TextVideoPath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextVideoPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextVideoPath.ForeColor = System.Drawing.Color.White;
            this.TextVideoPath.Location = new System.Drawing.Point(105, 22);
            this.TextVideoPath.Name = "TextVideoPath";
            this.TextVideoPath.ReadOnly = true;
            this.TextVideoPath.Size = new System.Drawing.Size(347, 23);
            this.TextVideoPath.TabIndex = 1;
            this.TextVideoPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextVideoPath_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video file path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckBoxHWAccel);
            this.groupBox2.Controls.Add(this.TextAudioBitrate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TextVideoBitrate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TextAudioSampleRate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TextConstantRateFactor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced settings";
            // 
            // CheckBoxHWAccel
            // 
            this.CheckBoxHWAccel.AutoSize = true;
            this.CheckBoxHWAccel.Checked = true;
            this.CheckBoxHWAccel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxHWAccel.ForeColor = System.Drawing.Color.White;
            this.CheckBoxHWAccel.Location = new System.Drawing.Point(6, 81);
            this.CheckBoxHWAccel.Name = "CheckBoxHWAccel";
            this.CheckBoxHWAccel.Size = new System.Drawing.Size(375, 19);
            this.CheckBoxHWAccel.TabIndex = 9;
            this.CheckBoxHWAccel.Text = "Use Hardware Accelerator (might not work, depending on system)";
            this.CheckBoxHWAccel.UseVisualStyleBackColor = true;
            this.CheckBoxHWAccel.Click += new System.EventHandler(this.CheckBoxHWAccel_Click);
            // 
            // TextAudioBitrate
            // 
            this.TextAudioBitrate.BackColor = System.Drawing.Color.White;
            this.TextAudioBitrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextAudioBitrate.ForeColor = System.Drawing.Color.Black;
            this.TextAudioBitrate.Location = new System.Drawing.Point(446, 52);
            this.TextAudioBitrate.Name = "TextAudioBitrate";
            this.TextAudioBitrate.Size = new System.Drawing.Size(131, 23);
            this.TextAudioBitrate.TabIndex = 8;
            this.TextAudioBitrate.Text = "892";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(308, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Audio bitrate (kbps)";
            // 
            // TextVideoBitrate
            // 
            this.TextVideoBitrate.AutoCompleteCustomSource.AddRange(new string[] {
            "16000",
            "25000"});
            this.TextVideoBitrate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextVideoBitrate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextVideoBitrate.BackColor = System.Drawing.Color.White;
            this.TextVideoBitrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextVideoBitrate.ForeColor = System.Drawing.Color.Black;
            this.TextVideoBitrate.Location = new System.Drawing.Point(161, 52);
            this.TextVideoBitrate.Name = "TextVideoBitrate";
            this.TextVideoBitrate.Size = new System.Drawing.Size(131, 23);
            this.TextVideoBitrate.TabIndex = 7;
            this.TextVideoBitrate.Text = "16000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Video bitrate (kbps)";
            // 
            // TextAudioSampleRate
            // 
            this.TextAudioSampleRate.AutoCompleteCustomSource.AddRange(new string[] {
            "44100",
            "48000",
            "96000"});
            this.TextAudioSampleRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextAudioSampleRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextAudioSampleRate.BackColor = System.Drawing.Color.White;
            this.TextAudioSampleRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextAudioSampleRate.ForeColor = System.Drawing.Color.Black;
            this.TextAudioSampleRate.Location = new System.Drawing.Point(446, 23);
            this.TextAudioSampleRate.Name = "TextAudioSampleRate";
            this.TextAudioSampleRate.Size = new System.Drawing.Size(131, 23);
            this.TextAudioSampleRate.TabIndex = 6;
            this.TextAudioSampleRate.Text = "48000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(308, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Audio Sample Rate (Hz)";
            // 
            // TextConstantRateFactor
            // 
            this.TextConstantRateFactor.BackColor = System.Drawing.Color.White;
            this.TextConstantRateFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextConstantRateFactor.ForeColor = System.Drawing.Color.Black;
            this.TextConstantRateFactor.Location = new System.Drawing.Point(161, 23);
            this.TextConstantRateFactor.Name = "TextConstantRateFactor";
            this.TextConstantRateFactor.Size = new System.Drawing.Size(131, 23);
            this.TextConstantRateFactor.TabIndex = 5;
            this.TextConstantRateFactor.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Constant Rate Factor (CRF)";
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonExecute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonExecute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.ButtonExecute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExecute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonExecute.ForeColor = System.Drawing.Color.Black;
            this.ButtonExecute.Location = new System.Drawing.Point(224, 219);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(75, 23);
            this.ButtonExecute.TabIndex = 10;
            this.ButtonExecute.Text = "&Execute";
            this.ButtonExecute.UseVisualStyleBackColor = false;
            this.ButtonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Location = new System.Drawing.Point(305, 219);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 11;
            this.ButtonExit.Text = "E&xit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LinkLabelCrazyFacebook
            // 
            this.LinkLabelCrazyFacebook.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.LinkLabelCrazyFacebook.AutoSize = true;
            this.LinkLabelCrazyFacebook.ForeColor = System.Drawing.Color.White;
            this.LinkLabelCrazyFacebook.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkLabelCrazyFacebook.Location = new System.Drawing.Point(12, 245);
            this.LinkLabelCrazyFacebook.Name = "LinkLabelCrazyFacebook";
            this.LinkLabelCrazyFacebook.Size = new System.Drawing.Size(142, 15);
            this.LinkLabelCrazyFacebook.TabIndex = 12;
            this.LinkLabelCrazyFacebook.TabStop = true;
            this.LinkLabelCrazyFacebook.Text = "Visit our Facebook page...";
            this.LinkLabelCrazyFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCrazyFacebook_LinkClicked);
            // 
            // LinkLabelCrazyYouTube
            // 
            this.LinkLabelCrazyYouTube.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.LinkLabelCrazyYouTube.AutoSize = true;
            this.LinkLabelCrazyYouTube.ForeColor = System.Drawing.Color.White;
            this.LinkLabelCrazyYouTube.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkLabelCrazyYouTube.Location = new System.Drawing.Point(439, 245);
            this.LinkLabelCrazyYouTube.Name = "LinkLabelCrazyYouTube";
            this.LinkLabelCrazyYouTube.Size = new System.Drawing.Size(156, 15);
            this.LinkLabelCrazyYouTube.TabIndex = 13;
            this.LinkLabelCrazyYouTube.TabStop = true;
            this.LinkLabelCrazyYouTube.Text = "Visit our YouTube Channel...";
            this.LinkLabelCrazyYouTube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCrazyYouTube_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(605, 265);
            this.Controls.Add(this.LinkLabelCrazyYouTube);
            this.Controls.Add(this.LinkLabelCrazyFacebook);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video and Sub Joiner by FeelTheThunder 2.0.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel LinkLabelBrowseSutitle;
        private System.Windows.Forms.TextBox TextSubtitlePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LinkLabelBrowseVideo;
        private System.Windows.Forms.TextBox TextVideoPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextConstantRateFactor;
        private System.Windows.Forms.TextBox TextAudioSampleRate;
        private System.Windows.Forms.TextBox TextAudioBitrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextVideoBitrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonExecute;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.CheckBox CheckBoxHWAccel;
        private System.Windows.Forms.LinkLabel LinkLabelCrazyFacebook;
        private System.Windows.Forms.LinkLabel LinkLabelCrazyYouTube;
    }
}

