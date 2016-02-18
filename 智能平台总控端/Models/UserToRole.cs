using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能平台总控端.Models
{
    [Table("UserToRole")]
    public  class UserToRole
    {
        [Column("ID")]
        public int ID { get; set; }
        [Column("RoleID")]
        public int RoleID { get; set; }
        [Column("UserID")]
        public int UserID { get; set; }
    }
}
