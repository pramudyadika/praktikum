
namespace Apl_Penjualan.GUI
{
    partial class Menu_Utama
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_login = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.submenu_keluar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_master = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_buku = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_pelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolbar_pelanggan = new System.Windows.Forms.ToolStripButton();
            this.toolbar_buku = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbar_transaksi = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_master,
            this.menu_transaksi});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(948, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_login,
            this.submenu_logout,
            this.toolStripMenuItem1,
            this.submenu_keluar});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(54, 29);
            this.menu_file.Text = "&File";
            // 
            // submenu_login
            // 
            this.submenu_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submenu_login.Name = "submenu_login";
            this.submenu_login.Size = new System.Drawing.Size(293, 34);
            this.submenu_login.Text = "&Login";
            // 
            // submenu_logout
            // 
            this.submenu_logout.Name = "submenu_logout";
            this.submenu_logout.Size = new System.Drawing.Size(293, 34);
            this.submenu_logout.Text = "&Logout";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 6);
            // 
            // submenu_keluar
            // 
            this.submenu_keluar.Name = "submenu_keluar";
            this.submenu_keluar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.submenu_keluar.Size = new System.Drawing.Size(293, 34);
            this.submenu_keluar.Text = "&Keluar Aplikasi";
            // 
            // menu_master
            // 
            this.menu_master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_buku,
            this.submenu_pelanggan});
            this.menu_master.Name = "menu_master";
            this.menu_master.Size = new System.Drawing.Size(124, 29);
            this.menu_master.Text = "&Master Data";
            // 
            // submenu_buku
            // 
            this.submenu_buku.Name = "submenu_buku";
            this.submenu_buku.Size = new System.Drawing.Size(196, 34);
            this.submenu_buku.Text = "&Buku";
            this.submenu_buku.Click += new System.EventHandler(this.submenu_buku_Click);
            // 
            // submenu_pelanggan
            // 
            this.submenu_pelanggan.Name = "submenu_pelanggan";
            this.submenu_pelanggan.Size = new System.Drawing.Size(196, 34);
            this.submenu_pelanggan.Text = "&Pelanggan";
            this.submenu_pelanggan.Click += new System.EventHandler(this.submenu_pelanggan_Click);
            // 
            // menu_transaksi
            // 
            this.menu_transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_penjualan});
            this.menu_transaksi.Name = "menu_transaksi";
            this.menu_transaksi.Size = new System.Drawing.Size(98, 29);
            this.menu_transaksi.Text = "&Transaksi";
            // 
            // submenu_penjualan
            // 
            this.submenu_penjualan.Name = "submenu_penjualan";
            this.submenu_penjualan.Size = new System.Drawing.Size(188, 34);
            this.submenu_penjualan.Text = "&Penjualan";
            this.submenu_penjualan.Click += new System.EventHandler(this.submenu_penjualan_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbar_pelanggan,
            this.toolbar_buku,
            this.toolStripSeparator1,
            this.toolbar_transaksi});
            this.toolStrip.Location = new System.Drawing.Point(0, 33);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(948, 33);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolbar_pelanggan
            // 
            this.toolbar_pelanggan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_pelanggan.Image = global::Apl_Penjualan.Properties.Resources.user__3_;
            this.toolbar_pelanggan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_pelanggan.Name = "toolbar_pelanggan";
            this.toolbar_pelanggan.Size = new System.Drawing.Size(34, 28);
            // 
            // toolbar_buku
            // 
            this.toolbar_buku.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_buku.Image = global::Apl_Penjualan.Properties.Resources.cart;
            this.toolbar_buku.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_buku.Name = "toolbar_buku";
            this.toolbar_buku.Size = new System.Drawing.Size(34, 28);
            this.toolbar_buku.ToolTipText = "Data Buku";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolbar_transaksi
            // 
            this.toolbar_transaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_transaksi.Image = global::Apl_Penjualan.Properties.Resources.transaction;
            this.toolbar_transaksi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_transaksi.Name = "toolbar_transaksi";
            this.toolbar_transaksi.Size = new System.Drawing.Size(34, 28);
            this.toolbar_transaksi.ToolTipText = "Data Transaksi";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 665);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(948, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(144, 25);
            this.toolStripStatusLabel.Text = "By Pramudya KH";
            // 
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apl_Penjualan.Properties.Resources.alfons_morales_YLSwjSy7stw_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu_Utama";
            this.Text = "Xy Bookstore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem menu_file;
        public System.Windows.Forms.ToolStripMenuItem submenu_login;
        public System.Windows.Forms.ToolStripMenuItem menu_master;
        public System.Windows.Forms.ToolStripMenuItem menu_transaksi;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem submenu_logout;
        public System.Windows.Forms.ToolStripMenuItem submenu_keluar;
        public System.Windows.Forms.ToolStripMenuItem submenu_buku;
        public System.Windows.Forms.ToolStripMenuItem submenu_pelanggan;
        public System.Windows.Forms.ToolStripMenuItem submenu_penjualan;
        public System.Windows.Forms.ToolStripButton toolbar_pelanggan;
        public System.Windows.Forms.ToolStripButton toolbar_buku;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton toolbar_transaksi;
    }
}



