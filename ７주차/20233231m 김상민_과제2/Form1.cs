using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231m_김상민_과제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            string str = "";

            label2.Text = "";
            try
            {
                if (num > 0 && num <= 100)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (i % 3 == 0)
                        {
                            str += " 짝 ";
                        }
                        else
                        {
                            str += " " + i + " ";
                        }
                        if (i % 10 == 0)
                        {
                            str += "\n";
                        }
                    }
                    label2.Text = str;
                }
                else
                {
                    label2.Text = "Error";
                }
                
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "결과가 출력되는 곳입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
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
    }
}
