using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class ModeToTimer
    {
        public int ID { get; set; }
        public int TimerID { get; set; }
        public int ModeID { get; set; }
    }
}
