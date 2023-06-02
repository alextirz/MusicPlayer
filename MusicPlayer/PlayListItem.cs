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
    public partial class PlayListItem : UserControl
    {
        public PlayListItem()
        {
            InitializeComponent();
            RecursiveHandlerHover(this);
            RecursiveHandlerDoubleClick(this);
        }

        public event EventHandler PlayListItemChanged;

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
            BackColor = Color.CadetBlue;
        }

        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.DarkSlateGray;
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
            PlayListItemChanged.Invoke(this, e);
        }
        #endregion

        #region Playlist properties

        [Category("Playlist properties")]
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

        [Category("Playlist properties")]
        public string Description
        {
            get { return description.Text; }
            set { description.Text = value; }
        }

        [Category("Playlist properties")]
        string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public Image ImageCover
        {
            set {  pictureBox1.Image = value; }
        }
        #endregion

    }
}
