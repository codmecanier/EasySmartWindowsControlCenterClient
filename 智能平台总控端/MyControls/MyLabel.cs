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
    public class MyLabel
    {
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public string Text { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Font Font { get; set; }

        public Label Control
        {
            get
            {
                Label lb = new Label();
                lb.ForeColor = ForeColor;
                lb.BackColor = BackColor;
                lb.Text = Text;
                lb.Location = Location;
                lb.Size = Size;
                lb.Font = Font;
                return lb;
            }
            set
            {
                ForeColor = value.ForeColor;
                BackColor = value.BackColor;
                Text = value.Text;
                Location = value.Location;
                Size = value.Size;
                Font = value.Font;
            }
        }
    }
}
