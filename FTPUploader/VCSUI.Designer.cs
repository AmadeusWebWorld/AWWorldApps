﻿namespace AmadeusWeb.SmartSiteUploader
{
	partial class VCSUI
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
			this.VSplit = new System.Windows.Forms.SplitContainer();
			this.HSplit = new System.Windows.Forms.SplitContainer();
			this.Fols = new System.Windows.Forms.TreeView();
			this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MnuScan = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuPush = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuDiff = new System.Windows.Forms.ToolStripMenuItem();
			this.Files = new System.Windows.Forms.ListBox();
			this.Content = new System.Windows.Forms.TextBox();
			this.FileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MnuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuFileDiff = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuRevert = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuCommit = new System.Windows.Forms.ToolStripMenuItem();
			this.VSplit.Panel1.SuspendLayout();
			this.VSplit.Panel2.SuspendLayout();
			this.VSplit.SuspendLayout();
			this.HSplit.Panel1.SuspendLayout();
			this.HSplit.Panel2.SuspendLayout();
			this.HSplit.SuspendLayout();
			this.Menu.SuspendLayout();
			this.FileMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// VSplit
			// 
			this.VSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VSplit.Location = new System.Drawing.Point(0, 0);
			this.VSplit.Name = "VSplit";
			// 
			// VSplit.Panel1
			// 
			this.VSplit.Panel1.Controls.Add(this.HSplit);
			// 
			// VSplit.Panel2
			// 
			this.VSplit.Panel2.Controls.Add(this.Content);
			this.VSplit.Size = new System.Drawing.Size(484, 261);
			this.VSplit.SplitterDistance = 160;
			this.VSplit.TabIndex = 0;
			// 
			// HSplit
			// 
			this.HSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HSplit.Location = new System.Drawing.Point(0, 0);
			this.HSplit.Name = "HSplit";
			this.HSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// HSplit.Panel1
			// 
			this.HSplit.Panel1.Controls.Add(this.Fols);
			// 
			// HSplit.Panel2
			// 
			this.HSplit.Panel2.Controls.Add(this.Files);
			this.HSplit.Size = new System.Drawing.Size(160, 261);
			this.HSplit.SplitterDistance = 145;
			this.HSplit.TabIndex = 0;
			// 
			// Fols
			// 
			this.Fols.ContextMenuStrip = this.Menu;
			this.Fols.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Fols.HideSelection = false;
			this.Fols.Location = new System.Drawing.Point(0, 0);
			this.Fols.Name = "Fols";
			this.Fols.Size = new System.Drawing.Size(160, 145);
			this.Fols.TabIndex = 1;
			this.Fols.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Fols_AfterSelect);
			// 
			// Menu
			// 
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuScan,
            this.MnuUpdate,
            this.MnuPush,
            this.MnuDiff});
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(113, 92);
			// 
			// MnuScan
			// 
			this.MnuScan.Name = "MnuScan";
			this.MnuScan.Size = new System.Drawing.Size(112, 22);
			this.MnuScan.Text = "Scan";
			this.MnuScan.Click += new System.EventHandler(this.MnuScan_Click);
			// 
			// MnuUpdate
			// 
			this.MnuUpdate.Name = "MnuUpdate";
			this.MnuUpdate.Size = new System.Drawing.Size(112, 22);
			this.MnuUpdate.Text = "Update";
			this.MnuUpdate.Click += new System.EventHandler(this.MnuUpdate_Click);
			// 
			// MnuPush
			// 
			this.MnuPush.Name = "MnuPush";
			this.MnuPush.Size = new System.Drawing.Size(112, 22);
			this.MnuPush.Text = "Push";
			this.MnuPush.Click += new System.EventHandler(this.MnuPush_Click);
			// 
			// MnuDiff
			// 
			this.MnuDiff.Name = "MnuDiff";
			this.MnuDiff.Size = new System.Drawing.Size(112, 22);
			this.MnuDiff.Text = "Diff";
			this.MnuDiff.Click += new System.EventHandler(this.MnuDiff_Click);
			// 
			// Files
			// 
			this.Files.ContextMenuStrip = this.Menu;
			this.Files.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Files.FormattingEnabled = true;
			this.Files.Location = new System.Drawing.Point(0, 0);
			this.Files.Name = "Files";
			this.Files.Size = new System.Drawing.Size(160, 112);
			this.Files.TabIndex = 0;
			// 
			// Content
			// 
			this.Content.ContextMenuStrip = this.FileMenu;
			this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Content.Location = new System.Drawing.Point(0, 0);
			this.Content.Multiline = true;
			this.Content.Name = "Content";
			this.Content.Size = new System.Drawing.Size(320, 261);
			this.Content.TabIndex = 2;
			// 
			// FileMenu
			// 
			this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEdit,
            this.MnuFileDiff,
            this.MnuRevert,
            this.MnuCommit});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(130, 92);
			// 
			// MnuEdit
			// 
			this.MnuEdit.Name = "MnuEdit";
			this.MnuEdit.Size = new System.Drawing.Size(152, 22);
			this.MnuEdit.Text = "Edit / Save";
			this.MnuEdit.Click += new System.EventHandler(this.MnuEdit_Click);
			// 
			// MnuFileDiff
			// 
			this.MnuFileDiff.Name = "MnuFileDiff";
			this.MnuFileDiff.Size = new System.Drawing.Size(118, 22);
			this.MnuFileDiff.Text = "Diff";
			this.MnuFileDiff.Click += new System.EventHandler(this.MnuFileDiff_Click);
			// 
			// MnuRevert
			// 
			this.MnuRevert.Name = "MnuRevert";
			this.MnuRevert.Size = new System.Drawing.Size(118, 22);
			this.MnuRevert.Text = "Revert";
			this.MnuRevert.Click += new System.EventHandler(this.MnuRevert_Click);
			// 
			// MnuCommit
			// 
			this.MnuCommit.Name = "MnuCommit";
			this.MnuCommit.Size = new System.Drawing.Size(118, 22);
			this.MnuCommit.Text = "Commit";
			this.MnuCommit.Click += new System.EventHandler(this.MnuCommit_Click);
			// 
			// VCSUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.VSplit);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "VCSUI";
			this.ShowIcon = false;
			this.Text = "VCSUI";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.VSplit.Panel1.ResumeLayout(false);
			this.VSplit.Panel2.ResumeLayout(false);
			this.VSplit.Panel2.PerformLayout();
			this.VSplit.ResumeLayout(false);
			this.HSplit.Panel1.ResumeLayout(false);
			this.HSplit.Panel2.ResumeLayout(false);
			this.HSplit.ResumeLayout(false);
			this.Menu.ResumeLayout(false);
			this.FileMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer VSplit;
		private System.Windows.Forms.SplitContainer HSplit;
		private System.Windows.Forms.TextBox Content;
		private System.Windows.Forms.TreeView Fols;
		private System.Windows.Forms.ListBox Files;
		private System.Windows.Forms.ContextMenuStrip Menu;
		private System.Windows.Forms.ToolStripMenuItem MnuScan;
		private System.Windows.Forms.ToolStripMenuItem MnuUpdate;
		private System.Windows.Forms.ToolStripMenuItem MnuPush;
		private System.Windows.Forms.ContextMenuStrip FileMenu;
		private System.Windows.Forms.ToolStripMenuItem MnuEdit;
		private System.Windows.Forms.ToolStripMenuItem MnuFileDiff;
		private System.Windows.Forms.ToolStripMenuItem MnuRevert;
		private System.Windows.Forms.ToolStripMenuItem MnuCommit;
		private System.Windows.Forms.ToolStripMenuItem MnuDiff;
	}
}