using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasySmartDataBaseService.Models;

namespace EasySmartDataBaseService.Service
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
        public User Login(string username, string password)
        {
            User us = userRepository.GetByFirstOrDefault(P => P.UserName == username);
            if ((us != null) && (us.PassWord == password))
            {
                User ud = new User();
                ud.UserName=username;
                ud.PassWord=password;
                return ud;
            }
            return null;
        }
    }
}
