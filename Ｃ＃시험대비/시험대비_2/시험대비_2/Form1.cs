using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험대비_2
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
                int min = int.Parse(textBox1.Text);//최소 값
                int max = int.Parse(textBox2.Text);//최대 값
                int increment = int.Parse(textBox3.Text);//증가 값
                string sumResult = "";//더한 값의 결과
                string mulResult = "";//곱한 값의 결과
                label4.Text = "더한값: ";
                label5.Text = "곱한값: ";

                if (min > max || min == max)//최소 값이 최대 값보다 클 때와 최소 값과 최대 값이 같을 경우 오류 처리.
                {
                    label4.Text = "최소 최대 값을 다시 확인해주세요";
                }
                else if (increment == 0)// ?
                {
                    label4.Text = "무한루프 돕니다.";
                    /*
                     * 무한 루프 돌리는 코드
                     * 
                     * while (true)
                        {
                            label5.Text = "무한루프";
                        }
                    */
                }
                else if (min > 1 && min < 20 && max < 20 && max > 1 && increment > 1 && increment < 20)//최소 값과 최대 값은 1 ~ 20까지의 수를 입력한다.
                {
                    int sum = 0;
                    int mul = 1;

                    for (int i = min; i <= max; i += increment)//최소 값부터 시작하여 최대 값까지 증가 값만큼 반복하는 반복문이다.
                    {
                        sumResult += i + " + ";
                        mulResult += i + " * ";
                        sum += i;
                        mul *= i;


                    }
                    label4.Text = min + " 부터 " + max + " 까지 증가값 " + increment + "로";
                    sumResult = sumResult.Trim();
                    sumResult = sumResult.TrimEnd('+');
                    mulResult = mulResult.Trim();
                    mulResult = mulResult.TrimEnd('*');

                    label4.Text += sumResult + "= " + sum;
                    label5.Text += mulResult + "= " + mul;
                }
                else//최소 값이 최대 값보다 클 경우와 최소 최대 값이 같을 경우, 1 ~ 20 사이의 수 마지막으로 증가값이 0이 아닌 모든 경우의 수는 여기서 구현된다.
                {
                    label4.Text = "1~20 사이의 수만 입력해주세요.";
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
