namespace _20233231_김상민_과제1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색깔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선굵ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선모ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.굵기2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선색깔CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.선색ToolStripMenuItem,
            this.색깔ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 405);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|모든파일|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|모든파일|*.*";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로만들기(&N)";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.열기ToolStripMenuItem.Text = "열기(&O)";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.저장ToolStripMenuItem.Text = "저장(&S)";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기(&X)";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 선색ToolStripMenuItem
            // 
            this.선색ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선굵ToolStripMenuItem,
            this.선모ToolStripMenuItem});
            this.선색ToolStripMenuItem.Name = "선색ToolStripMenuItem";
            this.선색ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.선색ToolStripMenuItem.Text = "편집";
            // 
            // 색깔ToolStripMenuItem
            // 
            this.색깔ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선색깔CToolStripMenuItem});
            this.색깔ToolStripMenuItem.Name = "색깔ToolStripMenuItem";
            this.색깔ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.색깔ToolStripMenuItem.Text = "색깔";
            this.색깔ToolStripMenuItem.Click += new System.EventHandler(this.색깔ToolStripMenuItem_Click);
            // 
            // 선굵ToolStripMenuItem
            // 
            this.선굵ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.굵기10ToolStripMenuItem,
            this.굵기7ToolStripMenuItem,
            this.굵기5ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.굵기2ToolStripMenuItem,
            this.굵기1ToolStripMenuItem});
            this.선굵ToolStripMenuItem.Name = "선굵ToolStripMenuItem";
            this.선굵ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.선굵ToolStripMenuItem.Text = "선굵기(&T)";
            this.선굵ToolStripMenuItem.Click += new System.EventHandler(this.선굵ToolStripMenuItem_Click);
            // 
            // 선모ToolStripMenuItem
            // 
            this.선모ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.toolStripMenuItem3,
            this.dotToolStripMenuItem,
            this.dashDotToolStripMenuItem});
            this.선모ToolStripMenuItem.Name = "선모ToolStripMenuItem";
            this.선모ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.선모ToolStripMenuItem.Text = "선모양(&S)";
            // 
            // 굵기10ToolStripMenuItem
            // 
            this.굵기10ToolStripMenuItem.Name = "굵기10ToolStripMenuItem";
            this.굵기10ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.굵기10ToolStripMenuItem.Text = "굵기 10";
            this.굵기10ToolStripMenuItem.Click += new System.EventHandler(this.굵기10ToolStripMenuItem_Click);
            // 
            // 굵기7ToolStripMenuItem
            // 
            this.굵기7ToolStripMenuItem.Name = "굵기7ToolStripMenuItem";
            this.굵기7ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.굵기7ToolStripMenuItem.Text = "굵기 7";
            this.굵기7ToolStripMenuItem.Click += new System.EventHandler(this.굵기7ToolStripMenuItem_Click);
            // 
            // 굵기5ToolStripMenuItem
            // 
            this.굵기5ToolStripMenuItem.Name = "굵기5ToolStripMenuItem";
            this.굵기5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.굵기5ToolStripMenuItem.Text = "굵기 5";
            this.굵기5ToolStripMenuItem.Click += new System.EventHandler(this.굵기5ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // 굵기2ToolStripMenuItem
            // 
            this.굵기2ToolStripMenuItem.Name = "굵기2ToolStripMenuItem";
            this.굵기2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.굵기2ToolStripMenuItem.Text = "굵기 2";
            this.굵기2ToolStripMenuItem.Click += new System.EventHandler(this.굵기2ToolStripMenuItem_Click);
            // 
            // 굵기1ToolStripMenuItem
            // 
            this.굵기1ToolStripMenuItem.Name = "굵기1ToolStripMenuItem";
            this.굵기1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.굵기1ToolStripMenuItem.Text = "굵기 1";
            this.굵기1ToolStripMenuItem.Click += new System.EventHandler(this.굵기1ToolStripMenuItem_Click);
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dotToolStripMenuItem.Text = "Dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
            // 
            // dashDotToolStripMenuItem
            // 
            this.dashDotToolStripMenuItem.Name = "dashDotToolStripMenuItem";
            this.dashDotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dashDotToolStripMenuItem.Text = "DashDot";
            this.dashDotToolStripMenuItem.Click += new System.EventHandler(this.dashDotToolStripMenuItem_Click);
            // 
            // 선색깔CToolStripMenuItem
            // 
            this.선색깔CToolStripMenuItem.Name = "선색깔CToolStripMenuItem";
            this.선색깔CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.선색깔CToolStripMenuItem.Text = "선색깔(&C)";
            this.선색깔CToolStripMenuItem.Click += new System.EventHandler(this.선색깔CToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 선색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색깔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선굵ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 굵기2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선모ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선색깔CToolStripMenuItem;
    }
}

