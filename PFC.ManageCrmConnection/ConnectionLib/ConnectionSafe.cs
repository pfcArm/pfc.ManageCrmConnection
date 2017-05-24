using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLib
{
    public class ConnectionSafe
    {
        public void TryToUse()
        {
            //var org = ServerConnection.GetOrganizationProxy();

            //metadata
            IServiceManagement<IOrganizationService> orgServiceManagement = ServiceConfigurationFactory.CreateManagement<IOrganizationService>(new Uri("https://crmqa.pruksa.com/CRMQA"));
            //auth
            //AuthenticationCredentials authCredentials = orgServiceManagement.Authenticate(credentials);
            /*
            using (var service = new OrganizationServiceProxy(uri, uri, credential, credential)){ }

            using (var service = new OrganizationServiceProxy(orgServiceManagement, authCredentials.SecurityTokenResponse)) {

            }

            using (var service = new OrganizationServiceProxy(orgServiceManagement, authCredentials.ClientCredentials)){

            }
            */
        }
    }
}
