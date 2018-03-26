using System;
using System.Collections.Generic;
using TMS.Dal.Interface;
using TMS.Model;

namespace TMS.Dal.Memory
{
    public class UserMemory : IDal
    {
        List<UserModel> users = new List<UserModel>();

        public UserMemory()
        {
            users.Add(new UserModel(1, "Sven", "Schoot", 21));
            users.Add(new UserModel(2, "Bryan", "Schoot", 18));
            users.Add(new UserModel(3, "Jasper", "Schoot", 15));
            users.Add(new UserModel(4, "Melle", "Schoot", 13));
        }

        public UserModel Read(int id)
        {
            var user = users.Find(x => x.Id == id);

            return user;
        }

        public List<UserModel> GetAll()
        {
            return users;
        }
    }
}