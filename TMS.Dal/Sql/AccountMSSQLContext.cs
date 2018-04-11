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
            this.Query = $"SELECT [Email], [Password] FROM [Account] WHERE [Email]=@Email AND [Password]=@Password";

            using (SqlConnection Conn = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand Cmd = new SqlCommand(this.Query, Conn))
                {
                    Conn.Open();

                    Cmd.Parameters.Add(new SqlParameter("@Email", entity.Email));
                    Cmd.Parameters.Add(new SqlParameter("@Password", entity.Password));
                    SqlDataReader Reader = Cmd.ExecuteReader();

                    return Reader.HasRows;
                }
            }
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