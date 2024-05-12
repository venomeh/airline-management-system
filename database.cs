using System;
using Oracle.ManagedDataAccess.Client;

namespace DATABASE_PROJECT
{
    public class database
    {
        private OracleConnection _connection;

        public database()
        {
            _connection = GetConnection();
            _connection.Open();
        }

        public OracleConnection GetConnection()
        {
            string connectionString = "DATA SOURCE=localhost:1521/xe;USER ID=AirlineSystem;PASSWORD=12345;";
            return new OracleConnection(connectionString);
        }

        public OracleConnection con() { return _connection; }
    }
}
