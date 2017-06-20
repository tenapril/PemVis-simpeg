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
    public partial class FormEdit_Keluarga : Form
    {
        List<string> data;
        public FormEdit_Keluarga()
        {
            InitializeComponent();
        }
        public FormEdit_Keluarga(List<string> pass_data)
        {
            InitializeComponent();
            this.data = pass_data;

            tb_nip.Text = data[0];
            tb_nama.Text = data[1];
            cb_jk.Text = data[2];
            tb_pob.Text = data[3];
            tb_dob.Text = data[4];
            cb_pekerjaan.Text = data[5];
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
            string nama = tb_nama.Text;
            string pob = tb_pob.Text;
            string dob = tb_dob.Text;
            string jeniskel = cb_jk.Text;
            string pekerjaan = cb_pekerjaan.Text;

            try
            {
                sqlquery.CommandText = "UPDATE anak SET " +
                    "nama = @nama, tempat_lahir = @pob, tgl_lahir = @dob, " +
                    "kelamin = @jeniskel, pekerjaan = @pekerjaan " +
                    "WHERE noanak = @noanak;";
                sqlquery.Parameters.AddWithValue("@noanak", data[6]);
                sqlquery.Parameters.AddWithValue("@nama", nama);
                sqlquery.Parameters.AddWithValue("@pob", pob);
                sqlquery.Parameters.AddWithValue("@dob", dob);
                sqlquery.Parameters.AddWithValue("@jeniskel", jeniskel);
                sqlquery.Parameters.AddWithValue("@pekerjaan", pekerjaan);
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
