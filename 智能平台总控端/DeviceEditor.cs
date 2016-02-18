using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 智能灯泡总控程序.BaseCopper;
using 智能平台总控端.Models;
using 智能平台总控端.Service;

namespace 智能平台总控端
{
    public partial class DeviceEditor : BaseForm
    {
        public string Iconpath = "";
        public int DeviceID;
        public DeviceEditor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeviceEditor_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "DeviceTypeName";
            comboBox1.ValueMember = "DeviceTypeID";
            comboBox2.DisplayMember = "FloorName";
            comboBox2.ValueMember = "FloorID";
            comboBox3.DisplayMember = "RoomName";
            comboBox3.ValueMember = "RoomID";
            FloorService fs = new FloorService();
            comboBox2.DataSource = fs.GetAll();
            DeviceTypeService dts = new DeviceTypeService();
            comboBox1.DataSource = dts.GetAll().ToList();
            if(WindowsState.Edit==state)
            {
                DeviceInformationViewService ds = new DeviceInformationViewService();
                DeviceInformationView model = ds.GetByFirstOrDefault(P => P.DeviceID == DeviceID);
                Nametext.Text = model.DeviceName;
                richTextBox1.Text = model.DeviceInfo;
                numericUpDown1.Value = model.DeviceAddress;
                Iconpath = model.DeviceImage;
                comboBox1.SelectedValue = model.DeviceTypeID;
                comboBox2.SelectedValue = model.FloorID;
                comboBox3.SelectedValue = model.RoomID;           
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "图片文件|*.jpg;*.png;*.bmp*.gif*.tif*.ico";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Iconpath = ofd.FileName;
                Image img = Image.FromFile(Iconpath);
                pictureBox1.Image = img;
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            string str = "";
            if (Nametext.Text.Trim().Length == 0)
            { str += "请输入设备名称"; }
            if (comboBox1.SelectedIndex == -1)
            { str += "请选择设备类型"; }
            if (comboBox2.SelectedIndex == -1)
            { str += "请选择设备一级分类"; }
            if (comboBox3.SelectedIndex == -1)
            { str += "请选择设备二级分类"; }
            if (str.Length > 0)
            {
                MessageBox.Show(str, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DeviceService ds = new DeviceService();
            DeviceTypeDeviceViewService dtdvs = new DeviceTypeDeviceViewService();
            DeviceTypeToDeviceService dttdSer = new DeviceTypeToDeviceService();
            RoomToDeviceService rdvs = new RoomToDeviceService();
            if(state==WindowsState.Add )
            {
                Device model = new Device();
                model.DeviceName = Nametext.Text.Trim();
                model.DeviceInfo = richTextBox1.Text.Trim();
                model.DeviceAddress = (int)numericUpDown1.Value;
                model.DeviceImage = Iconpath;
                ds.Add(model);
                DeviceTypeToDevice dttd = new DeviceTypeToDevice();
                dttd.DeviceID = model.DeviceID;
                dttd.DeviceTypeID = (int)comboBox1.SelectedValue;
                RoomToDevice rtd = new RoomToDevice();
                rtd.DeviceID = model.DeviceID;
                rtd.RoomID = (int)comboBox3.SelectedValue;
                dttdSer.Add(dttd);
                rdvs.Add(rtd);
                
            }
            else
            {
                Device model = new Device();
                model.DeviceName = Nametext.Text.Trim();
                model.DeviceInfo = richTextBox1.Text.Trim();
                model.DeviceAddress = (int)numericUpDown1.Value;
                model.DeviceImage = Iconpath;
                model.DeviceID = DeviceID;
                ds.Update(model);
                DeviceTypeToDevice dttd = new DeviceTypeToDevice();
                dttd.DeviceID = model.DeviceID;
                dttd.DeviceTypeID = (int)comboBox1.SelectedValue;
                RoomToDevice rtd = new RoomToDevice();
                rtd.DeviceID = model.DeviceID;
                rtd.RoomID = (int)comboBox3.SelectedValue;
                dttdSer.Update(dttd);
                rdvs.Update(rtd);
            }
            this.Close();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FloorRoomViewService frvs = new FloorRoomViewService();
            comboBox3.DataSource = null;
            comboBox3.DataSource = frvs.GetByCondition(P => P.FloorID == (int)comboBox2.SelectedValue).ToList();
            comboBox3.DisplayMember = "RoomName";
            comboBox3.ValueMember = "RoomID";
        }
    }
}
