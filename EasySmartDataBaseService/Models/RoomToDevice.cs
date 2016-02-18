using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class RoomToDevice
    {
        public int RoomID { get; set; }
        public int DeviceID { get; set; }
        public int RoomToDeviceID { get; set; }
    }
}
