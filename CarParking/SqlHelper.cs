using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    public static class SqlHelper
    {
        private static string connectionString = @"Server=NisaPc;Database=OtoparkYonetimSistemi;User ID=Nisa;Password=12345;TrustServerCertificate=True;MultipleActiveResultSets=true;Min Pool Size=3;Connection Timeout=30;Pooling=false;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
