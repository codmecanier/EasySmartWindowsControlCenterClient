using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using 智能平台总控端.Models;

namespace 智能平台总控端.Service
{
    public class PerformService
    {
        private SqlDao<Perform> PerformRepository = new SqlDao<Perform>();
        private SqlDao<DevicePerformView> PerformviewRepository = new SqlDao<DevicePerformView>();
        private SqlDao<UserPerformPower> userPerformRepository = new SqlDao<UserPerformPower>();
        private SqlDao<DeviceToPerform> devicePerformRepository = new SqlDao<DeviceToPerform>();

        public void AddPerform(DevicePerformView dsw)
        {
            Perform s = new Perform();
            s.PerformID = dsw.PerformID;
            s.PerformName = dsw.PerformName;
            s.PerformAddress = dsw.PerformAddress;
            s.PerformCopmcition = dsw.PerformCopmcition;
            s.PerformInfo = dsw.PerformInfo;
            s.PerformBase = dsw.PerformBase;
            s.PerformMaxim = dsw.PerformMaxim;
            s.PerformMinum = dsw.PerformMinum;
            s.PerformUnit = dsw.PerformUnit;
            PerformRepository.Add(s);
            DeviceToPerform dfs = new DeviceToPerform();
            dfs.DeviceID = dsw.DeviceID;
            dfs.PerformID = dsw.PerformID;
            devicePerformRepository.Add(dfs);
            UserPerformPower usp = new UserPerformPower();
            usp.Visible = true;
            usp.ArrowRead = true;
            usp.ArrowUpdate = true;
            usp.PerformID = dsw.PerformID;
            usp.UserID = NowUser.UserID;
            userPerformRepository.Add(usp);
        }
        public bool DeletePerform(DevicePerformView dsw)
        {
            DevicePerformView ds = new DevicePerformView();
            ds = PerformviewRepository.GetByFirstOrDefault(P => P.UserID == NowUser.UserID);
            if ((ds == null) || (ds.IsAdmin == false))
            {
                return false;
            }
            Perform s = new Perform();
            s.PerformID = dsw.PerformID;
            s.PerformName = dsw.PerformName;
            s.PerformAddress = dsw.PerformAddress;
            s.PerformCopmcition = dsw.PerformCopmcition;
            s.PerformInfo = dsw.PerformInfo;
            s.PerformBase = dsw.PerformBase;
            s.PerformMaxim = dsw.PerformMaxim;
            s.PerformMinum = dsw.PerformMinum; 
            s.PerformUnit = dsw.PerformUnit;
            PerformRepository.Add(s);
            DeviceToPerform dfs = new DeviceToPerform();
            dfs.DeviceID = dsw.DeviceID;
            dfs.PerformID = dsw.PerformID;
            devicePerformRepository.Add(dfs);
            return true;
        }
        public bool Update(DevicePerformView dsw)
        {
            DevicePerformView ds = new DevicePerformView();
            ds = PerformviewRepository.GetByFirstOrDefault(P => P.UserID == NowUser.UserID);
            if ((ds == null) || (ds.IsAdmin== false))
            {
                return false;
            }
            Perform s = new Perform();
            s.PerformID = dsw.PerformID;
            s.PerformName = dsw.PerformName;
            s.PerformAddress = dsw.PerformAddress;
            s.PerformCopmcition = dsw.PerformCopmcition;
            s.PerformInfo = dsw.PerformInfo;
            s.PerformBase = dsw.PerformBase;
            s.PerformMaxim = dsw.PerformMaxim;
            s.PerformMinum = dsw.PerformMinum;
            s.PerformUnit = dsw.PerformUnit;
            PerformRepository.Update(s);
            DeviceToPerform dfs = new DeviceToPerform();
            dfs.DeviceID = dsw.DeviceID;
            dfs.PerformID = dsw.PerformID;
            devicePerformRepository.Update(dfs);
            return true;
        }
        public IEnumerable<DevicePerformView> GetByCondiction(Expression<Func<DevicePerformView, bool>> where)
        {
            return PerformviewRepository.GetByCondition(where).Where<DevicePerformView>(P => P.UserID == NowUser.UserID);
        }
        public DevicePerformView GetFirstOrDefault(Expression<Func<DevicePerformView, bool>> where)
        {
            return PerformviewRepository.GetByCondition(where).Where<DevicePerformView>(P => P.UserID == NowUser.UserID).FirstOrDefault<DevicePerformView>();
        }
        public double GetPerformValue(int Performid)
        {
            Perform s = PerformRepository.GetByFirstOrDefault(P => P.PerformID == Performid);
            DevicePerformView ds = this.GetFirstOrDefault(P => P.UserID == NowUser.UserID);
            if (ds.ArrowRead == true)
            {
                return (double)s.PerformInPut;
            }
            return double.NaN;
        }
        public bool ControlPerform(int Performid,decimal dd)
        {
            DevicePerformView ds = this.GetFirstOrDefault(P => P.UserID == NowUser.UserID);
            if (ds.ArrowUpdate == true)
            {
                Perform pp = new Perform();
                pp.PerformID=ds.DeviceID;
                pp.PerformName=ds.PerformName;
                pp.PerformUnit = ds.PerformUnit;
                pp.PerformMaxim=ds.PerformMaxim;
                pp.PerformMinum= ds.PerformMinum;
                pp.PerformAddress=ds.PerformAddress;
                pp.PerformBase=ds.PerformBase;
                pp.PerformCopmcition=ds.PerformCopmcition;
                pp.PerformInPut = dd;
                PerformRepository.Update(pp);
            }
            return false;
        }
    }
}
