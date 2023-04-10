using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 과제_3.cs
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
            try
            {
                int iData = int.Parse(textBox1.Text);
                int i;
                int z = 0;
                int x = 0;

                label1.Text = "";
                if(iData <= 100)
                {
                    for (i = 1; i <= iData; i++)
                    {
                        //짝수 수만 나오게 하는 코드 + 5번째 수 이후에 다음 열로 이동.
                        if (i % 2 == 0)
                        {
                            label1.Text += i + " ";
                            z++;
                            if (i % 5 == 0)
                            {
                                label1.Text += "\n";
                            }
                        }
                        for(int y = 2; y <= iData; y++)
                        {
                            if (i % y == 0)
                            {
                                if (i == y)
                                {
                                    x++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    label2.Text = "짝수의 개수 = " + z;
                    label3.Text = "소수의 개수 = " + x;
                }
                else
                {
                    label1.Text = "값을 확인하고 다시 입력해주세요.";
                }
            }
                
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
