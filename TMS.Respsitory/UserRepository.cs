using System.Collections.Generic;
using TMS.Dal.Interface;
using TMS.Model;
using TMS.Repository.Interface;

namespace TMS.Repository
{
    public class UserRepository : IUserRepository
    {
        IDal context { get; }

        public UserRepository(IDal context)
        {
            this.context = context;
        }

        public void Create(UserModel entity)
        {
            throw new System.NotImplementedException();
        }

        public UserModel Read(int id)
        {
            return context.Read(id);
        }

        public void Update(UserModel entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(UserModel entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            return context.GetAll();
        }
    }
}