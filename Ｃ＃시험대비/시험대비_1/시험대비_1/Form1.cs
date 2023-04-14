using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_1
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
            label2.Text = "";//label 초기화
            string str = "";//str 초기화
            int cnt = 0;//count 변수 생성
            try
            {
                int num = int.Parse(textBox1.Text);//textbox의 입력 값을 num이라는 변수에 받는다.

                if (num < 0 || num > 100)// 1 ~ 100까지의 수만 받아들여야만 하므로 음수와 100초과하는 수는 다시 입력 처리하는 조건문이다.
                {
                    label2.Text = "1~100 사이의 수를 입력해주세요";
                }
                else//위에서 음수와 100초과 수가 걸러지고 그 외에 1 ~ 100까지의 수가 이쪽으로 처리된다.
                {

                    for (int i = 1; i <= num; i++)//num까지 반복
                    {
                        if (i % 2 == 0)//짝수일 경우 이쪽 코드로 처리된다.
                        {
                            str += i + ",";
                            cnt++;

                        }
                        if (cnt % 10 == 0 && i != 100)//숫자가 10개 나온 뒤 줄바꿈 실행 // i != 100은 100은 10으로 나누면 0이 되기 때문에 101에 다음줄로 가야되는데 100에서 넘어가기 때문.
                        {
                            str += "\n";
                        }
                    }
                    if (cnt % 10 < 5 && cnt % 10 != 0)//한 줄에 출력 개수가 5개이상 10이하의 개수가 되지 않을 경우 다시 입력 요구하는 코드
                    {
                        str = "한 줄에 5~10개가 오도록 다시 입력해주세요";
                    }

                    str = str.TrimEnd(',');//TrimEnd(',')은 마지막에 나오는 쉼표 ( , )를 없애주는 코드입니다.
                    label2.Text = str;
                }
            }
            catch (Exception ex)//textbox에 아무 값도 할당해주지 않고 실행을 시켰을 때 "값을 입력하시오"라는 문자열 출력 코드
            {
                if (textBox1.Text == "") 
                {
                    label2.Text = "값을 입력해주세요"; 
                }
            }
        }
    }
}
