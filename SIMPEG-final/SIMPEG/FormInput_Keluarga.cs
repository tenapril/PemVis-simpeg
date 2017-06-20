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
    public partial class FormInput_Keluarga : Form
    {
        string nip;
        public FormInput_Keluarga()
        {
            InitializeComponent();
        }
        public FormInput_Keluarga(string nip_pass)
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
            
            string nama = tb_nama.Text;
            string pob = tb_pob.Text;
            string dob = tb_dob.Text;
            string jeniskel = cb_jk.Text;
            string pekerjaan = cb_pekerjaan.Text;

            try
            {
                sqlquery.CommandText = "INSERT INTO anak " +
                    "(nip,nama,tempat_lahir,tgl_lahir,kelamin,pekerjaan)" +
                    " VALUES (@nip, @nama, @pob, @dob, @jeniskel,@pekerjaan);";
                sqlquery.Parameters.AddWithValue("@nip", nip);
                sqlquery.Parameters.AddWithValue("@nama", nama);
                sqlquery.Parameters.AddWithValue("@pob", pob);
                sqlquery.Parameters.AddWithValue("@dob", dob);
                sqlquery.Parameters.AddWithValue("@jeniskel", jeniskel);
                sqlquery.Parameters.AddWithValue("@pekerjaan", pekerjaan);
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
