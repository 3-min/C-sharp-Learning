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
                string str = textBox1.Text;
                int[] arrary01 = new int[13];

                if (str.IndexOf("-") >= 0)
                {
                    label2.Text = "- 빼고 입력해주세요.";
                }
                else if(str.Length != 13)
                {
                    label2.Text = "정확히 입력해주세요.";
                }
                else
                {
                    for (int i = 0; i < 13; i++)
                    {
                        arrary01[i] = int.Parse(str.Substring(i, 1));
                    }

                    int y = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        y += arrary01[i] * (i + 2);
                    }

                    for (int i = 8; i < 12; i++)
                    {
                        y += arrary01[i] * (i - 6);
                    }

                    int z = (11 - (y % 11) % 10);

                    if (z == arrary01[12])
                    {
                        label2.Text = "올바른 주민번호입니다.";
                    }
                    else
                    {
                        label2.Text = "잘못된 주민번호입니다.";
                    }
                }
                
            }
            catch (Exception ex)
            {
                label2.Text = "결과에 이상이 있습니다.";
            }
        }
    }
}
