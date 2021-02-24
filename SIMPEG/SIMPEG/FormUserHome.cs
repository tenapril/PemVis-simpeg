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
    public partial class FormUserHome : Form
    {
        string email;
        List<string> data = new List<string>();
        public FormUserHome()
        {
            InitializeComponent();
        }
        public FormUserHome(string username)
        {
            InitializeComponent();
            this.email = username;
        }

        private void FormUserHome_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            DBConnect dbkonek = new DBConnect();
            dbkonek.Initialize();
            dbkonek.OpenConnection();
            MySqlCommand query = dbkonek.buatcommand();
            query.CommandText = "SELECT * FROM pegawai where email = @email";
            query.Parameters.AddWithValue("@email", email);
            query.ExecuteNonQuery();
            reader = query.ExecuteReader();

            while (reader.Read())
            {
                List<string> temp = new List<string>();
                temp.Add(reader["nip"].ToString());
                temp.Add(reader["nama"].ToString());
                temp.Add(reader["goldarah"].ToString());
                temp.Add(reader["agama"].ToString());
                temp.Add(reader["alamat"].ToString());
                temp.Add(reader["notelpon"].ToString());
                temp.Add(reader["tempat_lahir"].ToString());
                temp.Add(reader["tanggal_lahir"].ToString());
                temp.Add(reader["jabatan"].ToString());
                temp.Add(reader["bagian"].ToString());
                temp.Add(reader["kodekantor"].ToString());
                temp.Add(reader["gaji"].ToString());
                temp.Add(reader["kelamin"].ToString());
                temp.Add(reader["email"].ToString());
                temp.Add(reader["password"].ToString());
                data = temp;

               
            }
            dbkonek.CloseConnection();

            tb_nip.Text = data[0];
            tb_nama.Text = data[1];
            tb_goldar.Text = data[2];
            tb_agama.Text = data[3];
            tb_alamat.Text = data[4];
            tb_pob.Text = data[6];
            tb_dob.Text = data[7];
            tb_jabatan.Text = data[8];
            tb_kodekantor.Text = data[10];
            tb_jk.Text = data[12];
            tb_gaji.Text = data[13];
            tb_email.Text = data[14];

        }
    }
}
