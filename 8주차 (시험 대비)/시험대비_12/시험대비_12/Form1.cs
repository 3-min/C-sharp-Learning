using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = int.Parse(textBox1.Text);
            int max = int.Parse(textBox2.Text);
            int inc = int.Parse(textBox3.Text);
            string str1 = "";
            string str2 = "";
            int sum = 0;
            int mul = 1;

            label4.Text = "";
            try
            {
                for(int i = min; i <= max; i += inc)
                {
                    sum += i;
                    mul *= i;
                    str1 += i + " + ";
                    str2 += i + " * ";
                }
                str1 = str1.TrimEnd(' ');
                str1 = str1.TrimEnd('+');
                str2 = str2.TrimEnd(' ');
                str2 = str2.TrimEnd('*');
                label4.Text = str1 + " = " + sum + "\n" + str2 + " = " + mul;
            }
            catch(Exception ex)
            {
                label4.Text = ex.Message;
            }
        }
    }
}
