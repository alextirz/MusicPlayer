using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicItem : UserControl
    {

        public event EventHandler MusicPlay;
        public event EventHandler MusicHover;
        public MusicItem()
        {
            InitializeComponent();
            RecursiveHandlerHover(itemArea);
            RecursiveHandlerHover(playButton);
            RecursiveHandlerDoubleClick(itemArea);
            playButton.CustomClick += PlayButton_CustomClick;
            Padding = new Padding(2);
            playButton.ButtonImage = Properties.Resources.play;
            playButton.Padding = new Padding(7);
        }

        private void PlayButton_CustomClick(object? sender, EventArgs e)
        {
            //
            MusicPlay.Invoke(this, e);

        }
        public bool ButtonVisible { get; set; }
        public bool ButtonPlay
        {
            set
            {
                if (value)
                {
                    playButton.ButtonImage = Properties.Resources.pause;
                }
                else
                {
                    playButton.ButtonImage = Properties.Resources.play;
                }
            }
        }


        #region RecursiveHandlerHover
        void RecursiveHandlerHover(Control element)
        {
            element.MouseEnter += Element_MouseEnter;
            element.MouseLeave += Element_MouseLeave;
            foreach (Control child in element.Controls)
            {
                RecursiveHandlerHover(child);
            }
        }

        private void Element_MouseEnter(object? sender, EventArgs e)
        {
            if (MusicHover != null)
            {
                MusicHover.Invoke(this, e);
            }

            itemArea.BackColor = Color.CadetBlue;
        }

        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            itemArea.BackColor = Color.DarkSlateGray;
        }
        #endregion

        #region RecursiveHandlerDoubleClick
        void RecursiveHandlerDoubleClick(Control element)
        {
            element.MouseDoubleClick += Element_MouseDoubleClick;

            foreach (Control child in element.Controls)
            {
                RecursiveHandlerDoubleClick(child);
            }
        }

        private void Element_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            MusicPlay.Invoke(this, e);
        }
        #endregion

        #region OnPaint
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            int radius = 50;
            graphicsPath.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            graphicsPath.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            graphicsPath.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            //graphicsPath.CloseFigure();

            Region = new Region(graphicsPath);
            base.OnPaint(e);
        }
        #endregion

        #region Custom properties

        [Category("Track properties")]
        public string Title
        {
            get
            {
                return title.Text;
            }
            set
            {
                title.Text = value;
            }
        }

        [Category("Track properties")]
        public string Description
        {
            get { return description.Text; }
            set { description.Text = value; }
        }

        [Category("Track properties")]
        string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public void SetMusicItemImage(string path)
        {
            string imagePath = path;
            if (imagePath == "default")
                image.Image = Properties.Resources._default;
            else
                image.Image = Image.FromFile(imagePath);
        }
        #endregion

        private void display_Tick(object sender, EventArgs e)
        {


            if (ButtonVisible)
            {
                if (!playButton.Visible)
                {
                    playButton.Visible = true;
                }
                if (playButton.Top > 260)
                {
                    playButton.Top--;
                }
            }
            else
            {
                if (playButton.Top < 280)
                {
                    playButton.Top++;
                }
                else if (playButton.Visible)
                {
                    playButton.Visible = false;
                }
            }

        }


    }
}
