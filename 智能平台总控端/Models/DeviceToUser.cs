using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class DeviceToUser
    {
        public int UserID { get; set; }
        public int DeviceID { get; set; }
        public bool IsAdmin { get; set; }
    }
}
