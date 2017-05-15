namespace KalkulatorMini
{
    partial class Form1
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
            this.label_operand1 = new System.Windows.Forms.Label();
            this.label_operand2 = new System.Windows.Forms.Label();
            this.textBox_operand1 = new System.Windows.Forms.TextBox();
            this.textBox_operand2 = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divider = new System.Windows.Forms.Button();
            this.label_hasil = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_operand1
            // 
            this.label_operand1.AutoSize = true;
            this.label_operand1.Location = new System.Drawing.Point(69, 53);
            this.label_operand1.Name = "label_operand1";
            this.label_operand1.Size = new System.Drawing.Size(52, 13);
            this.label_operand1.TabIndex = 0;
            this.label_operand1.Text = "operand1";
            // 
            // label_operand2
            // 
            this.label_operand2.AutoSize = true;
            this.label_operand2.Location = new System.Drawing.Point(69, 76);
            this.label_operand2.Name = "label_operand2";
            this.label_operand2.Size = new System.Drawing.Size(52, 13);
            this.label_operand2.TabIndex = 1;
            this.label_operand2.Text = "operand2";
            // 
            // textBox_operand1
            // 
            this.textBox_operand1.Location = new System.Drawing.Point(121, 46);
            this.textBox_operand1.Name = "textBox_operand1";
            this.textBox_operand1.Size = new System.Drawing.Size(100, 20);
            this.textBox_operand1.TabIndex = 2;
            // 
            // textBox_operand2
            // 
            this.textBox_operand2.Location = new System.Drawing.Point(121, 73);
            this.textBox_operand2.Name = "textBox_operand2";
            this.textBox_operand2.Size = new System.Drawing.Size(100, 20);
            this.textBox_operand2.TabIndex = 3;
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_plus.Location = new System.Drawing.Point(32, 121);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(40, 40);
            this.button_plus.TabIndex = 4;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_minus.Location = new System.Drawing.Point(94, 121);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(40, 40);
            this.button_minus.TabIndex = 5;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_multiply.Location = new System.Drawing.Point(156, 121);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(40, 40);
            this.button_multiply.TabIndex = 6;
            this.button_multiply.Text = "x";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_divider
            // 
            this.button_divider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_divider.Location = new System.Drawing.Point(218, 121);
            this.button_divider.Name = "button_divider";
            this.button_divider.Size = new System.Drawing.Size(40, 40);
            this.button_divider.TabIndex = 7;
            this.button_divider.Text = "/";
            this.button_divider.UseVisualStyleBackColor = true;
            this.button_divider.Click += new System.EventHandler(this.button_divider_Click);
            // 
            // label_hasil
            // 
            this.label_hasil.AutoSize = true;
            this.label_hasil.Location = new System.Drawing.Point(69, 193);
            this.label_hasil.Name = "label_hasil";
            this.label_hasil.Size = new System.Drawing.Size(45, 13);
            this.label_hasil.TabIndex = 8;
            this.label_hasil.Text = "Answer:";
            // 
            // textBox_answer
            // 
            this.textBox_answer.Location = new System.Drawing.Point(121, 186);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(100, 20);
            this.textBox_answer.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label_hasil);
            this.Controls.Add(this.button_divider);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.textBox_operand2);
            this.Controls.Add(this.textBox_operand1);
            this.Controls.Add(this.label_operand2);
            this.Controls.Add(this.label_operand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_operand1;
        private System.Windows.Forms.Label label_operand2;
        private System.Windows.Forms.TextBox textBox_operand1;
        private System.Windows.Forms.TextBox textBox_operand2;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divider;
        private System.Windows.Forms.Label label_hasil;
        private System.Windows.Forms.TextBox textBox_answer;
    }
}

