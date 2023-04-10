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
                ulong a = ulong.Parse(textBox1.Text);
                ulong b = ulong.Parse(textBox2.Text);
                ulong sum = 0;
                ulong mul = 1;

               
                    
                if(a == b)
                {
                    label3.Text = "시작값은 마지막값 보다 작은 값이어야 합니다!";
                }
                else if (a > b)
                {
                    label3.Text = "시작값은 마지막값 보다 작은 값이어야 합니다!";
                }
                else if (b > 20)
                {
                    label3.Text = "마지막값은 21보다 작은 값이어야 합니다.";
                }
                else if( 0 >= a)
                {
                    label3.Text = "시작값은 0보다 큰 값이야 합니다!";
                }
                
                else
                {
                    for(ulong i = a; i <= b; i++)
                    {
                        sum = sum + i;
                        mul = mul * i;
                    }
                    label3.Text = a + "부터 " + b + "까지의 합은" + sum
                   + "\n곱은 " + mul;
                }
                
                
               
                
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
