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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata1 = int.Parse(textBox1.Text);
                switch (idata1)
                {
                    case 1:
                        label2.Text = "입력값 : " + idata1 + "->" + " January";
                        break;
                    case 2:
                        label2.Text = "입력값 : " + idata1 + "->" + " February";
                        break;
                    case 3:
                        label2.Text = "입력값 : " + idata1 + "->" + " March";
                        break;
                    case 4:
                        label2.Text = "입력값 : " + idata1 + "->" + " April";
                        break;
                    case 5:
                        label2.Text = "입력값 : " + idata1 + "->" + " May";
                        break;
                    case 6:
                        label2.Text = "입력값 : " + idata1 + "->" + " June";
                        break;
                    case 7:
                        label2.Text = "입력값 : " + idata1 + "->" + "July";
                        break;
                    case 8:
                        label2.Text = "입력값 : " + idata1 + "->" + " August";
                        break;
                    case 9:
                        label2.Text = "입력값 : " + idata1 + "->" + " September";
                        break;
                    case 10:
                        label2.Text = "입력값 : " + idata1 + "->" + " October";
                        break;
                    case 11:
                        label2.Text = "입력값 : " + idata1 + "->" + " November";
                        break;
                    case 12:
                        label2.Text = "입력값 :" + idata1 + "->" + " December";
                        break;
                    default:
                        textBox1.Text = "잘못되었습니다.";
                        break;
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
