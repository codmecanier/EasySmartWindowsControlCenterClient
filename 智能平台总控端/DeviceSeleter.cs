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
    public partial class DeviceSeleter : Form
    {
        private int SelectedFloor;
        private int SelectedRoom;
        public DeviceSeleter()
        {
            InitializeComponent();
        }

        private void DeviceSeleter_Load(object sender, EventArgs e)
        {
            GenrateFloorButton();
            GetDeviceData();
        }
        private void GenrateFloorButton()
        {
            FloorService fs = new FloorService();
            flowLayoutPanel2.Controls.Add(NewFloorButton("0", Properties.Resources.select, "全部"));
            foreach (FloorView model in fs.GetAll(NowUser.CurrentUser))
            {
                flowLayoutPanel2.Controls.Add(NewFloorButton(model.FloorID.ToString(), Properties.Resources.select, model.FloorName));
            }
        }
        private FlowLayoutPanel NewFloorButton(string name, Image img, string text)
        {
            const int picturesize = 68;
            FlowLayoutPanel pan = new FlowLayoutPanel();
            pan.Width = picturesize + 20;
            Label lb = new Label();
            lb.Text = text;
            lb.AutoSize = true;
            lb.Font = new Font("微软雅黑", 12f);
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
            pb.MouseClick += ClickFloorEvent;
            pb.MouseEnter += EnterPicEvent;
            pb.MouseLeave += LeavePicEvent;
            return pan;
        }

      
        private FlowLayoutPanel NewRoomButton(string name, Image img, string text)
        {
            const int picturesize = 68;
            FlowLayoutPanel pan = new FlowLayoutPanel();
            pan.Width = picturesize + 20;
            Label lb = new Label();
            lb.Text = text;
            lb.AutoSize = true;
            lb.Font = new Font("微软雅黑", 12f);
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
            pb.MouseClick += ClickRoomEvent;
            pb.MouseEnter += EnterPicEvent;
            pb.MouseLeave += LeavePicEvent;
            return pan;
        }
        private void GenerateRoomsBtn(List<RoomView> rooms)
        {
            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel3.Controls.Add(NewRoomButton("0", Properties.Resources.select,"全部"));
            foreach (RoomView model in rooms)
            {
                flowLayoutPanel3.Controls.Add(NewRoomButton(model.RoomID.ToString(), Properties.Resources.select, model.RoomName));
            }
        }

        public void Display(int RoomID)
        {
            DeviceService ds = new DeviceService();
            GenerateDevicesBtn(ds.GetByComdiction(P => P.RoomID == RoomID,NowUser.CurrentUser).ToList());
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
            const int picturesize = 100;
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
            pb.MouseClick += ClickDeviceEvent;
            pb.MouseEnter += EnterPicEvent;
            pb.MouseLeave += LeavePicEvent;
            return pan;
        }

        private void ClickDeviceEvent(object sender, MouseEventArgs e)
        {
            DeviceControler dcs = new DeviceControler();
            dcs.DeviceID = int.Parse((sender as PictureBox).Name);
            dcs.ShowDialog();
        }
        private void EnterPicEvent(object sender, EventArgs e)
        { ((PictureBox)sender).BackColor = Color.LightBlue; }
        private void LeavePicEvent(object sender, EventArgs e)
        { ((PictureBox)sender).BackColor = this.BackColor; }
        private void ClickRoomEvent(object sender, MouseEventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int i = int.Parse(btn.Name);
            SelectedRoom = i;
            GetDeviceData();
        }
        private void ClickFloorEvent(object sender, MouseEventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int i = int.Parse(btn.Name);
            SelectedFloor = i;
            if (i == 0)
            {
                RoomService ds = new RoomService();
                List<RoomView> roomlist = ds.GetAll(NowUser.CurrentUser).ToList<RoomView>();
                GenerateRoomsBtn(roomlist);
            }
            else
            {
                RoomService ds = new RoomService();
                List<RoomView> roomlist = ds.GetByCondiction(P => P.FloorID == i, NowUser.CurrentUser).ToList<RoomView>();
                GenerateRoomsBtn(roomlist);
            }
            GetDeviceData();
        }
        private void GetDeviceData()
        {
            DeviceService ds = new DeviceService();
            List<DeviceInformationView> dlist;
            if (textBox1.Text.Length == 0)
            {
                if (SelectedRoom == 0)
                {
                    if (SelectedFloor == 0)
                    {
                        dlist = ds.GetAll(NowUser.CurrentUser).ToList<DeviceInformationView>();
                    }
                    else
                    {
                        dlist = ds.GetAll(NowUser.CurrentUser).Where(P => P.FloorID == (int)SelectedFloor).ToList<DeviceInformationView>();
                    }
                }
                else
                {
                    if (SelectedFloor == 0)
                    {
                        dlist = ds.GetAll(NowUser.CurrentUser).Where(P => P.RoomID == (int)SelectedRoom).ToList<DeviceInformationView>();
                    }
                    else
                    {
                        dlist = ds.GetAll(NowUser.CurrentUser).Where(P => P.FloorID == (int)SelectedFloor).Where(P => P.RoomID == (int)SelectedRoom).ToList<DeviceInformationView>();
                    }
                }
            }
            else
            {
                if (SelectedRoom == 0)
                {
                    if (SelectedFloor == 0)
                    {
                        dlist = ds.GetByComdiction(P => P.DeviceName.Contains(textBox1.Text.Trim()), NowUser.CurrentUser).ToList<DeviceInformationView>();
                    }
                    else
                    {
                        dlist = ds.GetByComdiction(P => P.DeviceName.Contains(textBox1.Text.Trim()), NowUser.CurrentUser).Where(P => P.FloorID == (int)SelectedFloor).ToList<DeviceInformationView>();
                    }
                }
                else
                {
                    if (SelectedFloor == 0)
                    {
                        dlist = ds.GetByComdiction(P => P.DeviceName.Contains(textBox1.Text.Trim()), NowUser.CurrentUser).Where(P => P.RoomID == (int)SelectedRoom).ToList<DeviceInformationView>();
                    }
                    else
                    {
                        dlist = ds.GetByComdiction(P => P.DeviceName.Contains(textBox1.Text.Trim()), NowUser.CurrentUser).Where(P => P.FloorID == (int)SelectedFloor).Where(P => P.RoomID == (int)SelectedRoom).ToList<DeviceInformationView>();
                    }
                }

            }

            GenerateDevicesBtn(dlist);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetDeviceData();
        }
    }
}
