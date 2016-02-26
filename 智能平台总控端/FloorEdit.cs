using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasySmartDataBaseService.Service;
using EasySmartDataBaseService.Models;

namespace 智能平台总控端
{
    public partial class FloorEdit : Form
    {
        public int floorID;
        public bool IsEdit = false;
        public FloorEdit()
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
            if (errorinfo.Length != 0)
            {
                MessageBox.Show(errorinfo, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsEdit)
            {
                FloorView fr = new FloorView();
                fr.FloorName = Nametext.Text;
                fr.FloorInfo = Infotext.Text;
                FloorService fs = new FloorService();
                fs.Add(fr,NowUser.CurrentUser);
            }
            else
            {
                FloorService fs = new FloorService();
                FloorView fr = fs.GetFirstOrDefault(P => P.FloorID == floorID,NowUser.CurrentUser);
                if (fr != null)
                {
                    fr.FloorName = Nametext.Text;
                    fr.FloorInfo = Infotext.Text;
                    fs.Update(fr,NowUser.CurrentUser);
                }
            }
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RoomEdit_Load(object sender, EventArgs e)
        {
            FloorService fs = new FloorService();
            if (IsEdit)
            {
                FloorView fr = fs.GetFirstOrDefault(P => P.FloorID == floorID,NowUser.CurrentUser);
                if (fr != null)
                {
                    Nametext.Text = fr.FloorName;
                    Infotext.Text = fr.FloorInfo;
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
