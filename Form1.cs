using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简易计算器
{
    public partial class Form1 : Form
    {
        decimal sum;
        string sign;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //           textBox1.Text =  string (sum);
            if (sign == "+")
            {
                sum += decimal.Parse(textBox1.Text);

            }
            else if (sign == "-")
            {
                sum -= decimal.Parse(textBox1.Text);
            }

            else if (sign == "=")
            {
                sum= decimal.Parse(textBox1.Text);
            }

            else
            {
                sum = decimal.Parse(textBox1.Text);
            }
            textBox1.Text = null;
            sign = "=";

        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (sign == "+")
            {
                sum += decimal.Parse(textBox1.Text);

            }
            else if (sign == "-")
            {
                sum -= decimal.Parse(textBox1.Text);
            }

            else if (sign == "=")
            {
                sum = decimal.Parse(textBox1.Text);
            }

            else
            {
                sum = decimal.Parse(textBox1.Text);
            }
            textBox1.Text = null;
            sign = "+";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sign == "+")
            {
                sum += decimal.Parse(textBox1.Text);

            }
            else if (sign == "-")
            {
                sum -= decimal.Parse(textBox1.Text);
            }

            else if (sign == "=")
            {
                sum = decimal.Parse(textBox1.Text);
            }

            else
            {
                sum = decimal.Parse(textBox1.Text);
            }
            textBox1.Text = null;
            sign = "-";
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
