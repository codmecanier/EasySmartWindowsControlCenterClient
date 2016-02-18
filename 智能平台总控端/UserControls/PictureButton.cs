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
    public partial class PictureButton : UserControl
    {
        public PictureButton()
        {
            InitializeComponent();
        }
        public string LabelText
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
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
            this.OnMouseEnter(e);
            if(MoveInImage!=null)
            {
                pictureBox1.BackgroundImage = MoveInImage;
            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
            if (MoveInImage != null)
            {
                pictureBox1.BackgroundImage = BackGroundImage;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            this.OnMouseUp(e);
            if (PressingImage != null)
            {
                pictureBox1.BackgroundImage = BackGroundImage;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
            if (PressingImage != null)
            {
                pictureBox1.BackgroundImage = PressingImage;
            }
        }
    }
}
