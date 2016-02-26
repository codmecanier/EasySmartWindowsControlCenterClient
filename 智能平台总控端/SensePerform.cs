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
    public partial class SensePerform : Form
    {
        public int DeviceID;
        public SensePerform()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SensePerform_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        public void Display(int deviceid)
        {
            DeviceID = deviceid;
            this.ShowDialog();
        }



        private void Addbtn_Click(object sender, EventArgs e)
        {
            SenseEdit form = new SenseEdit();
            form.DeviceID = DeviceID;
            form.IsEdit = false;
            form.ShowDialog();
            BindingData();
        }

        private void BindingData()
        {
            SensorService model = new SensorService();
            this.BindingContext[dataGridView1.DataSource].SuspendBinding();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = model.GetByCondiction(P => P.DeviceID == DeviceID,NowUser.CurrentUser).ToList();
            this.BindingContext[dataGridView1.DataSource].ResumeBinding();
            PerformService model2 = new PerformService();
            this.BindingContext[dataGridView2.DataSource].SuspendBinding();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = model2.GetByCondiction(P => P.DeviceID == DeviceID, NowUser.CurrentUser).ToList();
            this.BindingContext[dataGridView2.DataSource].ResumeBinding();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceSensorView model = dataGridView1.SelectedRows[0].DataBoundItem as DeviceSensorView;
                SensorService ss = new SensorService();
                ss.DeleteSensor(model,NowUser.CurrentUser );
                BindingData();
            }
            catch
            {
                MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceSensorView model = dataGridView1.SelectedRows[0].DataBoundItem as DeviceSensorView;
                SenseEdit form = new SenseEdit();
                form.IsEdit = true;
                form.SenseID = model.SenseID;
                form.ShowDialog();
                BindingData();
            }
            catch
            {
                MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PerformEdit form = new PerformEdit();
            form.DeviceID = DeviceID;
            form.IsEdit = false;
            form.ShowDialog();
            BindingData();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //try
            //{
            DevicePerformView model = dataGridView2.SelectedRows[0].DataBoundItem as DevicePerformView;
            PerformService ss = new PerformService();
            ss.DeletePerform(model,NowUser.CurrentUser);
            BindingData();

            //}
            //catch
            //{
            //    MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                DevicePerformView model = dataGridView2.SelectedRows[0].DataBoundItem as DevicePerformView;
                PerformEdit form = new PerformEdit();
                form.IsEdit = true;
                form.PerformID = model.PerformID;
                form.ShowDialog();
                BindingData();
            }
            catch
            {
                MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
