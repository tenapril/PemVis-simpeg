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
    public partial class FormAdmin_Pendidikan: Form
    {
        MySqlConnection conn = new MySqlConnection("Server=vps.eriksenfinarto.com;Database=pemvis_simpeg;Uid=pemvis_simpeg;Pwd='pemvis2017'");
        List<List<string>> data = new List<List<string>>();
        public bool logout = false;
        public int ListIndex = 0;
        List<string> data_kel;

        public FormAdmin_Pendidikan()
        {
            InitializeComponent();
        }

        public FormAdmin_Pendidikan(List<string> pass_data)
        {
            InitializeComponent();
            this.data_kel = pass_data;
            label_nip_nama.Text = data_kel[0] + " - " + data_kel[1];
            LoadListView();
        }

        private void LoadListView()
        {
            data = null;
            data = new List<List<string>>();
            MySqlDataReader reader = null;
            list_pendidikan.Clear();
            list_pendidikan.Items.Clear();
            list_pendidikan.Columns.Clear();
            list_pendidikan.Columns.Add("NIP", 100, HorizontalAlignment.Left);
            list_pendidikan.Columns.Add("Jenjang", 100, HorizontalAlignment.Left);
            list_pendidikan.Columns.Add("Jurusan", 40, HorizontalAlignment.Left);
            list_pendidikan.Columns.Add("Nama Sekolah", 100, HorizontalAlignment.Left);
            list_pendidikan.Columns.Add("Tahun Lulus", 50, HorizontalAlignment.Left);

            list_pendidikan.GridLines = true;
            list_pendidikan.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            list_pendidikan.View = View.Details;
            list_pendidikan.MultiSelect = false;

            conn.Open();
            MySqlCommand query = conn.CreateCommand();
            query.CommandText = "SELECT * FROM pendidikan WHERE nip=@nip ORDER BY 1 ASC";
            query.Parameters.AddWithValue("@nip", data_kel[0]);
            query.ExecuteNonQuery();
            reader = query.ExecuteReader();
            ListViewItem item = null;

            while (reader.Read())
            {
                List<string> temp = new List<string>();
                temp.Add(reader["nip"].ToString());
                temp.Add(reader["jenjang"].ToString());
                temp.Add(reader["jurusan"].ToString());
                temp.Add(reader["namasekolah"].ToString());
                temp.Add(reader["alamatsekolah"].ToString());
                temp.Add(reader["noijazah"].ToString());
                temp.Add(reader["tahunlulus"].ToString());
                temp.Add(reader["nopendidikan"].ToString());
                data.Add(temp);
                item = new ListViewItem(reader["nip"].ToString(), 0);
                item.SubItems.Add(reader["jenjang"].ToString());
                item.SubItems.Add(reader["jurusan"].ToString());
                item.SubItems.Add(reader["namasekolah"].ToString());
                item.SubItems.Add(reader["tahunlulus"].ToString());
                list_pendidikan.Items.Add(item);

            }
            conn.Close();

        }

        private void FormAdminHome_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void button_adduser_Click(object sender, EventArgs e)
        {
            FormInput_Pendidikan input = new FormInput_Pendidikan(data_kel[0]);
            input.ShowDialog();
        }

        private void list_pegawai_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = list_pendidikan.HitTest(e.X, e.Y);
            ListIndex = info.Item.Index;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete_User();
            LoadListView();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            FormEdit_Pendidikan edis = new FormEdit_Pendidikan(data[ListIndex]);
            edis.ShowDialog();

        }

        private void Delete_User()
        {
            if (MessageBox.Show("Are you sure want to Delete " + data[ListIndex][1]+ "?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand query = conn.CreateCommand();
                query.CommandText = "DELETE from pendidikan WHERE nopendidikan = @nopendidikan";
                query.Parameters.AddWithValue("@nopendidikan", data[ListIndex][7]);
                query.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            FormEdit_Pendidikan edd = new FormEdit_Pendidikan(data[ListIndex]);
            edd.ShowDialog();
            LoadListView();
        }

        private void list_pendidikan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = list_pendidikan.HitTest(e.X, e.Y);
            var row = info.Item.Index;
            FormEdit_Pendidikan edituser = new FormEdit_Pendidikan(data[row]);
            edituser.ShowDialog();
            LoadListView();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormInput_Pendidikan input = new FormInput_Pendidikan(data[ListIndex][0]);
            input.ShowDialog();
            LoadListView();
        }
    }
}
