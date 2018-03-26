using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using TMS.Dal.Interface;
using TMS.Dal.Memory;
using TMS.Logic;
using TMS.Logic.Interface;
using TMS.Repository;
using TMS.Repository.Interface;

namespace TMS.Factory
{
    public class UserFactory
    {
        private string context;

        public UserFactory(IConfiguration config)
        {
            context = config["ContextType:Type"];
        }

        public IUserRepository CreateUserRepository(IDal context)
        {
            IUserRepository repository = new UserRepository(context);
            return repository;
        }

        public IUserLogic CreateUserLogic()
        {
            UserLogic logic = null;

            switch (context)
            {
                case "MSSQL":
                    logic = new UserLogic(CreateUserRepository(new UserMemory()));
                    break;
                case "MEMORY":
                    logic = new UserLogic(CreateUserRepository(new UserMemory()));
                    break;
            }
            return logic;
        }
    }
}
