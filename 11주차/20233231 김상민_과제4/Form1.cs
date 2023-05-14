using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제4
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
                int num = 12345;
                string str = string.Format("{0:C}", num);//결과 "\12,345"
                label1.Text = "귀하의 잔액은 " + str + "입니다.";

                int inum = 12345;
                double dnum = 0.05;
                string str2 = string.Format("{0:C}이고, 계산순위 상위 {1:P1}", inum, dnum);
                label2.Text = "귀하의 총액은 " + str2 + " 입니다."; //결과 "귀하의 계좌총액은 \12,345이고, 재산순위 상위 5.0%입니다.
            }
            catch (Exception ex)
            {

            }
        }
    }
}
