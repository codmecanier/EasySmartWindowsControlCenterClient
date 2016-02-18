using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class UserToFloor
    {
        public int ID { get; set; }
        public int FloorID { get; set; }
        public int UserID { get; set; }
        public bool IsAdmin { get; set; }
    }
}
