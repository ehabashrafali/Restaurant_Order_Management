using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace ResturantTaskSDk.Data
{
    public static class CrmServiceHelper
    {
        public static IOrganizationService GetCrmService()
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string connectionString = ConfigurationManager.ConnectionStrings["CRMConnectionString"].ConnectionString;
                CrmServiceClient crmServiceClient = new CrmServiceClient(connectionString);

                if (crmServiceClient != null && crmServiceClient.IsReady)
                {
                    return (IOrganizationService)crmServiceClient.OrganizationServiceProxy;
                }
                else
                {
                    throw new Exception(crmServiceClient.LastCrmError);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to establish CRM connection.", ex);
            }
        }
    }
}