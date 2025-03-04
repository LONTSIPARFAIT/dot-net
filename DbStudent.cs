using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace CRUD_DotNet
{
    internal class DbStudent
    {
        public static MySqlConnection GetMySqlConnection()
        {
            String connectionString = "server=localhost;" +
                                  "database=student-dot-net;" +
                                  "username=root;" +
                                  "pwd=; port=3306;";
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            Console.WriteLine("Connected success");
            connect.Close();
        }
    }
}
