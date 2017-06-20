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
        
        public FormInput()
        {
            InitializeComponent();
        }
        
        private void btn_submit_Click(object sender, EventArgs e)
        {
            DBConnect dbkonek = new DBConnect();
            dbkonek.Initialize();
            dbkonek.OpenConnection();
            MySqlCommand sqlquery = dbkonek.buatcommand();

            string nip = tb_nip.Text;
            string nama = tb_nama.Text;
            string pob = tb_pob.Text;
            string dob = tb_dob.Text;
            string jeniskel = cb_jk.Text;
            string goldar = cb_goldar.Text;
            string agama = cb_agama.Text;
            string email = tb_email.Text;
            string kodekantor = tb_kodekantor.Text;
            string jabatan = tb_jabatan.Text;
            string gaji = tb_gaji.Text;
            string alamat = tb_alamat.Text;
            string priv = tb_priv.Text;
            string password = tb_password.Text;
            string telpon = tb_telpon.Text;
            string bagian = tb_bagian.Text;

            try
            {
                sqlquery.CommandText = "INSERT INTO pegawai " + 
                    "(nip, nama, tempat_lahir, tanggal_lahir, kelamin, goldarah, agama, email, kodekantor, jabatan, gaji, alamat,priv,password,notelpon,bagian)" +
                    " VALUES (@nip, @nama, @pob, @dob, @jeniskel, @goldar, @agama, @email, @kodekantor, @jabatan, @gaji, @alamat, @priv, @password,@telpon,@bagian);";
                sqlquery.Parameters.AddWithValue("@nip", nip);
                sqlquery.Parameters.AddWithValue("@nama", nama);
                sqlquery.Parameters.AddWithValue("@pob", pob);
                sqlquery.Parameters.AddWithValue("@dob", dob);
                sqlquery.Parameters.AddWithValue("@jeniskel", jeniskel);
                sqlquery.Parameters.AddWithValue("@goldar", goldar);
                sqlquery.Parameters.AddWithValue("@agama", agama);
                sqlquery.Parameters.AddWithValue("@email", email);
                sqlquery.Parameters.AddWithValue("@kodekantor", kodekantor);
                sqlquery.Parameters.AddWithValue("@jabatan", jabatan);
                sqlquery.Parameters.AddWithValue("@gaji", gaji);
                sqlquery.Parameters.AddWithValue("@alamat", alamat);
                sqlquery.Parameters.AddWithValue("@priv", priv);
                sqlquery.Parameters.AddWithValue("@password", password);
                sqlquery.Parameters.AddWithValue("@telpon", telpon);
                sqlquery.Parameters.AddWithValue("@bagian",bagian);

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
