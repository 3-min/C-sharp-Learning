using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 메모장_연습
{
    public partial class Form1 : Form
    {
        bool ismodified = false;
        bool has_file_name = false;
        string s_file_name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //공통 부분, 내용이 수정된 경우 저장여부 확인 후, 원하면 저장!
                if(ismodified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if(answer == DialogResult.Yes)
                    {
                        if (has_file_name == true)
                        {
                            System.IO.StreamWriter fs = System.IO.File.CreateText(s_file_name);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            ismodified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                s_file_name = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = System.IO.File.CreateText(s_file_name);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                has_file_name = true;
                                ismodified = false;
                            }
                        }
                    }
                }//공통 부분 끝
                textBox1.Text = "";
                ismodified = false;
                has_file_name = false;
                s_file_name = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("새파일을 준비하는 도중 이상이 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ismodified = true;
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ismodified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (has_file_name == true)
                        {
                            System.IO.StreamWriter fs = System.IO.File.CreateText(s_file_name);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            ismodified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                s_file_name = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = System.IO.File.CreateText(s_file_name);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                has_file_name = true;
                                ismodified = false;
                            }
                        }
                    }
                }//공통 부분 끝
                if(openFileDialog1.ShowDialog() == DialogResult.OK)//open code
                {
                    s_file_name = openFileDialog1.FileName;
                    System.IO.StreamReader fs = System.IO.File.OpenText(s_file_name);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    has_file_name = true;
                    ismodified = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("열기를 하는 도중 문제가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try//save code
            {
                if(has_file_name == true)
                {
                    System.IO.StreamWriter fs = System.IO.File.CreateText(s_file_name);
                    fs.WriteLine(textBox1.Text);
                    fs.Close();
                    ismodified = false;
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        s_file_name = saveFileDialog1.FileName;
                        System.IO.StreamWriter fs = new System.IO.StreamWriter(s_file_name, false, System.Text.Encoding.Default);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        has_file_name = true;
                        ismodified = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("저장을 하는 도중 문제가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ismodified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (has_file_name == true)
                        {
                            System.IO.StreamWriter fs = System.IO.File.CreateText(s_file_name);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            ismodified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                s_file_name = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = System.IO.File.CreateText(s_file_name);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                has_file_name = true;
                                ismodified = false;
                            }
                        }
                    }
                }//same part end
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("끝내기 도중 문제가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 복사하기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 삭제XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste("");
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 색깔CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ismodified)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하고 종료하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(answer == DialogResult.Yes)
                {
                    저장SToolStripMenuItem_Click(sender, e); //저장 메뉴 함수 재사용
                }
                else if(answer == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
