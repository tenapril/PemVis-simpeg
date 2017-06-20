using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SIMPEG
{
    class DBConnect
    {
        private MySqlConnection connection;
        
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            server = "vps.eriksenfinarto.com";
            port = "3306";
            database = "pemvis_simpeg";
            uid = "pemvis_simpeg";
            password = "pemvis2017";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" +
            port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool LoginForm(string username,string password)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM pegawai WHERE email = @email AND password = @password";
                cmd.Parameters.AddWithValue("@email", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                cmd.Connection = connection;
                MySqlDataReader login = cmd.ExecuteReader();
                if (login.Read())
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public MySqlCommand buatcommand()
        {
            return connection.CreateCommand();
        }
    }
}
