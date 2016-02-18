using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class UserToFloor
    {
        public int ID { get; set; }
        public int FloorID { get; set; }
        public int UserID { get; set; }
        public bool IsAdmin { get; set; }
    }
}
