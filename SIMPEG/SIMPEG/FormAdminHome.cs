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
    
    public partial class FormAdminHome : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=vps.eriksenfinarto.com;Database=pemvis_simpeg;Uid=pemvis_simpeg;Pwd='pemvis2017'");
        List<List<string>> data = new List<List<string>>();
        public FormAdminHome()
        {
            InitializeComponent();
        }

        private void FormAdminHome_Load(object sender, EventArgs e)
        {

            MySqlDataReader reader = null;

            list_pegawai.Items.Clear();
            list_pegawai.Columns.Clear();
            list_pegawai.Columns.Add("NIP", 50, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Nama Lengkap", 100, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Gender", 40, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Tempat Lahir", 100, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Tanggal Lahir", 100, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Gol. Darah", 50, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Agama", 60, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("No Telp", 100, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Email", 100, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Jabatan", 100, HorizontalAlignment.Left);

            list_pegawai.GridLines = true;
            list_pegawai.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            list_pegawai.View = View.Details;
            list_pegawai.MultiSelect = false;

            conn.Open();
            MySqlCommand query = conn.CreateCommand();
            query.CommandText = "SELECT * FROM pegawai";
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
                data.Add(temp);

                ListViewItem item = new ListViewItem(reader["nip"].ToString(), 0);
                item.SubItems.Add(reader["nama"].ToString());
                item.SubItems.Add(reader["kelamin"].ToString());
                item.SubItems.Add(reader["tempat_lahir"].ToString());
                item.SubItems.Add(reader["tanggal_lahir"].ToString());
                item.SubItems.Add(reader["goldarah"].ToString());
                item.SubItems.Add(reader["agama"].ToString());
                item.SubItems.Add(reader["notelpon"].ToString());
                item.SubItems.Add(reader["email"].ToString());
                item.SubItems.Add(reader["jabatan"].ToString());
                list_pegawai.Items.Add(item);

            }
            conn.Close();

        }

        private void adduser_hover(object sender, EventArgs e)
        {
            tooltip_adduser = new ToolTip();

            tooltip_adduser.ToolTipIcon = ToolTipIcon.Info;
            tooltip_adduser.IsBalloon = true;
            tooltip_adduser.ShowAlways = true;
        }

        private void list_pegawai_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = list_pegawai.HitTest(e.X, e.Y);
            var row = info.Item.Index;
            MessageBox.Show(data[row][0] + " " + data[row][1]);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button_adduser_Click(object sender, EventArgs e)
        {
            FormInput input = new FormInput();
            input.ShowDialog();
        }
    }
}
