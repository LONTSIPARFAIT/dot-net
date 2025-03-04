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
            String connectionString = "server=localhost;database=student-dot-net;username=root;pwd=;port=3306;";
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            //Console.WriteLine("Connected success");
            //connect.Close;
            return connect;
        }

        public static AddStudent(Student student)
        {
            MySqlConnection connect = GetMySqlConnection();

            // Definir la requette SQL d'insertion
            string query = "INSERT INTO student (name, resister, class, section) VALUES (@name, @resister, @class, @section)";

            //creation de la commande sql
            MySqlCommand command = new MySqlCommand(query, connect);

            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@register", student.Register);
            command.Parameters.AddWithValue("@class", student.Class);
            command.Parameters.AddWithValue("@section", student.Section);

            //Exeption de la requete
            command.ExecuteNonQuery();

            //Afficher un message de confirmation
            MessageBox("");
        }
    }
}
