using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EasySmartDataBaseService.Models;

namespace EasySmartDataBaseService.Service
{
    public class SensorService
    {
        private SqlDao<Sensor> sensorRepository = new SqlDao<Sensor>();
        private SqlDao<DeviceSensorView> sensorviewRepository = new SqlDao<DeviceSensorView>();
        private SqlDao<UserSensorPower> userSensorRepository = new SqlDao<UserSensorPower>();
        private SqlDao<DeviceToSensor> deviceSensorRepository = new SqlDao<DeviceToSensor>();

        public void AddSensor(DeviceSensorView dsw)
        {
            Sensor s = new Sensor();
            s.SenseID = dsw.SenseID;
            s.SenseName = dsw.SenseName;
            s.SenserAddress = dsw.SenserAddress;
            s.SensorCompiction = dsw.SensorCompiction;
            s.SensorInfo = dsw.SensorInfo;
            s.SensorBase = dsw.SensorBase;
            s.SensorMaxim = dsw.SensorMaxim;
            s.SensorMinim = dsw.SensorMinim;
            s.SensorUnit = dsw.SensorUnit;
            sensorRepository.Add(s);
            DeviceToSensor dfs = new DeviceToSensor();
            dfs.DeviceID = dsw.DeviceID;
            dfs.SensorID = dsw.SenseID;
            deviceSensorRepository.Add(dfs);
            UserSensorPower usp = new UserSensorPower();
            usp.Visible = true;
            usp.ArrowReadData = true;
            usp.IsAdmin = true;
            usp.SenseID = dsw.SenseID;
            usp.UserID = us.UserID;
            userSensorRepository.Add(usp);
        }
        public bool DeleteSensor(DeviceSensorView dsw)
        {
            DeviceSensorView ds = new DeviceSensorView();
            ds = sensorviewRepository.GetByFirstOrDefault(P=>P.UserID == us.UserID);
            if((ds == null)||(ds.IsAdmin == false))
            {
                return false;
            }
            Sensor s = new Sensor();
            s.SenseID = dsw.SenseID;
            s.SenseName = dsw.SenseName;
            s.SenserAddress = dsw.SenserAddress;
            s.SensorCompiction = dsw.SensorCompiction;
            s.SensorInfo = dsw.SensorInfo;
            s.SensorBase = dsw.SensorBase;
            s.SensorMaxim = dsw.SensorMaxim;
            s.SensorMinim = dsw.SensorMinim;
            s.SensorUnit = dsw.SensorUnit;
            sensorRepository.Add(s);
            DeviceToSensor dfs = new DeviceToSensor();
            dfs.DeviceID = dsw.DeviceID;
            dfs.SensorID = dsw.SenseID;
            deviceSensorRepository.Add(dfs);
            return true;
        }
        public bool Update(DeviceSensorView dsw)
        {
            DeviceSensorView ds = new DeviceSensorView();
            ds = sensorviewRepository.GetByFirstOrDefault(P => P.UserID == us.UserID);
            if ((ds == null) || (ds.IsAdmin == false))
            {
                return false;
            }
            Sensor s = new Sensor();
            s.SenseID = dsw.SenseID;
            s.SenseName = dsw.SenseName;
            s.SenserAddress = dsw.SenserAddress;
            s.SensorCompiction = dsw.SensorCompiction;
            s.SensorInfo = dsw.SensorInfo;
            s.SensorBase = dsw.SensorBase;
            s.SensorMaxim = dsw.SensorMaxim;
            s.SensorMinim = dsw.SensorMinim;
            s.SensorUnit = dsw.SensorUnit;
            sensorRepository.Update(s);
            DeviceToSensor dfs = new DeviceToSensor();
            dfs.DeviceID = dsw.DeviceID;
            dfs.SensorID = dsw.SenseID;
            deviceSensorRepository.Update(dfs);
            return true;
        }
        public IEnumerable<DeviceSensorView>GetByCondiction(Expression<Func<DeviceSensorView,bool>> where)
        {
            return sensorviewRepository.GetByCondition(where, us).Where<DeviceSensorView>(P => P.UserID == us.UserID);
        }
        public DeviceSensorView GetFirstOrDefault(Expression<Func<DeviceSensorView, bool>> where , User us)
        {
            return sensorviewRepository.GetByCondition(where, us).Where<DeviceSensorView>(P => P.UserID == us.UserID).FirstOrDefault<DeviceSensorView>();
        }
        public double GetSensorValue(int senseid)
        {
            Sensor s = sensorRepository.GetByFirstOrDefault(P => P.SenseID == senseid);
            DeviceSensorView ds = this.GetFirstOrDefault(P => P.UserID == us.UserID);
            if(ds.ArrowReadData==true)
                {
                    return (double)s.SensorOutPut;
                }
            return double.NaN;
        }
    }
}
