using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能平台总控端.Models
{
    [Table("Role")]
    public  class Role
    {
        [Column("RoleID")]
        public int RoleID { get; set; }
        [Column("RoleName")]
        public string RoleName { get; set; }
        [Column("RoleRemark")]
        public string RoleRemark { get; set; }
    }
}
