namespace Cselian.IViewer.UI
{
	partial class Options
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
			this.MenuItems = new System.Windows.Forms.ListView();
			this.MenuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MenuSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MenuShortcut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblHint = new System.Windows.Forms.Label();
			this.KnownFolders = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TabMenuShortcuts = new System.Windows.Forms.TabPage();
			this.SCKey = new System.Windows.Forms.TextBox();
			this.TabOptions = new System.Windows.Forms.TabControl();
			this.TabFolders = new System.Windows.Forms.TabPage();
			this.TabFavorites = new System.Windows.Forms.TabPage();
			this.lblFaves = new System.Windows.Forms.Label();
			this.Faves = new System.Windows.Forms.TreeView();
			this.History = new System.Windows.Forms.ListBox();
			this.Save = new System.Windows.Forms.Button();
			this.TabMenuShortcuts.SuspendLayout();
			this.TabOptions.SuspendLayout();
			this.TabFolders.SuspendLayout();
			this.TabFavorites.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuItems
			// 
			this.MenuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MenuName,
            this.MenuSection,
            this.MenuShortcut});
			this.MenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MenuItems.FullRowSelect = true;
			this.MenuItems.Location = new System.Drawing.Point(10, 10);
			this.MenuItems.Name = "MenuItems";
			this.MenuItems.Size = new System.Drawing.Size(428, 350);
			this.MenuItems.TabIndex = 0;
			this.MenuItems.UseCompatibleStateImageBehavior = false;
			this.MenuItems.View = System.Windows.Forms.View.Details;
			// 
			// MenuName
			// 
			this.MenuName.Text = "Menu";
			this.MenuName.Width = 158;
			// 
			// MenuSection
			// 
			this.MenuSection.Text = "Section";
			this.MenuSection.Width = 103;
			// 
			// MenuShortcut
			// 
			this.MenuShortcut.Text = "Shortcut";
			this.MenuShortcut.Width = 144;
			// 
			// lblHint
			// 
			this.lblHint.AutoSize = true;
			this.lblHint.Location = new System.Drawing.Point(13, 10);
			this.lblHint.Name = "lblHint";
			this.lblHint.Size = new System.Drawing.Size(320, 13);
			this.lblHint.TabIndex = 2;
			this.lblHint.Text = "Click Insert to Add, F2 to edit and Delete to remove known folders.";
			// 
			// KnownFolders
			// 
			this.KnownFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.KnownFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
			this.KnownFolders.FullRowSelect = true;
			this.KnownFolders.HideSelection = false;
			this.KnownFolders.LabelEdit = true;
			this.KnownFolders.Location = new System.Drawing.Point(10, 33);
			this.KnownFolders.Name = "KnownFolders";
			this.KnownFolders.Size = new System.Drawing.Size(428, 327);
			this.KnownFolders.TabIndex = 1;
			this.KnownFolders.UseCompatibleStateImageBehavior = false;
			this.KnownFolders.View = System.Windows.Forms.View.Details;
			// 
			// ColumnHeader1
			// 
			this.ColumnHeader1.Text = "Folder";
			this.ColumnHeader1.Width = 296;
			// 
			// ColumnHeader2
			// 
			this.ColumnHeader2.Text = "Exists";
			this.ColumnHeader2.Width = 103;
			// 
			// TabMenuShortcuts
			// 
			this.TabMenuShortcuts.Controls.Add(this.SCKey);
			this.TabMenuShortcuts.Controls.Add(this.MenuItems);
			this.TabMenuShortcuts.Location = new System.Drawing.Point(4, 22);
			this.TabMenuShortcuts.Name = "TabMenuShortcuts";
			this.TabMenuShortcuts.Padding = new System.Windows.Forms.Padding(10);
			this.TabMenuShortcuts.Size = new System.Drawing.Size(448, 370);
			this.TabMenuShortcuts.TabIndex = 0;
			this.TabMenuShortcuts.Text = "Menu Shortcuts";
			this.TabMenuShortcuts.UseVisualStyleBackColor = true;
			// 
			// SCKey
			// 
			this.SCKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SCKey.Location = new System.Drawing.Point(273, 37);
			this.SCKey.Name = "SCKey";
			this.SCKey.Size = new System.Drawing.Size(100, 20);
			this.SCKey.TabIndex = 1;
			this.SCKey.Visible = false;
			// 
			// TabOptions
			// 
			this.TabOptions.Controls.Add(this.TabMenuShortcuts);
			this.TabOptions.Controls.Add(this.TabFolders);
			this.TabOptions.Controls.Add(this.TabFavorites);
			this.TabOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabOptions.Location = new System.Drawing.Point(10, 10);
			this.TabOptions.Name = "TabOptions";
			this.TabOptions.SelectedIndex = 0;
			this.TabOptions.Size = new System.Drawing.Size(456, 396);
			this.TabOptions.TabIndex = 4;
			// 
			// TabFolders
			// 
			this.TabFolders.Controls.Add(this.lblHint);
			this.TabFolders.Controls.Add(this.KnownFolders);
			this.TabFolders.Location = new System.Drawing.Point(4, 22);
			this.TabFolders.Name = "TabFolders";
			this.TabFolders.Padding = new System.Windows.Forms.Padding(10);
			this.TabFolders.Size = new System.Drawing.Size(448, 370);
			this.TabFolders.TabIndex = 1;
			this.TabFolders.Text = "Folders";
			this.TabFolders.UseVisualStyleBackColor = true;
			// 
			// TabFavorites
			// 
			this.TabFavorites.Controls.Add(this.lblFaves);
			this.TabFavorites.Controls.Add(this.Faves);
			this.TabFavorites.Controls.Add(this.History);
			this.TabFavorites.Location = new System.Drawing.Point(4, 22);
			this.TabFavorites.Margin = new System.Windows.Forms.Padding(10);
			this.TabFavorites.Name = "TabFavorites";
			this.TabFavorites.Padding = new System.Windows.Forms.Padding(3);
			this.TabFavorites.Size = new System.Drawing.Size(448, 370);
			this.TabFavorites.TabIndex = 2;
			this.TabFavorites.Text = "Favorites";
			this.TabFavorites.UseVisualStyleBackColor = true;
			// 
			// lblFaves
			// 
			this.lblFaves.Location = new System.Drawing.Point(17, 13);
			this.lblFaves.Name = "lblFaves";
			this.lblFaves.Size = new System.Drawing.Size(425, 28);
			this.lblFaves.TabIndex = 3;
			this.lblFaves.Text = "Click Insert to Add SubGroup, Delete to remove favorite. Double Click the history" +
				" Item to add to the selected node. Also Delete in History to remove Entries.";
			// 
			// Faves
			// 
			this.Faves.HideSelection = false;
			this.Faves.Location = new System.Drawing.Point(10, 44);
			this.Faves.Name = "Faves";
			treeNode1.Name = "RootFave";
			treeNode1.Text = "Root";
			this.Faves.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.Faves.Size = new System.Drawing.Size(422, 147);
			this.Faves.TabIndex = 1;
			this.Faves.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Faves_KeyDown);
			// 
			// History
			// 
			this.History.FormattingEnabled = true;
			this.History.Location = new System.Drawing.Point(10, 212);
			this.History.Name = "History";
			this.History.Size = new System.Drawing.Size(422, 147);
			this.History.TabIndex = 0;
			this.History.KeyDown += new System.Windows.Forms.KeyEventHandler(this.History_KeyDown);
			this.History.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.History_MouseDoubleClick);
			// 
			// Save
			// 
			this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Save.Location = new System.Drawing.Point(372, 10);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(91, 20);
			this.Save.TabIndex = 5;
			this.Save.Text = "&Save Options";
			this.Save.UseVisualStyleBackColor = true;
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 416);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.TabOptions);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Options";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "Options";
			this.TabMenuShortcuts.ResumeLayout(false);
			this.TabMenuShortcuts.PerformLayout();
			this.TabOptions.ResumeLayout(false);
			this.TabFolders.ResumeLayout(false);
			this.TabFolders.PerformLayout();
			this.TabFavorites.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.ListView MenuItems;
		internal System.Windows.Forms.ColumnHeader MenuName;
		internal System.Windows.Forms.ColumnHeader MenuSection;
		internal System.Windows.Forms.ColumnHeader MenuShortcut;
		internal System.Windows.Forms.Label lblHint;
		internal System.Windows.Forms.ListView KnownFolders;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.TabPage TabMenuShortcuts;
		internal System.Windows.Forms.TextBox SCKey;
		internal System.Windows.Forms.TabControl TabOptions;
		internal System.Windows.Forms.TabPage TabFolders;
		internal System.Windows.Forms.Button Save;
		private System.Windows.Forms.TabPage TabFavorites;
		private System.Windows.Forms.TreeView Faves;
		private System.Windows.Forms.ListBox History;
		internal System.Windows.Forms.Label lblFaves;

	}
}