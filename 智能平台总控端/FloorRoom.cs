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
    public partial class FloorRoom : Form
    {
        public FloorRoom()
        {
            InitializeComponent();
        }

        private void FloorView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

                FloorEdit fe = new FloorEdit();
                fe.ShowDialog();
                RefreshData();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                FloorView model = dataGridView1.SelectedRows[0].DataBoundItem as FloorView;
                FloorEdit fe = new FloorEdit();
                fe.floorID = model.FloorID;
                fe.ShowDialog();
            }
            catch
            {
                MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                FloorView model = dataGridView1.SelectedRows[0].DataBoundItem as FloorView;
                FloorService fs = new FloorService();
                fs.Delete(model);
                RefreshData();
            }
            catch
            {
                MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FloorRoom_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            this.BindingContext[dataGridView2.DataSource].SuspendBinding();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Home.services.roomservice.GetAll().ToList();
            this.BindingContext[dataGridView2.DataSource].ResumeBinding();
            this.BindingContext[dataGridView1.DataSource].SuspendBinding();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Home.services.floorservice.GetAll().ToList();
            this.BindingContext[dataGridView1.DataSource].ResumeBinding();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            //try
            //{
                RoomView model = dataGridView2.SelectedRows[0].DataBoundItem as RoomView;
                RoomService fs = Home.services.roomservice;
                fs.Delete(model);
                RefreshData();
            //}
            //catch
            //{
            //    MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            RoomEdit re = new RoomEdit();
            re.ShowDialog();
            this.RefreshData();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //try
            //{
                RoomView model = dataGridView2.SelectedRows[0].DataBoundItem as RoomView;
                RoomEdit re = new RoomEdit();
                re.EditID = model.RoomID;
                re.IsEdit = true;
                re.ShowDialog();
                this.RefreshData();
                RefreshData();
            //}
            //catch
            //{
            //    MessageBox.Show("请正确选中行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
