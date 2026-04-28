namespace SuperPeng
{
    partial class Start
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.pic_sound = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.用剩下一半的生命招呼一次刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_show = new System.Windows.Forms.PictureBox();
            this.pic_GameField = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myProcessbar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmiSkin = new System.Windows.Forms.ToolStripDropDownButton();
            this.宝石蓝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.翡翠之恋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绿色玻璃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.永恒埃及ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.夏至未至ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.银边美丽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.海洋的波浪ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ｍＳＮToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sound)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GameField)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_sound
            // 
            this.pic_sound.Image = global::SuperPeng.Properties.Resources.sound;
            this.pic_sound.Location = new System.Drawing.Point(435, 6);
            this.pic_sound.Name = "pic_sound";
            this.pic_sound.Size = new System.Drawing.Size(42, 39);
            this.pic_sound.TabIndex = 6;
            this.pic_sound.TabStop = false;
            this.pic_sound.Click += new System.EventHandler(this.pic_sound_Click);
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(479, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "帮助";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用剩下一半的生命招呼一次刷新ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(278, 48);
            // 
            // 用剩下一半的生命招呼一次刷新ToolStripMenuItem
            // 
            this.用剩下一半的生命招呼一次刷新ToolStripMenuItem.Enabled = false;
            this.用剩下一半的生命招呼一次刷新ToolStripMenuItem.Name = "用剩下一半的生命招呼一次刷新ToolStripMenuItem";
            this.用剩下一半的生命招呼一次刷新ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.用剩下一半的生命招呼一次刷新ToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.用剩下一半的生命招呼一次刷新ToolStripMenuItem.Text = "用剩下一半的生命招呼一次刷新";
            this.用剩下一半的生命招呼一次刷新ToolStripMenuItem.Click += new System.EventHandler(this.用剩下一半的生命招呼一次刷新ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic_show
            // 
            this.pic_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_show.Image = global::SuperPeng.Properties.Resources.bg_start;
            this.pic_show.Location = new System.Drawing.Point(16, 51);
            this.pic_show.Name = "pic_show";
            this.pic_show.Size = new System.Drawing.Size(500, 500);
            this.pic_show.TabIndex = 10;
            this.pic_show.TabStop = false;
            this.pic_show.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_show_MouseUp);
            // 
            // pic_GameField
            // 
            this.pic_GameField.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pic_GameField.BackgroundImage = global::SuperPeng.Properties.Resources.bg_GameField;
            this.pic_GameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_GameField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_GameField.Location = new System.Drawing.Point(16, 51);
            this.pic_GameField.Name = "pic_GameField";
            this.pic_GameField.Size = new System.Drawing.Size(500, 500);
            this.pic_GameField.TabIndex = 0;
            this.pic_GameField.TabStop = false;
            this.pic_GameField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_GameField_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体_GB2312", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "生命";
            // 
            // myProcessbar1
            // 
            this.myProcessbar1.Location = new System.Drawing.Point(55, 14);
            this.myProcessbar1.Name = "myProcessbar1";
            this.myProcessbar1.Size = new System.Drawing.Size(374, 23);
            this.myProcessbar1.TabIndex = 13;
            this.myProcessbar1.Value = 100;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSkin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmiSkin
            // 
            this.tsmiSkin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiSkin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宝石蓝ToolStripMenuItem,
            this.翡翠之恋ToolStripMenuItem,
            this.绿色玻璃ToolStripMenuItem,
            this.永恒埃及ToolStripMenuItem,
            this.夏至未至ToolStripMenuItem,
            this.银边美丽ToolStripMenuItem,
            this.海洋的波浪ToolStripMenuItem,
            this.ｍＳＮToolStripMenuItem,
            this.xPToolStripMenuItem,
            this.默认模式ToolStripMenuItem});
            this.tsmiSkin.Image = global::SuperPeng.Properties.Resources._7;
            this.tsmiSkin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSkin.Name = "tsmiSkin";
            this.tsmiSkin.Size = new System.Drawing.Size(29, 20);
            this.tsmiSkin.Text = "皮肤";
            // 
            // 宝石蓝ToolStripMenuItem
            // 
            this.宝石蓝ToolStripMenuItem.Name = "宝石蓝ToolStripMenuItem";
            this.宝石蓝ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.宝石蓝ToolStripMenuItem.Tag = "1";
            this.宝石蓝ToolStripMenuItem.Text = "宝石的心";
            this.宝石蓝ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 翡翠之恋ToolStripMenuItem
            // 
            this.翡翠之恋ToolStripMenuItem.Name = "翡翠之恋ToolStripMenuItem";
            this.翡翠之恋ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.翡翠之恋ToolStripMenuItem.Tag = "2";
            this.翡翠之恋ToolStripMenuItem.Text = "翡翠之恋";
            this.翡翠之恋ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 绿色玻璃ToolStripMenuItem
            // 
            this.绿色玻璃ToolStripMenuItem.Name = "绿色玻璃ToolStripMenuItem";
            this.绿色玻璃ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.绿色玻璃ToolStripMenuItem.Tag = "3";
            this.绿色玻璃ToolStripMenuItem.Text = "绿色玻璃";
            this.绿色玻璃ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 永恒埃及ToolStripMenuItem
            // 
            this.永恒埃及ToolStripMenuItem.Name = "永恒埃及ToolStripMenuItem";
            this.永恒埃及ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.永恒埃及ToolStripMenuItem.Tag = "4";
            this.永恒埃及ToolStripMenuItem.Text = "永恒埃及";
            this.永恒埃及ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 夏至未至ToolStripMenuItem
            // 
            this.夏至未至ToolStripMenuItem.Name = "夏至未至ToolStripMenuItem";
            this.夏至未至ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.夏至未至ToolStripMenuItem.Tag = "5";
            this.夏至未至ToolStripMenuItem.Text = "夏至未至";
            this.夏至未至ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 银边美丽ToolStripMenuItem
            // 
            this.银边美丽ToolStripMenuItem.Name = "银边美丽ToolStripMenuItem";
            this.银边美丽ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.银边美丽ToolStripMenuItem.Tag = "7";
            this.银边美丽ToolStripMenuItem.Text = "银边美丽";
            this.银边美丽ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 海洋的波浪ToolStripMenuItem
            // 
            this.海洋的波浪ToolStripMenuItem.Name = "海洋的波浪ToolStripMenuItem";
            this.海洋的波浪ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.海洋的波浪ToolStripMenuItem.Tag = "8";
            this.海洋的波浪ToolStripMenuItem.Text = "海洋的波浪";
            this.海洋的波浪ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ｍＳＮToolStripMenuItem
            // 
            this.ｍＳＮToolStripMenuItem.Name = "ｍＳＮToolStripMenuItem";
            this.ｍＳＮToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ｍＳＮToolStripMenuItem.Tag = "6";
            this.ｍＳＮToolStripMenuItem.Text = "MSN";
            this.ｍＳＮToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // xPToolStripMenuItem
            // 
            this.xPToolStripMenuItem.Name = "xPToolStripMenuItem";
            this.xPToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.xPToolStripMenuItem.Tag = "9";
            this.xPToolStripMenuItem.Text = "XP";
            this.xPToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 默认模式ToolStripMenuItem
            // 
            this.默认模式ToolStripMenuItem.Name = "默认模式ToolStripMenuItem";
            this.默认模式ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.默认模式ToolStripMenuItem.Tag = "0";
            this.默认模式ToolStripMenuItem.Text = "默认模式";
            this.默认模式ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 583);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myProcessbar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_sound);
            this.Controls.Add(this.pic_GameField);
            this.Controls.Add(this.pic_show);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(532, 650);
            this.MinimumSize = new System.Drawing.Size(532, 594);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#版对对碰2.0";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_sound)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GameField)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_GameField;
        private System.Windows.Forms.PictureBox pic_sound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用剩下一半的生命招呼一次刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_show;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar myProcessbar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsmiSkin;
        private System.Windows.Forms.ToolStripMenuItem 宝石蓝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 翡翠之恋ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绿色玻璃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 永恒埃及ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 夏至未至ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 银边美丽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 海洋的波浪ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ｍＳＮToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认模式ToolStripMenuItem;
    }
}

