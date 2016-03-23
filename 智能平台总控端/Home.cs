using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using EasySmartDataBaseService;
using System.Linq.Dynamic;
using EasySmartDataBaseService.Service;

namespace 智能平台总控端
{
    public partial class Home : Form
    {
        public static NowUser services = new NowUser();
        public static FileObject file = new FileObject();
        public static PersonalSettings ps;
        FloorService fService = new FloorService();
        static Int16 locknumber = 0;
        public Home()
        {
            InitializeComponent();
            login lg = new login();
            lg.ShowDialog();
            label2.Text = NowUser.CurrentUser.UserName;
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void pictureButton4_Load(object sender, EventArgs e)
        {

        }

        private void Home_Resize(object sender, EventArgs e)
        {
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Height + 20;
        }

        private void pictureButton2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureButton4_Click(object sender, EventArgs e)
        {
            FloorRoom fw = new FloorRoom();
            fw.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void pictureButton8_Load(object sender, EventArgs e)
        {
        }

        private void pictureButton8_Click(object sender, EventArgs e)
        {
            DeviceSeleter ds = new DeviceSeleter();
            ds.ShowDialog();
        }

        private void pictureButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureButton5_Load(object sender, EventArgs e)
        {
        }

        private void pictureButton3_Load(object sender, EventArgs e)
        {
        }

        private void pictureButton9_Click(object sender, EventArgs e)
        {
            //Frm_Role role = new Frm_Role();
            //role.ShowDialog();
        }

        private void pictureButton3_Click(object sender, EventArgs e)
        {
            Devicemanager dv = new Devicemanager();
            dv.ShowDialog();
        }

        private void pictureButton9_Click_1(object sender, EventArgs e)
        {
            DeviceSeleter ds = new DeviceSeleter();
            ds.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Devicemanager DM = new Devicemanager();
            DM.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FloorRoom fr = new FloorRoom();
            fr.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = Color.LightCyan;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = this.BackColor;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = Color.LightCyan;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = Color.Purple;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DeviceSeleter ds = new DeviceSeleter();
            ds.Show();
        }

    }
}
