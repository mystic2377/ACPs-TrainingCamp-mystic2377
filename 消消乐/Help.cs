using System;
using System.Diagnostics;  // 用于进程操作（如启动外部程序）
using System.Windows.Forms;  // Windows窗体应用程序的核心命名空间（包含Form、Button等控件）

namespace SuperPeng
{
    // Help类继承自Form，表示一个帮助窗口
    public partial class Help : Form
    {
        // 构造函数
        public Help()
        {
            // 初始化窗体组件（由Windows窗体设计器自动生成的代码）
            // 这个方法会在"Help.Designer.cs"文件中实现具体的控件初始化
            InitializeComponent();
        }

        // 链接标签(LinkLabel)点击事件处理程序
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 当用户点击链接标签时，启动Internet Explorer浏览器
            // Process.Start方法用于启动外部进程
            // 这里直接启动了IE浏览器(iexplore.exe)，但没有指定要打开的URL
            Process.Start("iexplore.exe");

            // 注意：现代应用程序通常应该:
            // 1. 指定要打开的URL，如 Process.Start("http://example.com")
            // 2. 使用默认浏览器而不是硬编码IE，如 Process.Start("explorer.exe", "http://example.com")
        }

        // "确定"按钮点击事件处理程序
        private void btnOK_Click(object sender, EventArgs e)
        {
            // 关闭当前帮助窗口
            // this指向当前Help窗体实例
            this.Close();
        }

        // 标签(Label)点击事件处理程序（目前为空实现）
        private void label3_Click(object sender, EventArgs e)
        {
            // 这个方法目前没有实现任何功能
            // 可能是:
            // 1. 为未来的功能预留
            // 2. 由设计器自动生成的事件处理程序但尚未实现功能
            // 3. 可能需要删除的冗余代码
        }
    }
}