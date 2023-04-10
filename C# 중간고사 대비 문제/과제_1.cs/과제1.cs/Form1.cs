using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 과제1.cs
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
                string str1 = textBox1.Text;
                string str2 = textBox2.Text;

                if ((str1 == "가위" || str1 == "바위" || str1 == "보") &&
                   (str2 == "가위" || str2 == "바위" || str2 == "보"))
                {
                    if (str1 == "가위")
                    {
                        if (str2 == "가위")
                        {
                            label3.Text = "비겼습니다.";
                        }
                        else if (str2 == "바위")
                        {
                            label3.Text = "유저 B가 이겼습니다.";
                        }
                        else
                        {
                            label3.Text = "유저 A가 이겼습니다.";
                        }
                    }
                    else if (str1 == "바위")
                    {
                        if (str2 == "가위")
                        {
                            label3.Text = "유저 A가 이겼습니다.";
                        }
                        else if (str2 == "바위")
                        {
                            label3.Text = "비겼습니다.";
                        }
                        else
                        {
                            label3.Text = "유저 B가 이겼습니다.";
                        }
                    }
                    else if(str1 == "보")
                        {
                        if (str2 == "가위")
                        {
                            label3.Text = "유저 B가 이겼습니다.";
                        }
                        else if (str2 == "바위")
                        {
                            label3.Text = "유저 A가 이겼습니다.";
                        }
                        else
                        {
                            label3.Text = "비겼습니다.";
                        }
                    }
                }
                else
                {
                    label3.Text = "Error";
                }
            }
                
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }
    }
}
