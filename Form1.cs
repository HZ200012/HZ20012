using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//窗口大小1050,650   实际大小除于1.25  791 530
//游戏边界 left：600，top：480
//蛇和食物为正方形size20，颜色为红色,食物颜色为黑色
//top为560和40是碰上下边的条件，left为580和0是碰左右边的条件，location同理
//移动距离为20
//Right向右    Up向上      Down向下    Left向右
namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
        int sum = 0;//第几个蛇块
		const int GameHeight = 560;//游戏高度
		const int GameWidth = 600;//游戏宽度
		const int SIZE = 20;//蛇的宽和高
        const string W = "Up";
        const string A = "Left";
        const string S = "Down";
        const string D = "Right";
        static Label[] LabelSum;//蛇块
        string SpeedLevel;//速度等级
        Label SnakeHead = new Label();//蛇头初始化
        Label labelfood;//食物
         bool Border;//true可以越界，false不可以越界
        int score;
        string MoveDirection = D;//初始化移动方向
        void Restart()//游戏重新开始
        {
            if (sum > 0)
                for (int i = 1; i <= sum; i++)
                    this.Controls.Remove(LabelSum[i]);
            SnakeHead.Location = new Point(GameWidth / 2, GameHeight / 2);
            sum = 0;
            timer1.Enabled = false;
        }

        public Form1()
		{
			InitializeComponent();
           LabelSum = new Label[700];//蛇长     （可改变）       
		}
        void SnakeMove()//蛇移动
        {
            for (int i = sum; i >= 1; i--)
                LabelSum[i].Location = LabelSum[i - 1].Location;//每一个蛇块的下一个移动位置都是前一个蛇块的之前的位置
                if (MoveDirection == W)
                 LabelSum[0].Top -= SIZE;
            else if (MoveDirection == A)
                 LabelSum[0].Left -= SIZE;
            else if (MoveDirection == S)
                 LabelSum[0].Top += SIZE;
            else if (MoveDirection == D)
                 LabelSum[0].Left += SIZE;

        }
        void EatFood()//蛇头吃食物
        {
            if (LabelSum[0].Location == labelfood.Location)
            {
                labelfood.Tag = "snake";
                labelfood.BackColor = Color.Red;
                LabelSum[++sum] = labelfood;
                LabelSum[sum].Location = LabelSum[sum - 1].Location;
                if (MoveDirection == W) LabelSum[sum].Top += SIZE;
                if (MoveDirection == A) LabelSum[sum].Left += SIZE;
                if (MoveDirection == S) LabelSum[sum].Top -= SIZE;
                if (MoveDirection == D) LabelSum[sum].Left -= SIZE;
                this.Controls.Add(LabelSum[sum]);
                MakeFood();//造新的食物
            }
        }
        void MakeFood()//生成食物
        {
            Random random = new Random();
            int x, y;//食物出现的位置
            x = random.Next(GameWidth/SIZE);
            y = random.Next(2,GameHeight/SIZE);
            labelfood = new Label();
            labelfood.Width = labelfood.Height = SIZE;
            labelfood.Tag = "food";
            labelfood.BackColor = Color.Black;
            labelfood.Location = new Point(x * 20, y * 20);
            this.Controls.Add(labelfood);
        }
        void OverBorder(bool judge)//越界判断    ture可以越界,false不可以越界
        {
            if (judge){
                if (LabelSum[0].Top == 20 && MoveDirection == W) LabelSum[0].Top = GameHeight - 20;
                if (LabelSum[0].Top == GameHeight && MoveDirection == S) LabelSum[0].Top = 40;
                if (LabelSum[0].Left == 0 && MoveDirection == A) LabelSum[0].Left = GameWidth - SIZE;
                if (LabelSum[0].Left == GameWidth && MoveDirection == D) LabelSum[0].Left = 0;
            }
            else {
                if ((LabelSum[0].Top == 20 && MoveDirection == W)
                    || (LabelSum[0].Top == GameHeight && MoveDirection == S)|| (LabelSum[0].Left == GameWidth && MoveDirection == D)||LabelSum[0].Left==-20)
                    {
                    timer1.Enabled = false;
                    if (MessageBox.Show("你输了，" + "你越界了,是否重来", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        Restart();
                    else this.Close();
                    }
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)//改变方向
        {          
            if (e.KeyCode == Keys.W) MoveDirection = W;
            if (e.KeyCode == Keys.A) MoveDirection = A;
            if (e.KeyCode == Keys.S) MoveDirection = S;
            if (e.KeyCode == Keys.D) MoveDirection = D;
            if (e.KeyCode == Keys.Space)
            {//蛇加速
                if ((timer1.Interval -100)== 0) timer1.Interval = 500;
                else timer1.Interval -= 100;
            }
        }
        bool SnakeTouch()//碰到自己
        {
            for (int i = 1; i <= sum; i++)
                if (LabelSum[0].Location == LabelSum[i].Location) return true;//代表碰到自己
            return false;//没有碰到自己
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Border = true;
            score = 100;//胜利得分
            Label LabelRightLine = new Label();
            Label labelDownLine = new Label();
            Label LabelTopLine = new Label();
            LabelRightLine.Width = 1;
            LabelRightLine.Height = 521;
            labelDownLine.Height = 1;
            labelDownLine.Width = 600;
            LabelTopLine.Height = 1;
            LabelTopLine.Width = 600;
            LabelRightLine.BackColor = Color.Black;
            labelDownLine.BackColor = Color.Black;
            LabelTopLine.BackColor = Color.Black;
            LabelTopLine.Top = 40;
            LabelRightLine.Left = GameWidth;
            LabelRightLine.Top = 40;
            labelDownLine.Top = GameHeight;
            this.Controls.Add(labelDownLine);
            this.Controls.Add(LabelRightLine);
            this.Controls.Add(LabelTopLine);//右分界线和下分界线的设置
            
        
            SnakeHead.Tag = "snakehead";
            SnakeHead.BackColor = Color.Red;
            SnakeHead.Location = new Point(GameWidth / 2, GameHeight / 2);
            SnakeHead.Width = SnakeHead.Height = SIZE;
            SnakeHead.Font = new System.Drawing.Font("宋体", 18F);
            SnakeHead.Text = "→";
            SnakeHead.TextAlign=ContentAlignment.MiddleCenter;

            this.Controls.Add(SnakeHead);
                                            /*Label SnakeHead = new Label(){
                                                 BackColor=Color.Red;  
                                                      };         这种初始化方式会出现未知的错误*/
            LabelSum[sum] = SnakeHead;//初始化蛇头
            MakeFood();//初始化第一个食物
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                switch (timer1.Interval)
                {
                    case 500: SpeedLevel = "极慢"; break;
                    case 400: SpeedLevel = "慢"; break;
                    case 300: SpeedLevel = "中"; break;
                    case 200: SpeedLevel = "快"; break;
                    case 100: SpeedLevel = "极快"; break;
                }
            if (MoveDirection == W) SnakeHead.Text = "↑";
            if (MoveDirection == A) SnakeHead.Text = "←";
            if (MoveDirection == S) SnakeHead.Text = "↓";
            if (MoveDirection == D) SnakeHead.Text = "→";
            SnakeMove();
            if (SnakeTouch())
            {
                timer1.Enabled = false;
                if (MessageBox.Show("你输了，你碰到了蛇身,是否重来", "提示",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    Restart();
                else this.Close();
            }
            EatFood();
            OverBorder(Border);
            labelScore.Text = "分数：" + sum + "\n当前速度:" + SpeedLevel;
            if (sum == score) {
                timer1.Enabled = false;
                MessageBox.Show("恭喜你，你赢了" , "提示");                
                Close();
               }
        }
        private void button3_Click(object sender, EventArgs e)//刷新窗体
        {
            Restart();
        }

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void 暂停toolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void 重新开始toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 普通模式toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            score = 100;
            Border = true;
        }

        private void 困难模式toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            score = 400;
            Border = false;
        }

        private void 炼狱模式toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            score = 700;
            Border = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者是一位英气逼人的帅哥，自己呕心沥血做出了这个小游戏，" +
                "决不允许其他人利用这个小游戏，" +
                "如果有人拿这个东西去为自己谋取利益让作者发现了，" +
                "作者一定会不远万里取你狗命！！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}