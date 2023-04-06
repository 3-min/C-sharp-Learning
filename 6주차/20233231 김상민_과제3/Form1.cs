using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                double uData01 = double.Parse(textBox1.Text);
                double uData02 = 1;

                for (double i = 1; i <= uData01; i++)
                {
                    uData02 = uData02 * i;
                }
                if (double.IsInfinity(uData02)) {
                    label2.Text = uData01 + "! = " + "Infinity 입니다.";
                }
                
                else label2.Text = uData01 + "! = " + uData02 + "입니다.";
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "결과가 나오는 곳입니다!";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
