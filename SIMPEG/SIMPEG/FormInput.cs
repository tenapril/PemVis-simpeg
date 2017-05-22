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
    public partial class FormInput : Form
    {
        string MyConnectionString = "Server=localhost;Database=db_pemvis_umn;Uid=eriksen;Pwd='123'";

        public FormInput()
        {
            InitializeComponent();
        }
        
        private void btn_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(MyConnectionString);
            MySqlCommand sqlquery;

            string nip = tb_nip.Text;
            string name = tb_nama.Text;
            string jeniskel = cb_jk.Text;
            string pob = tb_pob.Text;
            string dob = tb_dob.Text;
            string postal = tb_postal.Text;

            try
            {
                conn.Open();
                sqlquery = conn.CreateCommand();
                sqlquery.CommandText = "INSERT INTO karyawan (nopeg, nama, jenkelamin, kota, kodepos, tgllahir)" +
                    " VALUES ('" + nip + "', '" + name + "', '" + jeniskel + "', '" + pob + "', '" + postal + "', '" + tb_dob + "');";
                sqlquery.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Inputkan");
                conn.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
