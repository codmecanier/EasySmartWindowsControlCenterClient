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
    public partial class DeviceSeleter : Form
    {
        public DeviceSeleter()
        {
            InitializeComponent();
        }

        private void DeviceSeleter_Load(object sender, EventArgs e)
        {
        }

        public void Display(int RoomID)
        {
            DeviceInformationViewService ds = new DeviceInformationViewService();
            GenerateDevicesBtn(ds.GetByCondition(P => P.RoomID == RoomID).ToList());
            this.ShowDialog();
        }
        private void GenerateDevicesBtn(List<DeviceInformationView> device)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DeviceInformationView model in device)
            {
                Image img;
                try { img = Image.FromFile(model.DeviceImage); }
                catch { img = Properties.Resources.Error; }
                flowLayoutPanel1.Controls.Add(NewDeviceButton(model.DeviceID.ToString(), img, model.DeviceName));
            }
        }
        private FlowLayoutPanel NewDeviceButton(string name, Image img, string text)
        {
            const int picturesize = 160;
            FlowLayoutPanel pan = new FlowLayoutPanel();
            pan.Width = picturesize + 20;
            Label lb = new Label();
            lb.Text = text;
            lb.AutoSize = true;
            lb.Font = new Font("微软雅黑", 14f);
            pan.Height = lb.Height + picturesize + 15;
            lb.AutoSize = false;
            lb.Width = picturesize;
            lb.Height = pan.Height - 15 - picturesize;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            PictureBox pb = new PictureBox();
            pb.Width = picturesize;
            pb.Height = picturesize;
            pb.Image = img;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Name = name;
            pan.Controls.Add(pb);
            pan.Controls.Add(lb);
            pb.MouseClick += ClickPicEvent;
            pb.MouseEnter += EnterPicEvent;
            pb.MouseLeave += LeavePicEvent;
            return pan;
        }
        private void EnterPicEvent(object sender, EventArgs e)
        { ((PictureBox)sender).BackColor = Color.LightBlue; }
        private void LeavePicEvent(object sender, EventArgs e)
        { ((PictureBox)sender).BackColor = this.BackColor; }
        private void ClickPicEvent(object sender, MouseEventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int i = int.Parse(btn.Name);
            DeviceControler form = new DeviceControler();
            form.DeviceID = i;
            form.ShowDialog();
        }
    }
}
