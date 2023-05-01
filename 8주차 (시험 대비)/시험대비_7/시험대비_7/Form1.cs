using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_7
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
            int cnt = 0;

            label3.Text = "";
            try
            {
                if (num1 > 0 && num1 <= 100)
                {
                    for(int i = 1; i <= num1; i++)
                    {
                        if( i % 2 == 0)
                        {
                            label3.Text += i + " ";
                            cnt++;
                            if (cnt == num2)
                            {
                                label3.Text += "\n\n";
                                cnt = 0;
                            }
                        }
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
