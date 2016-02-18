using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
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
