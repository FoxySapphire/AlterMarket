﻿namespace AlterMarket
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Dummy Item 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Dummy Item 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Dummy Item 1");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Dummy Item 2");
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstvwApplications = new System.Windows.Forms.ListView();
            this.clmApplications = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglstApplications = new System.Windows.Forms.ImageList(this.components);
            this.lstvwApplicationsVersions = new System.Windows.Forms.ListView();
            this.clmApplication = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglstApplicationsVersions = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 364);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Applications";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstvwApplications);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstvwApplicationsVersions);
            this.splitContainer1.Size = new System.Drawing.Size(595, 332);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstvwApplications
            // 
            this.lstvwApplications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmApplications});
            this.lstvwApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvwApplications.FullRowSelect = true;
            this.lstvwApplications.GridLines = true;
            this.lstvwApplications.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lstvwApplications.Location = new System.Drawing.Point(0, 0);
            this.lstvwApplications.MultiSelect = false;
            this.lstvwApplications.Name = "lstvwApplications";
            this.lstvwApplications.Size = new System.Drawing.Size(166, 332);
            this.lstvwApplications.SmallImageList = this.imglstApplications;
            this.lstvwApplications.TabIndex = 0;
            this.lstvwApplications.UseCompatibleStateImageBehavior = false;
            this.lstvwApplications.View = System.Windows.Forms.View.Details;
            this.lstvwApplications.SelectedIndexChanged += new System.EventHandler(this.lstvwApplications_SelectedIndexChanged);
            // 
            // clmApplications
            // 
            this.clmApplications.Text = "Applications";
            this.clmApplications.Width = 162;
            // 
            // imglstApplications
            // 
            this.imglstApplications.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglstApplications.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstApplications.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstvwApplicationsVersions
            // 
            this.lstvwApplicationsVersions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmApplication,
            this.clmSize});
            this.lstvwApplicationsVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvwApplicationsVersions.FullRowSelect = true;
            this.lstvwApplicationsVersions.GridLines = true;
            this.lstvwApplicationsVersions.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lstvwApplicationsVersions.Location = new System.Drawing.Point(0, 0);
            this.lstvwApplicationsVersions.MultiSelect = false;
            this.lstvwApplicationsVersions.Name = "lstvwApplicationsVersions";
            this.lstvwApplicationsVersions.Size = new System.Drawing.Size(425, 332);
            this.lstvwApplicationsVersions.SmallImageList = this.imglstApplicationsVersions;
            this.lstvwApplicationsVersions.TabIndex = 0;
            this.lstvwApplicationsVersions.UseCompatibleStateImageBehavior = false;
            this.lstvwApplicationsVersions.View = System.Windows.Forms.View.Details;
            // 
            // clmApplication
            // 
            this.clmApplication.Text = "Application";
            this.clmApplication.Width = 325;
            // 
            // clmSize
            // 
            this.clmSize.Text = "Size";
            this.clmSize.Width = 96;
            // 
            // imglstApplicationsVersions
            // 
            this.imglstApplicationsVersions.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglstApplicationsVersions.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstApplicationsVersions.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Games";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(601, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Music";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
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
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(423, 17);
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
            this.applicationsToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.musicToolStripMenuItem});
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.reloadToolStripMenuItem.Text = "Reload";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.musicToolStripMenuItem.Text = "Music";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.marqueeProgressBarControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 364);
            this.panel2.TabIndex = 3;
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(240, 183);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Properties.LookAndFeel.SkinName = "VS2010";
            this.marqueeProgressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed = 75;
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(129, 18);
            this.marqueeProgressBarControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(240, 164);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Loading, please wait...";
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
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstvwApplications;
        private System.Windows.Forms.ListView lstvwApplicationsVersions;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader clmApplications;
        private System.Windows.Forms.ColumnHeader clmApplication;
        private System.Windows.Forms.ColumnHeader clmSize;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ImageList imglstApplications;
        private System.Windows.Forms.ImageList imglstApplicationsVersions;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

