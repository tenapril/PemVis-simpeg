namespace SIMPEG
{
    partial class FormInput_Keluarga
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_pob = new System.Windows.Forms.TextBox();
            this.tb_dob = new System.Windows.Forms.TextBox();
            this.cb_jk = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_pekerjaan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Data Anak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nama Lengkap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tempat Lahir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tanggal Lahir";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(112, 62);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(183, 20);
            this.tb_nama.TabIndex = 11;
            // 
            // tb_pob
            // 
            this.tb_pob.Location = new System.Drawing.Point(112, 88);
            this.tb_pob.Name = "tb_pob";
            this.tb_pob.Size = new System.Drawing.Size(183, 20);
            this.tb_pob.TabIndex = 12;
            // 
            // tb_dob
            // 
            this.tb_dob.Location = new System.Drawing.Point(112, 114);
            this.tb_dob.Name = "tb_dob";
            this.tb_dob.Size = new System.Drawing.Size(183, 20);
            this.tb_dob.TabIndex = 13;
            // 
            // cb_jk
            // 
            this.cb_jk.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_jk.FormattingEnabled = true;
            this.cb_jk.Items.AddRange(new object[] {
            "Laki",
            "Perempuan"});
            this.cb_jk.Location = new System.Drawing.Point(112, 140);
            this.cb_jk.Name = "cb_jk";
            this.cb_jk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_jk.Size = new System.Drawing.Size(183, 21);
            this.cb_jk.TabIndex = 14;
            this.cb_jk.Text = "-- Jenis Kelamin --";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(184, 234);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(90, 23);
            this.btn_submit.TabIndex = 51;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(91, 234);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 23);
            this.btn_cancel.TabIndex = 50;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Pekerjaan";
            // 
            // cb_pekerjaan
            // 
            this.cb_pekerjaan.FormattingEnabled = true;
            this.cb_pekerjaan.Items.AddRange(new object[] {
            "Balita",
            "SD",
            "SMP",
            "SMA",
            "Mahasiswa",
            "Pegawai",
            "Tidak Berkerja"});
            this.cb_pekerjaan.Location = new System.Drawing.Point(112, 167);
            this.cb_pekerjaan.Name = "cb_pekerjaan";
            this.cb_pekerjaan.Size = new System.Drawing.Size(183, 21);
            this.cb_pekerjaan.TabIndex = 52;
            this.cb_pekerjaan.Text = "-- Pekerjaan --";
            // 
            // FormInput_Keluarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 269);
            this.Controls.Add(this.cb_pekerjaan);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cb_jk);
            this.Controls.Add(this.tb_dob);
            this.Controls.Add(this.tb_pob);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormInput_Keluarga";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Sistem Informasi Manajemen Kepegawaian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_pob;
        private System.Windows.Forms.TextBox tb_dob;
        private System.Windows.Forms.ComboBox cb_jk;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_pekerjaan;
    }
}

