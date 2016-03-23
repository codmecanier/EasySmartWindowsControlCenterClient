using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能平台总控端.MyControls
{
    class MyNumericUpDown
    {
        public string Name { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public string Text { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Font Font { get; set; }
        public decimal  Maxim { get; set; }
        public decimal Minim { get; set; }
        public decimal Value { get; set; }
        public int DecimalPlaces { get; set; }
        public decimal Increment { get; set; }
        public NumericUpDown Control
        {
            get
            {
                NumericUpDown lb = new NumericUpDown();
                lb.Name = Name;
                lb.ForeColor = ForeColor;
                lb.BackColor = BackColor;
                lb.Text = Text;
                lb.Location = Location;
                lb.Size = Size;
                lb.Font = Font;
                lb.Maximum = Maxim;
                lb.Minimum = Minim;
                lb.Value = Value;
                lb.DecimalPlaces = DecimalPlaces;
                lb.Increment = Increment;
                return lb;
            }
            set
            {
                Name = value.Name;
                ForeColor = value.ForeColor;
                BackColor = value.BackColor;
                Text = value.Text;
                Location = value.Location;
                Size = value.Size;
                Font = value.Font;
                Minim = value.Minimum;
                Maxim = value.Maximum;
                Value = value.Value;
                DecimalPlaces = DecimalPlaces;
                Increment = Increment;
            }
        }
    }
}
