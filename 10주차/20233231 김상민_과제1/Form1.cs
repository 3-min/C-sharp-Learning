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
                int[] Arrary01 = new int[100];
                string str1 = "";
                int cnt = 0;

                for (int i = 0; i < 100; i++)
                {
                    Arrary01[i] = i + 1;
                }
                foreach (int ione in Arrary01)
                {
                    cnt++;
                    if (cnt % 10 == 0)
                    {
                        str1 += ione + "\n";
                    }
                    else
                    {
                        str1 = str1 + ione + " ";
                    }
                }
                label1.Text = str1;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
