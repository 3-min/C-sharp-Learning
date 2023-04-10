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
                int num = int.Parse(textBox1.Text);
                if(num != 0 && num < 10)
                {
                    label2.Text = "";
                    int a = 0;
                    int b = 0;
                    for(int z =1; z <=9; z++)
                    {
                        a++;
                        b = num * a;
                        label2.Text += num + " * " + a + " = " + b + "\n";
                    }
                }
                else
                {
                    label2.Text = "Error\n1~9까지의 숫자를 입력하여주십시오.";
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
