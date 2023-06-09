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
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
            button.Margin = new Padding(7);
            RecursiveHandlerHover(buttonArea);
            RecursiveHandlerClick(buttonArea);
        }
        public event EventHandler CustomClick;

        public Image ButtonImage
        {
            get
            {
                return button.BackgroundImage;
            }
            set
            {
                button.BackgroundImage = value;
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
            button.Margin = new Padding(5);
        }

        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            button.Margin = new Padding(7);
        }
        #endregion

        #region RecursiveHandlerClick
        void RecursiveHandlerClick(Control element)
        {
            element.MouseClick += Element_MouseClick;

            foreach (Control child in element.Controls)
            {
                RecursiveHandlerClick(child);
            }
        }

        private void Element_MouseClick(object? sender, MouseEventArgs e)
        {
            CustomClick.Invoke(this, e);
        }
        #endregion
    }
}
