using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using TMS.Dal.Interface;
using TMS.Dal.Memory;
using TMS.Logic;
using TMS.Logic.Interface;
using TMS.Repository;
using TMS.Repository.Interface;

namespace TMS.Factory
{
    public class Factory
    {
        private string ConnectionString;
        private string Context;
        //Reading Form Application
        public Factory()
        {
            this.Context = ConfigurationManager.AppSettings["context"];
            this.ConnectionString = ConfigurationManager.ConnectionStrings[this.Context].ConnectionString;
        }
        //Reading Core Application
        public Factory(IConfiguration Config)
        {
            this.Context = Config.GetSection("Database")["Type"];
            this.ConnectionString = Config.GetSection("ConnectionStrings")[Context];
        }
        private IDal CreateDal()
        {
            IDal context = null;

            switch (this.Context)
            {
                case "MSSQL":
                    context = new SQLContext(context, ConnectionString);
                    break;
                case "MEMORY":
                    context = new MemoryContext();
                    break;
                default:
                    new NotImplementedException();
                    break;
            }

            return context;
        }
        private IAccountRepository CreateAccountRepository(IDal context)
        {
            IAccountRepository repository = new AccountRepository(context, this.Context);
        }
        private IAccountLogic CreateAccountLogic()
        {
            var logic = new AccountLogic(this.CreateAccountRepository(this.CreateDal()));
        }
        private IUserRepository CreateUserRepository(IDal context)
        {
            IUserRepository repository = new UserRepository(context);
            return repository;
        }
        public IUserLogic CreateUserLogic()
        {
            var logic = new UserLogic(this.CreateUserRepository(this.CreateDal()));
            return logic;
        }
    }
}
