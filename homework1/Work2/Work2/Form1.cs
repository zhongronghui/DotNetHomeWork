using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (comboBox1.Text == "+")
            { textBox3.Text = Convert.ToString(a + b); }

            else if (comboBox1.Text == "-")
            { textBox3.Text = Convert.ToString(a - b); }
            else if (comboBox1.Text == "*")
            { textBox3.Text = Convert.ToString(a * b); }
            else
            if (comboBox1.Text == "/" && b != 0)
            { textBox3.Text = Convert.ToString(a / b); 
            }
            else
            {
                textBox3.Text = "除数不能为0";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
