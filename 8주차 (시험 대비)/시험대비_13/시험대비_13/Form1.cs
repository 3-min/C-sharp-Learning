using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_13
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
            int cnt = 0;

            label2.Text = "";
            try 
            {
                if (num > 1 && num <= 200)
                {
                    for(int i = 1; i <= num; i++)
                    {
                        for(int y = 2; y <= i; y++)
                        {
                            if (i % y == 0)
                            {
                                if (i == y)
                                {
                                    cnt++;
                                    label2.Text += i + " ";
                                    if(cnt == 10)
                                    {
                                        label2.Text += "\n";
                                        cnt = 0;
                                    }
                                }
                                else
                                    break;
                            }
                            
                        }
                        
                    }
                }
                else
                {
                    label2.Text = "Error";
                }
            }
            catch(Exception ee)
            {
                label2.Text = ee.Message;
            }
        }
    }
}
