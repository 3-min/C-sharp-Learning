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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sdata1 = textBox1.Text;
                switch (sdata1)
                {
                    case "int":
                        int int_Min = int.MinValue;
                        int int_Max = int.MaxValue;
                        label2.Text = sdata1 + "의 허용값은 " + int_Min + " ~ " + int_Max;
                        break;
                    case "double":
                        label2.Text = sdata1 + "의 허용값은 " + double.MinValue + " ~ " + double.MaxValue;
                        break;
                    case "uint":
                        label2.Text = sdata1 + "의 허용값은" + uint.MinValue + " ~ " + uint.MaxValue;
                        break;
                    case "float":
                        label2.Text = sdata1 + "의 허용값은" + float.MinValue + " ~ " + float.MaxValue;
                        break;
                    case "long":
                        label2.Text = sdata1 + "의 허용값은" + long.MinValue + " ~ " + long.MaxValue;
                        break;
                    case "ulong":
                        label2.Text = sdata1 + "의 허용값은" + ulong.MinValue + " ~ " + ulong.MaxValue;
                        break;
                    case "byte":
                        label2.Text = sdata1 + "의 허용값은" + byte.MinValue + " ~ " + byte.MaxValue;
                        break;
                    case "sbyte":
                        label2.Text = sdata1 + "의 허용값은" + sbyte.MinValue + " ~ " + sbyte.MaxValue;
                        break;
                    case "short":
                        label2.Text = sdata1 + "의 허용값은" + short.MinValue + " ~ " + short.MaxValue;
                        break;
                    case "ushort":
                        label2.Text = sdata1 + "의 허용값은" + ushort.MinValue + " ~ " + ushort.MaxValue;
                        break;
                    default:
                        label2.Text = "알 수 없는 데이터 타입입니다.";
                        break;


                }
            }
            catch(Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
