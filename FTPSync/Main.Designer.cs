namespace Cselian.FTPSync
{
	partial class Main
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "inc/tpls/default.thtml",
            "Changed"}, -1);
            this.Log = new System.Windows.Forms.TextBox();
            this.Files = new System.Windows.Forms.ListView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MsgCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenContainingFolderMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyPathsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyPathsOfCheckedMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.SepX1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExcludeFileMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcludeFolderMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcludeFolderNameMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcludeExtensionMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.SepX2 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageExclusionsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.Splitter = new System.Windows.Forms.SplitContainer();
            this.fsw = new System.IO.FileSystemWatcher();
            this.MenuBar = new System.Windows.Forms.ToolStrip();
            this.SyncMnu = new System.Windows.Forms.ToolStripButton();
            this.PauseMnu = new System.Windows.Forms.ToolStripButton();
            this.DeleteMnu = new System.Windows.Forms.ToolStripDropDownButton();
            this.DeleteFtpMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteLocalMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddMnu = new System.Windows.Forms.ToolStripButton();
            this.QueueMnu = new System.Windows.Forms.ToolStripButton();
            this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearMnu = new System.Windows.Forms.ToolStripButton();
            this.ClearSelectedMnu = new System.Windows.Forms.ToolStripButton();
            this.ClearUncheckedMnu = new System.Windows.Forms.ToolStripButton();
            this.Sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectMnu = new System.Windows.Forms.ToolStripButton();
            this.GrabberMnu = new System.Windows.Forms.ToolStripButton();
            this.OpenLogMnu = new System.Windows.Forms.ToolStripButton();
            this.AboutMnu = new System.Windows.Forms.ToolStripButton();
            this.ContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).BeginInit();
            this.Splitter.Panel1.SuspendLayout();
            this.Splitter.Panel2.SuspendLayout();
            this.Splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(0, 2);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(950, 94);
            this.Log.TabIndex = 1;
            this.Log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Log_KeyDown);
            // 
            // Files
            // 
            this.Files.AllowDrop = true;
            this.Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Files.CheckBoxes = true;
            this.Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.MsgCol,
            this.SizeCol});
            this.Files.ContextMenuStrip = this.ContextMenu;
            this.Files.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.Files.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Files.LargeImageList = this.icons;
            this.Files.Location = new System.Drawing.Point(0, 0);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(947, 235);
            this.Files.SmallImageList = this.icons;
            this.Files.TabIndex = 0;
            this.Files.UseCompatibleStateImageBehavior = false;
            this.Files.View = System.Windows.Forms.View.Details;
            this.Files.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.Files_ColumnWidthChanged);
            this.Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.Files_DragDrop);
            this.Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.Files_DragEnter);
            this.Files.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Files_KeyDown);
            // 
            // NameCol
            // 
            this.NameCol.Text = "File";
            this.NameCol.Width = 250;
            // 
            // MsgCol
            // 
            this.MsgCol.Text = "Message";
            this.MsgCol.Width = 171;
            // 
            // SizeCol
            // 
            this.SizeCol.Text = "Size";
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenContainingFolderMnu,
            this.CopyPathsMnu,
            this.CopyPathsOfCheckedMnu,
            this.SepX1,
            this.ExcludeFileMnu,
            this.ExcludeFolderMnu,
            this.ExcludeFolderNameMnu,
            this.ExcludeExtensionMnu,
            this.SepX2,
            this.ManageExclusionsMnu});
            this.ContextMenu.Name = "ExcludeMenu";
            this.ContextMenu.Size = new System.Drawing.Size(202, 192);
            // 
            // OpenContainingFolderMnu
            // 
            this.OpenContainingFolderMnu.Name = "OpenContainingFolderMnu";
            this.OpenContainingFolderMnu.Size = new System.Drawing.Size(201, 22);
            this.OpenContainingFolderMnu.Text = "Open Containing Folder";
            this.OpenContainingFolderMnu.Click += new System.EventHandler(this.OpenContainingFolderMnu_Click);
            // 
            // CopyPathsMnu
            // 
            this.CopyPathsMnu.Name = "CopyPathsMnu";
            this.CopyPathsMnu.Size = new System.Drawing.Size(201, 22);
            this.CopyPathsMnu.Text = "Copy Path(s)";
            this.CopyPathsMnu.Click += new System.EventHandler(this.CopyPathsMnu_Click);
            // 
            // CopyPathsOfCheckedMnu
            // 
            this.CopyPathsOfCheckedMnu.Name = "CopyPathsOfCheckedMnu";
            this.CopyPathsOfCheckedMnu.Size = new System.Drawing.Size(201, 22);
            this.CopyPathsOfCheckedMnu.Text = "Copy Path(s)";
            // 
            // SepX1
            // 
            this.SepX1.Name = "SepX1";
            this.SepX1.Size = new System.Drawing.Size(198, 6);
            // 
            // ExcludeFileMnu
            // 
            this.ExcludeFileMnu.Name = "ExcludeFileMnu";
            this.ExcludeFileMnu.Size = new System.Drawing.Size(201, 22);
            this.ExcludeFileMnu.Text = "Exclude File";
            // 
            // ExcludeFolderMnu
            // 
            this.ExcludeFolderMnu.Name = "ExcludeFolderMnu";
            this.ExcludeFolderMnu.Size = new System.Drawing.Size(201, 22);
            this.ExcludeFolderMnu.Text = "Exclude Folder";
            // 
            // ExcludeFolderNameMnu
            // 
            this.ExcludeFolderNameMnu.Name = "ExcludeFolderNameMnu";
            this.ExcludeFolderNameMnu.Size = new System.Drawing.Size(201, 22);
            this.ExcludeFolderNameMnu.Text = "Exclude Folder Name";
            // 
            // ExcludeExtensionMnu
            // 
            this.ExcludeExtensionMnu.Name = "ExcludeExtensionMnu";
            this.ExcludeExtensionMnu.Size = new System.Drawing.Size(201, 22);
            this.ExcludeExtensionMnu.Text = "Exclude Extension";
            // 
            // SepX2
            // 
            this.SepX2.Name = "SepX2";
            this.SepX2.Size = new System.Drawing.Size(198, 6);
            // 
            // ManageExclusionsMnu
            // 
            this.ManageExclusionsMnu.Name = "ManageExclusionsMnu";
            this.ManageExclusionsMnu.Size = new System.Drawing.Size(201, 22);
            this.ManageExclusionsMnu.Text = "Manage Exclusions";
            // 
            // icons
            // 
            this.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.icons.ImageSize = new System.Drawing.Size(16, 16);
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Splitter
            // 
            this.Splitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Splitter.Location = new System.Drawing.Point(11, 48);
            this.Splitter.Name = "Splitter";
            this.Splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Splitter.Panel1
            // 
            this.Splitter.Panel1.Controls.Add(this.Files);
            // 
            // Splitter.Panel2
            // 
            this.Splitter.Panel2.Controls.Add(this.Log);
            this.Splitter.Size = new System.Drawing.Size(950, 340);
            this.Splitter.SplitterDistance = 235;
            this.Splitter.TabIndex = 4;
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.SynchronizingObject = this;
            // 
            // MenuBar
            // 
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SyncMnu,
            this.PauseMnu,
            this.DeleteMnu,
            this.Sep1,
            this.AddMnu,
            this.QueueMnu,
            this.Sep2,
            this.ClearMnu,
            this.ClearSelectedMnu,
            this.ClearUncheckedMnu,
            this.Sep3,
            this.SelectMnu,
            this.GrabberMnu,
            this.OpenLogMnu,
            this.AboutMnu});
            this.MenuBar.Location = new System.Drawing.Point(8, 8);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuBar.Size = new System.Drawing.Size(946, 35);
            this.MenuBar.TabIndex = 5;
            this.MenuBar.Text = "Toolbar";
            // 
            // SyncMnu
            // 
            this.SyncMnu.Image = global::Cselian.FTPSync.Properties.Resources.sync;
            this.SyncMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SyncMnu.Name = "SyncMnu";
            this.SyncMnu.Size = new System.Drawing.Size(64, 32);
            this.SyncMnu.Text = "&Sync";
            this.SyncMnu.Click += new System.EventHandler(this.SyncOrDelete_Click);
            // 
            // PauseMnu
            // 
            this.PauseMnu.Image = global::Cselian.FTPSync.Properties.Resources.pause;
            this.PauseMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseMnu.Name = "PauseMnu";
            this.PauseMnu.Size = new System.Drawing.Size(70, 32);
            this.PauseMnu.Text = "&Pause";
            this.PauseMnu.Click += new System.EventHandler(this.Pause_Click);
            // 
            // DeleteMnu
            // 
            this.DeleteMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteFtpMnu,
            this.DeleteLocalMnu});
            this.DeleteMnu.Image = global::Cselian.FTPSync.Properties.Resources.delete;
            this.DeleteMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteMnu.Name = "DeleteMnu";
            this.DeleteMnu.Size = new System.Drawing.Size(81, 32);
            this.DeleteMnu.Text = "&Delete";
            // 
            // DeleteFtpMnu
            // 
            this.DeleteFtpMnu.Name = "DeleteFtpMnu";
            this.DeleteFtpMnu.Size = new System.Drawing.Size(167, 22);
            this.DeleteFtpMnu.Text = "Delete from Ftp";
            this.DeleteFtpMnu.Click += new System.EventHandler(this.SyncOrDelete_Click);
            // 
            // DeleteLocalMnu
            // 
            this.DeleteLocalMnu.Name = "DeleteLocalMnu";
            this.DeleteLocalMnu.Size = new System.Drawing.Size(167, 22);
            this.DeleteLocalMnu.Text = "Delete from Local";
            this.DeleteLocalMnu.Click += new System.EventHandler(this.SyncOrDelete_Click);
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(6, 35);
            // 
            // AddMnu
            // 
            this.AddMnu.Image = global::Cselian.FTPSync.Properties.Resources.add;
            this.AddMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddMnu.Name = "AddMnu";
            this.AddMnu.Size = new System.Drawing.Size(70, 32);
            this.AddMnu.Text = "&Add...";
            this.AddMnu.Click += new System.EventHandler(this.AddMnu_Click);
            // 
            // QueueMnu
            // 
            this.QueueMnu.Image = global::Cselian.FTPSync.Properties.Resources.add;
            this.QueueMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QueueMnu.Name = "QueueMnu";
            this.QueueMnu.Size = new System.Drawing.Size(83, 32);
            this.QueueMnu.Text = "&Queue...";
            this.QueueMnu.Click += new System.EventHandler(this.QueueMnu_Click);
            // 
            // Sep2
            // 
            this.Sep2.Name = "Sep2";
            this.Sep2.Size = new System.Drawing.Size(6, 35);
            // 
            // ClearMnu
            // 
            this.ClearMnu.Image = global::Cselian.FTPSync.Properties.Resources.clear;
            this.ClearMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearMnu.Name = "ClearMnu";
            this.ClearMnu.Size = new System.Drawing.Size(66, 32);
            this.ClearMnu.Text = "&Clear";
            this.ClearMnu.Click += new System.EventHandler(this.ClearMnu_Click);
            // 
            // ClearSelectedMnu
            // 
            this.ClearSelectedMnu.Image = global::Cselian.FTPSync.Properties.Resources.clear;
            this.ClearSelectedMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearSelectedMnu.Name = "ClearSelectedMnu";
            this.ClearSelectedMnu.Size = new System.Drawing.Size(83, 32);
            this.ClearSelectedMnu.Text = "S&elected";
            this.ClearSelectedMnu.Click += new System.EventHandler(this.ClearSelectedMnu_Click);
            // 
            // ClearUncheckedMnu
            // 
            this.ClearUncheckedMnu.Image = global::Cselian.FTPSync.Properties.Resources.clear;
            this.ClearUncheckedMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearUncheckedMnu.Name = "ClearUncheckedMnu";
            this.ClearUncheckedMnu.Size = new System.Drawing.Size(98, 32);
            this.ClearUncheckedMnu.Text = "&Unchecked";
            this.ClearUncheckedMnu.Click += new System.EventHandler(this.ClearUncheckedMnu_Click);
            // 
            // Sep3
            // 
            this.Sep3.Name = "Sep3";
            this.Sep3.Size = new System.Drawing.Size(6, 35);
            // 
            // SelectMnu
            // 
            this.SelectMnu.Image = global::Cselian.FTPSync.Properties.Resources.select;
            this.SelectMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectMnu.Name = "SelectMnu";
            this.SelectMnu.Size = new System.Drawing.Size(97, 32);
            this.SelectMnu.Text = "Workspace";
            this.SelectMnu.Click += new System.EventHandler(this.SelectMnu_Click);
            // 
            // GrabberMnu
            // 
            this.GrabberMnu.Image = global::Cselian.FTPSync.Properties.Resources.grabber;
            this.GrabberMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GrabberMnu.Name = "GrabberMnu";
            this.GrabberMnu.Size = new System.Drawing.Size(81, 32);
            this.GrabberMnu.Text = "&Grabber";
            this.GrabberMnu.Click += new System.EventHandler(this.GrabberMnu_Click);
            // 
            // OpenLogMnu
            // 
            this.OpenLogMnu.Image = global::Cselian.FTPSync.Properties.Resources.log;
            this.OpenLogMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenLogMnu.Name = "OpenLogMnu";
            this.OpenLogMnu.Size = new System.Drawing.Size(59, 32);
            this.OpenLogMnu.Text = "&Log";
            this.OpenLogMnu.Click += new System.EventHandler(this.OpenLogMnu_Click);
            // 
            // AboutMnu
            // 
            this.AboutMnu.Image = global::Cselian.FTPSync.Properties.Resources.about;
            this.AboutMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutMnu.Name = "AboutMnu";
            this.AboutMnu.Size = new System.Drawing.Size(72, 32);
            this.AboutMnu.Text = "About";
            this.AboutMnu.Click += new System.EventHandler(this.AboutMnu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 412);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.Splitter);
            this.MinimumSize = new System.Drawing.Size(989, 451);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ContextMenu.ResumeLayout(false);
            this.Splitter.Panel1.ResumeLayout(false);
            this.Splitter.Panel2.ResumeLayout(false);
            this.Splitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).EndInit();
            this.Splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.TextBox Log;
		internal System.Windows.Forms.ListView Files;
		internal System.Windows.Forms.ColumnHeader NameCol;
		internal System.Windows.Forms.ColumnHeader MsgCol;
		internal System.Windows.Forms.ColumnHeader SizeCol;
		internal System.Windows.Forms.ImageList icons;
		internal System.Windows.Forms.SplitContainer Splitter;
		internal System.IO.FileSystemWatcher fsw;
		private System.Windows.Forms.ToolStrip MenuBar;
		private System.Windows.Forms.ToolStripButton ClearMnu;
		private System.Windows.Forms.ToolStripButton ClearUncheckedMnu;
		private System.Windows.Forms.ToolStripButton SelectMnu;
		private System.Windows.Forms.ToolStripSeparator Sep3;
		private System.Windows.Forms.ToolStripButton SyncMnu;
		private System.Windows.Forms.ToolStripButton PauseMnu;
		private System.Windows.Forms.ToolStripDropDownButton DeleteMnu;
		private System.Windows.Forms.ToolStripMenuItem DeleteFtpMnu;
		private System.Windows.Forms.ToolStripMenuItem DeleteLocalMnu;
		private System.Windows.Forms.ToolStripSeparator Sep1;
		private System.Windows.Forms.ToolStripButton ClearSelectedMnu;
		private System.Windows.Forms.ToolStripButton OpenLogMnu;
		private System.Windows.Forms.ToolStripButton QueueMnu;
		private System.Windows.Forms.ToolStripSeparator Sep2;
		private System.Windows.Forms.ToolStripButton AddMnu;
		private System.Windows.Forms.ContextMenuStrip ContextMenu;
		private System.Windows.Forms.ToolStripMenuItem ExcludeFileMnu;
		private System.Windows.Forms.ToolStripMenuItem ExcludeFolderMnu;
		private System.Windows.Forms.ToolStripMenuItem ExcludeExtensionMnu;
		private System.Windows.Forms.ToolStripMenuItem ExcludeFolderNameMnu;
		private System.Windows.Forms.ToolStripSeparator SepX2;
		private System.Windows.Forms.ToolStripMenuItem ManageExclusionsMnu;
		private System.Windows.Forms.ToolStripButton GrabberMnu;
		private System.Windows.Forms.ToolStripMenuItem OpenContainingFolderMnu;
		private System.Windows.Forms.ToolStripSeparator SepX1;
		private System.Windows.Forms.ToolStripMenuItem CopyPathsMnu;
		private System.Windows.Forms.ToolStripMenuItem CopyPathsOfCheckedMnu;
        private System.Windows.Forms.ToolStripButton AboutMnu;
    }
}