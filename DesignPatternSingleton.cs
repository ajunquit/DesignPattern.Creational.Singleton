using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace design_pattern_singleton
{

    class ConnectionDatabase
    {
      
        private string Server { get; set; }
        private string Database { get; set; }
        private string UserId { get; set; }
        private string Password { get; set; }

        private static ConnectionDatabase _connectionDatabase;

        private ConnectionDatabase()
        {
            Server = "myServer";
            Database = "myDatabase";
            UserId = "myUserId";
            Password = "myPassword";
        }

        public string GetConnectionString()
        {
            return $"Server={Server};Database={Database};User Id={UserId};Password={Password};";
        }

        public static ConnectionDatabase GetConnectionDatabase()
        {
            if (_connectionDatabase == null)
            {
                _connectionDatabase = new ConnectionDatabase();
            }
            return _connectionDatabase;
        }

    }
}
