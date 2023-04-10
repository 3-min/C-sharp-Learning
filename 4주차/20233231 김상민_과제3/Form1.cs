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
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                string sData01 = textBox3.Text;

                if (sData01 == "==")
                {
                    bool bData01 = iData01 == iData02;
                    label5.Text = iData01 + "==" + iData02 + "의 결과는" + bData01;

                }
                else if (sData01 == "<=")
                {
                    bool bData01 = iData01 <= iData02;
                    label5.Text = iData01 + "<=" + iData02 + "의 결과는" + bData01;
                }
                else if (sData01 == "=>")
                {
                    bool bData01 = iData01 >= iData02;
                    label5.Text = iData01 + ">=" + iData02 + "의 결과는" + bData01;
                }
                else if (sData01 == "!=")
                {
                    bool bData01 = iData01 != iData02;
                    label5.Text = iData01 + "!=" + iData02 + "의 결과는" + bData01;
                }
                else if (sData01 == "<")
                {
                    bool bData01 = iData01 < iData02;
                    label5.Text = iData01 + "<" + iData02 + "의 결과는" + bData01;
                }
                else if (sData01 == ">")
                {
                    bool bData01 = iData01 > iData02;
                    label5.Text = iData01 + ">" + iData02 + "의 결과는" + bData01;
                }
                else
                {
                    label5.Text = "알 수 없는 관계연산자입니다.";
                }
            }
            catch (Exception ex)
            {
                label5.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
