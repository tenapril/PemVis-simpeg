namespace SIMPEG
{
    partial class FormAdmin_Pendidikan
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
            this.label1 = new System.Windows.Forms.Label();
            this.list_pendidikan = new System.Windows.Forms.ListView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tooltip_adduser = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_entry_family = new System.Windows.Forms.ToolTip(this.components);
            this.label_nip_nama = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pendidikan";
            // 
            // list_pendidikan
            // 
            this.list_pendidikan.Location = new System.Drawing.Point(12, 65);
            this.list_pendidikan.Name = "list_pendidikan";
            this.list_pendidikan.Size = new System.Drawing.Size(510, 255);
            this.list_pendidikan.TabIndex = 2;
            this.list_pendidikan.UseCompatibleStateImageBehavior = false;
            this.list_pendidikan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_pegawai_MouseClick);
            this.list_pendidikan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_pendidikan_MouseDoubleClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(366, 326);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(447, 326);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tooltip_adduser
            // 
            this.tooltip_adduser.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_adduser.ToolTipTitle = "Tambah Pegawai";
            this.tooltip_adduser.UseAnimation = false;
            // 
            // tooltip_entry_family
            // 
            this.tooltip_entry_family.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_entry_family.ToolTipTitle = "Entry Data Keluarga";
            // 
            // label_nip_nama
            // 
            this.label_nip_nama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_nip_nama.Location = new System.Drawing.Point(235, 43);
            this.label_nip_nama.Name = "label_nip_nama";
            this.label_nip_nama.Size = new System.Drawing.Size(62, 6);
            this.label_nip_nama.TabIndex = 8;
            this.label_nip_nama.Text = "NIP - Nama";
            this.label_nip_nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(285, 326);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.Location = new System.Drawing.Point(138, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "NIP - Nama";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdmin_Pendidikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label_nip_nama);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.list_pendidikan);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin_Pendidikan";
            this.Text = "Sistem Informasi Manajemen Kepegawaian - Admin ";
            this.Load += new System.EventHandler(this.FormAdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_pendidikan;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ToolTip tooltip_adduser;
        private System.Windows.Forms.ToolTip tooltip_entry_family;
        private System.Windows.Forms.Label label_nip_nama;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
    }
}