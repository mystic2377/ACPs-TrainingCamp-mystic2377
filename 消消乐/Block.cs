using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using SuperPeng.Properties;

namespace SuperPeng
{
    /*本类描述的对象是对对碰的每个小方块*/
    class Block
    {
        private Point location; //小方块坐标
        private Bitmap blockImage; //小方块图案
        private int imageType;  //图片种类
        public int ImageType//ImageType属性
        {
            get
            {
                return imageType;
            }
        }
        public Point Location//Location属性
        {
            get
            {
                return location;
            }
            set
            {
                location= value;
                
            }
        }

        public Block(int imageIndex,int x,int y)
        {
            location = new Point(x, y);
            imageType = imageIndex;
            //初始化小方块图案
            switch (imageIndex)
            {
                case 1:
                    blockImage = Resources._1;
                    break;
                case 2:
                    blockImage = Resources._2;
                    break;
                case 3:
                    blockImage = Resources._3;
                    break;
                case 4:
                    blockImage = Resources._4;
                    break;
                case 5:
                    blockImage = Resources._5;
                    break;
                case 6:
                    blockImage = Resources._6;
                    break;
                case 7:
                    blockImage = Resources._7;
                    break;
                case 8:
                    blockImage = Resources._8;
                    break;
                default:
                    blockImage = Resources._4;
                    imageType = 4;
                    break;
            }
        }

        /*画对象*/
        public void Draw(Image img)
        {
            Graphics g = Graphics.FromImage(img);
            Rectangle r = new Rectangle(location, new Size(50, 50));
            g.DrawImage(blockImage, r);
        }
        public void DrawSelectedBlock(Graphics g)
        {
            //画选中方块的示意边框线
            Pen myPen = new Pen(Color.Black, 3);
            Rectangle r = new Rectangle(location, new Size(50, 50));
            g.DrawRectangle(myPen, r);
        }
        public void ClearSelectedBlock(int x, int y, Graphics g)
        {
            //清除选中方块

        }
    }
}
