using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "홍길동,이순신;임꺽정 세종대왕";
                string str2 = ";, ";//차례대로 세미콜론, 쉼표, 띄어쓰기
                string[] str1;
                string[] str3;
                str1 = str.Split(str2.ToCharArray());
                str3 = str.Split(str2.ToCharArray(), 3);
                label3.Text = str1[0];
                label4.Text = str1[1];
                label5.Text = str1[2];
                label6.Text = str1[3];
                
                label7.Text = str3[0];
                label8.Text = str3[1];
                label9.Text = str3[2];
            }
            catch (Exception ex)
            {

            }
        }
    }
}
