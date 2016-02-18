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
    public partial class Devicemanager : Form
    {
        public Devicemanager()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {

                DeviceTypeEdit dte = new DeviceTypeEdit();
                dte.DeviceTypeID = (int)listBox1.SelectedValue;
                dte.editmode = DeviceTypeEdit.EditMode.Edit;
                dte.ShowDialog();
                RefreshData();
                RefreshData();
            }
            catch { MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void Devicemanager_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            listBox1.DisplayMember = "DeviceTypeName";
            listBox1.ValueMember = "DeviceTypeID";
            DeviceTypeService dts = new DeviceTypeService();
            listBox1.DataSource = dts.GetAll().ToList();
            DeviceInformationViewService model = new DeviceInformationViewService();
            this.BindingContext[dataGridView1.DataSource].SuspendBinding();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = model.GetAll().ToList();
            this.BindingContext[dataGridView1.DataSource].ResumeBinding();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DeviceTypeService dts = new DeviceTypeService();
            try
            {
                dts.Delete(P => P.DeviceTypeID == (int)listBox1.SelectedValue);
                RefreshData();
            }
            catch { MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DeviceTypeEdit dte = new DeviceTypeEdit();
            dte.editmode = DeviceTypeEdit.EditMode.Add;
            dte.ShowDialog();
            RefreshData();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            DeviceEditor form = new DeviceEditor();
            form.state = WindowsState.Add;
            form.ShowDialog();
            RefreshData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceInformationView model = dataGridView1.SelectedRows[0].DataBoundItem as DeviceInformationView;
                DeviceInformationViewService ds = new DeviceInformationViewService();
                ds.DeleteDevice(model.DeviceID);
                RefreshData();
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
                DeviceInformationView model = dataGridView1.SelectedRows[0].DataBoundItem as DeviceInformationView;
                DeviceEditor form = new DeviceEditor();
                form.state = WindowsState.Edit;
                form.DeviceID = model.DeviceID;
                form.ShowDialog();
                RefreshData();
            }
            catch
            {
                MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplaySensorPerform(int DeviceID)
        {
            DevicePerformViewService dsvs = new DevicePerformViewService();
            IEnumerable<DevicePerformView> sensorlist = dsvs.GetByCondition(P => P.DeviceID == DeviceID);
            IEnumerable<DevicePerformView> performlist = dsvs.GetByCondition(P => P.DeviceID == DeviceID);
            listBox2.DisplayMember = "SenseName";
            listBox3.DisplayMember = "PerformName";
            listBox2.DataSource = sensorlist;
            listBox3.DataSource = performlist;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DeviceInformationView model = dataGridView1.SelectedRows[0].DataBoundItem as DeviceInformationView;
                DisplaySensorPerform(model.DeviceID);
            }
            catch { }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //try
            //{
            DeviceInformationView model = dataGridView1.SelectedRows[0].DataBoundItem as DeviceInformationView;
            SensePerform sp = new SensePerform();
            sp.Display(model.DeviceID);
            //}
            //catch { }
        }
    }
}
