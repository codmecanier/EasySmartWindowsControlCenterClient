using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class UserSensorPower
    {
        public int UserID { get; set; }
        public int SenseID { get; set; }
        public bool Visible { get; set; }
        public bool ArrowReadData { get; set; }
        public bool IsAdmin { get; set; }
    }
}
