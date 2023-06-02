namespace MusicPlayer
{
    partial class MusicItem
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
            itemArea = new TableLayoutPanel();
            image = new PictureBox();
            title = new Label();
            description = new Label();
            playButton = new CustomButton();
            display = new System.Windows.Forms.Timer(components);
            itemArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // itemArea
            // 
            itemArea.BackColor = Color.DarkSlateGray;
            itemArea.ColumnCount = 1;
            itemArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            itemArea.Controls.Add(image, 0, 0);
            itemArea.Controls.Add(title, 0, 1);
            itemArea.Controls.Add(description, 0, 2);
            itemArea.Dock = DockStyle.Fill;
            itemArea.Location = new Point(0, 0);
            itemArea.Margin = new Padding(4, 5, 4, 5);
            itemArea.Name = "itemArea";
            itemArea.Padding = new Padding(29, 33, 29, 33);
            itemArea.RowCount = 3;
            itemArea.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            itemArea.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            itemArea.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            itemArea.Size = new Size(344, 475);
            itemArea.TabIndex = 1;
            // 
            // image
            // 
            image.Dock = DockStyle.Fill;
            image.Image = Properties.Resources.kimetsu_no_yaiba_11;
            image.Location = new Point(29, 33);
            image.Margin = new Padding(0);
            image.Name = "image";
            image.Size = new Size(286, 286);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 0;
            image.TabStop = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Dock = DockStyle.Fill;
            title.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.WhiteSmoke;
            title.Location = new Point(33, 319);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(278, 61);
            title.TabIndex = 1;
            title.Text = "title";
            title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            description.ForeColor = SystemColors.ControlLight;
            description.Location = new Point(33, 380);
            description.Margin = new Padding(4, 0, 4, 0);
            description.Name = "description";
            description.Size = new Size(278, 62);
            description.TabIndex = 2;
            description.Text = "description";
            description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // playButton
            // 
            playButton.BackColor = Color.Teal;
            playButton.ButtonImage = null;
            playButton.ForeColor = SystemColors.ControlText;
            playButton.Location = new Point(250, 260);
            playButton.Name = "playButton";
            playButton.Size = new Size(75, 75);
            playButton.TabIndex = 2;
            playButton.Visible = false;
            // 
            // display
            // 
            display.Enabled = true;
            display.Interval = 10;
            display.Tick += display_Tick;
            // 
            // MusicItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(playButton);
            Controls.Add(itemArea);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MusicItem";
            Size = new Size(344, 475);
            itemArea.ResumeLayout(false);
            itemArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel itemArea;
        private PictureBox image;
        private Label title;
        private Label description;
        private CustomButton playButton;
        private System.Windows.Forms.Timer display;
    }
}
