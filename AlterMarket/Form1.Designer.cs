namespace AlterMarket
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstvGames = new System.Windows.Forms.ListView();
            this.clmGames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglstGames = new System.Windows.Forms.ImageList(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lstvwGamesSubs = new System.Windows.Forms.ListView();
            this.clmSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuGamesSubs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imglstGamesSubs = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuGamesSubs.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 364);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 364);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Games";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstvGames);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.lstvwGamesSubs);
            this.splitContainer1.Size = new System.Drawing.Size(595, 332);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstvGames
            // 
            this.lstvGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmGames});
            this.lstvGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvGames.FullRowSelect = true;
            this.lstvGames.GridLines = true;
            this.lstvGames.Location = new System.Drawing.Point(0, 0);
            this.lstvGames.MultiSelect = false;
            this.lstvGames.Name = "lstvGames";
            this.lstvGames.Size = new System.Drawing.Size(166, 332);
            this.lstvGames.SmallImageList = this.imglstGames;
            this.lstvGames.TabIndex = 0;
            this.lstvGames.UseCompatibleStateImageBehavior = false;
            this.lstvGames.View = System.Windows.Forms.View.Details;
            this.lstvGames.SelectedIndexChanged += new System.EventHandler(this.lstvGames_SelectedIndexChanged);
            // 
            // clmGames
            // 
            this.clmGames.Text = "Games";
            this.clmGames.Width = 162;
            // 
            // imglstGames
            // 
            this.imglstGames.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglstGames.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstGames.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(400, 309);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.BrowserDocumentCompleted);
            // 
            // lstvwGamesSubs
            // 
            this.lstvwGamesSubs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSub,
            this.clmSize});
            this.lstvwGamesSubs.ContextMenuStrip = this.menuGamesSubs;
            this.lstvwGamesSubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvwGamesSubs.FullRowSelect = true;
            this.lstvwGamesSubs.GridLines = true;
            this.lstvwGamesSubs.Location = new System.Drawing.Point(0, 0);
            this.lstvwGamesSubs.MultiSelect = false;
            this.lstvwGamesSubs.Name = "lstvwGamesSubs";
            this.lstvwGamesSubs.Size = new System.Drawing.Size(425, 332);
            this.lstvwGamesSubs.SmallImageList = this.imglstGamesSubs;
            this.lstvwGamesSubs.TabIndex = 0;
            this.lstvwGamesSubs.UseCompatibleStateImageBehavior = false;
            this.lstvwGamesSubs.View = System.Windows.Forms.View.Details;
            // 
            // clmSub
            // 
            this.clmSub.Text = "Item";
            this.clmSub.Width = 325;
            // 
            // clmSize
            // 
            this.clmSize.Text = "Size";
            this.clmSize.Width = 96;
            // 
            // menuGamesSubs
            // 
            this.menuGamesSubs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem});
            this.menuGamesSubs.Name = "menuGamesSubs";
            this.menuGamesSubs.Size = new System.Drawing.Size(129, 26);
            this.menuGamesSubs.Opening += new System.ComponentModel.CancelEventHandler(this.menuGamesSubs_Opening);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // imglstGamesSubs
            // 
            this.imglstGamesSubs.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglstGamesSubs.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstGamesSubs.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(609, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "0 Items";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(361, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel3.Text = "Made by FoxySapphire";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel5.Text = "-";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel4.Text = "V 0.0.0.0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesToolStripMenuItem});
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.reloadToolStripMenuItem.Text = "Reload";
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.gamesToolStripMenuItem.Text = "Games";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.gamesToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 364);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterMarket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuGamesSubs.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstvGames;
        private System.Windows.Forms.ListView lstvwGamesSubs;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader clmGames;
        private System.Windows.Forms.ColumnHeader clmSub;
        private System.Windows.Forms.ColumnHeader clmSize;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ImageList imglstGames;
        private System.Windows.Forms.ImageList imglstGamesSubs;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip menuGamesSubs;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
    }
}

