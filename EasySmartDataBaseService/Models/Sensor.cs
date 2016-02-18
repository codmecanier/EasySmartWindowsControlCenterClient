using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class Sensor
    {
        public int SenseID { get; set; }
        public string SenseName { get; set; }
        public int SenserAddress { get; set; }
        public string SensorInfo { get; set; }
        public decimal Sensorvalue { get; set; }
        public decimal SensorBase { get; set; }
        public decimal SensorCompiction { get; set; }
        public decimal SensorOutPut { get; set; }
        public string SensorUnit { get; set; }
        public int Display { get; set; }
        public decimal AlarmHigh { get; set; }
        public decimal AlarmLow { get; set; }
        public decimal SensorMaxim { get; set; }
        public decimal SensorMinim { get; set; }
    }
}
