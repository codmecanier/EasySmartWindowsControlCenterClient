using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class Timer
    {
        public int TimerID { get; set; }
        public System.DateTime Timertime { get; set; }
        public string TimerName { get; set; }
    }
}
