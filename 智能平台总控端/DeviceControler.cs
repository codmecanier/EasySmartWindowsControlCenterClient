using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 智能平台总控端.Models;
using 智能平台总控端.Service;

namespace 智能平台总控端
{
    public partial class DeviceControler : Form
    {
        public int DeviceID;
        public DeviceControler()
        {
            InitializeComponent();
        }

        private void DeviceControler_Load(object sender, EventArgs e)
        {
            DisplaySensors();
            DisplayPerforms();
            pictureBox2.Visible = false;
        }
        private GroupBox NewSensorController(DeviceSensorView model)
        {
            GroupBox gb = new GroupBox();
            Label lb = new Label();
            TextBox tb = new TextBox();
            ProgressBar pb = new ProgressBar();
            gb.Controls.Add(lb);
            gb.Controls.Add(pb);
            gb.Controls.Add(tb);
            gb.Name = model.SenseID.ToString();
            gb.Size = new System.Drawing.Size(474, 93);
            gb.Text = model.SenseName;
            lb.Location = new System.Drawing.Point(13, 40);
            lb.Size = new System.Drawing.Size(69, 25);
            lb.Text = "状态：";
            pb.Location = new System.Drawing.Point(88, 32);
            pb.Size = new System.Drawing.Size(198, 41);
            pb.Maximum = (int)model.SensorMaxim;
            pb.Minimum = (int)model.SensorMinim;
            pb.Value = (int)model.SensorOutPut;
            tb.Location = new System.Drawing.Point(292, 37);
            tb.Size = new System.Drawing.Size(176, 33);
            tb.Text = model.SensorOutPut.ToString();
            tb.Text += model.SensorUnit;
            return gb;
        }
        private GroupBox NewPerformController(DevicePerformView model)
        {
            GroupBox gb = new GroupBox();
            Label lb = new Label();
            NumericUpDown tb = new NumericUpDown();
            TrackBar pb = new TrackBar();
            gb.Controls.Add(lb);
            gb.Controls.Add(pb);
            gb.Controls.Add(tb);
            gb.Name = model.PerformID.ToString();
            gb.Size = new System.Drawing.Size(474, 93);
            gb.Text = model.PerformName;
            lb.Location = new System.Drawing.Point(13, 40);
            lb.Size = new System.Drawing.Size(69, 25);
            lb.Text = "状态：";
            pb.Location = new System.Drawing.Point(88, 32);
            pb.Size = new System.Drawing.Size(198, 41);
            pb.Maximum = (int)model.PerformMaxim;
            pb.Minimum = (int)model.PerformMinum;
            pb.Value = (int)model.PerformInPut;
            pb.TickStyle = TickStyle.Both;
            tb.Location = new System.Drawing.Point(292, 37);
            tb.Size = new System.Drawing.Size(176, 33);
            tb.Maximum = model.PerformMaxim;
            tb.Minimum = model.PerformMinum;
            tb.Value = model.PerformInPut;
            tb.DecimalPlaces = 8;
            pb.MouseUp += TrackUpdate;
            tb.ValueChanged += NumericUpdate;
            pb.Name = model.PerformID.ToString() + "T";
            tb.Name = model.PerformID.ToString() + "N";
            return gb;
        }
        private void DisplaySensors()
        {
            DeviceSensorViewService model = new DeviceSensorViewService();
            IEnumerable<DeviceSensorView> list = model.GetByCondition(P => P.DeviceID == DeviceID);
            flowLayoutPanel1.Controls.Clear();
            foreach (DeviceSensorView models in list)
            {
                GroupBox box = NewSensorController(models);
                flowLayoutPanel1.Controls.Add(box);
            }

        }

        private void DisplayPerforms()
        {
            DevicePerformViewService model = new DevicePerformViewService();
            IEnumerable<DevicePerformView> list = model.GetByCondition(P => P.DeviceID == DeviceID);
            flowLayoutPanel2.Controls.Clear();
            foreach (DevicePerformView models in list)
            {
                GroupBox box = NewPerformController(models);
                flowLayoutPanel2.Controls.Add(box);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplaySensors();
            DisplayPerforms();
        }
        private void NumericUpdate(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            int id = int.Parse(num.Name.Split('N')[0]);
            TrackBar ctrl = this.Controls.Find(id.ToString() + "T",true)[0] as TrackBar;
            ctrl.Value = (int)num.Value;
            pictureBox2.Visible = true;
            this.Refresh();
            PerformService ps = new PerformService();
            Perform model = ps.GetByFirstOrDefault(P => P.PerformID==id);
            model.PerformInPut = num.Value;
            ps.Update(model);
            pictureBox2.Visible = false;
            this.Refresh();
        }
        private void TrackUpdate(object sender, EventArgs e)
        {
            TrackBar num = (TrackBar)sender;
            int id = int.Parse(num.Name.Split('T')[0]);
            NumericUpDown ctrl = this.Controls.Find(id.ToString() + "N", true)[0] as NumericUpDown;
            ctrl.Value = (decimal)num.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
