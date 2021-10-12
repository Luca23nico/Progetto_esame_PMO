using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoPMO
{
    public sealed class Database
    {
        private static Database dbInstance = null;
        private readonly MySqlConnection conn = new MySqlConnection(@"server = localhost; userid=root;password=;database=prova");
        private Database()
        {
        }
        public static Database GetInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new Database();
            }
            return dbInstance;
        }

        public MySqlConnection GetDBConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;  
        }
    }
}

