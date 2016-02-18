using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class UserRolePowerView
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public string RoleRemark { get; set; }
        public string PowerValue { get; set; }
        public string PowerDisplay { get; set; }
    }
}
