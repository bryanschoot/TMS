using System;
using System.Configuration;
using TMS;

namespace TMS.Config
{
    public class Config
    {
        private string Context;
        private string ConnectionString;

        public Config(ConfigurationManager config)
        {
        }

        public string GetXml()
        {
            this.Context = ConfigurationManager.AppSettings["context"];
            this.ConnectionString = ConfigurationManager.ConnectionStrings[Context].ConnectionString;

            return this.ConnectionString;
        }
    }
}
