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
    public partial class PerformEdit : BaseForm
    {
        public int PerformID;
        public int DeviceID;
        public PerformEdit()
        {
            InitializeComponent();
        }

        private void PerformEdit_Load(object sender, EventArgs e)
        {
            if (state == WindowsState.Edit)
            {
                PerformService ss = new PerformService();
                Perform model = ss.GetByFirstOrDefault(P => P.PerformID == PerformID);
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
            if (state == WindowsState.Add)
            {
                PerformService ss = new PerformService();
                Perform model = new Perform();
                model.PerformName = Nametext.Text.Trim();
                model.PerformBase = (int)numericUpDown2.Value;
                model.PerformAddress = (int)numericUpDown1.Value;
                model.PerformCopmcition = (decimal)numericUpDown3.Value;
                model.PerformInfo = richTextBox1.Text.Trim();
                model.PerformUnit = textBox1.Text.Trim();
                model.PerformMaxim = (int)Nummax.Value;
                model.PerformMinum = (int)Nummin.Value;
                ss.Add(model);
                DeviceToPerformService dtss = new DeviceToPerformService();
                DeviceToPerform cck = new DeviceToPerform();
                cck.PerformID = model.PerformID;
                cck.DeviceID = DeviceID;
                dtss.Add(cck);
            }
            else
            {
                PerformService ss = new PerformService();
                Perform model = new Perform();
                model.PerformID = PerformID;
                model.PerformName = Nametext.Text.Trim();
                model.PerformBase = (int)numericUpDown2.Value;
                model.PerformAddress = (int)numericUpDown1.Value;
                model.PerformCopmcition = numericUpDown3.Value;
                model.PerformInfo = richTextBox1.Text.Trim();
                model.PerformUnit = textBox1.Text.Trim();
                model.PerformMaxim = (int)Nummax.Value;
                model.PerformMinum = (int)Nummin.Value;
                ss.Update(model);
            }
            this.Close();
        }

        private void OKbtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
