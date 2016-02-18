using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class UserPerformPower
    {
        public int UserID { get; set; }
        public int PerformID { get; set; }
        public bool Visible { get; set; }
        public bool ArrowRead { get; set; }
        public bool ArrowUpdate { get; set; }
        public bool IsAdmin { get; set; }
    }
}
