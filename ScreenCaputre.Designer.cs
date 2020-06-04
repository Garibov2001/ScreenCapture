namespace ScreenCapture
{
    partial class ScreenCaputre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenCaputre));
            this.captureCaunterLabel = new System.Windows.Forms.Label();
            this.captureTimer = new System.Windows.Forms.Timer(this.components);
            this.programStatus = new System.Windows.Forms.Label();
            this.captureCounter = new System.Windows.Forms.Label();
            this.timerCheckBox = new System.Windows.Forms.CheckBox();
            this.cleanDirectoryButton = new System.Windows.Forms.Button();
            this.intervalSettings = new System.Windows.Forms.NumericUpDown();
            this.captureIntervalLabel = new System.Windows.Forms.Label();
            this.captureNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.minimuzePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimuzePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captureCaunterLabel
            // 
            this.captureCaunterLabel.AutoSize = true;
            this.captureCaunterLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureCaunterLabel.Location = new System.Drawing.Point(17, 47);
            this.captureCaunterLabel.Name = "captureCaunterLabel";
            this.captureCaunterLabel.Size = new System.Drawing.Size(214, 26);
            this.captureCaunterLabel.TabIndex = 0;
            this.captureCaunterLabel.Text = "The number of capture:";
            // 
            // captureTimer
            // 
            this.captureTimer.Enabled = true;
            this.captureTimer.Interval = 5000;
            this.captureTimer.Tick += new System.EventHandler(this.captureTimer_Tick);
            // 
            // programStatus
            // 
            this.programStatus.AutoSize = true;
            this.programStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programStatus.Location = new System.Drawing.Point(17, 88);
            this.programStatus.Name = "programStatus";
            this.programStatus.Size = new System.Drawing.Size(211, 25);
            this.programStatus.TabIndex = 3;
            this.programStatus.Text = "Program Status : Good";
            // 
            // captureCounter
            // 
            this.captureCounter.AutoSize = true;
            this.captureCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.captureCounter.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureCounter.Location = new System.Drawing.Point(249, 47);
            this.captureCounter.Name = "captureCounter";
            this.captureCounter.Size = new System.Drawing.Size(40, 28);
            this.captureCounter.TabIndex = 5;
            this.captureCounter.Text = "   0";
            // 
            // timerCheckBox
            // 
            this.timerCheckBox.AutoSize = true;
            this.timerCheckBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerCheckBox.Location = new System.Drawing.Point(512, 88);
            this.timerCheckBox.Name = "timerCheckBox";
            this.timerCheckBox.Size = new System.Drawing.Size(85, 27);
            this.timerCheckBox.TabIndex = 6;
            this.timerCheckBox.Text = "PAUSE";
            this.timerCheckBox.UseVisualStyleBackColor = true;
            this.timerCheckBox.CheckedChanged += new System.EventHandler(this.timerCheckBox_CheckedChanged);
            // 
            // cleanDirectoryButton
            // 
            this.cleanDirectoryButton.Enabled = false;
            this.cleanDirectoryButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanDirectoryButton.Location = new System.Drawing.Point(457, 125);
            this.cleanDirectoryButton.Name = "cleanDirectoryButton";
            this.cleanDirectoryButton.Size = new System.Drawing.Size(140, 32);
            this.cleanDirectoryButton.TabIndex = 7;
            this.cleanDirectoryButton.Text = "Clean The Directory";
            this.cleanDirectoryButton.UseVisualStyleBackColor = true;
            this.cleanDirectoryButton.Click += new System.EventHandler(this.cleanDirectoryButton_Click);
            // 
            // intervalSettings
            // 
            this.intervalSettings.Enabled = false;
            this.intervalSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalSettings.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intervalSettings.Location = new System.Drawing.Point(266, 125);
            this.intervalSettings.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intervalSettings.Name = "intervalSettings";
            this.intervalSettings.ReadOnly = true;
            this.intervalSettings.Size = new System.Drawing.Size(120, 31);
            this.intervalSettings.TabIndex = 8;
            this.intervalSettings.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intervalSettings.ValueChanged += new System.EventHandler(this.intervalSettings_ValueChanged);
            // 
            // captureIntervalLabel
            // 
            this.captureIntervalLabel.AutoSize = true;
            this.captureIntervalLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureIntervalLabel.Location = new System.Drawing.Point(17, 127);
            this.captureIntervalLabel.Name = "captureIntervalLabel";
            this.captureIntervalLabel.Size = new System.Drawing.Size(243, 25);
            this.captureIntervalLabel.TabIndex = 9;
            this.captureIntervalLabel.Text = "Capture Interval in second:";
            // 
            // captureNotifyIcon
            // 
            this.captureNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("captureNotifyIcon.Icon")));
            this.captureNotifyIcon.Text = "Screen Capture";
            this.captureNotifyIcon.Visible = true;
            this.captureNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.captureNotifyIcon_MouseClick);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Image = global::ScreenCapture.Properties.Resources.closeIcon;
            this.closePictureBox.Location = new System.Drawing.Point(574, 13);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(23, 21);
            this.closePictureBox.TabIndex = 11;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // minimuzePictureBox
            // 
            this.minimuzePictureBox.Image = global::ScreenCapture.Properties.Resources.minimizeIcon;
            this.minimuzePictureBox.Location = new System.Drawing.Point(536, 13);
            this.minimuzePictureBox.Name = "minimuzePictureBox";
            this.minimuzePictureBox.Size = new System.Drawing.Size(23, 21);
            this.minimuzePictureBox.TabIndex = 10;
            this.minimuzePictureBox.TabStop = false;
            this.minimuzePictureBox.Click += new System.EventHandler(this.minimuzePictureBox_Click);
            // 
            // ScreenCaputre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 181);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.minimuzePictureBox);
            this.Controls.Add(this.captureIntervalLabel);
            this.Controls.Add(this.intervalSettings);
            this.Controls.Add(this.cleanDirectoryButton);
            this.Controls.Add(this.timerCheckBox);
            this.Controls.Add(this.captureCounter);
            this.Controls.Add(this.programStatus);
            this.Controls.Add(this.captureCaunterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScreenCaputre";
            this.Text = "Screen Capture";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenCaputre_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenCaputre_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.intervalSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimuzePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label captureCaunterLabel;
        private System.Windows.Forms.Timer captureTimer;
        private System.Windows.Forms.Label programStatus;
        private System.Windows.Forms.Label captureCounter;
        private System.Windows.Forms.CheckBox timerCheckBox;
        private System.Windows.Forms.Button cleanDirectoryButton;
        private System.Windows.Forms.NumericUpDown intervalSettings;
        private System.Windows.Forms.Label captureIntervalLabel;
        private System.Windows.Forms.NotifyIcon captureNotifyIcon;
        private System.Windows.Forms.PictureBox minimuzePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
    }
}

