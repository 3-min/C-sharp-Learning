using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_과제_3
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
            int sum = 1;

            label3.Text = "구구단 " + num1 + "부터 " + num2 + "단 까지입니다.\n\n";
            try
            {
                if (num1 == num2 || num1 > num2)
                {
                    label3.Text = "Error";
                }
                else
                {
                    for (int i = num1; i <= num2; i++)
                    {
                        for (int y = 1; y <= 9; y++)
                        {
                            sum = i * y;
                            label3.Text += i + " * " + y + " = " + sum + "\n";
                            if (y % 9 == 0)
                            {
                                label3.Text += "\n";
                            }
                        }

                    }
                }
                
                
            }
            catch (Exception ex)
            {
                label3.Text = ex.Message;
            }
           
        }
    }
}
