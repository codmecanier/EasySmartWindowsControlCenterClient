using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能平台总控端.DTO
{
    public  class RoomDTO
    {
        public bool Room_Check { get; set; }
        public string RoomName { get; set; }
        public string RoomInfo { get; set; }
        public int RoomID { get; set; }
        public int FloorID { get; set; }
        public List<DeviceDTO> dDTOList { get; set; }
    }
}
