using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SIMPEG
{
    public partial class FormAdminUserEdit : Form
    {
        List<string> data;
        public FormAdminUserEdit()
        {
            InitializeComponent();
        }
        public FormAdminUserEdit(List<string> pass_data)
        {
            InitializeComponent();
            this.data = pass_data;
        }

        private void FormUserHome_Load(object sender, EventArgs e)
        {
            tb_nip.Text = data[0];
            tb_nama.Text = data[1];
            tb_email.Text = data[2];
            tb_pob.Text = data[3];
            tb_dob.Text = data[4];
            cb_jk.Text = data[5];
            cb_goldar.Text = data[6];
            cb_agama.Text = data[7];
            tb_alamat.Text = data[8];
            tb_telpon.Text = data[9];
            tb_kodekantor.Text = data[10];
            tb_bagian.Text = data[11];
            tb_jabatan.Text = data[12];
            tb_gaji.Text = data[13];
            tb_password.Text = data[14];
            tb_priv.Text = data[15];
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
                sqlquery.CommandText = "UPDATE pegawai SET " +
                    "nama = @nama, tempat_lahir = @pob, tanggal_lahir = @dob, " + 
                    "kelamin = @jeniskel, goldarah = @goldar, agama = @agama, email = @email, " + 
                    "kodekantor = @kodekantor, jabatan = @jabatan, gaji = @gaji, alamat = @alamat, " + 
                    "priv = @priv, password = @password, notelpon = @telpon, bagian = @bagian " +
                    "WHERE nip = @nip;";
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
                sqlquery.Parameters.AddWithValue("@bagian", bagian);

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
