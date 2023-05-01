using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_3
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
                int num = int.Parse(textBox1.Text);
                string result = "";
                string primeText = "";
                string text = "";
                int cnt = 0;//count
                int prime = 0;//소수 변수
                int v = num / 100;
                if (num < 2 || num > 1000)//2미만 1000초과의 수가 입력될 시 아래 코드 구현됌.
                {
                    label2.Text = "2~1000 사이의 수를 입력해주세요.";
                }
                else//2 ~ 1000 사이의 수는 이쪽으로 걸러져서 작동됌.
                {

                    for (int i = 1; i <= num; i++)//소수 찾는 코드
                    {
                        for (int y = 1; y <= i; y++)
                        {
                            if (i % y == 0)//소수는 1과 자기 자신으로만 나누어지므로 conut 변수가 2번 체크되면 그 수는 소수가 된다.
                            {
                                cnt++;
                            }
                        }
                        if (cnt == 2)
                        {
                            prime++;
                            primeText += i + ", ";

                        }
                        cnt = 0;//count를 초기화 시켜주지 않으면 계속 늘어나기 때문에 정상적인 값이 도출되지 않는다.

                        if (i % 100 == 0)//100 단위로 나누어 소수와 소수 개수를 구하는 코드
                        {
                            text = i - 99 + "부터 " + i + "까지 " + prime + " 개\n";//ex) 1부터 100까지 25 개
                            result += text + primeText;
                            result = result.Trim(' ');
                            result = result.TrimEnd(',');
                            result += "\n\n";
                            prime = 0;
                            primeText = "";

                        }

                        else if (i == num)//이해 안감
                        {
                            text = i - num % 100 + 1 + "부터 " + i + "까지 " + prime + " 개\n";
                            result += text + primeText;
                        }

                    }
                    label2.Text = result;
                }



            }
            catch (Exception ex)
            {
                if (textBox1.Text == "")
                {
                    label2.Text = "값이 비어있습니다.";
                }
                else
                {
                    label2.Text = "정수를 입력하시죠?";
                }

            }
        }
    }
}
