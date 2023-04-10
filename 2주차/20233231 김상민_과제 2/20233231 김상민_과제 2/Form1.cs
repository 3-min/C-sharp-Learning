using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sData01 = "20233231";
            string sData02 = "홍길동";

            label1.Text = "학번은 " + sData01 + "\n성명은 " + sData02;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sData03 = "010-7442-1262";
            label3.Text = "연락처는" + sData03 + "입니다.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
