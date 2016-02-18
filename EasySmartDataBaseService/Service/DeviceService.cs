using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EasySmartDataBaseService.Models;

namespace EasySmartDataBaseService.Service
{
    public class DeviceService
    {
        private SqlDao<Device> DeviceRepository = new SqlDao<Device>();
        private SqlDao<DeviceInformationView> DeviceVeiwRepository = new SqlDao<DeviceInformationView>();
        private SqlDao<RoomToDevice> RoomDeviceRepository = new SqlDao<RoomToDevice>();
        private SqlDao<DeviceToUser> DeviceUserRepoistory = new SqlDao<DeviceToUser>();
        public void AddDevice(DeviceInformationView md)
        {
            md.IsAdmin = true;
            Device d = new Device();
            d.DeviceName = md.DeviceName;
            d.DeviceID = md.DeviceID;
            d.DeviceImage = md.DeviceImage;
            d.DeviceAddress = md.DeviceAddress;
            d.DeviceInfo = md.DeviceInfo;
            DeviceRepository.Add(d);
            RoomToDevice rtd = new RoomToDevice();
            rtd.DeviceID = md.DeviceID;
            rtd.RoomID = md.RoomID;
            RoomDeviceRepository.Add(rtd);
            DeviceToUser dtu = new DeviceToUser();
            dtu.DeviceID = md.DeviceID;
            dtu.UserID = md.UserID;
            DeviceUserRepoistory.Add(dtu);
        }
        public IEnumerable<DeviceInformationView> GetAll(User us)
        {
            return DeviceVeiwRepository.GetByCondition(P => P.UserID == us.UserID);
        }
        public IEnumerable<DeviceInformationView> GetByComdiction(Expression<Func<DeviceInformationView, bool>> where , User us)
        {
            return DeviceVeiwRepository.GetByCondition(where, us).Where<DeviceInformationView >(P=>P.UserID==us.UserID);
        }
        public DeviceInformationView GetFirstOrDefault(Expression<Func<DeviceInformationView, bool>> where , User us)
        {
            return DeviceVeiwRepository.GetByCondition(where, us).Where<DeviceInformationView>(P => P.UserID == us.UserID).FirstOrDefault<DeviceInformationView>();
        }
        public bool DeleteDevice(DeviceInformationView md)
        {
            DeviceInformationView tm = DeviceVeiwRepository.GetByFirstOrDefault(P => P.UserID == us.UserID && P.DeviceID == md.DeviceID);
            if((tm==null)||(tm.IsAdmin==false))
            { return false; }
            Device d = new Device();
            d.DeviceName = md.DeviceName;
            d.DeviceID = md.DeviceID;
            d.DeviceImage = md.DeviceImage;
            d.DeviceAddress = md.DeviceAddress;
            d.DeviceInfo = md.DeviceInfo;
            DeviceRepository.Delete(d);
            RoomToDevice rtd = new RoomToDevice();
            rtd.DeviceID = md.DeviceID;
            rtd.RoomID = md.RoomID;
            RoomDeviceRepository.Delete(rtd);
            DeviceToUser dtu = new DeviceToUser();
            dtu.DeviceID = md.DeviceID;
            dtu.UserID = md.UserID;
            DeviceUserRepoistory.Delete(dtu);
            return true;
        }
     
        public bool UpdateDevice(DeviceInformationView md)
        {
            DeviceInformationView tm = DeviceVeiwRepository.GetByFirstOrDefault(P => P.UserID == us.UserID && P.DeviceID == md.DeviceID);
            if ((tm == null) || (tm.IsAdmin == false))
            { return false; }
            Device d = new Device();
            d.DeviceName = md.DeviceName;
            d.DeviceID = md.DeviceID;
            d.DeviceImage = md.DeviceImage;
            d.DeviceAddress = md.DeviceAddress;
            d.DeviceInfo = md.DeviceInfo;
            DeviceRepository.Update(d);
            RoomToDevice rtd = new RoomToDevice();
            rtd.DeviceID = md.DeviceID;
            rtd.RoomID = md.RoomID;
            RoomDeviceRepository.Update(rtd);
            DeviceToUser dtu = new DeviceToUser();
            dtu.DeviceID = md.DeviceID;
            dtu.UserID = md.UserID;
            DeviceUserRepoistory.Update(dtu);
            return true;
        }

    }
}
