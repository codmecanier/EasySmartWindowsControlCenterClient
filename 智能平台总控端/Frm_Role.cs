using EasySmartDataBaseService.Models;
using EasySmartDataBaseService.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能平台总控端
{
    public partial class Frm_Role : Form
    {
        public Frm_Role()
        {
            InitializeComponent();
        }
        private void DataRefresh(object sender,EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            new Thread(() =>
            {
                SqlDao<Role> rRepository = new SqlDao<Role>();
                var roleEntities = rRepository.GetAll(NowUser.CurrentUser).ToList();
                this.BeginInvoke(new Action(()=>{
                    this.Role_Data.DataSource = roleEntities;
                }));
            }).Start();
        }

        private void Frm_Role_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Frm_Role_AddEdit add = new Frm_Role_AddEdit();
            add.saveEvent += DataRefresh;
            add.ShowDialog();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (0 == this.Role_Data.SelectedRows.Count)
                return;
            object entity = this.Role_Data.SelectedRows[0].DataBoundItem;
            if (null != entity)
            {
                Frm_Role_AddEdit edit = new Frm_Role_AddEdit();
                edit.Edit = true;
                edit.RoleID = (entity as Role).RoleID;
                edit.saveEvent += DataRefresh;
                edit.ShowDialog();
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (0 == this.Role_Data.SelectedRows.Count)
                return;
            object entity = this.Role_Data.SelectedRows[0].DataBoundItem;
            if (null != entity && MessageBox.Show("确认删除?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                lock (this)
                {
                    Role role = entity as Role;
                    SqlDao<Role> rRepository = new SqlDao<Role>();
                    SqlDao<UserToRole> utrRepository = new SqlDao<UserToRole>();
                    SqlDao<RoleToPower> rtpRepository = new SqlDao<RoleToPower>();
                    SqlDao<Power> pRepository = new SqlDao<Power>();
                    List<Power> power = (from rtp in rtpRepository.GetByCondition(p => p.RoleID == role.RoleID)
                                         join p in pRepository.GetAll(NowUser.CurrentUser) on rtp.PowerID equals p.PowerID
                                         select p).ToList();
                    foreach (var ex in power)
                    {
                        pRepository.Delete(ex);
                    }
                    var _rtp=rtpRepository.GetByCondition(p => p.RoleID == role.RoleID);
                    foreach (var ex in _rtp)
                    {
                        rtpRepository.Delete(ex);
                    }
                    var _utr=utrRepository.GetByCondition(p => p.RoleID == role.RoleID);
                    foreach (var ex in _utr)
                    {
                        utrRepository.Delete(ex);
                    }
                    rRepository.Delete(p => p.RoleID == role.RoleID);
                    RefreshData();
                }
            }
        }
    }
}
