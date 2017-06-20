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
    public partial class FormAdmin_Keluarga: Form
    {
        MySqlConnection conn = new MySqlConnection("Server=vps.eriksenfinarto.com;Database=pemvis_simpeg;Uid=pemvis_simpeg;Pwd='pemvis2017'");
        List<List<string>> data = new List<List<string>>();
        public bool logout = false;
        public int ListIndex = 0;
        List<string> data_kel;

        public FormAdmin_Keluarga()
        {
            InitializeComponent();
        }

        public FormAdmin_Keluarga(List<string> pass_data)
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
            list_anak.Clear();
            list_anak.Items.Clear();
            list_anak.Columns.Clear();
            list_anak.Columns.Add("NIP", 100, HorizontalAlignment.Left);
            list_anak.Columns.Add("Nama Lengkap", 100, HorizontalAlignment.Left);
            list_anak.Columns.Add("Gender", 40, HorizontalAlignment.Left);
            list_anak.Columns.Add("Tempat Lahir", 100, HorizontalAlignment.Left);
            list_anak.Columns.Add("Tanggal Lahir", 100, HorizontalAlignment.Left);
            list_anak.Columns.Add("Pekerjaan", 50, HorizontalAlignment.Left);
            
            list_anak.GridLines = true;
            list_anak.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            list_anak.View = View.Details;
            list_anak.MultiSelect = false;

            conn.Open();
            MySqlCommand query = conn.CreateCommand();
            query.CommandText = "SELECT * FROM anak WHERE nip=@nip ORDER BY 1 ASC";
            query.Parameters.AddWithValue("@nip", data_kel[0]);
            query.ExecuteNonQuery();
            reader = query.ExecuteReader();
            ListViewItem item = null;

            while (reader.Read())
            {
                List<string> temp = new List<string>();
                temp.Add(reader["nip"].ToString());
                temp.Add(reader["nama"].ToString());
                temp.Add(reader["kelamin"].ToString());
                temp.Add(reader["tempat_lahir"].ToString());
                temp.Add(reader["tgl_lahir"].ToString());
                temp.Add(reader["pekerjaan"].ToString());
                temp.Add(reader["noanak"].ToString());
                string s = temp[4];
                DateTime dt = DateTime.Parse(s);
                temp[4] = dt.ToString("yyyy-MM-dd");
                data.Add(temp);

                item = new ListViewItem(reader["nip"].ToString(), 0);
                item.SubItems.Add(reader["nama"].ToString());
                item.SubItems.Add(reader["kelamin"].ToString());
                item.SubItems.Add(reader["tempat_lahir"].ToString());
                item.SubItems.Add(temp[4]);
                item.SubItems.Add(reader["pekerjaan"].ToString());
                item.SubItems.Add(reader["noanak"].ToString());
                list_anak.Items.Add(item);

            }
            conn.Close();

        }

        private void list_anak_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = list_anak.HitTest(e.X, e.Y);
            ListIndex = info.Item.Index;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete_User();
            LoadListView();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            FormEdit_Keluarga edituser = new FormEdit_Keluarga(data[ListIndex]);
            edituser.ShowDialog();
            LoadListView();

        }

        private void Delete_User()
        {
            if (MessageBox.Show("Are you sure want to Delete " + data[ListIndex][1]+ "?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes && data[ListIndex] != null)
            {
                conn.Open();
                MySqlCommand query = conn.CreateCommand();
                query.CommandText = "DELETE from anak WHERE noanak = @noanak";
                query.Parameters.AddWithValue("@noanak", data[ListIndex][6]);
                query.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void list_anak_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = list_anak.HitTest(e.X, e.Y);
            var row = info.Item.Index;
            FormEdit_Keluarga edituser = new FormEdit_Keluarga(data[row]);
            edituser.ShowDialog();
            LoadListView();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormInput_Keluarga input = new FormInput_Keluarga(data[ListIndex][0]);
            input.ShowDialog();
            LoadListView();
        }
    }
}
