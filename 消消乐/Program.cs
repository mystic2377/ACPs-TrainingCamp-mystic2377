using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SuperPeng
{
    // Program类是应用程序的主入口点类
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        // STAThread属性指示应用程序的COM线程模型是单线程单元(STA)
        [STAThread]
        static void Main()
        {
            // 启用应用程序的可视样式，使控件能根据系统主题显示
            Application.EnableVisualStyles();

            // 设置控件文本的默认呈现方式为使用GDI+（而不是传统的GDI）
            // false表示使用新的文本渲染引擎
            Application.SetCompatibleTextRenderingDefault(false);

            // 创建并运行主窗体(Start窗体)，启动消息循环
            // Start()是自定义的窗体类，作为应用程序的主窗口
            Application.Run(new Start());
        }
    }
}