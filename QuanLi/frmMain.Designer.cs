namespace QuanLi
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tínhNăngQuảnTrịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giơiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.noti = new System.Windows.Forms.NotifyIcon(this.components);
            this.khởiTạoMậtKhẩuNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tínhNăngQuảnTrịToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.giơiThiệuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tínhNăngQuảnTrịToolStripMenuItem
            // 
            this.tínhNăngQuảnTrịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíNhânViênToolStripMenuItem,
            this.khởiTạoMậtKhẩuNhânViênToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.tínhNăngQuảnTrịToolStripMenuItem.Name = "tínhNăngQuảnTrịToolStripMenuItem";
            this.tínhNăngQuảnTrịToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.tínhNăngQuảnTrịToolStripMenuItem.Text = "Tính năng quản trị";
            // 
            // quảnLíNhânViênToolStripMenuItem
            // 
            this.quảnLíNhânViênToolStripMenuItem.Name = "quảnLíNhânViênToolStripMenuItem";
            this.quảnLíNhânViênToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.quảnLíNhânViênToolStripMenuItem.Text = "Quản lí nhân viên";
            this.quảnLíNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLíNhânViênToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.thayĐổiMậtKhẩuToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Mật khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // giơiThiệuToolStripMenuItem
            // 
            this.giơiThiệuToolStripMenuItem.Name = "giơiThiệuToolStripMenuItem";
            this.giơiThiệuToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.giơiThiệuToolStripMenuItem.Text = "Giới thiệu";
            this.giơiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giơiThiệuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1019, 505);
            this.pnlMain.TabIndex = 1;
            // 
            // noti
            // 
            this.noti.BalloonTipText = "Đăng xuất thành công.";
            this.noti.BalloonTipTitle = "W4.Developer";
            this.noti.Icon = ((System.Drawing.Icon)(resources.GetObject("noti.Icon")));
            this.noti.Text = "notifyIcon1";
            this.noti.Visible = true;
            // 
            // khởiTạoMậtKhẩuNhânViênToolStripMenuItem
            // 
            this.khởiTạoMậtKhẩuNhânViênToolStripMenuItem.Name = "khởiTạoMậtKhẩuNhânViênToolStripMenuItem";
            this.khởiTạoMậtKhẩuNhânViênToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.khởiTạoMậtKhẩuNhânViênToolStripMenuItem.Text = "Khởi tạo mật khẩu nhân viên";
            this.khởiTạoMậtKhẩuNhânViênToolStripMenuItem.Click += new System.EventHandler(this.khởiTạoMậtKhẩuNhânViênToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 548);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí bán hàng";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.NotifyIcon noti;
        private System.Windows.Forms.ToolStripMenuItem giơiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhNăngQuảnTrịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khởiTạoMậtKhẩuNhânViênToolStripMenuItem;
    }
}