using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
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
