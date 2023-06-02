namespace MusicPlayer
{
    partial class CustomButton
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
            panel1 = new Panel();
            buttonArea = new TableLayoutPanel();
            button = new Button();
            panel1.SuspendLayout();
            buttonArea.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonArea);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 100);
            panel1.TabIndex = 0;
            // 
            // buttonArea
            // 
            buttonArea.BackColor = Color.Transparent;
            buttonArea.ColumnCount = 1;
            buttonArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonArea.Controls.Add(button, 0, 0);
            buttonArea.Dock = DockStyle.Fill;
            buttonArea.Location = new Point(0, 0);
            buttonArea.Name = "buttonArea";
            buttonArea.RowCount = 1;
            buttonArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonArea.Size = new Size(100, 100);
            buttonArea.TabIndex = 0;
            // 
            // button
            // 
            button.BackColor = Color.Transparent;
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Dock = DockStyle.Fill;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.Location = new Point(7, 7);
            button.Margin = new Padding(7);
            button.Name = "button";
            button.Size = new Size(86, 86);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = false;
            // 
            // CustomButton
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "CustomButton";
            Size = new Size(100, 100);
            panel1.ResumeLayout(false);
            buttonArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel buttonArea;
        private Button button;
    }
}
