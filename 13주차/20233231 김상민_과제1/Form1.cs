using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제1
{
    public partial class Form1 : Form
    {
        bool ismodified = false;
        bool hasfilename = false;
        string sfilename = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ismodified = true;
        }

        private void 파일FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //공통 부분
                if (ismodified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (hasfilename == true)
                        {
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sfilename);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            ismodified = false;

                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sfilename = openFileDialog1.FileName;
                                sfilename = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs =
                                    System.IO.File.CreateText(sfilename);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                hasfilename = true;
                                ismodified = false;
                            }
                        }
                    }
                }
                //공통 부분 끝
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sfilename = openFileDialog1.FileName;
                    System.IO.StreamReader fs =
                        System.IO.File.OpenText(sfilename);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    hasfilename = true;
                    ismodified = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("열기를 하는 도중 이상입 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //공통 부분, 내용이 수정된 경우 저장여부 확인후, 원하면 저장
                   if (ismodified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (hasfilename == true)
                        {
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sfilename);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            ismodified = false;

                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sfilename = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs =
                                    System.IO.File.CreateText(sfilename);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                hasfilename = true;
                                ismodified = false;

                            }
                        }
                    }
                } //공통 부분 끝
                textBox1.Text = "";
                ismodified = false;
                hasfilename = false;
                sfilename = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("새파일을 준비하는 도중 이상이 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
           
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (hasfilename == true)
                {
                    System.IO.StreamWriter fs =
                        System.IO.File.CreateText(sfilename);
                    fs.WriteLine(textBox1.Text);
                    fs.Close();
                    ismodified = false;

                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        sfilename = saveFileDialog1.FileName;
                        System.IO.StreamWriter fs =
                            new System.IO.StreamWriter(sfilename, false, System.Text.Encoding.Default);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        hasfilename = true;
                        ismodified = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장을 하는 도중 이상이 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //공통 부분
                if (ismodified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (hasfilename == true)
                        {
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sfilename);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            ismodified = false;

                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sfilename = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs =
                                    System.IO.File.CreateText(sfilename);
                                fs.WriteLine(textBox1.Text);
                                hasfilename = true;
                                ismodified = false;

                            }
                        }
                    }
                }//공통 부분 끝
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("끝내는 도중 이상이 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();//복사
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();//잘라내기
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();//붙여넣기
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste("");//삭제
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void 색깔CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void 끝내기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ismodified)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하고 종료하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) // yes 클릭 시
                {
                    저장ToolStripMenuItem_Click(sender, e); //저장메뉴 함수를 재사용
                }
                else if(answer == DialogResult.Cancel) //취소 버튼 클릭 시
                {
                    e.Cancel = true;
                }
            }
        }
        
    }
}
