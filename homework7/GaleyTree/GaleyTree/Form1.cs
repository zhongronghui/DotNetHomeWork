using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = Pens.Black;
        int n = 10;
        int length = 100;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "10";
            textBox2.Text = "100 ";
            rightPer1.Text = "0.6";
            leftPer2.Text = "0.7";
            rightTh1.Text = "0.521";
            leftTh2.Text = "0.345";
            comboBox1.Items.Add("绿色");
            comboBox1.Items.Add("红色");
            comboBox1.Items.Add("蓝色");
            comboBox1.Items.Add("灰色");      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (graphics != null) graphics.Clear(panel2.BackColor);
            try
            {   n = Convert.ToInt32(textBox1.Text);
                length = Convert.ToInt32(textBox2.Text);
                per1 = Convert.ToDouble(rightPer1.Text);
                per2 = Convert.ToDouble(leftPer2.Text);
                th1 = Convert.ToDouble(rightTh1.Text);
                th2 = Convert.ToDouble(leftTh2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("请输入正确数值");
            }

            if (graphics == null) graphics = panel2.CreateGraphics();
                drawGayleyTree(n, 200, 300, length, -Math.PI / 2); 
        }
       
       

        void drawGayleyTree(int n ,double x0, double y0 ,double leng,double th)
        {
            if (n == 0) 
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
            drawGayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawGayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }
       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          

            switch (comboBox1.Text)
            {
                case "绿色" : pen=Pens.Green;  break;
                case "红色" : pen = Pens.Red;  break;
                case "蓝色" : pen = Pens.Blue; break;
                case "灰色" :pen = Pens.Gray;break;
                default: pen = Pens.Blue; break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
