using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class Alarm
    {
        public int AlarmID { get; set; }
        public string AlarmName { get; set; }
        public string AlarmText { get; set; }
        public decimal AlarmHighValue { get; set; }
        public decimal AlarmLowValue { get; set; }
        public int AlarmTickTime { get; set; }
        public int AlarmKeepingTime { get; set; }
        public decimal AlarmMachValue { get; set; }
    }
}
