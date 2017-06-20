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
    public partial class FormInput_Pendidikan : Form
    {
        string nip;
        public FormInput_Pendidikan()
        {
            InitializeComponent();
        }
        public FormInput_Pendidikan(string nip_pass)
        {
            InitializeComponent();
            this.nip = nip_pass;
            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DBConnect dbkonek = new DBConnect();
            dbkonek.Initialize();
            dbkonek.OpenConnection();
            MySqlCommand sqlquery = dbkonek.buatcommand();

            string jenjang = tb_jenjang.Text;
            string jurusan = tb_jurusan.Text;
            string namasekolah = tb_namasekolah.Text;
            string alamatsekolah = tb_alamatsekolah.Text;
            string noijazah = tb_noijazah.Text;
            string tahunlulus = tb_tahunlulus.Text;

            try
            {
                sqlquery.CommandText = "INSERT INTO pendidikan " +
                    "(nip,jenjang,jurusan,namasekolah,alamatsekolah,noijazah,tahunlulus)" +
                    " VALUES (@nip, @jenjang, @jurusan, @namasekolah, @alamatsekolah, @noijazah, @tahunlulus);";
                sqlquery.Parameters.AddWithValue("@nip", nip);
                sqlquery.Parameters.AddWithValue("@jenjang", jenjang);
                sqlquery.Parameters.AddWithValue("@jurusan", jurusan);
                sqlquery.Parameters.AddWithValue("@namasekolah", namasekolah);
                sqlquery.Parameters.AddWithValue("@alamatsekolah", alamatsekolah);
                sqlquery.Parameters.AddWithValue("@noijazah", noijazah);
                sqlquery.Parameters.AddWithValue("@tahunlulus", tahunlulus);
                sqlquery.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Inputkan");
                dbkonek.CloseConnection();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
