using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能平台总控端.Models
{
    [Table("Power")]
    public class Power
    {
        [Column("PowerID")]
        public int PowerID { get; set; }
        [Column("PowerValue")]
        public string PowerValue { get; set; }
        [Column("PowerDisplay")]
        public string PowerDisplay { get; set; }
    }
}
