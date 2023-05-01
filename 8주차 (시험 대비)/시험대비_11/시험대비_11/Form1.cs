using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = int.Parse(textBox1.Text);
            int line = int.Parse(textBox2.Text);
            int check = 0;
            string str = "";

           
            try
            {
                if(max > 0 && max <= 100)
                {
                    for(int i = 1; i <= max; i++)
                    {
                        if (i % 2 == 0)
                        {
                            check++;
                            str += i + " , ";
                            if (check == line)
                            {
                                str += "\n";
                                check = 0;
                            }
                        }
                    }
                    str = str.TrimEnd(' ');
                    str = str.TrimEnd(',');
                    label3.Text = str;
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
