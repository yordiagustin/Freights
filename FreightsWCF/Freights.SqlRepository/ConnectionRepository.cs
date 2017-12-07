using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Freights.SqlRepository
{
    public class ConnectionRepository
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["FreightsDB"].ToString();
        }
    }
}
