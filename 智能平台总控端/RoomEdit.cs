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
    public partial class RoomEdit : Form
    {
        public int EditID;
        public bool IsEdit = false;
        public RoomEdit()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            string errorinfo = "";
            if (Nametext.Text.Trim().Length == 0)
            {
                errorinfo += "请输入房间名称\n";
            }
            if (Floorcmb.Text.Length == 0)
            {
                errorinfo += "请选择房间楼层";
            }
            if (errorinfo.Length != 0)
            {
                MessageBox.Show(errorinfo, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsEdit)
            {
                RoomView room = new RoomView();
                room.RoomName = Nametext.Text;
                room.FloorID = (int)Floorcmb.SelectedValue;
                RoomService rService = Home.services.roomservice;
                rService.Add(room,NowUser.CurrentUser);
            }
            else
            {
                RoomService rService = Home.services.roomservice;
                RoomView room = rService.GetFirstOrDefault(p => p.RoomID == EditID,NowUser.CurrentUser);
                room.RoomName = Nametext.Text;
                room.FloorID = (int)Floorcmb.SelectedValue;
                rService.Update(room,NowUser.CurrentUser);
            }
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void RoomEdit_Load(object sender, EventArgs e)
        {
            FloorService fs = Home.services.floorservice;
            Floorcmb.ValueMember = "FloorID";
            Floorcmb.DisplayMember = "FloorName";
            Floorcmb.DataSource = fs.GetAll(NowUser.CurrentUser).ToList();
            if(IsEdit)
            {
                RoomService rs = Home.services.roomservice;
                RoomView rw = rs.GetFirstOrDefault(P => P.RoomID == EditID,NowUser.CurrentUser);
                rw.ID = 0;
                Nametext.Text = rw.RoomName;
                Floorcmb.SelectedValue = rw.FloorID;
            }
        }
    }
}
