﻿using System;
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
        //        string MyConnectionString = "Server=vps.eriksenfinarto.com;Port=3306;Database=pemvis_simpeg;Uid=pemvis_simpeg;Pwd=pemvis2017";
        List<string> data = new List<string>();
        public FormLogin()
        {
            InitializeComponent();

        }

        private bool validate_login(string username, string password)
        {

            DBConnect dbkonek = new DBConnect();
            dbkonek.Initialize();
            dbkonek.OpenConnection();
            //MySqlConnection connection = new MySqlConnection(MyConnectionString);
            //connection.Open();
            return dbkonek.LoginForm(username, password);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            bool r = validate_login(username, password);
            MySqlDataReader reader = null;
            DBConnect dbkonek = new DBConnect();
            dbkonek.Initialize();
            dbkonek.OpenConnection();
            MySqlCommand query = dbkonek.buatcommand();
            query.CommandText = "SELECT priv FROM pegawai where email = @email";
            query.Parameters.AddWithValue("@email", username);
            query.ExecuteNonQuery();
            reader = query.ExecuteReader();

            while (reader.Read())
            {
                List<string> temp = new List<string>();
                temp.Add(reader["priv"].ToString());
                data = temp;
            }
            dbkonek.CloseConnection();
            if (r)
            {
                MessageBox.Show("Correct Login Credentials");
                this.Hide();
                if (data[0] == "admin")
                {
                    FormAdminHome admin = new FormAdminHome();
                    admin.Show();
                }else if(data[0] == "user")
                {
                    FormUserHome user = new FormUserHome(username);
                    user.Show();
                }
//                this.Close();
            }
            else
                MessageBox.Show("Incorrect Login Credentials");
        }
    }
}

