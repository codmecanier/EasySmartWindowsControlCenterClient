using AGaugeApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能平台总控端
{
    public partial class ControlPanelEditor : Form
    {
        public int DeviceID;
        PickBox pb = new PickBox();
        public ControlPanelEditor()
        {
            InitializeComponent();
        }

        private void ControlPanelEditor_Load(object sender, EventArgs e)
        {
        }

        private void aGauge1_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)listBox1.SelectedItem)
            {
                case "标签":
                    {
                        Label lb = new Label();
                        lb.Text = "文字";
                        lb.AutoSize = true;
                        lb.Name = "文字";
                        lb.Click += Control_Click;
                        pb.WireControl(lb);
                        panel4.Controls.Add(lb);
                        break;
                    }
                case "仪表控件":
                    {
                        AGauge ag = new AGauge();
                        ag.Width = 200;
                        ag.Height = 200;
                        ag.Click += Control_Click;
                        pb.WireControl(ag);
                        panel4.Controls.Add(ag);
                        break;
                    }
                case "图片":
                    {
                        PictureBox ag = new PictureBox();
                        ag.BackColor = Color.Gray;
                        ag.Width = 128;
                        ag.Height = 128;
                        ag.SizeMode = PictureBoxSizeMode.StretchImage;
                        ag.Click += Control_Click;
                        pb.WireControl(ag);
                        panel4.Controls.Add(ag);
                        break;
                    }
            }
        }
        private void Control_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = sender;
        }
    }
}
