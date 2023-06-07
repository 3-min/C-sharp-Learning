using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 그림판_연습
{
    public partial class Form1 : Form
    {
        //전역 변수
        bool isDrag = false;
        bool modified = false;
        Bitmap MyBitMap;
        Pen MyPen = new Pen(Color.Black, 2);
        Point Point1;
        Point Point2;

        public Form1()
        {
            InitializeComponent();
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel);
                    if(answer == DialogResult.Yes)
                    {
                        저장SToolStripMenuItem_Click(sender, e);
                        modified = false;
                        pictureBox1.Refresh();
                    }
                    else if(answer == DialogResult.No)
                    {
                        MyBitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = MyBitMap;

                        Graphics g = Graphics.FromImage(pictureBox1.Image);
                        g.Clear(Color.White);
                        g.Dispose();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("새로 만들기 과정에서 문제가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 잘못 클릭함
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            Point1.X = e.X;
            Point1.Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrag)
            {
                Point2.X = e.X;
                Point2.Y = e.Y;
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.DrawLine(MyPen, Point1, Point2);
                Point1 = Point2;
                pictureBox1.Refresh();
                modified = true;
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog1.FilterIndex == 1)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if(saveFileDialog1.FilterIndex == 2)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else if(saveFileDialog1.FilterIndex == 3)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                }
            }
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MyBitMap.Dispose();
                    MyBitMap = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                    pictureBox1.Image = MyBitMap;
                    pictureBox1.Refresh();
                    modified = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("열기를 하는 도중 문제가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel);
                    if (answer == DialogResult.Yes)
                    {
                        저장SToolStripMenuItem_Click(sender, e);
                        modified = false;
                        pictureBox1.Refresh();
                    }
                    else if (answer == DialogResult.No)
                    {
                        MyBitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = MyBitMap;

                        Graphics g = Graphics.FromImage(pictureBox1.Image);
                        g.Clear(Color.White);
                        g.Dispose();
                    }
                }
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("종료를 하는 도중 문제가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 선굵기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //잘못 누름
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MyPen.Width = 10;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MyPen.Width = 7;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MyPen.Width = 5;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MyPen.Width = 2;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            MyPen.Width = 1;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void dashDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void 선색깔CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                MyPen.Color = colorDialog1.Color;
            }
        }
    }
}
