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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                string sData01 = "";
                
                for(int i=1; i <= iData01; i++)
                {
                    sData01 = sData01 + i + " , ";
                    if (i % 7 == 0)
                    {
                        sData01 += "\n";
                    }
                }
                sData01 = sData01.Substring(0, sData01.Length - 2);
                label2.Text = "수행된 i값 : " + sData01;
                
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
