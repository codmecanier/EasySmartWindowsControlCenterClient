using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class Perform
    {
        public int PerformID { get; set; }
        public string PerformName { get; set; }
        public int PerformAddress { get; set; }
        public string PerformInfo { get; set; }
        public int Performvalue { get; set; }
        public int PerformBase { get; set; }
        public decimal PerformCopmcition { get; set; }
        public decimal PerformInPut { get; set; }
        public string PerformUnit { get; set; }
        public int PerformMaxim { get; set; }
        public int PerformMinum { get; set; }
        public Nullable<int> Display { get; set; }
    }
}
