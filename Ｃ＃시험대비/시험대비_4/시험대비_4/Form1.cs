using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_4
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
            int num = int.Parse(textBox1.Text);
            int sum = 0;
           
            try
            {
                if (num > 0 && num <= 9)
                {
                    label2.Text = "구구단 " + num + "단\n";
                    for (int i = 1; i <= 9; i++)
                    {
                        sum = num * i;
                        label2.Text += num + " * " + i + " = " + sum + "\n";
                    }
                }
                else
                {
                    label2.Text = "Error\n1 ~ 9 까지의 수를 입력하여주십시오.";
                }
            }
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
            
        }
    }
}
