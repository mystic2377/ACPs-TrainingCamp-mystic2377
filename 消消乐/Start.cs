using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SuperPeng
{
    // Start类是游戏的主窗体类，继承自Form
    public partial class Start : Form
    {
        // 构造函数
        public Start()
        {
            InitializeComponent();  // 初始化窗体组件（由设计器生成）
        }

        // 游戏相关字段
        private GameField gameField;  // 游戏场地逻辑对象，处理游戏核心逻辑
        private bool first = true;    // 标记是否是第一次点击方块（用于方块交换逻辑）
        private Block firstBlock2 = null;  // 第一次点击的方块对象
        private Block secondBlock2 = null; // 第二次点击的方块对象
        private int xx1, yy1, xx2, yy2;   // 两个方块在二维数组中的坐标(x,y)
        private int tempx, tempy;          // 临时存储坐标（用于analyse方法）
        private int timeAll = 0;           // 游戏总时间计时器(秒)
        private int score = 0;             // 游戏得分

        // 皮肤引擎（使用Sunisoft.IrisSkin库）
        private Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();

        // 窗体加载事件处理程序
        private void Start_Load(object sender, EventArgs e)
        {
            GetSkin("0.ssk");  // 加载默认皮肤文件
            gameField = new GameField();  // 初始化游戏场地逻辑对象
            gameField.winHandle = pic_GameField.Handle;  // 设置游戏场地的窗口句柄
            gameField.bufferImage = pic_GameField.BackgroundImage;  // 设置缓冲图像

            // 显示游戏开始画面
            pic_show.BringToFront();  // 将开始画面置于最前
            pic_show.Image = Properties.Resources.bg_start;  // 设置开始背景图
        }

        #region 事件处理

        /* 鼠标点击游戏区域 - 处理方块选择和交换 */
        private void pic_GameField_MouseClick(object sender, MouseEventArgs e)
        {
            if (first)  // 第一次点击方块
            {
                firstBlock2 = analyse(e.X, e.Y);  // 分析点击位置获取方块对象
                xx1 = tempx; yy1 = tempy;  // 保存方块坐标

                if (firstBlock2 != null)
                {
                    first = false;  // 标记下一次为第二次点击
                    firstBlock2.DrawSelectedBlock(pic_GameField.CreateGraphics());  // 绘制选中效果
                }
            }
            else  // 第二次点击方块
            {
                secondBlock2 = analyse(e.X, e.Y);
                xx2 = tempx; yy2 = tempy;

                // 检查第二次点击是否有效（相邻且不是同一个方块）
                if (secondBlock2 == null || firstBlock2.Location == secondBlock2.Location
                   || Math.Abs(firstBlock2.Location.X - secondBlock2.Location.X) > 50
                   || Math.Abs(firstBlock2.Location.Y - secondBlock2.Location.Y) > 50
                   || (Math.Abs(firstBlock2.Location.X - secondBlock2.Location.X) == 50
                   && Math.Abs(firstBlock2.Location.Y - secondBlock2.Location.Y) == 50))
                {
                    return;  // 无效点击则返回
                }
                else
                {
                    first = true;  // 重置为第一次点击状态
                    secondBlock2.DrawSelectedBlock(pic_GameField.CreateGraphics());  // 绘制选中效果
                }

                // 交换方块并检查是否可以消除
                gameField.exchange(xx1, yy1, xx2, yy2);
                bool cando = false;  // 标记是否可以消除
                int numb;  // 消除的方块数量
                int k;    // 临时变量

                // 检查并消除连续方块（可能产生连锁反应）
                while ((numb = gameField.check()) != 0)
                {
                    cando = true;  // 标记可以消除
                    score += numb;  // 增加分数

                    // 更新生命值进度条（每消除2个方块增加1点生命值）
                    k = myProcessbar1.Value + (int)Math.Floor((double)numb / 2);
                    myProcessbar1.Value = (k <= 100) ? k : 100;  // 生命值上限100

                    gameField.fill();  // 填充新方块
                    Thread.Sleep(500); // 延迟500ms以显示消除效果
                }

                // 如果不能消除，则撤销交换
                if (!cando)
                {
                    gameField.exchange(xx1, yy1, xx2, yy2);
                }
                first = true;  // 重置为第一次点击状态
            }
        }

        /* 声音开关控制 */
        private void pic_sound_Click(object sender, EventArgs e)
        {
            gameField.soundSwitch = !gameField.soundSwitch;  // 切换声音状态
            if (gameField.soundSwitch)
                pic_sound.Image = Properties.Resources.sound;  // 显示声音开启图标
            else
                pic_sound.Image = Properties.Resources.nosound;  // 显示声音关闭图标
        }

        /* 在开始/结束画面点击鼠标 - 重新开始游戏 */
        private void pic_show_MouseUp(object sender, MouseEventArgs e)
        {
            // 检查是否点击了开始按钮(坐标范围检查)
            if (164 < e.X && e.X < 330 && 400 < e.Y && e.Y < 456)
            {
                score = 0;  // 重置分数
                myProcessbar1.Value = 100;  // 重置生命值为满值
                timer1.Start();  // 启动计时器
                pic_show.SendToBack();  // 隐藏开始画面
                reStart();  // 重新开始游戏
                用剩下一半的生命招呼一次刷新ToolStripMenuItem.Enabled = true;  // 启用刷新菜单项
            }
        }

        /* 游戏计时器事件（每2秒触发一次） */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myProcessbar1.Value > 0)
                myProcessbar1.Value--;  // 减少生命值
            else
                gameover();  // 生命值为0时游戏结束

            // 每5分钟（300秒）自动刷新游戏
            if (timeAll < 300)
                timeAll += 2;  // 每次计时器触发增加2（假设计时器间隔为2秒）
            else
            {
                reStart();  // 刷新游戏
                timeAll = 0;  // 重置计时
            }
        }

        /* 按钮鼠标按下事件 - 显示上下文菜单 */
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                contextMenuStrip1.Show(button1, new Point(button1.Width, button1.Height));
        }

        /* 按钮点击事件 - 显示帮助窗口 */
        private void button1_Click(object sender, EventArgs e)
        {
            Help he = new Help();
            he.Show();
        }

        /* 菜单项事件 - 用一半生命值刷新游戏 */
        private void 用剩下一半的生命招呼一次刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();  // 暂停计时器
            myProcessbar1.Value = (int)Math.Floor((double)myProcessbar1.Value / 2);  // 生命值减半
            reStart();  // 刷新游戏
            timer1.Start();  // 恢复计时器
        }

        /* 菜单项事件 - 显示帮助窗口 */
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help he = new Help();
            he.Show();
        }
        #endregion

        #region 方法

        /* 重新开始游戏 */
        public void reStart()
        {
            gameField.createAll();  // 创建新游戏布局
            // 确保初始状态没有可以直接消除的方块
            while (gameField.check() != 0)
            {
                gameField.fill();  // 填充新方块
                Thread.Sleep(500); // 延迟显示消除效果
            }
        }

        /* 分析鼠标点击位置对应的方块 */
        private Block analyse(int x, int y)
        {
            // 计算方块在数组中的坐标(每个方块50x50像素)
            tempx = (int)Math.Floor((double)y / 50);
            tempy = (int)Math.Floor((double)x / 50);

            // 检查是否超出边界（10x10的方块矩阵）
            if (tempx > 9 || tempy > 9 || tempx < 0 || tempy < 0)
                return null;
            else
                return gameField.blocks[tempx, tempy];  // 返回对应方块对象
        }

        /* 游戏结束处理 */
        public void gameover()
        {
            timer1.Stop();  // 停止计时器
            Image tempimg = Properties.Resources.bg_end;  // 加载结束背景图

            // 在结束画面上绘制分数
            Graphics g = Graphics.FromImage(tempimg);
            g.DrawString(score.ToString(), new Font("Arial", 36, FontStyle.Bold),
                new SolidBrush(Color.Yellow), new Point(238, 240));

            pic_show.Image = tempimg;
            pic_show.BringToFront();  // 显示结束画面
            用剩下一半的生命招呼一次刷新ToolStripMenuItem.Enabled = false;  // 禁用刷新菜单项
        }

        #endregion

        /* 皮肤菜单项点击事件 */
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            int index = Convert.ToInt32(tsmi.Tag);  // 获取皮肤索引

            string skinname = "";

            // 根据索引选择皮肤文件（0-9.ssk）
            switch (index)
            {
                case 0: skinname = "0.ssk"; break;
                case 1: skinname = "1.ssk"; break;
                case 2: skinname = "2.ssk"; break;
                case 3: skinname = "3.ssk"; break;
                case 4: skinname = "4.ssk"; break;
                case 5: skinname = "5.ssk"; break;
                case 6: skinname = "6.ssk"; break;
                case 7: skinname = "7.ssk"; break;
                case 8: skinname = "8.ssk"; break;
                case 9: skinname = "9.ssk"; break;
                default: skinname = ""; break;
            }
            GetSkin(skinname);  // 应用皮肤
        }

        /* 加载并应用皮肤 */
        private void GetSkin(string skinName)
        {
            skin.SkinFile = Application.StartupPath + @"\skin\" + skinName;  // 设置皮肤文件路径
            skin.Active = true;  // 激活皮肤
            skin.SkinAllForm = true;  // 应用到所有窗体
        }
    }
}