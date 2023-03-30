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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata1 = int.Parse(textBox1.Text);
                switch (idata1)
                {
                    case 1:
                        label2.Text = "one";
                        break;
                    case 2:
                        label2.Text = "two";
                        break;
                    case 3:
                        label2.Text = "three";
                        break;
                    case 4:
                        label2.Text = "four";
                        break;
                    case 5:
                        label2.Text = "five";
                        break;
                    default:
                        label2.Text = "알 수 없는 수입니다.";
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
