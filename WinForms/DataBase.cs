using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WinForms
{
    class DataBase
    {
               
        public void OpenConnection()
        {
            MySqlConnection connection = GetConnection();
            
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            
        }
        public void CloseConnection()
        {
            MySqlConnection connection = GetConnection();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            string pathToFile = @"C:\\Users\isila\Desktop\pass.txt";
            string password = File.ReadAllText(pathToFile);

            string connString = "server = localhost; database = users;port = 3306;username = root;password=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            Console.WriteLine("Succsess");
            return connection;
        }
    }
}
