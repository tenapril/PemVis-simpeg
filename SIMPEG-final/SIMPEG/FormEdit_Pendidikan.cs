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
    public partial class FormEdit_Pendidikan : Form
    {
        List<string> data;
        public FormEdit_Pendidikan()
        {
            InitializeComponent();
        }
        public FormEdit_Pendidikan(List<string> pass_data)
        {
            InitializeComponent();
            this.data = pass_data;

            tb_nip.Text = data[0];
            tb_jenjang.Text = data[1];
            tb_jurusan.Text = data[2];
            tb_namasekolah.Text = data[3];
            tb_alamatsekolah.Text = data[4];
            tb_noijazah.Text = data[5];
            tb_tahunlulus.Text = data[6];
        }

        private void FormUserHome_Load(object sender, EventArgs e)
        {
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DBConnect dbkonek = new DBConnect();
            dbkonek.Initialize();
            dbkonek.OpenConnection();
            MySqlCommand sqlquery = dbkonek.buatcommand();

            string nip = tb_nip.Text;
            string jenjang = tb_jenjang.Text;
            string jurusan = tb_jurusan.Text;
            string namasekolah = tb_namasekolah.Text;
            string alamatsekolah = tb_alamatsekolah.Text;
            string noijazah = tb_noijazah.Text;
            string tahunlulus = tb_tahunlulus.Text;

            try
            {
                sqlquery.CommandText = "UPDATE pendidikan SET " +
                    "jenjang = @jenjang, jurusan = @jurusan, namasekolah = @namasekolah, " +
                    "alamatsekolah = @alamatsekolah, noijazah = @noijazah, tahunlulus = @tahunlulus " +
                    "WHERE nopendidikan = @nopendidikan;";
                sqlquery.Parameters.AddWithValue("@nopendidikan", data[7]);
                sqlquery.Parameters.AddWithValue("@jenjang" , jenjang);
                sqlquery.Parameters.AddWithValue("@jurusan", jurusan);
                sqlquery.Parameters.AddWithValue("@namasekolah", namasekolah);
                sqlquery.Parameters.AddWithValue("@alamatsekolah", alamatsekolah);
                sqlquery.Parameters.AddWithValue("@noijazah", noijazah);
                sqlquery.Parameters.AddWithValue("@tahunlulus", tahunlulus);
                sqlquery.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Edit");
                dbkonek.CloseConnection();
            }
            catch (Exception exc)
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
