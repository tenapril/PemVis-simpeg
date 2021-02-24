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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_adduser = new System.Windows.Forms.Button();
            this.tooltip_adduser = new System.Windows.Forms.ToolTip(this.components);
            this.groupbox_entry = new System.Windows.Forms.GroupBox();
            this.button_entry_jabatan = new System.Windows.Forms.Button();
            this.button_entry_education = new System.Windows.Forms.Button();
            this.button_entry_family = new System.Windows.Forms.Button();
            this.tooltip_entry_family = new System.Windows.Forms.ToolTip(this.components);
            this.button_exit = new System.Windows.Forms.Button();
            this.groupbox_entry.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistem Informasi Manajemen Kepegawaian";
            // 
            // list_pegawai
            // 
            this.list_pegawai.Location = new System.Drawing.Point(12, 121);
            this.list_pegawai.Name = "list_pegawai";
            this.list_pegawai.Size = new System.Drawing.Size(760, 341);
            this.list_pegawai.TabIndex = 2;
            this.list_pegawai.UseCompatibleStateImageBehavior = false;
            this.list_pegawai.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_pegawai_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
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
            this.groupbox_entry.Controls.Add(this.button_entry_jabatan);
            this.groupbox_entry.Controls.Add(this.button_entry_education);
            this.groupbox_entry.Controls.Add(this.button_entry_family);
            this.groupbox_entry.Location = new System.Drawing.Point(103, 13);
            this.groupbox_entry.Name = "groupbox_entry";
            this.groupbox_entry.Size = new System.Drawing.Size(248, 69);
            this.groupbox_entry.TabIndex = 8;
            this.groupbox_entry.TabStop = false;
            this.groupbox_entry.Text = "Entry Data";
            // 
            // button_entry_jabatan
            // 
            this.button_entry_jabatan.Location = new System.Drawing.Point(162, 19);
            this.button_entry_jabatan.Name = "button_entry_jabatan";
            this.button_entry_jabatan.Size = new System.Drawing.Size(72, 44);
            this.button_entry_jabatan.TabIndex = 11;
            this.button_entry_jabatan.Text = "Jabatan";
            this.button_entry_jabatan.UseVisualStyleBackColor = true;
            // 
            // button_entry_education
            // 
            this.button_entry_education.Location = new System.Drawing.Point(84, 19);
            this.button_entry_education.Name = "button_entry_education";
            this.button_entry_education.Size = new System.Drawing.Size(72, 44);
            this.button_entry_education.TabIndex = 10;
            this.button_entry_education.Text = "Education";
            this.button_entry_education.UseVisualStyleBackColor = true;
            // 
            // button_entry_family
            // 
            this.button_entry_family.Image = ((System.Drawing.Image)(resources.GetObject("button_entry_family.Image")));
            this.button_entry_family.Location = new System.Drawing.Point(6, 19);
            this.button_entry_family.Name = "button_entry_family";
            this.button_entry_family.Size = new System.Drawing.Size(72, 44);
            this.button_entry_family.TabIndex = 9;
            this.button_entry_family.UseVisualStyleBackColor = true;
            // 
            // tooltip_entry_family
            // 
            this.tooltip_entry_family.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_entry_family.ToolTipTitle = "Entry Data Keluarga";
            // 
            // button_exit
            // 
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(688, 19);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(84, 70);
            this.button_exit.TabIndex = 9;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // FormAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.groupbox_entry);
            this.Controls.Add(this.button_adduser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_pegawai);
            this.Controls.Add(this.label1);
            this.Name = "FormAdminHome";
            this.Text = "FormHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminHome_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminHome_Load);
            this.groupbox_entry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_pegawai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_adduser;
        private System.Windows.Forms.ToolTip tooltip_adduser;
        private System.Windows.Forms.GroupBox groupbox_entry;
        private System.Windows.Forms.Button button_entry_jabatan;
        private System.Windows.Forms.Button button_entry_education;
        private System.Windows.Forms.Button button_entry_family;
        private System.Windows.Forms.ToolTip tooltip_entry_family;
        private System.Windows.Forms.Button button_exit;
    }
}