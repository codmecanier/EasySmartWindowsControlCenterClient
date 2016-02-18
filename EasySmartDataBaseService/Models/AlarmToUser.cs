using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class AlarmToUser
    {
        public int AlarmID { get; set; }
        public int UserID { get; set; }
        public bool IsAdmin { get; set; }
    }
}
