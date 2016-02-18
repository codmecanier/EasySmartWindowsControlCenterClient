using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class FloorView
    {
        public int FloorID { get; set; }
        public string FloorName { get; set; }
        public string FloorInfo { get; set; }
        public bool IsAdmin { get; set; }
        public int UserID { get; set; }
    }
}
