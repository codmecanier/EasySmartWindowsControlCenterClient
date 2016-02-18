using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySmartDataBaseService.Service
{
    public class Services
    {
        public AlarmService alarmservice;
        public DeviceService deviceservice;
        public FloorService floorservice;
        public PerformService performservice;
        public RoomService roomservice;
        public SensorService sensorservice;
        public UserService userservice;

        public void LoadAllServices()
        {
            alarmservice = new AlarmService();
            deviceservice = new DeviceService();
            floorservice = new FloorService();
            performservice = new PerformService();
            roomservice = new RoomService();
            sensorservice = new SensorService();
            userservice=new UserService();
        }
        public BaseService GetService(string serviceName)
        {
            Service.BaseService form = GlobalService.container.Resolve(typeof(Service.BaseService), serviceName) as Service.BaseService;
            return form;
        }
    }
}
