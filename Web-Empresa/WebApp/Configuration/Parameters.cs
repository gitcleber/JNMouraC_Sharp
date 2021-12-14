using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Configuration
{
    public class Parameters
    {
        public static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["Empresa"].ConnectionString;
        }
    }
}