using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLib
{
    public static class ConnectionSafe
    {
        private static ServerConnection.Configuration config;

        public static OrganizationServiceProxy GetOrganizationProxy()
        {
            if(config == null)
            {
                ServerConnection serverConnect = new ServerConnection();
                config = serverConnect.GetServerConfiguration();
            }
            return ServerConnection.GetOrganizationProxy(config);
        }
    }

    internal static class GetAppConfig
    {
        public static string ServerAddress { get { return ConfigurationManager.AppSettings["ServerAddress"]; } }
        public static string SSL { get { return ConfigurationManager.AppSettings["SSL"]; } }
        public static string OrganizationName { get { return ConfigurationManager.AppSettings["OrganizationName"]; } }
        public static string User { get { return ConfigurationManager.AppSettings["User"]; } }
        public static string Password { get { return ConfigurationManager.AppSettings["Password"]; } }
        public static string CredentialsFilePath { get { return Path.Combine(Path.GetFullPath(ConfigurationManager.AppSettings["CredentialsFilePath"]), "Credentials.xml"); } }
    }
}
