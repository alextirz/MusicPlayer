namespace MusicPlayer
{
    partial class Form1
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
           // System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            musicArea = new FlowLayoutPanel();
            trackBar1 = new MusicTrackBar();
            playListArea = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // musicArea
            // 
            musicArea.AutoScroll = true;
            musicArea.BackColor = Color.FromArgb(80, 80, 80);
            musicArea.Dock = DockStyle.Fill;
            musicArea.Location = new Point(360, 0);
            musicArea.Name = "musicArea";
            musicArea.Size = new Size(998, 618);
            musicArea.TabIndex = 0;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.Black;
            trackBar1.Dock = DockStyle.Bottom;
            trackBar1.Location = new Point(0, 618);
            trackBar1.Margin = new Padding(0);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1358, 125);
            trackBar1.TabIndex = 1;
            // 
            // playListArea
            // 
            playListArea.AutoScroll = true;
            playListArea.BackColor = Color.FromArgb(80, 80, 80);
            playListArea.Dock = DockStyle.Left;
            playListArea.Location = new Point(0, 0);
            playListArea.Margin = new Padding(10);
            playListArea.Name = "playListArea";
            playListArea.Size = new Size(360, 618);
            playListArea.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1358, 743);
            Controls.Add(musicArea);
            Controls.Add(playListArea);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Music Player";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel musicArea;
        private MusicTrackBar trackBar1;
        private FlowLayoutPanel playListArea;
    }
}