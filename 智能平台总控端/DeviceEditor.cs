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
    public partial class DeviceEditor : Form
    {
        public string Iconpath = "";
        public int DeviceID;
        public bool IsEdit;
        public DeviceEditor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeviceEditor_Load(object sender, EventArgs e)
        {
            comboBox2.DisplayMember = "FloorName";
            comboBox2.ValueMember = "FloorID";
            comboBox3.DisplayMember = "RoomName";
            comboBox3.ValueMember = "RoomID";
            FloorService fs = new FloorService();
            comboBox2.DataSource = fs.GetAll(NowUser.CurrentUser).ToList();
            if(IsEdit)
            {
                DeviceService ds = new DeviceService();
                DeviceInformationView model = ds.GetFirstOrDefault(P => P.DeviceID == DeviceID,NowUser.CurrentUser);
                Nametext.Text = model.DeviceName;
                richTextBox1.Text = model.DeviceInfo;
                numericUpDown1.Value = model.DeviceAddress;
                Iconpath = model.DeviceImage;
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
            if(!IsEdit)
            {
                DeviceInformationView model = new DeviceInformationView();
                model.DeviceName = Nametext.Text.Trim();
                model.DeviceInfo = richTextBox1.Text.Trim();
                model.DeviceAddress = (int)numericUpDown1.Value;
                model.DeviceImage = Iconpath;
                model.FloorID = (int)comboBox2.SelectedValue;
                model.RoomID = (int)comboBox3.SelectedValue;
                ds.AddDevice(model,NowUser.CurrentUser);
                
            }
            else
            {
                DeviceInformationView model = new DeviceInformationView();
                model.DeviceName = Nametext.Text.Trim();
                model.DeviceInfo = richTextBox1.Text.Trim();
                model.DeviceAddress = (int)numericUpDown1.Value;
                model.DeviceImage = Iconpath;
                model.DeviceID = DeviceID;
                model.FloorID = (int)comboBox2.SelectedValue;
                model.RoomID = (int)comboBox3.SelectedValue;
                ds.UpdateDevice(model,NowUser.CurrentUser);
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
            RoomService frvs = new RoomService();
            comboBox3.DataSource = null;
            comboBox3.DataSource = frvs.GetByCondiction(P => P.FloorID == (int)comboBox2.SelectedValue,NowUser.CurrentUser).ToList();
            comboBox3.DisplayMember = "RoomName";
            comboBox3.ValueMember = "RoomID";
        }
    }
}
