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
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata1 = int.Parse(textBox1.Text);
                int result = 0;
                if (idata1 > 0 && idata1 <= 50000)
                {
                    count++;
                    for (int i = 1; i <= idata1; i++)
                    {
                        result += i;
                    }
                    label1.Text = "합 : " + result;
                    label2.Text = "이용횟수 : " + count + "회";
                }
                else if(idata1 < 1 || idata1 > 50000)
                {
                    label1.Text = "1~50000 사이의 수만 입력해주세요.";
                }
                
                
            }
            catch (Exception ex)
            {
                label1.Text = "결과에 이상이 있습니다.";
            }
        }
    }
}
