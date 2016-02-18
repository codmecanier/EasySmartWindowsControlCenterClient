using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class UserToRole
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int UserID { get; set; }
    }
}
