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
using 智能平台总控端.Models;
using 智能平台总控端.Service;
using System.Linq.Dynamic;

namespace 智能平台总控端
{
    public partial class Home : Form
    {
        public static Services services = new Services();
        public static FileObject file = new FileObject();
        public static PersonalSettings ps;
        FloorService fService = new FloorService();
        static Int16 locknumber = 0;
        public Home()
        {
            InitializeComponent();
            login lg = new login();
            lg.ShowDialog();
            label2.Text = NowUser.UserName;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DeviceService dService=services.GetService("DeviceService") as DeviceService;
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

        private void pictureButton2_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureButton).BackColor = Color.LightBlue;
        }

        private void pictureButton2_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureButton).BackColor = this.BackColor;
        }

        private void pictureButton2_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as PictureButton).BackColor = this.BackColor;
        }

        private void pictureButton2_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as PictureButton).BackColor = Color.LightCoral;

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
            Power_Frm p = new Power_Frm();
            p.ShowDialog();
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
            //Devicemanager dv = new Devicemanager();
            //dv.ShowDialog();
        }

        private void pictureButton9_Click(object sender, EventArgs e)
        {
            Frm_Role role = new Frm_Role();
            role.ShowDialog();
        }

    }
}
