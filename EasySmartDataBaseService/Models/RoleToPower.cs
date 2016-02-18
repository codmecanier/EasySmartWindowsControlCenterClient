using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class RoleToPower
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int PowerID { get; set; }
    }
}
