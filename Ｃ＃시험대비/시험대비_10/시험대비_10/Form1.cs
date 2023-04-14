using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);

            try
            {
                if(num <= 15 || num >= 65)
                {
                    label3.Text = "할인 받을 수 있습니다.";
                }
                else 
                {
                    label3.Text = "할인 대상이 아닙니다.";
                }
            }
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }
    }
}
