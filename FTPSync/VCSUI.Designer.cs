namespace Cselian.FTPSync
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
			this.Files = new System.Windows.Forms.ListBox();
			this.Fols = new System.Windows.Forms.TreeView();
			this.Content = new System.Windows.Forms.TextBox();
			this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MnuScan = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuPush = new System.Windows.Forms.ToolStripMenuItem();
			this.FileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.diffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.commitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			// Fols
			// 
			this.Fols.ContextMenuStrip = this.Menu;
			this.Fols.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Fols.Location = new System.Drawing.Point(0, 0);
			this.Fols.Name = "Fols";
			this.Fols.Size = new System.Drawing.Size(160, 145);
			this.Fols.TabIndex = 1;
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
			// Menu
			// 
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuScan,
            this.MnuUpdate,
            this.MnuPush});
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(113, 70);
			// 
			// MnuScan
			// 
			this.MnuScan.Name = "MnuScan";
			this.MnuScan.Size = new System.Drawing.Size(112, 22);
			this.MnuScan.Text = "Scan";
			// 
			// MnuUpdate
			// 
			this.MnuUpdate.Name = "MnuUpdate";
			this.MnuUpdate.Size = new System.Drawing.Size(112, 22);
			this.MnuUpdate.Text = "Update";
			// 
			// MnuPush
			// 
			this.MnuPush.Name = "MnuPush";
			this.MnuPush.Size = new System.Drawing.Size(112, 22);
			this.MnuPush.Text = "Push";
			// 
			// FileMenu
			// 
			this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.diffToolStripMenuItem,
            this.revertToolStripMenuItem,
            this.commitToolStripMenuItem});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(119, 92);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// diffToolStripMenuItem
			// 
			this.diffToolStripMenuItem.Name = "diffToolStripMenuItem";
			this.diffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.diffToolStripMenuItem.Text = "Diff";
			// 
			// revertToolStripMenuItem
			// 
			this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
			this.revertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.revertToolStripMenuItem.Text = "Revert";
			// 
			// commitToolStripMenuItem
			// 
			this.commitToolStripMenuItem.Name = "commitToolStripMenuItem";
			this.commitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.commitToolStripMenuItem.Text = "Commit";
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
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem diffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem revertToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem commitToolStripMenuItem;
	}
}