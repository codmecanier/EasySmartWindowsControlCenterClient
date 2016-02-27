using EasySmartDataBaseService.Models;
using EasySmartDataBaseService.Service;
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
    public partial class PerformEdit : Form
    {
        public int PerformID;
        public int DeviceID;
        public bool IsEdit = false;
        public PerformEdit()
        {
            InitializeComponent();
        }

        private void PerformEdit_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                PerformService ss = new PerformService();
                DevicePerformView model = ss.GetFirstOrDefault(P => P.PerformID == PerformID,NowUser.CurrentUser);
                Nametext.Text = model.PerformName;
                numericUpDown1.Value = model.PerformAddress;
                numericUpDown3.Value = model.PerformCopmcition;
                numericUpDown2.Value = model.PerformBase;
                textBox1.Text = model.PerformUnit;
                richTextBox1.Text = model.PerformInfo;
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            if (!IsEdit)
            {
                PerformService ss = new PerformService();
                DevicePerformView model = new DevicePerformView();
                model.PerformName = Nametext.Text.Trim();
                model.PerformBase = (int)numericUpDown2.Value;
                model.PerformAddress = (int)numericUpDown1.Value;
                model.PerformCopmcition = (decimal)numericUpDown3.Value;
                model.PerformInfo = richTextBox1.Text.Trim();
                model.PerformUnit = textBox1.Text.Trim();
                model.PerformMaxim = (int)Nummax.Value;
                model.PerformMinum = (int)Nummin.Value;
                model.DeviceID = DeviceID;
                ss.AddPerform(model,NowUser.CurrentUser);
            }
            else
            {
                PerformService ss = new PerformService();
                DevicePerformView model = new DevicePerformView();
                model.PerformID = PerformID;
                model.PerformName = Nametext.Text.Trim();
                model.PerformBase = (int)numericUpDown2.Value;
                model.PerformAddress = (int)numericUpDown1.Value;
                model.PerformCopmcition = numericUpDown3.Value;
                model.PerformInfo = richTextBox1.Text.Trim();
                model.PerformUnit = textBox1.Text.Trim();
                model.PerformMaxim = (int)Nummax.Value;
                model.PerformMinum = (int)Nummin.Value;
                model.DeviceID = DeviceID;
                ss.Update(model,NowUser.CurrentUser);
            }
            this.Close();
        }

        private void OKbtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
