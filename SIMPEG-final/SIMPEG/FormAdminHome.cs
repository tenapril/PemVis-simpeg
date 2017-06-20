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
        List<List<string>> viewdata = new List<List<string>>();
        public bool logout = false;
        public int ListIndex = 0;
        public int totalpegawai = 0;

        public FormAdminHome()
        {
            InitializeComponent();
        }

        public FormAdminHome(string admin_name)
        {
            InitializeComponent();
            label_admin_name.Text = "Login as " + admin_name;

        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void LoadListView()
        {
            data = null;
            data = new List<List<string>>();
            viewdata = null;
            viewdata = new List<List<string>>();
            MySqlDataReader reader = null;
            label_ket_pegawai.Text = "Total Pegawai : ";
            list_pegawai.Clear();
            list_pegawai.Items.Clear();
            list_pegawai.Columns.Clear();
            list_pegawai.Columns.Add("NIP", 80, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Nama Lengkap", 100, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Gender", 40, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Tempat Lahir", 70, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Tanggal Lahir", 70, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Gol. Darah", 40, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Agama", 50, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("No Telp", 85, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Email", 100, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Divisi", 70, HorizontalAlignment.Left);
            list_pegawai.Columns.Add("Jabatan", 70, HorizontalAlignment.Left);

            list_pegawai.GridLines = true;
            list_pegawai.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            list_pegawai.View = View.Details;
            list_pegawai.MultiSelect = false;
            
            conn.Open();
            MySqlCommand query = conn.CreateCommand();
            query.CommandText = "SELECT * FROM pegawai ORDER BY 1 ASC";
            query.ExecuteNonQuery();
            reader = query.ExecuteReader();
            ListViewItem item = null;
            totalpegawai = 0;
            while (reader.Read())
            {
                List<string> temp = new List<string>();
                temp.Add(reader["nip"].ToString());
                temp.Add(reader["nama"].ToString());
                temp.Add(reader["email"].ToString());
                temp.Add(reader["tempat_lahir"].ToString());
                temp.Add(reader["tanggal_lahir"].ToString());
                temp.Add(reader["kelamin"].ToString());
                temp.Add(reader["goldarah"].ToString());
                temp.Add(reader["agama"].ToString());
                temp.Add(reader["alamat"].ToString());
                temp.Add(reader["notelpon"].ToString());
                temp.Add(reader["kodekantor"].ToString());
                temp.Add(reader["bagian"].ToString());
                temp.Add(reader["jabatan"].ToString());
                temp.Add(reader["gaji"].ToString());
                temp.Add(reader["password"].ToString());
                temp.Add(reader["priv"].ToString());
                string s = temp[4];
                DateTime dt = DateTime.Parse(s);
                temp[4] = dt.ToString("yyyy-MM-dd");
                data.Add(temp);
                viewdata.Add(temp);
                /*
                item = new ListViewItem(reader["nip"].ToString(), 0);
                item.SubItems.Add(reader["nama"].ToString());
                item.SubItems.Add(reader["kelamin"].ToString());
                item.SubItems.Add(reader["tempat_lahir"].ToString());
                item.SubItems.Add(temp[4]);
                item.SubItems.Add(reader["goldarah"].ToString());
                item.SubItems.Add(reader["agama"].ToString());
                item.SubItems.Add(reader["notelpon"].ToString());
                item.SubItems.Add(reader["email"].ToString());
                item.SubItems.Add(reader["bagian"].ToString());
                item.SubItems.Add(reader["jabatan"].ToString());
                list_pegawai.Items.Add(item);
                */
                totalpegawai++;
            }
            conn.Close();
            cb_filter_divisi.Items.Clear();
            cb_filter_divisi.DropDownStyle = ComboBoxStyle.DropDownList;
            conn.Open();
            MySqlCommand querygetdiv = conn.CreateCommand();
            querygetdiv.CommandText = "SELECT bagian FROM pegawai GROUP BY 1";
            querygetdiv.ExecuteNonQuery();
            reader = querygetdiv.ExecuteReader();
            int ibagian = 1;
            ComboboxItem itembagian = new ComboboxItem();
            itembagian.Text = "Semua";
            itembagian.Value = 0;
            cb_filter_divisi.Items.Add(itembagian);
            while (reader.Read())
            {
                itembagian.Text = reader["bagian"].ToString();
                itembagian.Value = ibagian;
                ibagian++;
                cb_filter_divisi.Items.Add(itembagian);
            }
            cb_filter_divisi.SelectedIndex = 0;
            conn.Close();
/*            conn.Open();
            MySqlCommand queryku = conn.CreateCommand();
            queryku.CommandText = "SELECT COUNT(*) FROM pegawai";
            queryku.ExecuteNonQuery();
            reader = queryku.ExecuteReader();
            while (reader.Read())
            {
                totalpegawai = reader.GetString("COUNT(*)");
                label_pegawai.Text = totalpegawai;
            }
            conn.Close();
            conn.Open();
            MySqlCommand queryku2 = conn.CreateCommand();
            queryku2.CommandText = "SELECT COUNT(*) FROM pegawai WHERE jabatan LIKE 'Sales'";
            queryku2.ExecuteNonQuery();
            reader = queryku2.ExecuteReader();
            while (reader.Read())
            {
                label_sales.Text = reader.GetString("COUNT(*)");
            }
            conn.Close();
            conn.Open();
            MySqlCommand queryku3 = conn.CreateCommand();
            queryku3.CommandText = "SELECT COUNT(*) FROM pegawai WHERE jabatan LIKE 'Sales Manajer'";
            queryku3.ExecuteNonQuery();
            reader = queryku3.ExecuteReader();
            while (reader.Read())
            {
                label_sales_manajer.Text = reader.GetString("COUNT(*)");
            }
            conn.Close();
            conn.Open();
            MySqlCommand queryku4 = conn.CreateCommand();
            queryku4.CommandText = "SELECT COUNT(*) FROM pegawai WHERE jabatan LIKE 'Sekretaris'";
            queryku4.ExecuteNonQuery();
            reader = queryku4.ExecuteReader();
            while (reader.Read())
            {
                label_sekre.Text = reader.GetString("COUNT(*)");
            }
            conn.Close();
            conn.Open();
            MySqlCommand queryku5 = conn.CreateCommand();
            queryku5.CommandText = "SELECT COUNT(*) FROM pegawai WHERE jabatan LIKE 'OB'";
            queryku5.ExecuteNonQuery();
            reader = queryku5.ExecuteReader();
            while (reader.Read())
            {
                label_obb.Text = reader.GetString("COUNT(*)");
            }
            conn.Close();
            conn.Open();
            MySqlCommand queryku6 = conn.CreateCommand();
            queryku6.CommandText = "SELECT COUNT(*) FROM pegawai WHERE jabatan LIKE 'IT'";
            queryku6.ExecuteNonQuery();
            reader = queryku6.ExecuteReader();
            while (reader.Read())
            {
                label_it.Text = reader.GetString("COUNT(*)");
            }
            conn.Close();
*/
        }

        private void cb_filter_divisi_TextChanged(object sender, EventArgs e)
        {

        }
        private void cb_filter_divisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //            MessageBox.Show(cb_filter_divisi.SelectedValue + " " + cb_filter_divisi.SelectedText);
            //            string selected = this.cb_filter_divisi.GetItemText(this.cb_filter_divisi.SelectedItem);
            ListViewItem item = null;
            viewdata = null;
            viewdata = new List<List<string>>();
            list_pegawai.Items.Clear();
            string selected = cb_filter_divisi.Text;
            int temptotal = 0;
            if (selected != "Semua")
                label_ket_pegawai.Text = "Total Pegawai Divisi " + selected + " : ";
            else label_ket_pegawai.Text = "Total Pegawai : ";

            for (int i = 0; i < totalpegawai; i++ )
            {
                    if(selected == (data[i][11]) || selected.Equals("Semua") || cb_filter_divisi.SelectedIndex == 0)
                {
                    viewdata.Add(data[i]);
                    item = new ListViewItem(data[i][0].ToString());
                    item.SubItems.Add(data[i][1].ToString());
                    item.SubItems.Add(data[i][5].ToString());
                    item.SubItems.Add(data[i][3].ToString());
                    item.SubItems.Add(data[i][4].ToString());
                    item.SubItems.Add(data[i][6].ToString());
                    item.SubItems.Add(data[i][7].ToString());
                    item.SubItems.Add(data[i][9].ToString());
                    item.SubItems.Add(data[i][2].ToString());
                    item.SubItems.Add(data[i][11].ToString());
                    item.SubItems.Add(data[i][12].ToString());

/*
        item.SubItems.Add(reader["nama"].ToString());
        item.SubItems.Add(reader["kelamin"].ToString());
        item.SubItems.Add(reader["tempat_lahir"].ToString());
        item.SubItems.Add(temp[4]);
        item.SubItems.Add(reader["goldarah"].ToString());
        item.SubItems.Add(reader["agama"].ToString());
        item.SubItems.Add(reader["notelpon"].ToString());
        item.SubItems.Add(reader["email"].ToString());
        item.SubItems.Add(reader["bagian"].ToString());
        item.SubItems.Add(reader["jabatan"].ToString());
*/
                    list_pegawai.Items.Add(item);
                    temptotal ++ ;
                }
                
            }
                label_pegawai.Text = temptotal.ToString();

        }

        private void FormAdminHome_Load(object sender, EventArgs e)
        {
            LoadListView();
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
//            FormAdminUserEdit edituser = new FormAdminUserEdit(data[row]);
            FormAdminUserEdit edituser = new FormAdminUserEdit(viewdata[row]);
            edituser.ShowDialog();
            LoadListView();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.No)
            {

            }
            else
            {
                this.Hide();
                FormLogin login = new FormLogin();
                logout = true;
                this.Close();
                login.ShowDialog();
            }
        }

        private void FormAdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(logout == false)
            {
                if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void button_adduser_Click(object sender, EventArgs e)
        {
            FormInput input = new FormInput();
            input.ShowDialog();
            LoadListView();
        }

        private void list_pegawai_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = list_pegawai.HitTest(e.X, e.Y);
            ListIndex = info.Item.Index;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete_User();
            LoadListView();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            FormAdminUserEdit edituser = new FormAdminUserEdit(data[ListIndex]);
            edituser.ShowDialog();
            LoadListView();

        }

        private void Delete_User()
        {
            if (MessageBox.Show("Are you sure want to Delete " + data[ListIndex][0]+ "?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand query = conn.CreateCommand();
                query.CommandText = "DELETE from pegawai WHERE nip = @nip";
                query.Parameters.AddWithValue("@nip", data[ListIndex][0]);
                query.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void button_entry_family_Click(object sender, EventArgs e)
        {
            
            FormAdmin_Keluarga klg = new FormAdmin_Keluarga(data[ListIndex]);
            klg.ShowDialog();
        }

        private void button_entry_education_Click(object sender, EventArgs e)
        {
            FormAdmin_Pendidikan pdk = new FormAdmin_Pendidikan(data[ListIndex]);
            pdk.ShowDialog();
        }
        
    }
}
