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
    public partial class Devicemanager : Form
    {
        public Devicemanager()
        {
            InitializeComponent();
        }

        private void Devicemanager_Load(object sender, EventArgs e)
        {
            RefreshData();
            GetDeviceData();
        }

        private void GetDeviceData()
        {
            throw new NotImplementedException();
        }
        private void RefreshData()
        {
            listBox1.DisplayMember = "RoomName";
            listBox1.ValueMember = "RoomID";
            listBox4.DisplayMember = "FloorName";
            listBox4.ValueMember = "FloorID";
            FloorService fs = new FloorService();
            List<FloorView> floorlist = fs.GetAll(NowUser.CurrentUser).ToList<FloorView>();
            FloorView fw = new FloorView();
            fw.FloorName = "全部";
            fw.FloorID = 0;
            floorlist.Insert(0, fw);
            listBox4.DataSource = fw;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void Addbtn_Click(object sender, EventArgs e)
        {
            DeviceEditor form = new DeviceEditor();
            form.IsEdit = false;
            form.ShowDialog();
            RefreshData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceInformationView model = dataGridView1.SelectedRows[0].DataBoundItem as DeviceInformationView;
                DeviceService ds = Home.services.deviceservice;
                ds.DeleteDevice(model, NowUser.CurrentUser);
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
                form.IsEdit = true;
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
            SensorService ss = Home.services.sensorservice;
            PerformService ps = Home.services.performservice;
            IEnumerable<DeviceSensorView> sensorlist = ss.GetByCondiction(P => P.DeviceID == DeviceID, NowUser.CurrentUser);
            IEnumerable<DevicePerformView> performlist = ps.GetByCondiction(P => P.DeviceID == DeviceID, NowUser.CurrentUser);
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

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox4.SelectedIndex==0)
            {

            }
            else
            {

            }
        }
    }
}
