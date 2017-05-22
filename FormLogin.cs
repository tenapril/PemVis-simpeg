using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SIMPEG
{
    public partial class FormLogin : Form
    {
        string MyConnectionString = "Server=vps.eriksenfinarto.com;Port=3306;Database=pemvis_simpeg;Uid=pemvis_simpeg;Pwd=pemvis2017";

        public FormLogin()
        {
            InitializeComponent();
            
        }

        private bool validate_login(string username, string password)
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
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
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            bool r = validate_login(username, password);
            if (r)
                MessageBox.Show("Correct Login Credentials");
            else
                MessageBox.Show("Incorrect Login Credentials");
            }
            
        }
    }

