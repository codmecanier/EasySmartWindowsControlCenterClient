using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能平台总控端.DTO
{
    public class PerformOrSensorDTO
    {
        public bool PS_Check { get; set; }
        public int PSID { get; set; }
        public string PSName { get; set; }
        public string PSInfo { get; set; }
        public int DeviceID { get; set; }
        /// <summary>
        /// 0:Perform  1:Sensor
        /// </summary>
        public int _Type { get; set; }
    }
}
