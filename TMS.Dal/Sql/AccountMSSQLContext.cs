using System.Collections.Generic;
using TMS.Dal.Interface;
using TMS.Model;

namespace TMS.Dal.Sql
{
    public class AccountMSSQLContext : IAccountContext
    {
        private string ConnectionString { get; }
        public AccountMSSQLContext(string connstring)
        {
            this.ConnectionString = connstring;
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