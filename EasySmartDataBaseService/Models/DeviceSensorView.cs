using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class DeviceSensorView
    {
        public int SenseID { get; set; }
        public string SenseName { get; set; }
        public int SenserAddress { get; set; }
        public string SensorInfo { get; set; }
        public decimal Sensorvalue { get; set; }
        public decimal SensorBase { get; set; }
        public decimal SensorCompiction { get; set; }
        public string SensorUnit { get; set; }
        public int DeviceID { get; set; }
        public decimal AlarmHigh { get; set; }
        public decimal AlarmLow { get; set; }
        public decimal SensorMaxim { get; set; }
        public decimal SensorMinim { get; set; }
        public int UserID { get; set; }
        public int Expr1 { get; set; }
        public bool Visible { get; set; }
        public bool ArrowReadData { get; set; }
        public bool IsAdmin { get; set; }
    }
}
