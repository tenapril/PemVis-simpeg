namespace SIMPEG
{
    partial class FormInput
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_nip = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_pob = new System.Windows.Forms.TextBox();
            this.tb_dob = new System.Windows.Forms.TextBox();
            this.tb_postal = new System.Windows.Forms.TextBox();
            this.cb_jk = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistem Informasi Manajemen Kepegawaian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NIP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nama Lengkap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tempat Lahir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tanggal Lahir";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Kode Pos";
            // 
            // tb_nip
            // 
            this.tb_nip.Location = new System.Drawing.Point(96, 49);
            this.tb_nip.Name = "tb_nip";
            this.tb_nip.Size = new System.Drawing.Size(183, 20);
            this.tb_nip.TabIndex = 12;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(96, 75);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(183, 20);
            this.tb_nama.TabIndex = 13;
            // 
            // tb_pob
            // 
            this.tb_pob.Location = new System.Drawing.Point(96, 127);
            this.tb_pob.Name = "tb_pob";
            this.tb_pob.Size = new System.Drawing.Size(183, 20);
            this.tb_pob.TabIndex = 15;
            // 
            // tb_dob
            // 
            this.tb_dob.Location = new System.Drawing.Point(96, 153);
            this.tb_dob.Name = "tb_dob";
            this.tb_dob.Size = new System.Drawing.Size(183, 20);
            this.tb_dob.TabIndex = 16;
            // 
            // tb_postal
            // 
            this.tb_postal.Location = new System.Drawing.Point(96, 179);
            this.tb_postal.Name = "tb_postal";
            this.tb_postal.Size = new System.Drawing.Size(183, 20);
            this.tb_postal.TabIndex = 17;
            // 
            // cb_jk
            // 
            this.cb_jk.FormattingEnabled = true;
            this.cb_jk.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cb_jk.Location = new System.Drawing.Point(96, 101);
            this.cb_jk.Name = "cb_jk";
            this.cb_jk.Size = new System.Drawing.Size(183, 21);
            this.cb_jk.TabIndex = 14;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(127, 289);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 18;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 324);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cb_jk);
            this.Controls.Add(this.tb_postal);
            this.Controls.Add(this.tb_dob);
            this.Controls.Add(this.tb_pob);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.tb_nip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormInput";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Sistem Informasi Manajemen Kepegawaian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_nip;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_pob;
        private System.Windows.Forms.TextBox tb_dob;
        private System.Windows.Forms.TextBox tb_postal;
        private System.Windows.Forms.ComboBox cb_jk;
        private System.Windows.Forms.Button btn_submit;
    }
}

