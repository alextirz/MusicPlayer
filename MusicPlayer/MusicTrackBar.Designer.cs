namespace MusicPlayer
{
    partial class MusicTrackBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicTrackBar));
            trackBarArea = new TableLayoutPanel();
            progress = new TableLayoutPanel();
            whiteLine = new Label();
            label1 = new Label();
            controlArea = new TableLayoutPanel();
            controlSector = new TableLayoutPanel();
            buttonPlayPause = new CustomButton();
            buttonVolumeDown = new CustomButton();
            buttonPrevious = new CustomButton();
            buttonNext = new CustomButton();
            buttonVolumeUp = new CustomButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            trackBar1 = new TrackBar();
            audioTime = new System.Windows.Forms.Timer(components);
            trackBarArea.SuspendLayout();
            progress.SuspendLayout();
            controlArea.SuspendLayout();
            controlSector.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBarArea
            // 
            trackBarArea.BackColor = Color.DarkSlateGray;
            trackBarArea.ColumnCount = 1;
            trackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            trackBarArea.Controls.Add(progress, 0, 0);
            trackBarArea.Controls.Add(label1, 0, 2);
            trackBarArea.Controls.Add(controlArea, 0, 1);
            trackBarArea.Dock = DockStyle.Fill;
            trackBarArea.Location = new Point(0, 0);
            trackBarArea.Margin = new Padding(0);
            trackBarArea.Name = "trackBarArea";
            trackBarArea.RowCount = 3;
            trackBarArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            trackBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            trackBarArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            trackBarArea.Size = new Size(566, 92);
            trackBarArea.TabIndex = 0;
            // 
            // progress
            // 
            progress.ColumnCount = 2;
            progress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            progress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            progress.Controls.Add(whiteLine, 0, 0);
            progress.Dock = DockStyle.Fill;
            progress.Location = new Point(0, 0);
            progress.Margin = new Padding(0);
            progress.Name = "progress";
            progress.RowCount = 1;
            progress.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            progress.Size = new Size(566, 6);
            progress.TabIndex = 0;
            progress.MouseClick += progress_MouseClick;
            // 
            // whiteLine
            // 
            whiteLine.AutoSize = true;
            whiteLine.BackColor = SystemColors.ButtonHighlight;
            whiteLine.Dock = DockStyle.Fill;
            whiteLine.Location = new Point(0, 0);
            whiteLine.Margin = new Padding(0);
            whiteLine.Name = "whiteLine";
            whiteLine.Size = new Size(1, 6);
            whiteLine.TabIndex = 0;
            whiteLine.MouseClick += progress_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // controlArea
            // 
            controlArea.ColumnCount = 3;
            controlArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            controlArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            controlArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            controlArea.Controls.Add(controlSector, 1, 0);
            controlArea.Controls.Add(tableLayoutPanel1, 2, 0);
            controlArea.Dock = DockStyle.Fill;
            controlArea.Location = new Point(4, 9);
            controlArea.Margin = new Padding(4, 3, 4, 3);
            controlArea.Name = "controlArea";
            controlArea.RowCount = 1;
            controlArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlArea.Size = new Size(558, 62);
            controlArea.TabIndex = 2;
            // 
            // controlSector
            // 
            controlSector.BackColor = Color.DarkSlateGray;
            controlSector.ColumnCount = 5;
            controlSector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSector.Controls.Add(buttonPlayPause, 2, 0);
            controlSector.Controls.Add(buttonVolumeDown, 0, 0);
            controlSector.Controls.Add(buttonPrevious, 1, 0);
            controlSector.Controls.Add(buttonNext, 3, 0);
            controlSector.Controls.Add(buttonVolumeUp, 4, 0);
            controlSector.Dock = DockStyle.Fill;
            controlSector.Location = new Point(105, 1);
            controlSector.Margin = new Padding(1);
            controlSector.Name = "controlSector";
            controlSector.RowCount = 1;
            controlSector.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlSector.Size = new Size(348, 60);
            controlSector.TabIndex = 0;
            // 
            // buttonPlayPause
            // 
            buttonPlayPause.BackColor = Color.DarkSlateGray;
            buttonPlayPause.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPlayPause.ButtonImage = (Image)resources.GetObject("buttonPlayPause.ButtonImage");
            buttonPlayPause.Dock = DockStyle.Fill;
            buttonPlayPause.Location = new Point(142, 3);
            buttonPlayPause.Margin = new Padding(4, 3, 4, 3);
            buttonPlayPause.Name = "buttonPlayPause";
            buttonPlayPause.Size = new Size(61, 54);
            buttonPlayPause.TabIndex = 0;
            // 
            // buttonVolumeDown
            // 
            buttonVolumeDown.BackColor = Color.DarkSlateGray;
            buttonVolumeDown.ButtonImage = Properties.Resources.mute;
            buttonVolumeDown.Dock = DockStyle.Fill;
            buttonVolumeDown.Location = new Point(4, 3);
            buttonVolumeDown.Margin = new Padding(4, 3, 4, 3);
            buttonVolumeDown.Name = "buttonVolumeDown";
            buttonVolumeDown.Size = new Size(61, 54);
            buttonVolumeDown.TabIndex = 1;
            // 
            // buttonPrevious
            // 
            buttonPrevious.BackColor = Color.DarkSlateGray;
            buttonPrevious.ButtonImage = Properties.Resources.rewind;
            buttonPrevious.Dock = DockStyle.Fill;
            buttonPrevious.Location = new Point(73, 3);
            buttonPrevious.Margin = new Padding(4, 3, 4, 3);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(61, 54);
            buttonPrevious.TabIndex = 1;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.DarkSlateGray;
            buttonNext.ButtonImage = Properties.Resources.forward;
            buttonNext.Dock = DockStyle.Fill;
            buttonNext.Location = new Point(211, 3);
            buttonNext.Margin = new Padding(4, 3, 4, 3);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(61, 54);
            buttonNext.TabIndex = 1;
            // 
            // buttonVolumeUp
            // 
            buttonVolumeUp.BackColor = Color.DarkSlateGray;
            buttonVolumeUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVolumeUp.ButtonImage = Properties.Resources.speaker;
            buttonVolumeUp.Dock = DockStyle.Fill;
            buttonVolumeUp.Location = new Point(280, 3);
            buttonVolumeUp.Margin = new Padding(4, 3, 4, 3);
            buttonVolumeUp.Name = "buttonVolumeUp";
            buttonVolumeUp.Size = new Size(64, 54);
            buttonVolumeUp.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(trackBar1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(457, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(98, 56);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Fill;
            trackBar1.Location = new Point(3, 3);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(43, 50);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // audioTime
            // 
            audioTime.Interval = 1000;
            audioTime.Tick += audioTime_Tick;
            // 
            // MusicTrackBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(trackBarArea);
            Margin = new Padding(0);
            Name = "MusicTrackBar";
            Size = new Size(566, 92);
            trackBarArea.ResumeLayout(false);
            trackBarArea.PerformLayout();
            progress.ResumeLayout(false);
            progress.PerformLayout();
            controlArea.ResumeLayout(false);
            controlSector.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel trackBarArea;
        private TableLayoutPanel progress;
        private Label whiteLine;
        private Label label1;
        private System.Windows.Forms.Timer audioTime;
        private TableLayoutPanel controlArea;
        private TableLayoutPanel controlSector;
        private CustomButton buttonPlayPause;
        private CustomButton buttonPrevious;
        private CustomButton buttonNext;
        private CustomButton buttonVolumeUp;
        private CustomButton buttonVolumeDown;
        private TableLayoutPanel tableLayoutPanel1;
        private TrackBar trackBar1;
    }
}
