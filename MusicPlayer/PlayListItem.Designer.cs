namespace MusicPlayer
{
    partial class PlayListItem
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
            playListArea = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            titleArea = new TableLayoutPanel();
            title = new Label();
            description = new Label();
            playListArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            titleArea.SuspendLayout();
            SuspendLayout();
            // 
            // playListArea
            // 
            playListArea.BackColor = Color.Transparent;
            playListArea.ColumnCount = 2;
            playListArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            playListArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            playListArea.Controls.Add(pictureBox1, 0, 0);
            playListArea.Controls.Add(titleArea, 1, 0);
            playListArea.Dock = DockStyle.Fill;
            playListArea.Location = new Point(7, 7);
            playListArea.Name = "playListArea";
            playListArea.RowCount = 1;
            playListArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            playListArea.Size = new Size(326, 76);
            playListArea.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // titleArea
            // 
            titleArea.BackColor = Color.Transparent;
            titleArea.ColumnCount = 1;
            titleArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            titleArea.Controls.Add(title, 0, 0);
            titleArea.Controls.Add(description, 0, 1);
            titleArea.Dock = DockStyle.Fill;
            titleArea.Location = new Point(70, 0);
            titleArea.Margin = new Padding(0);
            titleArea.Name = "titleArea";
            titleArea.RowCount = 2;
            titleArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            titleArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            titleArea.Size = new Size(256, 76);
            titleArea.TabIndex = 1;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Dock = DockStyle.Fill;
            title.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.WhiteSmoke;
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(250, 38);
            title.TabIndex = 0;
            title.Text = "label1";
            // 
            // description
            // 
            description.AutoSize = true;
            description.BackColor = Color.Transparent;
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Comic Sans MS", 8F, FontStyle.Regular, GraphicsUnit.Point);
            description.ForeColor = Color.WhiteSmoke;
            description.ImageAlign = ContentAlignment.MiddleLeft;
            description.Location = new Point(3, 38);
            description.Name = "description";
            description.Size = new Size(250, 38);
            description.TabIndex = 1;
            description.Text = "label2";
            // 
            // PlayListItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(playListArea);
            Name = "PlayListItem";
            Padding = new Padding(7);
            Size = new Size(340, 90);
            playListArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            titleArea.ResumeLayout(false);
            titleArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel playListArea;
        private PictureBox pictureBox1;
        private TableLayoutPanel titleArea;
        private Label title;
        private Label description;
    }
}
