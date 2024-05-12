using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=AirlineSystem; PASSWORD=12345");
        }

        public OracleConnection con() { return _connection; }

    }

}
