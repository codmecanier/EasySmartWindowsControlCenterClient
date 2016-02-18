using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能平台总控端
{
    public partial class ControlButton : UserControl
    {
        public ControlButton()
        {
            InitializeComponent();
        }
        public string Text
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public Image BackGroundImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public Image MoveInImage { get; set; }
        public Image PressingImage { get; set; }

        public Font Font
        {
            get
            {
                return label1.Font;
            }
            set
            {
                label1.Font = value;
            }
        }
        public Color Forecolor
        {
            get
            {
                return label1.ForeColor;
            }
            set
            {
                label1.ForeColor = value;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            if(MoveInImage!=null)
            {
                pictureBox1.BackgroundImage = MoveInImage;
            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (MoveInImage != null)
            {
                pictureBox1.BackgroundImage = BackGroundImage;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (PressingImage != null)
            {
                pictureBox1.BackgroundImage = BackGroundImage;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (PressingImage != null)
            {
                pictureBox1.BackgroundImage = PressingImage;
            }
        }
    }
}
