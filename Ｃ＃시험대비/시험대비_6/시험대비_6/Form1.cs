using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_6
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
            int cnt = 0;

            try
            {
                for(int i = 1; i <= num; i++)
                {
                    if(num % i == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt == 2)
                {
                    label2.Text = num + "은 소수입니다.";
                    cnt = 0;
                }
                
                else
                {
                    label2.Text = num + "은 소수가 아닙니다.";
                }
            }
            catch(Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
