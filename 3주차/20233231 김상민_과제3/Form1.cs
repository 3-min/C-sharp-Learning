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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);// 가로
                int iData02 = int.Parse(textBox2.Text);// 세로
                int iData03 = int.Parse(textBox3.Text);// 높이

                int iData04 = iData01 * 10 * iData02 * 10 * iData03 * 10;
                label1.Text = "직육면체의 가로: " + iData01 * 10 + "mm \n세로: " 
                    + iData02 * 10 + "mm \n높이: " + iData03 * 10 + "mm \n부피는: " 
                    + iData04 + "입니다."; 
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);// 가로
                int iData02 = int.Parse(textBox2.Text);// 세로
                int iData03 = int.Parse(textBox3.Text);// 높이

                int iData04 = iData01 * iData02 * iData03;
                label1.Text = "직육면체의 가로: " + iData01 + "cm \n세로: "
                    + iData02 + "cm \n높이: " + iData03 + "cm \n부피는: "
                    + iData04 + "입니다.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double iData01 = double.Parse(textBox1.Text);// 가로
                double iData02 = double.Parse(textBox2.Text);// 세로
                double iData03 = double.Parse(textBox3.Text);// 높이

                double iData04 = iData01 / 100 * iData02 / 100 * iData03 / 100;
                label1.Text = "직육면체의 가로: " + iData01 / 100 + "m \n세로: "
                    + iData02 / 100 + "m \n높이: " + iData03 / 100 + "m \n부피는: "
                    + iData04 + "입니다.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
