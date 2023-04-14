using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int sum = 0;
            int mul = 1;

            try 
            {
                if ((num1 > 0 && num1 <= 20) && (num2 > 0 && num2 <= 20))
                {
                     if (num1 > num2 || num1 == num2)
                    {
                        label3.Text = "다시 입력하십시오.";
                    }
                    else
                    {
                        for (int i = num1; i <= num2; i++)
                        {
                            sum += i;
                            mul *= i;
                        }
                        label3.Text = num1 + "부터" + num2 + "까지의 합은 " + sum + " 곱은 " + mul + "입니다.";
                    }
                }
               
                else
                {
                    label3.Text = "Error";
                }
            }
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }
    }
}
