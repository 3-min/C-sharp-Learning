using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sData01 = textBox1.Text;
            label5.Text = "셩명 :" + sData01;
            string sData02 = textBox4.Text;
            label6.Text = "학번 :" + sData02;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sData04 = textBox3.Text;
            label7.Text = "유선 :" + sData04;
            string sData03 = textBox2.Text;
            label8.Text = "무선 :" + sData03;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

        }
    }
}
