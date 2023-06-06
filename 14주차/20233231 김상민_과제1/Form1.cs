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
        bool isDrag = false;
        bool Modified = false;
        Bitmap MyBitMap;
        Pen MyPen = new Pen(Color.Black, 2);
        Point Point1;
        Point Point2;

        public Form1()
        {
            InitializeComponent();
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
            if (isDrag)
            {
                Point2.X = e.X;
                Point2.Y = e.Y;
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.DrawLine(MyPen, Point1, Point2);
                Point1 = Point2;
                pictureBox1.Refresh();
                Modified = true;
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyBitMap.Dispose();
                MyBitMap = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                pictureBox1.Image = MyBitMap;
                pictureBox1.Refresh();
                Modified = false;
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (saveFileDialog1.FilterIndex == 2)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else if (saveFileDialog1.FilterIndex == 3)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyBitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = MyBitMap;

            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.Dispose();

        }

        private void 색깔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Modified)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하고 종료하시겠습니까?", "그림판", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    저장ToolStripMenuItem_Click(sender, e);
                }
                else if (answer == DialogResult.No)
                {
                    MyBitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = MyBitMap;

                    Graphics g = Graphics.FromImage(pictureBox1.Image);
                    g.Clear(Color.White);
                    g.Dispose();
                }
                else if (answer == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 선굵ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel);
                    if (answer == DialogResult.Yes)
                    {
                        저장ToolStripMenuItem_Click(sender, e);
                        Modified = false;
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
                    else if (answer == DialogResult.Cancel)
                    {
                       
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void 선색깔CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                MyPen.Color = colorDialog1.Color;
            }
        }

        private void 굵기10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 10;
        }

        private void 굵기7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 7;
        }

        private void 굵기5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 5;
        }

        private void 굵기2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 2;
        }

        private void 굵기1ToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
