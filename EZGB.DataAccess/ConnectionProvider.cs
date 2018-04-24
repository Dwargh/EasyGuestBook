using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EZGB.DataAccess
{
    class ConnectionProvider : IDbConnectionProvider
    {
        public const string ConnectionStringName = "EZGBDatabase";
        public IDbConnection GetOpenConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
