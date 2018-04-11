using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using TMS.Dal.Interface;
using TMS.Dal.Memory;
using TMS.Dal.Sql;
using TMS.Logic;
using TMS.Logic.Interface;
using TMS.Repository;
using TMS.Repository.Interface;

namespace TMS.Factory
{
    public class Factory
    {
        /// <summary>
        /// The connection string and context string. Makes the connection and context string available in the rest of the class.
        /// </summary>
        private readonly string ConnectionString;
        private readonly string Context;

        /// <summary>
        /// Initializes a new instance of the <see cref="Factory"/> class from windows form application.
        /// </summary>
        public Factory()
        {
            this.Context = ConfigurationManager.AppSettings["context"];
            this.ConnectionString = ConfigurationManager.ConnectionStrings[this.Context].ConnectionString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Factory"/> class.
        /// </summary>
        /// <param name="Config">
        /// The config. Gets the config file from ASP.net Core.
        /// </param>
        public Factory(IConfiguration Config)
        {
            this.Context = Config.GetSection("Database")["Type"];
            this.ConnectionString = Config.GetSection("ConnectionStrings")[this.Context];
        }

        /// <summary>
        /// The create context. AccountContext is being created at 
        /// </summary>
        /// <returns>
        /// The <see cref="IAccountContext"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        private IAccountContext CreateAccountContext()
        {
            switch (this.Context)
            {
                case "MSSQL": return new AccountMSSQLContext(this.ConnectionString);
                case "MEMORY": return new AccountMemoryContext();
                default: throw new NotImplementedException();
            }
        }
        public IAccountLogic AccountLogic() => new AccountLogic(new AccountRepository(this.CreateAccountContext()));
    }
}
