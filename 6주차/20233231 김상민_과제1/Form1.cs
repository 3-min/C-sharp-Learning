using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제1
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
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int sum = 0;
                int mul = 1;

                if (a >= 1 && b <= 20)
                {
                    for(int i = a; i <= b; i++)
                    {
                        sum = sum + i;
                        mul = mul * i;
                    }
                }
                
                label3.Text = a + "부터 " + b + "까지의 합은" + sum
                    + "\n곱은 " + mul;
            }
            catch (Exception ex)
            {
                label3.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
