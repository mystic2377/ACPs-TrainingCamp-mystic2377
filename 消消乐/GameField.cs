using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Media;
using SuperPeng.Properties;

namespace SuperPeng
{
    /*
     * 场景大小：500×500
     * 方块大小：50×50
     */
    class GameField
    {
        // 窗口句柄，用于绘制
        public IntPtr winHandle;
        // 双缓冲图像，用于减少闪烁
        public Image bufferImage;
        // 10x10的游戏方块矩阵
        public Block[,] blocks = new Block[10, 10];
        // 存储方块类型的二维数组(0表示空白)
        private int[,] rectan2 = new int[10, 10];
        // 记录每列需要填充的空格数
        private int[] empty = new int[10];
        // 行连续相同方块计数器
        private int RowSames = 1;
        // 列连续相同方块计数器
        private int ColumSames = 1;
        // 音效播放器
        private SoundPlayer sound = new SoundPlayer();
        // 声音开关(true为开启)
        public bool soundSwitch = true;

        /* 初始化游戏场景，创建所有方块 */
        public void createAll()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    // 创建随机类型(1-8)的方块
                    Block b = new Block(rand.Next(8) + 1, j * 50, i * 50);
                    blocks[i, j] = b;
                    // 记录方块类型
                    rectan2[i, j] = b.ImageType;
                }
            reDraw(); // 绘制初始场景
        }

        /* 交换两个方块的位置 */
        public void exchange(int x1, int y1, int x2, int y2)
        {
            // 交换方块对象
            Block temp = blocks[x1, y1];
            blocks[x1, y1] = blocks[x2, y2];
            blocks[x2, y2] = temp;

            // 更新类型记录数组
            rectan2[x1, y1] = blocks[x1, y1].ImageType;
            rectan2[x2, y2] = blocks[x2, y2].ImageType;

            // 交换位置坐标
            Point tmploc = blocks[x1, y1].Location;
            blocks[x1, y1].Location = blocks[x2, y2].Location;
            blocks[x2, y2].Location = tmploc;

            PlaySound("Exchange"); // 播放交换音效
            reDraw(); // 重绘场景
        }

        /* 检查并标记可消除的方块，返回消除总数 */
        public int check()
        {
            // 行检测
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // 行检测逻辑
                    if (j == 0)
                        RowSames = 1;
                    else
                    {
                        if (blocks[i, j - 1].ImageType == blocks[i, j].ImageType)
                            RowSames++;
                        else
                        {
                            if (RowSames >= 3) // 连续3个以上相同
                            {
                                for (int n = 1; n <= RowSames; n++)
                                    rectan2[i, j - n] = 0; // 标记为可消除
                            }
                            RowSames = 1;
                        }
                        // 处理行末尾情况
                        if (j == 9 && RowSames >= 3)
                        {
                            for (int n = 1; n <= RowSames; n++)
                                rectan2[i, 10 - n] = 0;
                        }
                    }

                    // 列检测逻辑(与行检测类似)
                    if (j == 0)
                        ColumSames = 1;
                    else
                    {
                        if (blocks[j - 1, i].ImageType == blocks[j, i].ImageType)
                            ColumSames++;
                        else
                        {
                            if (ColumSames >= 3)
                            {
                                for (int n = 1; n <= ColumSames; n++)
                                    rectan2[j - n, i] = 0;
                            }
                            ColumSames = 1;
                        }
                        if (j == 9 && ColumSames >= 3)
                        {
                            for (int n = 1; n <= ColumSames; n++)
                                rectan2[10 - n, i] = 0;
                        }
                    }
                }
            }

            // 重置计数器
            RowSames = 1;
            ColumSames = 1;

            // 计算每列空白数
            int temp = 0;
            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (rectan2[j, i] == 0)
                        temp++;
                }
                empty[i] = temp;
                result += temp;
                temp = 0;
            }
            return result; // 返回总消除数
        }

        /* 填充空白方块 */
        public void fill()
        {
            Random rand = new Random();
            for (int j = 0; j < 10; j++) // 每列
            {
                if (empty[j] > 0) // 该列有空白
                {
                    for (int i = 0; i < 10; i++) // 每行
                    {
                        while (rectan2[i, j] == 0) // 当前位置是空白
                        {
                            if (i > 0)
                            {
                                // 上方方块下移
                                for (int n = i - 1; n >= 0; n--)
                                    down(n, j);
                            }
                            // 在顶部生成新方块
                            Block tb = new Block(rand.Next(8) + 1, j * 50, 0);
                            blocks[0, j] = tb;
                            rectan2[0, j] = tb.ImageType;
                        }
                    }
                }
            }
            PlaySound("AddScore"); // 播放得分音效
            reDraw(); // 重绘场景
        }

        /* 使指定位置的方块下移一格 */
        public void down(int x, int y)
        {
            if (x < 9) // 确保不是最底行
            {
                // 更新位置坐标
                int px = blocks[x, y].Location.X;
                int py = blocks[x, y].Location.Y;
                blocks[x, y].Location = new Point(px, py + 50);

                // 更新方块数组
                blocks[x + 1, y] = blocks[x, y];
                rectan2[x + 1, y] = rectan2[x, y];
            }
        }

        /* 播放音效 */
        public void PlaySound(string soundstr)
        {
            if (!soundSwitch || sound.Stream != null)
                return;

            switch (soundstr)
            {
                case "AddScore": // 消除音效
                    sound.Stream = Resources.folder;
                    break;
                case "Exchange": // 交换音效
                    sound.Stream = Resources.exchange;
                    break;
            }
            sound.Play();
            sound.Stream = null; // 释放资源
        }

        /* 重绘整个游戏场景 */
        public void reDraw()
        {
            // 绘制背景
            Graphics g = Graphics.FromImage(bufferImage);
            Bitmap bg = Properties.Resources.bg_GameField;
            g.DrawImage(bg, 0, 0, 500, 500);

            // 绘制所有非空白方块
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (rectan2[i, j] != 0)
                        blocks[i, j].Draw(bufferImage);
                }

            // 输出到窗口
            Graphics g2 = Graphics.FromHwnd(winHandle);
            g2.DrawImage(bufferImage, 0, 0, 500, 500);
        }
    }
}