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
    public partial class Frm_Role_AddEdit : Form
    {
        public EventHandler<EventArgs> saveEvent;
        public bool Edit = false;
        public int RoleID = 0;
        public Frm_Role_AddEdit()
        {
            InitializeComponent();
        }

        private void Frm_Role_Add_Load(object sender, EventArgs e)
        {
            if(Edit)
            {
                SqlDao<Role> rRepository = new SqlDao<Role>();
                Role role = rRepository.GetByFirstOrDefault(p => p.RoleID == RoleID);
                this.RoleName.Text = role.RoleName;
                this.RoleRemark.Text=role.RoleRemark;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SqlDao<Role> rRepository = new SqlDao<Role>();
            if(Edit)
            {
                Role role = rRepository.GetByFirstOrDefault(p => p.RoleID == RoleID);
                role.RoleName = this.RoleName.Text;
                role.RoleRemark = this.RoleRemark.Text;
                rRepository.Update(role);
            }
            else
            {
                Role role = new Role();
                role.RoleName = this.RoleName.Text;
                role.RoleRemark = this.RoleRemark.Text;
                rRepository.Add(role);
            }
            if(null!=saveEvent)
            {
                saveEvent(null, new EventArgs());
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
