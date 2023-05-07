using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제4
{
    public partial class Form1 : Form
    {
        string str = "";
        int cnt = 0;
        int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                int idata1 = int.Parse(textBox1.Text);
                if (cnt == 0)
                {
                    str = "0 + " + idata1;
                    result += idata1;
                    cnt++;
                }
                else
                {
                    str += " + " + idata1;
                    result += idata1;
                    cnt++;
                }
                label1.Text = "수행단계 : " + str;
                label2.Text = "계산결과 : " + result;
                label3.Text = "수행횟수 : " + cnt;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int idata1 = int.Parse(textBox1.Text);
                if (cnt == 0)
                {
                    str = "0 - " + idata1;
                    result -= idata1;
                    cnt++;
                }
                else
                {
                    str += " - " + idata1;
                    result -= idata1;
                    cnt++;
                }
                label1.Text = "수행단계 : " + str;
                label2.Text = "계산결과 : " + result;
                label3.Text = "수행횟수 : " + cnt;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int idata1 = int.Parse(textBox1.Text);
                if (cnt == 0)
                {
                    str = "0 * " + idata1;
                    result *= idata1;
                    cnt++;
                }
                else
                {
                    str += " * " + idata1;
                    result *= idata1;
                    cnt++;
                }
                label1.Text = "수행단계 : " + str;
                label2.Text = "계산결과 : " + result;
                label3.Text = "수행횟수 : " + cnt;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int idata1 = int.Parse(textBox1.Text);
                if (idata1 != 0)
                {
                    if (cnt == 0)
                    {
                        str = "0 / " + idata1;
                        result /= idata1;
                        cnt++;
                    }
                    else
                    {
                        str += " / " + idata1;
                        result /= idata1;
                        cnt++;
                    }
                }
                label1.Text = "수행단계 : " + str;
                label2.Text = "계산결과 : " + result;
                label3.Text = "수행횟수 : " + cnt;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "수행단계 : ";
            label2.Text = "계산결과 : 결과가 나오는 곳입니다!";
            textBox1.Text = "";
            str = "0";
            result = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
    }
}
