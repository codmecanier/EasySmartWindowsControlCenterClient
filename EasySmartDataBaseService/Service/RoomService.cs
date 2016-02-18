using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EasySmartDataBaseService.Models;

namespace EasySmartDataBaseService.Service
{
    public class RoomService
    {
        private SqlDao<RoomView> RoomViewRepository = new SqlDao<RoomView>();
        private SqlDao<Room> RoomRePository = new SqlDao<Room>();
        private SqlDao<RoomToUser> UserRepository = new SqlDao<RoomToUser>();
        private SqlDao<FloorToRoom> FloorRoomRepository = new SqlDao<FloorToRoom>();
        public void Add(RoomView rw)
        {
            Room rm = new Room();
            rm.RoomID = rw.RoomID;
            rm.RoomName = rw.RoomName;
            rm.RoomInfo = rw.FloorInfo;
            RoomRePository.Add(rm);
            RoomToUser rtu = new RoomToUser();
            rtu.UserID = us.UserID;
            rtu.IsAdmin = true;
            rtu.RoomID = rm.RoomID;
            UserRepository.Add(rtu);
            FloorToRoom ftr = new FloorToRoom();
            ftr.FloorID = rw.FloorID;
            ftr.RoomID = rm.RoomID;
            FloorRoomRepository.Add(ftr);
        }
        public bool Delete(RoomView rw)
        {
            RoomView r = RoomViewRepository.GetByFirstOrDefault(P => P.UserID == us.UserID);
            if ((r == null) || (r.IsAdmin == false))
            {
                return false;
            }
            Room rm = RoomRePository.GetByFirstOrDefault(p => p.RoomID == r.RoomID);
            RoomRePository.Delete(rm);
            RoomToUser rtu = UserRepository.GetByFirstOrDefault(p => p.RoomID == r.RoomID);
            UserRepository.Delete(rtu);
            FloorToRoom ftr = FloorRoomRepository.GetByFirstOrDefault(p => p.RoomID == r.RoomID);
            FloorRoomRepository.Delete(ftr);
            return true;
        }
        public bool Update(RoomView rw)
        {
            RoomView r = GetFirstOrDefault(P=>P.RoomID==rw.RoomID);
            if ((r == null) || (r.IsAdmin == false))
            {
                return false;
            }
            Room rm = RoomRePository.GetByFirstOrDefault(p => p.RoomID == r.RoomID);
            rm.RoomID = rw.RoomID;
            rm.RoomName = rw.RoomName;
            rm.RoomInfo = rw.FloorInfo;
            RoomRePository.Update(rm);
            RoomToUser rtu = UserRepository.GetByFirstOrDefault(p => p.RoomID == r.RoomID);
            rtu.UserID = us.UserID;
            rtu.IsAdmin = true;
            rtu.RoomID = rm.RoomID;
            UserRepository.Update(rtu);
            FloorToRoom ftr = FloorRoomRepository.GetByFirstOrDefault(p => p.RoomID == r.RoomID);
            ftr.FloorID = rw.FloorID;
            ftr.RoomID = rm.RoomID;
            FloorRoomRepository.Update(ftr);
            return true;
        }
        public IEnumerable<RoomView> GetAll(User us)
        {
            return RoomViewRepository.GetByCondition(P => P.UserID == us.UserID);
        }
        public IEnumerable<RoomView> GetByCondiction(Expression<Func<RoomView, bool>> where , User us)
        {
            return RoomViewRepository.GetByCondition(where, us).Where<RoomView>(P => P.UserID == us.UserID);
        }
        public RoomView GetFirstOrDefault(Expression<Func<RoomView, bool>> where , User us)
        {
            RoomView rw = RoomViewRepository.GetByFirstOrDefault(where);
            if ((rw == null) || (rw.UserID != us.UserID))
            {
                return null;
            }
            return rw;
        }
    }
}
