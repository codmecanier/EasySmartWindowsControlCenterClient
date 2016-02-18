using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class Device
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public int DeviceAddress { get; set; }
        public string DeviceInfo { get; set; }
        public string DeviceImage { get; set; }
    }
}
