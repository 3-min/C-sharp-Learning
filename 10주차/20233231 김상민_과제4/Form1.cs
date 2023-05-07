using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제4
{
    public partial class Form1 : Form
    {
        int win = 0;
        int draw = 0;
        int lose = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "가위";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "바위";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "보";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string user = textBox1.Text;
                if (user == "가위" || user == "바위" || user == "보")
                {
                    System.Random Rannum = new System.Random();
                    int sysnum = Rannum.Next(1, 4);
                    string sysstr = "";

                    if (sysnum == 1)
                    {
                        sysstr = "가위";
                    }
                    else if (sysnum == 2)
                    {
                        sysstr = "바위";
                    }
                    else
                    {
                        sysstr = "보";
                    }
                    if (user == "가위" && sysstr == "가위")
                    {
                        label2.Text = "User 는 -> 가위 " + "\n" +
                            "system은 -> 가위\n" + "결과는 -> 무승부";
                        draw++;
                        label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                    }
                    else if (user == "가위" && sysstr == "바위")
                    {
                        label2.Text = "User 는 -> 가위 " + "\n" +
                            "system은 -> 바위\n" + "결과는 -> User 패";
                        lose++;
                        label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                    }
                    else if (user == "가위" && sysstr == "보")
                    {
                        label2.Text = "User 는 -> 가위 " + "\n" +
                            "system은 -> 보\n" + "결과는 -> User 승";
                        win++;
                        label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                    }
                    if (user == "바위")
                    {
                        if (sysstr == "가위")
                        {
                            label2.Text = "User 는 -> 바위 " + "\n" +
                            "system은 -> 가위\n" + "결과는 -> User 승";
                            win++;
                            label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                        }
                        else if (sysstr == "바위")
                        {
                            label2.Text = "User 는 -> 바위 " + "\n" +
                            "system은 -> 바위\n" + "결과는 -> 무승부";
                            draw++;
                            label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                        }
                        else if (sysstr == "보")
                        {
                            label2.Text = "User 는 -> 바위 " + "\n" +
                            "system은 -> 보\n" + "결과는 -> User 패";
                            lose++;
                            label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                        }
                    }
                    if (user == "보")
                    {
                        if (sysstr == "가위")
                        {
                            label2.Text = "User 는 -> 보 " + "\n" +
                            "system은 -> 가위\n" + "결과는 -> User 패";
                            lose++;
                            label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                        }
                        else if (sysstr == "바위")
                        {
                            label2.Text = "User 는 -> 보 " + "\n" +
                            "system은 -> 바위\n" + "결과는 -> User 승";
                            win++;
                            label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                        }
                        else if (sysstr == "보")
                        {
                            label2.Text = "User 는 -> 보 " + "\n" +
                            "system은 -> 보\n" + "결과는 -> 무승부";
                            draw++;
                            label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                label3.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
