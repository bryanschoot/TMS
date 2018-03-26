using System.Collections.Generic;
using TMS.Logic.Interface;
using TMS.Model;
using TMS.Repository.Interface;

namespace TMS.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserRepository repository;

        public UserLogic(IUserRepository userRepository)
        {
            repository = userRepository;
        }

        public UserModel GetUser(int id)
        {
            UserModel user = repository.Read(id);
            return user;
        }

        public List<UserModel> GetAll()
        {
            var users = repository.GetAll();
            return users as List<UserModel>;
        }
    }
}