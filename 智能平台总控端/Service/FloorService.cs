using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using 智能平台总控端.Models;

namespace 智能平台总控端.Service
{
    public class FloorService:BaseService
    {
        public SqlDao<Floor> FloorRepositroy = new SqlDao<Floor>();
        public SqlDao<FloorView> FloorViewRepository = new SqlDao<FloorView>();
        public SqlDao<UserToFloor> UserRepository = new SqlDao<UserToFloor>();

        public void Add(FloorView fw)
        {
            Floor f = new Floor();
            f.FloorID = fw.FloorID;
            f.FloorName = fw.FloorName;
            f.FloorInfo = fw.FloorInfo;
            FloorRepositroy.Add(f);
            UserToFloor utf = new UserToFloor();
            utf.IsAdmin = true;
            utf.FloorID = f.FloorID;
            utf.UserID  = NowUser.UserID;
            UserRepository.Add(utf);
        }

        public bool Delete(FloorView fw)
        {
            FloorView few = FloorViewRepository.GetByFirstOrDefault(P => P.UserID == NowUser.UserID);
            if ((few == null )||( few.IsAdmin == false))
            {
                return false;
            }
            Floor f = new Floor();
            f.FloorID = fw.FloorID;
            f.FloorName = fw.FloorName;
            f.FloorInfo = fw.FloorInfo;
            FloorRepositroy.Delete(f);
            UserToFloor utf = new UserToFloor();
            utf.IsAdmin = true;
            utf.UserID = fw.UserID;
            utf.FloorID = fw.FloorID;
            UserRepository.Delete(utf);
            return true;
        }
        public bool Update(FloorView fw)
        {
            FloorView few = FloorViewRepository.GetByFirstOrDefault(P => P.UserID == NowUser.UserID);
            if (few != null || few.IsAdmin != false)
            {
                return false;
            }
            Floor f = new Floor();
            f.FloorID = fw.FloorID;
            f.FloorName = fw.FloorName;
            f.FloorInfo = fw.FloorInfo;
            FloorRepositroy.Update(f);
            UserToFloor utf = new UserToFloor();
            utf.IsAdmin = true;
            utf.UserID = fw.UserID;
            utf.FloorID = fw.FloorID;
            UserRepository.Update(utf);
            return true;
        }
        public IEnumerable<FloorView> GetByCondiction(Expression<Func<FloorView, bool>> where)
        {
            return FloorViewRepository.GetByCondition(where).Where(P => P.UserID == NowUser.UserID);
        }
        public FloorView GetFirstOrDefault(Expression<Func<FloorView, bool>> where)
        {
            FloorView fw = FloorViewRepository.GetByFirstOrDefault(where);
            if (fw.UserID == NowUser.UserID)
            { return fw; }
            return null;
        }
        public IEnumerable<FloorView> GetAll()
        {
            IEnumerable<FloorView> floorlist =  FloorViewRepository.GetByCondition(P => P.UserID == NowUser.UserID);
            return floorlist;
        }
    }
}
