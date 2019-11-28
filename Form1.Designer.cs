namespace WindowsFormsApp2
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏选项toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新开始toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.游戏模式toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.普通模式toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.困难模式toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.炼狱模式toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(834, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 470);
            this.label1.TabIndex = 2;
            this.label1.Tag = "information";
            this.label1.Text = "游戏说明：\r\nW向上\r\nS向下\r\nA向左\r\nD向右\r\n空格键加速\r\n普通模式：可穿墙，得分100获胜\r\n\r\n困难模式：不可穿墙，得分400获胜\r\n\r\n炼狱模式：不" +
    "可穿墙，得分700获胜\r\n\r\n\r\n速度等级：极慢，慢，中，快，极快\r\n\r\n默认普通模式";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScore.Location = new System.Drawing.Point(833, 60);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(87, 25);
            this.labelScore.TabIndex = 3;
            this.labelScore.Tag = "score";
            this.labelScore.Text = "分数：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏选项toolStripMenuItem,
            this.游戏模式toolStripMenuItem1,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游戏选项toolStripMenuItem
            // 
            this.游戏选项toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.暂停toolStripMenuItem,
            this.重新开始toolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.游戏选项toolStripMenuItem.Name = "游戏选项toolStripMenuItem";
            this.游戏选项toolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.游戏选项toolStripMenuItem.Text = "游戏选项";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.开始ToolStripMenuItem.Text = "开始";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.开始ToolStripMenuItem_Click);
            // 
            // 暂停toolStripMenuItem
            // 
            this.暂停toolStripMenuItem.Name = "暂停toolStripMenuItem";
            this.暂停toolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.暂停toolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.暂停toolStripMenuItem.Text = "暂停";
            this.暂停toolStripMenuItem.Click += new System.EventHandler(this.暂停toolStripMenuItem_Click);
            // 
            // 重新开始toolStripMenuItem
            // 
            this.重新开始toolStripMenuItem.Name = "重新开始toolStripMenuItem";
            this.重新开始toolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.重新开始toolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.重新开始toolStripMenuItem.Text = "重新开始";
            this.重新开始toolStripMenuItem.Click += new System.EventHandler(this.重新开始toolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 游戏模式toolStripMenuItem1
            // 
            this.游戏模式toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通模式toolStripMenuItem2,
            this.困难模式toolStripMenuItem3,
            this.炼狱模式toolStripMenuItem4});
            this.游戏模式toolStripMenuItem1.Name = "游戏模式toolStripMenuItem1";
            this.游戏模式toolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.游戏模式toolStripMenuItem1.Text = "游戏模式";
            // 
            // 普通模式toolStripMenuItem2
            // 
            this.普通模式toolStripMenuItem2.Name = "普通模式toolStripMenuItem2";
            this.普通模式toolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.普通模式toolStripMenuItem2.Text = "普通模式";
            this.普通模式toolStripMenuItem2.Click += new System.EventHandler(this.普通模式toolStripMenuItem2_Click);
            // 
            // 困难模式toolStripMenuItem3
            // 
            this.困难模式toolStripMenuItem3.Name = "困难模式toolStripMenuItem3";
            this.困难模式toolStripMenuItem3.Size = new System.Drawing.Size(144, 26);
            this.困难模式toolStripMenuItem3.Text = "困难模式";
            this.困难模式toolStripMenuItem3.Click += new System.EventHandler(this.困难模式toolStripMenuItem3_Click);
            // 
            // 炼狱模式toolStripMenuItem4
            // 
            this.炼狱模式toolStripMenuItem4.Name = "炼狱模式toolStripMenuItem4";
            this.炼狱模式toolStripMenuItem4.Size = new System.Drawing.Size(144, 26);
            this.炼狱模式toolStripMenuItem4.Text = "炼狱模式";
            this.炼狱模式toolStripMenuItem4.Click += new System.EventHandler(this.炼狱模式toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem1.Text = "关于作者";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem2.Text = "作者说明";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::贪吃蛇.Properties.Resources.snake;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 709);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贪吃蛇";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏选项toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 游戏模式toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 普通模式toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 困难模式toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 炼狱模式toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

