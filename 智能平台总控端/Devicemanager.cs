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
            this.BindingContext[dataGridView1.DataSource].SuspendBinding();
            DeviceService ds = new DeviceService();
            dataGridView1.DataSource = null;
            if (textBox1.Text.Length == 0)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    if (listBox4.SelectedIndex == 0)
                    {
                        dataGridView1.DataSource = ds.GetAll(NowUser.CurrentUser).ToList<DeviceInformationView>();
                    }
                    else
                    {
                        dataGridView1.DataSource = ds.GetAll(NowUser.CurrentUser).Where(P => P.FloorID == (int)listBox4.SelectedValue).ToList<DeviceInformationView>();
                    }
                }
                else
                {
                    if (listBox4.SelectedIndex == 0)
                    {
                        dataGridView1.DataSource = ds.GetAll(NowUser.CurrentUser).Where(P => P.RoomID == (int)listBox1.SelectedValue).ToList<DeviceInformationView>();
                    }
                    else
                    {
                        dataGridView1.DataSource = ds.GetAll(NowUser.CurrentUser).Where(P => P.FloorID == (int)listBox4.SelectedValue).Where(P => P.RoomID == (int)listBox1.SelectedValue).ToList<DeviceInformationView>();
                    }
                }
            }
            else
            {
                if (listBox1.SelectedIndex == 0)
                {
                    if (listBox4.SelectedIndex == 0)
                    {
                        dataGridView1.DataSource = ds.GetByComdiction(P => P.DeviceName.Contains(textBox1.Text.Trim()), NowUser.CurrentUser).ToList<DeviceInformationView>();
                    }
                    else
                    {
                        dataGridView1.DataSource = ds.GetByComdiction(P => P.DeviceName.Contains(textBox1.Text.Trim()), NowUser.CurrentUser).Where(P => P.FloorID == (int)listBox4.SelectedValue).ToList<DeviceInformationView>();
                    }
                }
                else
                {
                    if (listBox4.SelectedIndex == 0)
                    {
                        dataGridView1.DataSource = ds.GetByComdiction(P => P.DeviceName.Contains(textBox1.Text.Trim()), NowUser.CurrentUser).Where(P => P.RoomID == (int)listBox1.SelectedValue).ToList<DeviceInformationView>();
                    }
                    else
                    {
                        dataGridView1.DataSource = ds.GetByComdiction(P => P.DeviceName.Contains(textBox1.Text.Trim()), NowUser.CurrentUser).Where(P => P.FloorID == (int)listBox4.SelectedValue).Where(P => P.RoomID == (int)listBox1.SelectedValue).ToList<DeviceInformationView>();
                    }
                }
            }
            this.BindingContext[dataGridView1.DataSource].ResumeBinding();
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
            listBox4.DataSource = floorlist;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void Addbtn_Click(object sender, EventArgs e)
        {
            DeviceEditor form = new DeviceEditor();
            form.IsEdit = false;
            form.ShowDialog();
            GetDeviceData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceInformationView model = dataGridView1.SelectedRows[0].DataBoundItem as DeviceInformationView;
                DeviceService ds = Home.services.deviceservice;
                ds.DeleteDevice(model, NowUser.CurrentUser);
                GetDeviceData();
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
                GetDeviceData();
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
            if (listBox4.SelectedIndex == 0)
            {
                RoomService ds = new RoomService();
                List<RoomView> roomlist = ds.GetAll(NowUser.CurrentUser).ToList<RoomView>();
                RoomView rw = new RoomView();
                rw.RoomName = "全部";
                rw.RoomID = 0;
                roomlist.Insert(0, rw);
                listBox1.DataSource = roomlist;
            }
            else
            {
                RoomService ds = new RoomService();
                List<RoomView> roomlist = ds.GetByCondiction(P => P.FloorID == (int)listBox4.SelectedValue, NowUser.CurrentUser).ToList<RoomView>();
                RoomView rw = new RoomView();
                rw.RoomName = "全部";
                rw.RoomID = 0;
                roomlist.Insert(0, rw);
                listBox1.DataSource = roomlist;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {

            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDeviceData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
