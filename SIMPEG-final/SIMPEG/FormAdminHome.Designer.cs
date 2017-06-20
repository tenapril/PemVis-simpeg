namespace SIMPEG
{
    partial class FormAdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminHome));
            this.label1 = new System.Windows.Forms.Label();
            this.list_pegawai = new System.Windows.Forms.ListView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button_adduser = new System.Windows.Forms.Button();
            this.tooltip_adduser = new System.Windows.Forms.ToolTip(this.components);
            this.groupbox_entry = new System.Windows.Forms.GroupBox();
            this.button_entry_education = new System.Windows.Forms.Button();
            this.button_entry_family = new System.Windows.Forms.Button();
            this.tooltip_entry_family = new System.Windows.Forms.ToolTip(this.components);
            this.button_exit = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label_admin_name = new System.Windows.Forms.Label();
            this.label_pegawai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_filter_divisi = new System.Windows.Forms.ComboBox();
            this.label_ket_pegawai = new System.Windows.Forms.Label();
            this.groupbox_entry.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Pegawai";
            // 
            // list_pegawai
            // 
            this.list_pegawai.Location = new System.Drawing.Point(12, 121);
            this.list_pegawai.Name = "list_pegawai";
            this.list_pegawai.Size = new System.Drawing.Size(760, 341);
            this.list_pegawai.TabIndex = 2;
            this.list_pegawai.UseCompatibleStateImageBehavior = false;
            this.list_pegawai.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_pegawai_MouseClick);
            this.list_pegawai.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_pegawai_MouseDoubleClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(616, 500);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(697, 500);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button_adduser
            // 
            this.button_adduser.Image = ((System.Drawing.Image)(resources.GetObject("button_adduser.Image")));
            this.button_adduser.Location = new System.Drawing.Point(12, 12);
            this.button_adduser.Name = "button_adduser";
            this.button_adduser.Size = new System.Drawing.Size(84, 70);
            this.button_adduser.TabIndex = 7;
            this.button_adduser.UseVisualStyleBackColor = true;
            this.button_adduser.Click += new System.EventHandler(this.button_adduser_Click);
            this.button_adduser.MouseHover += new System.EventHandler(this.adduser_hover);
            // 
            // tooltip_adduser
            // 
            this.tooltip_adduser.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_adduser.ToolTipTitle = "Tambah Pegawai";
            this.tooltip_adduser.UseAnimation = false;
            // 
            // groupbox_entry
            // 
            this.groupbox_entry.Controls.Add(this.button_entry_education);
            this.groupbox_entry.Controls.Add(this.button_entry_family);
            this.groupbox_entry.Location = new System.Drawing.Point(103, 13);
            this.groupbox_entry.Name = "groupbox_entry";
            this.groupbox_entry.Size = new System.Drawing.Size(166, 69);
            this.groupbox_entry.TabIndex = 8;
            this.groupbox_entry.TabStop = false;
            this.groupbox_entry.Text = "Entry Data";
            // 
            // button_entry_education
            // 
            this.button_entry_education.Image = ((System.Drawing.Image)(resources.GetObject("button_entry_education.Image")));
            this.button_entry_education.Location = new System.Drawing.Point(84, 19);
            this.button_entry_education.Name = "button_entry_education";
            this.button_entry_education.Size = new System.Drawing.Size(72, 44);
            this.button_entry_education.TabIndex = 10;
            this.button_entry_education.UseVisualStyleBackColor = true;
            this.button_entry_education.Click += new System.EventHandler(this.button_entry_education_Click);
            // 
            // button_entry_family
            // 
            this.button_entry_family.Image = ((System.Drawing.Image)(resources.GetObject("button_entry_family.Image")));
            this.button_entry_family.Location = new System.Drawing.Point(6, 19);
            this.button_entry_family.Name = "button_entry_family";
            this.button_entry_family.Size = new System.Drawing.Size(72, 44);
            this.button_entry_family.TabIndex = 9;
            this.button_entry_family.UseVisualStyleBackColor = true;
            this.button_entry_family.Click += new System.EventHandler(this.button_entry_family_Click);
            // 
            // tooltip_entry_family
            // 
            this.tooltip_entry_family.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_entry_family.ToolTipTitle = "Entry Data Keluarga";
            // 
            // button_exit
            // 
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(706, 32);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(66, 57);
            this.button_exit.TabIndex = 9;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(275, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(84, 70);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label_admin_name
            // 
            this.label_admin_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_admin_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin_name.Location = new System.Drawing.Point(634, 6);
            this.label_admin_name.Name = "label_admin_name";
            this.label_admin_name.Size = new System.Drawing.Size(138, 23);
            this.label_admin_name.TabIndex = 11;
            this.label_admin_name.Text = "Login as";
            this.label_admin_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_pegawai
            // 
            this.label_pegawai.AutoSize = true;
            this.label_pegawai.Location = new System.Drawing.Point(746, 471);
            this.label_pegawai.Name = "label_pegawai";
            this.label_pegawai.Size = new System.Drawing.Size(24, 13);
            this.label_pegawai.TabIndex = 13;
            this.label_pegawai.Text = "n/a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Divisi :";
            // 
            // cb_filter_divisi
            // 
            this.cb_filter_divisi.FormattingEnabled = true;
            this.cb_filter_divisi.Location = new System.Drawing.Point(683, 97);
            this.cb_filter_divisi.Name = "cb_filter_divisi";
            this.cb_filter_divisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_filter_divisi.Size = new System.Drawing.Size(89, 21);
            this.cb_filter_divisi.TabIndex = 27;
            this.cb_filter_divisi.Text = "Semua";
            this.cb_filter_divisi.SelectedIndexChanged += new System.EventHandler(this.cb_filter_divisi_SelectedIndexChanged);
            // 
            // label_ket_pegawai
            // 
            this.label_ket_pegawai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ket_pegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ket_pegawai.Location = new System.Drawing.Point(602, 465);
            this.label_ket_pegawai.Name = "label_ket_pegawai";
            this.label_ket_pegawai.Size = new System.Drawing.Size(138, 23);
            this.label_ket_pegawai.TabIndex = 28;
            this.label_ket_pegawai.Text = "Total Pegawai :";
            this.label_ket_pegawai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label_ket_pegawai);
            this.Controls.Add(this.cb_filter_divisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_pegawai);
            this.Controls.Add(this.label_admin_name);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.groupbox_entry);
            this.Controls.Add(this.button_adduser);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.list_pegawai);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormAdminHome";
            this.Text = "Sistem Informasi Manajemen Kepegawaian - Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminHome_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminHome_Load);
            this.groupbox_entry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_pegawai;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button_adduser;
        private System.Windows.Forms.ToolTip tooltip_adduser;
        private System.Windows.Forms.GroupBox groupbox_entry;
        private System.Windows.Forms.Button button_entry_education;
        private System.Windows.Forms.Button button_entry_family;
        private System.Windows.Forms.ToolTip tooltip_entry_family;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label_admin_name;
        private System.Windows.Forms.Label label_pegawai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_filter_divisi;
        private System.Windows.Forms.Label label_ket_pegawai;
    }
}