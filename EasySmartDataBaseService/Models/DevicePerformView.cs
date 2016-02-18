using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class DevicePerformView
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
        public int DeviceID { get; set; }
        public bool Visible { get; set; }
        public bool ArrowRead { get; set; }
        public bool ArrowUpdate { get; set; }
        public bool IsAdmin { get; set; }
        public int UserID { get; set; }
        public string DeviceName { get; set; }
        public int DeviceAddress { get; set; }
    }
}
