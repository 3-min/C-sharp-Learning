using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                double dData01 = double.Parse(textBox2.Text);

                if (iData01 == 1)
                {
                    double result = dData01 * 3.28;
                    textBox3.Text = "결과는 " + result;
                    label6.Text = "feet";
                }
                else if (iData01 == 2)
                {
                    double result = dData01 / 3.28;
                    textBox3.Text = "결과는 " + result;
                    label6.Text = "meter";
                }
                else
                {
                    textBox1.Text = "1 또는 2를 입력하세요.";
                }
            }
            catch(Exception ex)
            {
                label7.Text = ex.Message;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
