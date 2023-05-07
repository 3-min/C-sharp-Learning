using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제2
{
    public partial class Form1 : Form
    {
        int in_num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                if (num > 0 && num < 1000)
                {
                    in_num += num;
                    label5.Text = "김태희의 계좌잔고 : " + in_num;
                }
                else if (num < 0 || num >= 1000)
                {
                    label6.Text = "정상적인 금액을 입금해주세요.";
                }
                
            }
            catch (Exception ex)
            {
                label6.Text = "결과에 이상이 있습니다.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int num = int.Parse(textBox2.Text);
                if (num > 0 && in_num > num)
                {
                    in_num -= num;
                    label5.Text = "김태희의 계좌잔고 : " + in_num;
                }
                else if (num < 0 || in_num < num)
                {
                    label6.Text = "정상적인 금액을 출금해주세요.";
                }
            }
            catch (Exception ex)
            {
                label6.Text = "결과에 이상이 있습니다.";
            }
        }
    }
}
