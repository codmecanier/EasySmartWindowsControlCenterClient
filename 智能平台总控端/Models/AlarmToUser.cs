using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class AlarmToUser
    {
        public int AlarmID { get; set; }
        public int UserID { get; set; }
        public bool IsAdmin { get; set; }
    }
}
