using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace H2School_ForumDB_Web.Data
{
    public class ConnectionConfig
    {
        public static IConfigurationRoot Configuration { get; private set; }
        static string connectionString;

        public static void ConnectionSQL()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            connectionString = Configuration.GetConnectionString("DefaultConnection");
        }
    }
}
