using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class Device
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public int DeviceAddress { get; set; }
        public string DeviceInfo { get; set; }
        public string DeviceImage { get; set; }
        public string DeviceControlPanel { get; set; }
    }
}
