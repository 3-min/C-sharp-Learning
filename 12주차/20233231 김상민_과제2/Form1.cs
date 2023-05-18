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
        int cnt = 20;
        CheckBox[] chkmgr;

        public Form1()
        {
            InitializeComponent();

            chkmgr = new CheckBox[20];
            chkmgr[0] = checkBox1;
            chkmgr[1] = checkBox2;
            chkmgr[2] = checkBox3;
            chkmgr[3] = checkBox4;
            chkmgr[4] = checkBox5;
            chkmgr[5] = checkBox6;
            chkmgr[6] = checkBox7;
            chkmgr[7] = checkBox8;
            chkmgr[8] = checkBox9;
            chkmgr[9] = checkBox10;
            chkmgr[10] = checkBox11;
            chkmgr[11] = checkBox12;
            chkmgr[12] = checkBox13;
            chkmgr[13] = checkBox14;
            chkmgr[14] = checkBox15;
            chkmgr[15] = checkBox16;
            chkmgr[16] = checkBox17;
            chkmgr[17] = checkBox18;
            chkmgr[18] = checkBox19;
            chkmgr[19] = checkBox20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random rannum = new System.Random();

            for (int i = 0; i < 20; i++)
            {
                chkmgr[i].Text = rannum.Next(1, 100).ToString();

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double chkcnt = 0;
            double sum = 0;
            double average = 0;


            listBox1.Items.Add("각 체크박스의 숫자들");
            listBox1.Items.Add("-----------------------------------");
            for (int i = 0; i < 20; i++)
            {
                listBox1.Items.Add("checkbox" + (i + 1) + " = " + chkmgr[i].Text);
            }

            listBox2.Items.Add("선택된 체크박스의 숫자들");
            listBox2.Items.Add("-----------------------------------");
            for (int i = 0; i < 20; i++)
            {
                if (chkmgr[i].Checked == true)
                {
                    listBox2.Items.Add("checkbox" + (i + 1) + " = " + chkmgr[i].Text);
                    sum += double.Parse(chkmgr[i].Text);
                    chkcnt++;
                }
            }
            listBox2.Items.Add("");
            listBox2.Items.Add("-----------------------------------");
            listBox2.Items.Add("선택된 체크박스의 숫자 합계");
            listBox2.Items.Add("-----------------------------------");
            listBox2.Items.Add("숫자 합계 -> " + sum);
            listBox2.Items.Add("-----------------------------------");
            listBox2.Items.Add("");
            listBox2.Items.Add("선택된 체크박스의 숫자 평균");
            listBox2.Items.Add("-----------------------------------");
            listBox2.Items.Add("숫자 평균 -> " + sum/chkcnt);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            for (int i = 0; i < 20; i++)
            {
                chkmgr[i].Text = "checkBox" + (i + 1);
                chkmgr[i].Checked = false;
            }
        }
    }
}
