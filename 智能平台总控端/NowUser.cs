using EasySmartDataBaseService.Models;
using EasySmartDataBaseService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能平台总控端
{
    public partial class NowUser
    {
        public  static User CurrentUser { get; set; }
        public  FloorService floorservice{ get; set; }
        public  RoomService roomservice { get; set; }
        public  DeviceService deviceservice{ get; set; }
        public  PerformService performservice{ get; set; }
        public  SensorService sensorservice{ get; set; }
        public  UserService userservice { get; set; }
        public  void LoadAllServices()
        {
            floorservice = new FloorService();
            roomservice = new RoomService();
            deviceservice = new DeviceService();
            sensorservice = new SensorService();
            roomservice = new RoomService();
            userservice = new UserService();
        }
    }
}
