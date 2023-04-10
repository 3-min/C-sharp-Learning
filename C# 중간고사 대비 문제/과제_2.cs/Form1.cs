using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 과제_2.cs
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
                int i = int.Parse(textBox1.Text);
                int a, b;

                if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8 || i == 9)
                {
                    if (i == 1)
                    {
                        label2.Text = "";
                        for (a = 1; a <= 9; a++)
                        {
                            b = 1 * a;
                            label2.Text += "1 * " + a + " = " + b + "\n";
                        }
                    }
                    else if (i == 2)
                    {
                        label2.Text = "";
                        for (a = 1; a <= 9; a++)
                        {
                            b = 2 * a;
                            label2.Text += "2 * " + a + " = " + b + "\n";
                        }
                    }
                    else if (i == 3)
                    {
                        label2.Text = "";
                        for (a = 1; a <= 9; a++)
                        {
                            b = 3 * a;
                            label2.Text += "3 * " + a + " = " + b + "\n";
                        }
                    }
                    else if (i == 4)
                    {
                        label2.Text = "";
                        for (a = 1; a <= 9; a++)
                        {
                            b = 4 * a;
                            label2.Text += "4 * " + a + " = " + b + "\n";
                        }
                    }
                    else if (i == 5)
                    {
                        label2.Text = "";
                        for (a = 1; a <= 9; a++)
                        {
                            b = 5 * a;
                            label2.Text += "5 * " + a + " = " + b + "\n";
                        }
                    }
                    else if (i == 6)
                    {
                        label2.Text = "";
                        for (a = 1; a <= 9; a++)
                        {
                            b = 6 * a;
                            label2.Text += "6 * " + a + " = " + b + "\n";
                        }
                    }
                    else if (i == 7)
                    {
                        label2.Text = "";
                        for (a = 1; a <= 9; a++)
                        {
                            b = 7 * a;
                            label2.Text += "7 * " + a + " = " + b + "\n";
                        }
                    }
                    else if (i == 8)
                    {
                        label2.Text = "";
                        for (a = 1; a <= 9; a++)
                        {
                            b = 8 * a;
                            label2.Text += "8 * " + a + " = " + b + "\n";
                        }
                    }
                    else if (i == 9)
                    {
                        label2.Text = "";
                        for (a = 1; a <= 9; a++)
                        {
                            b = 9 * a;
                            label2.Text += "9 * " + a + " = " + b + "\n";
                        }
                    }
                }
                else
                {
                    label2.Text = "1단에서 9단까지만 출력할 수 있습니다." + "\n숫자를 다시 입력하여주십시오.";
                }
            }
            catch(Exception ex)
            {
                label2.Text = ex.Message;
            }
            }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
