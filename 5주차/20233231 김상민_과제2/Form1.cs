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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                char cdata1 = char.Parse(textBox1.Text);
                if ((cdata1 >= 'a' && cdata1 <= 'z') || (cdata1 >= 'A' && cdata1 <= 'z'))
                {
                    switch (cdata1)
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'o':
                        case 'O':
                        case 'u':
                        case 'U':
                        case 'y':
                        case 'Y':
                            label2.Text = cdata1 + "은 모음입니다.";
                            break;
                        default:
                            label2.Text = cdata1 + "은 자음입니다.";
                            break;
                    }
                }
                else
                {
                    label2.Text = cdata1 + "을 입력하였습니다.\n영문 알파벳 한글자를 입력하세요!";
                }
                }
               
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
