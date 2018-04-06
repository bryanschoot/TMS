using System.Collections.Generic;
using TMS.Dal.Interface;
using TMS.Model;
using TMS.Repository.Interface;

namespace TMS.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private IAccountContext Context { get; }
        public AccountRepository(IAccountContext context)
        {
            this.Context = context;
        }
        public IEnumerable<AccountModel> All()
        {
            throw new System.NotImplementedException();
        }
        public AccountModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Exists(AccountModel entity)
        {
            throw new System.NotImplementedException();
        }
        public bool Insert(AccountModel entity)
        {
            throw new System.NotImplementedException();
        }
        public bool Update(AccountModel entity)
        {
            throw new System.NotImplementedException();
        }
        public bool Delete(AccountModel entity)
        {
            throw new System.NotImplementedException();
        }
        public int Count(AccountModel entity)
        {
            throw new System.NotImplementedException();
        }
    }
}