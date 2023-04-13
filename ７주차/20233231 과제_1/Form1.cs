using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_과제_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            bool is_prime = true;

            try
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        is_prime = false;
                    }
                }
                if (is_prime)
                {
                    label2.Text = num + "은 소수입니다.";
                }
                else
                {
                    label2.Text = num + "은 소수가 아닙니다.";
                }
            }
            catch (Exception ex)
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
