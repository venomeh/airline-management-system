using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace DATABASE_PROJECT
{
    public class database
    {
        private NpgsqlConnection _connection;

        public database()
        {
            _connection = GetConnection();
            _connection.Open();
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=password;Database=demo;");
        }

    }
}
