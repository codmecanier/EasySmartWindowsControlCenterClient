using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class RoomView
    {
        public string RoomName { get; set; }
        public int RoomID { get; set; }
        public int FloorID { get; set; }
        public string FloorName { get; set; }
        public string FloorInfo { get; set; }
        public int UserID { get; set; }
        public bool IsAdmin { get; set; }
        public int ID { get; set; }
    }
}
