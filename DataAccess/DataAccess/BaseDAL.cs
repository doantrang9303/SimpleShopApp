using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BaseDAL
    {
        public DataProvider Provider {  get; set; } = null;
        public SqlConnection Connection = null;
        public BaseDAL() {
            var connectionString = GetConnectionString();
            Provider = new DataProvider(connectionString);
        }

        //-------------------------------------------------------
        public string GetConnectionString()
        {
            string connectionString = null;

            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json",true,true)
                                    .Build();
            connectionString = config["ConnectionStrings:MyDB"];
            return connectionString;
        }
        //----------------------------------------------------
        public void CloseConnection() => Provider.CloseConnection(Connection);
    }

}
