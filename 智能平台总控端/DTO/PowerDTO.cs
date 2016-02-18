using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能平台总控端.DTO
{
    public class PowerDTO
    {
        public int FloorID { get; set; }
        public Nullable<int> RoomID { get; set; }
        public Nullable<int> DeviceID { get; set; }
        public Nullable<int> _Type { get; set; }
        public Nullable<int> Type_Of_Id { get; set; }
        public Nullable<bool> _Control { get; set; }
        public Nullable<bool> _Display { get; set; }
        public Nullable<bool> _Using { get; set; }
    }
}
