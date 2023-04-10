using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 과제_4
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
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int check = 0;
                int sum = 0;

                label1.Text = "< 결과 출력 >\n\n";
                for(int i =1; i <= num1; i++)
                {
                    if(i % num2 == 0)
                    {
                        label1.Text += i + " ";
                        check++;
                        sum++;
                    }
                    if(check == 5)
                    {
                        label1.Text += "\n\n";
                        check = 0;
                    }
                }
                label2.Text = num2 + " 배수의 갯수 : " + sum;
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
