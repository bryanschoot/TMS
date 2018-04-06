using System.Collections.Generic;
using TMS.Dal.Interface;
using TMS.Model;
using System.Data;

namespace TMS.Dal.Sql
{
    using System;
    using System.Data.Common;
    using System.Data.SqlClient;

    public class AccountMSSQLContext : IAccountContext
    {
        private string ConnectionString { get; }
        private string Query;
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
            bool result = false;
            this.Query = $"";
            using (SqlConnection con = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(this.Query, con))
                {
                    cmd.Parameters.Add(new SqlParameter());
                    cmd.Parameters.Add(new SqlParameter());
                    cmd.ExecuteNonQuery();
                    result = true;
                }

            }
            return result;
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