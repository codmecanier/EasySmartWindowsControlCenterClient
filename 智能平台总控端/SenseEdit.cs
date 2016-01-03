using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasySmartDataBaseService;
using EasySmartDataBaseService.Service;
using EasySmartDataBaseService.Models;

namespace 智能平台总控端
{
    public partial class SenseEdit : Form
    {
        public int SenseID;
        public int DeviceID;
        public bool IsEdit = false;
        public SenseEdit()
        {
            InitializeComponent();
        }

        private void SenseEdit_Load(object sender, EventArgs e)
        {
            if (IsEdit )
            {
                SensorService ss = new SensorService();
                DeviceSensorView model = ss.GetFirstOrDefault(P => P.SenseID == SenseID,NowUser.CurrentUser);
                Nametext.Text = model.SenseName;
                numericUpDown1.Value = model.SenserAddress;
                numericUpDown3.Value = model.SensorCompiction;
                numericUpDown2.Value = model.SensorBase;
                textBox1.Text = model.SensorUnit;
                richTextBox1.Text = model.SensorInfo;
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void OKbtn_Click_1(object sender, EventArgs e)
        {
            if (!IsEdit)
            {
                SensorService ss = new SensorService();
                DeviceSensorView model = new DeviceSensorView();
                model.SenseName = Nametext.Text.Trim();
                model.SensorBase = (decimal)numericUpDown2.Value;
                model.SenserAddress = (int)numericUpDown1.Value;
                model.SensorCompiction = (decimal)numericUpDown3.Value;
                model.SensorInfo = richTextBox1.Text.Trim();
                model.SensorUnit = textBox1.Text.Trim();
                model.DeviceID = DeviceID;
                ss.AddSensor(model, NowUser.CurrentUser);
            }
            else
            {
                SensorService ss = new SensorService();
                DeviceSensorView model = new DeviceSensorView();
                model.SenseID = SenseID;
                model.SenseName = Nametext.Text.Trim();
                model.SensorBase = numericUpDown2.Value;
                model.SenserAddress = (int)numericUpDown1.Value;
                model.SensorCompiction = numericUpDown3.Value;
                model.SensorInfo = richTextBox1.Text.Trim();
                model.SensorUnit = textBox1.Text.Trim();
                model.DeviceID = DeviceID;
                ss.Update(model, NowUser.CurrentUser);
            }
            this.Close();
        }
    }
}