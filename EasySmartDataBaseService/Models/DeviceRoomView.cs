using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class DeviceRoomView
    {
        public int DeviceID { get; set; }
        public int Expr1 { get; set; }
        public int Expr2 { get; set; }
        public string DeviceName { get; set; }
        public string RoomName { get; set; }
        public int RoomID { get; set; }
        public int UserID { get; set; }
        public int Expr3 { get; set; }
        public bool IsAdmin { get; set; }
        public int FloorID { get; set; }
        public string FloorName { get; set; }
        public string FloorInfo { get; set; }
    }
}
