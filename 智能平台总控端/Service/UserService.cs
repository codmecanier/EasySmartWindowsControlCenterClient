using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 智能平台总控端.Models;

namespace 智能平台总控端.Service
{
    public class UserService
    {
        SqlDao<User> userRepository = new SqlDao<User>();
        public void Add(User us)
        {
            userRepository.Add(us);
        }
        public void Delete(User us)
        {
            userRepository.Delete(us);
        }
        public void Update(User us)
        {
            userRepository.Update(us);
        } 
        public bool Login(string username, string password)
        {
            User us = userRepository.GetByFirstOrDefault(P => P.UserName == username);
            if ((us != null) && (us.PassWord == password))
            {
                NowUser.UserID = us.UserID;
                NowUser.UserName = us.UserName;
                return true;
            }
            return false;
        }
    }
}
