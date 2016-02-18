using ExpressionEvaluator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 智能平台总控端.DTO;

namespace 智能平台总控端
{
    public partial class Power : Form
    {
        public Power()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Func<int, int, int> result = add<int>();
            int i = result(1, 1);
            MessageBox.Show(i.ToString());
        }
        public Func<T, T, T> add<T>()
        {
            var x = Expression.Parameter(typeof(T), "x");
            var y = Expression.Parameter(typeof(T), "y");
            var body = Expression.Add(x, y);
            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(
                body, x, y).Compile();
            return add;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void Power_Load(object sender, EventArgs e)
        {
            var fService = Home.services.floorservice;
            var floor_entities = fService.GetAll();
            this.Floor_Data.DataSource = floor_entities.Select(p => new FloorDTO()
            {
                FloorInfo = p.FloorInfo,
                FloorName = p.FloorName,
                FloorID = p.FloorID
            }).ToList();
        }

        private void Floor_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fEntity = Floor_Data.SelectedRows[0].DataBoundItem as FloorDTO;
            var rService = Home.services.roomservice;
            var room_entities = rService.GetByCondiction(p => p.FloorID == fEntity.FloorID);
            this.Room_Data.DataSource = room_entities.Select(p => new RoomDTO()
            {
                RoomID = p.RoomID,
                RoomInfo = string.Empty,
                RoomName = p.RoomName
            }).ToList();
        }

        private void Room_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Device_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Perform_Or_Sensor_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
