using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class AlarmView
    {
        public int AlarmID { get; set; }
        public int SensorID { get; set; }
        public string AlarmName { get; set; }
        public string AlarmText { get; set; }
        public decimal AlarmHighValue { get; set; }
        public decimal AlarmLowValue { get; set; }
        public int AlarmTickTime { get; set; }
        public int AlarmKeepingTime { get; set; }
        public int UserID { get; set; }
        public bool IsAdmin { get; set; }
    }
}
