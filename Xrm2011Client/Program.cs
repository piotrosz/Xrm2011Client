using System;
using System.Configuration;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;

namespace XrmQuery
{
    class Program
    {
        static void Main()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Xrm"].ConnectionString;
            var connection = CrmConnection.Parse(connectionString);

            using (var organizationService = new OrganizationService(connection))
            {
                
            }
        }
    }
}
