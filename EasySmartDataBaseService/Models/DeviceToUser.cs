using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class DeviceToUser
    {
        public int UserID { get; set; }
        public int DeviceID { get; set; }
        public bool IsAdmin { get; set; }
    }
}
