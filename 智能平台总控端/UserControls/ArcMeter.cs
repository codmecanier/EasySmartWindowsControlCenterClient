using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace 智能平台总控端
{
    public partial class ArcMeter : UserControl
    {
        Graphics g;

        public Color MeterColor { get; set; }

        public string NameText
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
        public decimal MaxValue { get; set; }
        public decimal MinValue { get; set; }
        private decimal val;
        public string Unit { get; set; }
        public int demic;
        public decimal Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
                label2.Text = val.ToString("f" + demic.ToString()) + "\n" + Unit;
            }
        }
        public Color TextColor
        {
            get
            {
                return label1.ForeColor;
            }
            set
            {
                label1.ForeColor = value;
                label2.ForeColor = value;
            }
        }
        public int ArcWidth { get; set; }
        public ArcMeter()
        {
            InitializeComponent();
            MaxValue = 100;
            MinValue = 0;
            Value = 38;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;
            RefreshArc();
        }
        private void ArcMeter_Load(object sender, EventArgs e)
        {
            label2.Width = this.Height;
        }

        private void RefreshArc()
        {
            Rectangle rect = new Rectangle(label1.Width + (ArcWidth / 2),ArcWidth/2, this.Height - ArcWidth, this.Height - ArcWidth);
            Pen pen = new Pen(MeterColor, ArcWidth);
            pen.LineJoin = LineJoin.Round;
            g.DrawArc(pen, rect, 0, (int)((val - MinValue) / (MaxValue - MinValue) * 360));

        }

        private void ArcMeter_SizeChanged(object sender, EventArgs e)
        {
            label2.Width = this.Height;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
