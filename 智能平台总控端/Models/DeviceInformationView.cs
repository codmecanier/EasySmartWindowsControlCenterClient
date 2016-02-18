using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class DeviceInformationView
    {
        public string DeviceName { get; set; }
        public int DeviceAddress { get; set; }
        public string DeviceImage { get; set; }
        public string DeviceInfo { get; set; }
        public string RoomName { get; set; }
        public string RoomInfo { get; set; }
        public string FloorName { get; set; }
        public string FloorInfo { get; set; }
        public int FloorID { get; set; }
        public int RoomID { get; set; }
        public int DeviceID { get; set; }
        public int UserID { get; set; }
        public bool IsAdmin { get; set; }
    }
}
