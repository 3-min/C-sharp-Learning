using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "결과가 출력되는 곳입니다.";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int sum = 0;
            int mul = 1;
            string text1 = "";
            string text2 = "";

            try
            {
                for (int i = 1; i <= num1; i += num2)
                {
                    text1 += i + " + ";
                    text2 += i + " * ";
                    sum += i;
                    mul *= i;
                }
                label3.Text = text1 + " = " + sum + "\n" + text2 + " = " + mul;
            }
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }
    }
}
