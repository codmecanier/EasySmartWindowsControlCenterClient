using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能平台总控端.MyControls
{
    [Serializable]
    public class MyPictureBox
    {
        public Color BackColor { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Image Image { get; set; }
        public PictureBoxSizeMode SizeMode { get; set; }

        public PictureBox Control
        {
            get
            {
                PictureBox lb = new PictureBox();
                lb.Location = Location;
                lb.Size = Size;
                lb.SizeMode = SizeMode;
                lb.Image = Image;
                return lb;
            }
            set
            {
                BackColor = value.BackColor;
                Location = value.Location;
                Size = value.Size;
                SizeMode = value.SizeMode;
                Image = value.Image;
            }
        }
    }
}
