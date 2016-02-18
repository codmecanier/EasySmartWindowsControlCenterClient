using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EasySmartDataBaseService.Models;

namespace EasySmartDataBaseService.Service
{
    public class FloorService
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
            utf.UserID  = us.UserID;
            UserRepository.Add(utf);
        }

        public bool Delete(FloorView fw)
        {
            FloorView few = FloorViewRepository.GetByFirstOrDefault(P => P.UserID == us.UserID);
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
            FloorView few = FloorViewRepository.GetByFirstOrDefault(P => P.UserID == us.UserID);
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
        public IEnumerable<FloorView> GetByCondiction(Expression<Func<FloorView, bool>> where , User us)
        {
            return FloorViewRepository.GetByCondition(where, us).Where(P => P.UserID == us.UserID);
        }
        public FloorView GetFirstOrDefault(Expression<Func<FloorView, bool>> where , User us)
        {
            FloorView fw = FloorViewRepository.GetByFirstOrDefault(where);
            if (fw.UserID == us.UserID)
            { return fw; }
            return null;
        }
        public IEnumerable<FloorView> GetAll(User us)
        {
            IEnumerable<FloorView> floorlist =  FloorViewRepository.GetByCondition(P => P.UserID == us.UserID);
            return floorlist;
        }
    }
}
