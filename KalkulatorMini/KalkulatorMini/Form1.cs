using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalkulatorMini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            int operand1, operand2;
            //int operand1 = int.Parse(textBox_operand1.Text);
            int.TryParse(textBox_operand1.Text, out operand1);
            int.TryParse(textBox_operand2.Text, out operand2);
            //int operand2 = int.Parse(textBox_operand2.Text);
            int total = operand1+operand2;
            textBox_answer.Text = total.ToString();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            int operand1, operand2;
            //int operand1 = int.Parse(textBox_operand1.Text);
            int.TryParse(textBox_operand1.Text, out operand1);
            int.TryParse(textBox_operand2.Text, out operand2);
            //int operand2 = int.Parse(textBox_operand2.Text);
            int total = operand1 - operand2;
            textBox_answer.Text = total.ToString();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            int operand1, operand2;
            //int operand1 = int.Parse(textBox_operand1.Text);
            int.TryParse(textBox_operand1.Text, out operand1);
            int.TryParse(textBox_operand2.Text, out operand2);
            //int operand2 = int.Parse(textBox_operand2.Text);
            int total = operand1 * operand2;
            textBox_answer.Text = total.ToString();
        }

        private void button_divider_Click(object sender, EventArgs e)
        {
            double operand1, operand2;
            //int operand1 = int.Parse(textBox_operand1.Text);
            double.TryParse(textBox_operand1.Text, out operand1);
            double.TryParse(textBox_operand2.Text, out operand2);
            //int operand2 = int.Parse(textBox_operand2.Text);
            double total = operand1 / operand2;
            textBox_answer.Text = total.ToString();
        }


        
    }
}
