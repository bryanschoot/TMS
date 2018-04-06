using System;
using System.Collections.Generic;
using TMS.Dal.Interface;
using TMS.Model;

namespace TMS.Dal.Memory
{
    public class AccountMemoryContext : IAccountContext
    {
        public AccountMemoryContext() { }
        public IEnumerable<AccountModel> All()
        {
            throw new NotImplementedException();
        }

        public AccountModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(AccountModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(AccountModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(AccountModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(AccountModel entity)
        {
            throw new NotImplementedException();
        }

        public int Count(AccountModel entity)
        {
            throw new NotImplementedException();
        }
    }
}