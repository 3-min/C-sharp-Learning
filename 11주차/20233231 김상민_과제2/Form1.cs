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
                string[] sUacceptableWords = new string[4];
                sUacceptableWords[0] = "바보";
                sUacceptableWords[1] = "메롱";
                sUacceptableWords[2] = "님아";
                sUacceptableWords[3] = "8억";

                string str = textBox1.Text;

                foreach(string str1 in sUacceptableWords)
                {
                    int fp = str.IndexOf(str1);
                    while (fp >= 0)
                    {
                        string bstr = str.Substring(0, fp);//앞부분
                        string cstr = str.Substring(fp + str1.Length);//뒷부분
                        str = bstr + "(금지어)" + cstr;
                        fp = str.IndexOf(str1);
                    }
                }
                textBox1.Text = str;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
