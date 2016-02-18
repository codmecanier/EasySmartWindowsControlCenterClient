using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class RoomToUser
    {
        public int UserID { get; set; }
        public int RoomID { get; set; }
        public bool IsAdmin { get; set; }
        public int ID { get; set; }
    }
}
