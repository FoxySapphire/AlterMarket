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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstvGames = new System.Windows.Forms.ListView();
            this.clmGames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuGames = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imglstGames = new System.Windows.Forms.ImageList(this.components);
            this.lstvwGamesSubs = new System.Windows.Forms.ListView();
            this.clmSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuGamesSubs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imglstGamesSubs = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.chkOffline = new System.Windows.Forms.CheckBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.chkLan = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMadeBy = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.bgwrkLoadItem = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bgwrkLoadItemSub = new System.ComponentModel.BackgroundWorker();
            this.bgwrkCheckForUpdates = new System.ComponentModel.BackgroundWorker();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuGames.SuspendLayout();
            this.menuGamesSubs.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 415);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 415);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 389);
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
            this.splitContainer1.Panel2.Controls.Add(this.lstvwGamesSubs);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(737, 383);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstvGames
            // 
            this.lstvGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmGames});
            this.lstvGames.ContextMenuStrip = this.menuGames;
            this.lstvGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvGames.FullRowSelect = true;
            this.lstvGames.GridLines = true;
            this.lstvGames.Location = new System.Drawing.Point(0, 0);
            this.lstvGames.MultiSelect = false;
            this.lstvGames.Name = "lstvGames";
            this.lstvGames.Size = new System.Drawing.Size(204, 383);
            this.lstvGames.SmallImageList = this.imglstGames;
            this.lstvGames.TabIndex = 0;
            this.lstvGames.UseCompatibleStateImageBehavior = false;
            this.lstvGames.View = System.Windows.Forms.View.Details;
            this.lstvGames.SelectedIndexChanged += new System.EventHandler(this.lstvGames_SelectedIndexChanged);
            this.lstvGames.SizeChanged += new System.EventHandler(this.lstvGames_SizeChanged);
            // 
            // clmGames
            // 
            this.clmGames.Text = "Games";
            this.clmGames.Width = 200;
            // 
            // menuGames
            // 
            this.menuGames.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconsToolStripMenuItem});
            this.menuGames.Name = "menuGames";
            this.menuGames.Size = new System.Drawing.Size(103, 26);
            // 
            // iconsToolStripMenuItem
            // 
            this.iconsToolStripMenuItem.Checked = true;
            this.iconsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iconsToolStripMenuItem.Enabled = false;
            this.iconsToolStripMenuItem.Name = "iconsToolStripMenuItem";
            this.iconsToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.iconsToolStripMenuItem.Text = "Icons";
            this.iconsToolStripMenuItem.Click += new System.EventHandler(this.iconsToolStripMenuItem_Click);
            // 
            // imglstGames
            // 
            this.imglstGames.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglstGames.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstGames.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstvwGamesSubs
            // 
            this.lstvwGamesSubs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSub,
            this.clmSize,
            this.clmType,
            this.clmHost});
            this.lstvwGamesSubs.ContextMenuStrip = this.menuGamesSubs;
            this.lstvwGamesSubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvwGamesSubs.FullRowSelect = true;
            this.lstvwGamesSubs.GridLines = true;
            this.lstvwGamesSubs.Location = new System.Drawing.Point(0, 0);
            this.lstvwGamesSubs.MultiSelect = false;
            this.lstvwGamesSubs.Name = "lstvwGamesSubs";
            this.lstvwGamesSubs.Size = new System.Drawing.Size(529, 359);
            this.lstvwGamesSubs.SmallImageList = this.imglstGamesSubs;
            this.lstvwGamesSubs.TabIndex = 0;
            this.lstvwGamesSubs.UseCompatibleStateImageBehavior = false;
            this.lstvwGamesSubs.View = System.Windows.Forms.View.Details;
            // 
            // clmSub
            // 
            this.clmSub.Text = "Item";
            this.clmSub.Width = 225;
            // 
            // clmSize
            // 
            this.clmSize.Text = "Size";
            this.clmSize.Width = 100;
            // 
            // clmType
            // 
            this.clmType.Text = "Type";
            this.clmType.Width = 100;
            // 
            // clmHost
            // 
            this.clmHost.Text = "Host";
            this.clmHost.Width = 100;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.chkOnline);
            this.panel3.Controls.Add(this.chkOffline);
            this.panel3.Controls.Add(this.webBrowser1);
            this.panel3.Controls.Add(this.chkLan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 24);
            this.panel3.TabIndex = 2;
            // 
            // chkOnline
            // 
            this.chkOnline.AutoSize = true;
            this.chkOnline.Enabled = false;
            this.chkOnline.Location = new System.Drawing.Point(122, 6);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(56, 17);
            this.chkOnline.TabIndex = 0;
            this.chkOnline.Text = "Online";
            this.toolTip1.SetToolTip(this.chkOnline, "(The internet) Let\'s play online!");
            this.chkOnline.UseVisualStyleBackColor = true;
            this.chkOnline.Visible = false;
            this.chkOnline.CheckedChanged += new System.EventHandler(this.chkOnline_CheckedChanged);
            // 
            // chkOffline
            // 
            this.chkOffline.AutoSize = true;
            this.chkOffline.Checked = true;
            this.chkOffline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOffline.ForeColor = System.Drawing.Color.Red;
            this.chkOffline.Location = new System.Drawing.Point(7, 6);
            this.chkOffline.Name = "chkOffline";
            this.chkOffline.Size = new System.Drawing.Size(56, 17);
            this.chkOffline.TabIndex = 0;
            this.chkOffline.Text = "Offline";
            this.toolTip1.SetToolTip(this.chkOffline, "(Offline) This might be illegal... Meow~");
            this.chkOffline.UseVisualStyleBackColor = true;
            this.chkOffline.CheckedChanged += new System.EventHandler(this.chkOffline_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(506, 1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.BrowserDocumentCompleted);
            // 
            // chkLan
            // 
            this.chkLan.AutoSize = true;
            this.chkLan.Checked = true;
            this.chkLan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLan.Location = new System.Drawing.Point(69, 6);
            this.chkLan.Name = "chkLan";
            this.chkLan.Size = new System.Drawing.Size(47, 17);
            this.chkLan.TabIndex = 0;
            this.chkLan.Text = "LAN";
            this.toolTip1.SetToolTip(this.chkLan, "(Local Area Network) Let\'s play with your friends over LAN!");
            this.chkLan.UseVisualStyleBackColor = true;
            this.chkLan.CheckedChanged += new System.EventHandler(this.chkLan_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblItems,
            this.toolStripStatusLabel2,
            this.lblMadeBy,
            this.toolStripStatusLabel5,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(751, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblItems
            // 
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(45, 17);
            this.lblItems.Text = "0 Items";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(507, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.IsLink = true;
            this.lblMadeBy.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(126, 17);
            this.lblMadeBy.Text = "Made by FoxySapphire";
            this.lblMadeBy.Click += new System.EventHandler(this.lblMadeBy_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel5.Text = "-";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 17);
            this.lblVersion.Text = "Version";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLoading);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 415);
            this.panel2.TabIndex = 3;
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(12, 198);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(727, 19);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bgwrkLoadItem
            // 
            this.bgwrkLoadItem.WorkerReportsProgress = true;
            this.bgwrkLoadItem.WorkerSupportsCancellation = true;
            this.bgwrkLoadItem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwrkLoadItem_DoWork);
            this.bgwrkLoadItem.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwrkLoadItem_ProgressChanged);
            this.bgwrkLoadItem.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwrkLoadItem_RunWorkerCompleted);
            // 
            // bgwrkLoadItemSub
            // 
            this.bgwrkLoadItemSub.WorkerReportsProgress = true;
            this.bgwrkLoadItemSub.WorkerSupportsCancellation = true;
            this.bgwrkLoadItemSub.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwrkLoadItemSub_DoWork);
            this.bgwrkLoadItemSub.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwrkLoadItemSub_ProgressChanged);
            this.bgwrkLoadItemSub.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwrkLoadItemSub_RunWorkerCompleted);
            // 
            // bgwrkCheckForUpdates
            // 
            this.bgwrkCheckForUpdates.WorkerReportsProgress = true;
            this.bgwrkCheckForUpdates.WorkerSupportsCancellation = true;
            this.bgwrkCheckForUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwrkCheckForUpdates_DoWork);
            this.bgwrkCheckForUpdates.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwrkCheckForUpdates_ProgressChanged);
            this.bgwrkCheckForUpdates.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwrkCheckForUpdates_RunWorkerCompleted);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.menuItem1.Text = "Reload (F5)";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3});
            this.menuItem2.Text = "Help";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Check for updates";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterMarket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuGames.ResumeLayout(false);
            this.menuGamesSubs.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstvGames;
        private System.Windows.Forms.ListView lstvwGamesSubs;
        private System.Windows.Forms.ColumnHeader clmGames;
        private System.Windows.Forms.ColumnHeader clmSub;
        private System.Windows.Forms.ColumnHeader clmSize;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imglstGames;
        private System.Windows.Forms.ImageList imglstGamesSubs;
        private System.Windows.Forms.ToolStripStatusLabel lblItems;
        private System.Windows.Forms.ToolStripStatusLabel lblMadeBy;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip menuGamesSubs;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker bgwrkLoadItem;
        private System.Windows.Forms.ContextMenuStrip menuGames;
        private System.Windows.Forms.ToolStripMenuItem iconsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader clmHost;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkOffline;
        private System.Windows.Forms.CheckBox chkLan;
        private System.Windows.Forms.CheckBox chkOnline;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader clmType;
        private System.ComponentModel.BackgroundWorker bgwrkLoadItemSub;
        private System.ComponentModel.BackgroundWorker bgwrkCheckForUpdates;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
    }
}

