namespace Cselian.FTPSync
{
	partial class Select
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.lblFind = new System.Windows.Forms.ToolStripLabel();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.SelectMnu = new System.Windows.Forms.ToolStripSplitButton();
            this.OptNoPVCS = new System.Windows.Forms.ToolStripMenuItem();
            this.OptBoth = new System.Windows.Forms.ToolStripMenuItem();
            this.OptOnlyPVCS = new System.Windows.Forms.ToolStripMenuItem();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshMnu = new System.Windows.Forms.ToolStripButton();
            this.OpenMnu = new System.Windows.Forms.ToolStripButton();
            this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyMnu = new System.Windows.Forms.ToolStripButton();
            this.SaveMnu = new System.Windows.Forms.ToolStripButton();
            this.ShowPwdMnu = new System.Windows.Forms.ToolStripButton();
            this.Sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.GrabberMnu = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.Toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItems.ColumnHeadersHeight = 40;
            this.dgvItems.Location = new System.Drawing.Point(22, 81);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(6);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 72;
            this.dgvItems.RowTemplate.Height = 16;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvItems.Size = new System.Drawing.Size(1132, 325);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentDoubleClick);
            this.dgvItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItems_CellFormatting);
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            this.dgvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItems_KeyDown);
            // 
            // Toolbar
            // 
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.None;
            this.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFind,
            this.txtFind,
            this.SelectMnu,
            this.Sep1,
            this.RefreshMnu,
            this.OpenMnu,
            this.Sep2,
            this.CopyMnu,
            this.SaveMnu,
            this.ShowPwdMnu,
            this.Sep3,
            this.GrabberMnu});
            this.Toolbar.Location = new System.Drawing.Point(22, 18);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.Toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Toolbar.Size = new System.Drawing.Size(922, 40);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.Text = "toolStrip1";
            // 
            // lblFind
            // 
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(57, 34);
            this.lblFind.Text = "&Find:";
            // 
            // txtFind
            // 
            this.txtFind.MaxLength = 32;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(180, 40);
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // SelectMnu
            // 
            this.SelectMnu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptNoPVCS,
            this.OptBoth,
            this.OptOnlyPVCS});
            this.SelectMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectMnu.Name = "SelectMnu";
            this.SelectMnu.Size = new System.Drawing.Size(92, 34);
            this.SelectMnu.Text = "&Select";
            this.SelectMnu.ButtonClick += new System.EventHandler(this.SelectMnu_ButtonClick);
            // 
            // OptNoPVCS
            // 
            this.OptNoPVCS.Checked = true;
            this.OptNoPVCS.CheckOnClick = true;
            this.OptNoPVCS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OptNoPVCS.Name = "OptNoPVCS";
            this.OptNoPVCS.Size = new System.Drawing.Size(228, 40);
            this.OptNoPVCS.Text = "No PVCS";
            this.OptNoPVCS.Click += new System.EventHandler(this.OptPVCS_Click);
            // 
            // OptBoth
            // 
            this.OptBoth.CheckOnClick = true;
            this.OptBoth.Name = "OptBoth";
            this.OptBoth.Size = new System.Drawing.Size(228, 40);
            this.OptBoth.Text = "Both";
            this.OptBoth.Click += new System.EventHandler(this.OptPVCS_Click);
            // 
            // OptOnlyPVCS
            // 
            this.OptOnlyPVCS.CheckOnClick = true;
            this.OptOnlyPVCS.Name = "OptOnlyPVCS";
            this.OptOnlyPVCS.Size = new System.Drawing.Size(228, 40);
            this.OptOnlyPVCS.Text = "Only PVCS";
            this.OptOnlyPVCS.Click += new System.EventHandler(this.OptPVCS_Click);
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(6, 40);
            // 
            // RefreshMnu
            // 
            this.RefreshMnu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshMnu.Name = "RefreshMnu";
            this.RefreshMnu.Size = new System.Drawing.Size(86, 34);
            this.RefreshMnu.Text = "&Refresh";
            this.RefreshMnu.Click += new System.EventHandler(this.RefreshMnu_Click);
            // 
            // OpenMnu
            // 
            this.OpenMnu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenMnu.Name = "OpenMnu";
            this.OpenMnu.Size = new System.Drawing.Size(68, 34);
            this.OpenMnu.Text = "&Open";
            this.OpenMnu.Click += new System.EventHandler(this.OpenMnu_Click);
            // 
            // Sep2
            // 
            this.Sep2.Name = "Sep2";
            this.Sep2.Size = new System.Drawing.Size(6, 40);
            // 
            // CopyMnu
            // 
            this.CopyMnu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CopyMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyMnu.Name = "CopyMnu";
            this.CopyMnu.Size = new System.Drawing.Size(64, 34);
            this.CopyMnu.Text = "&Copy";
            this.CopyMnu.Click += new System.EventHandler(this.CopyMnu_Click);
            // 
            // SaveMnu
            // 
            this.SaveMnu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveMnu.Name = "SaveMnu";
            this.SaveMnu.Size = new System.Drawing.Size(60, 34);
            this.SaveMnu.Text = "&Save";
            this.SaveMnu.Click += new System.EventHandler(this.SaveMnu_Click);
            // 
            // ShowPwdMnu
            // 
            this.ShowPwdMnu.CheckOnClick = true;
            this.ShowPwdMnu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowPwdMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowPwdMnu.Name = "ShowPwdMnu";
            this.ShowPwdMnu.Size = new System.Drawing.Size(168, 34);
            this.ShowPwdMnu.Text = "Show Passwords";
            this.ShowPwdMnu.CheckStateChanged += new System.EventHandler(this.ShowPwdMnu_CheckStateChanged);
            // 
            // Sep3
            // 
            this.Sep3.Name = "Sep3";
            this.Sep3.Size = new System.Drawing.Size(6, 40);
            // 
            // GrabberMnu
            // 
            this.GrabberMnu.Image = global::Cselian.FTPSync.Properties.Resources.grabber;
            this.GrabberMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GrabberMnu.Name = "GrabberMnu";
            this.GrabberMnu.Size = new System.Drawing.Size(119, 34);
            this.GrabberMnu.Text = "&Grabber";
            this.GrabberMnu.Click += new System.EventHandler(this.GrabberMnu_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 436);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.dgvItems);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select FTP Connection / Folder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Select_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvItems;
		private System.Windows.Forms.ToolStrip Toolbar;
		private System.Windows.Forms.ToolStripButton RefreshMnu;
		private System.Windows.Forms.ToolStripButton OpenMnu;
		private System.Windows.Forms.ToolStripButton CopyMnu;
		private System.Windows.Forms.ToolStripButton SaveMnu;
		private System.Windows.Forms.ToolStripSeparator Sep1;
		private System.Windows.Forms.ToolStripSeparator Sep2;
		private System.Windows.Forms.ToolStripButton ShowPwdMnu;
		private System.Windows.Forms.ToolStripSeparator Sep3;
		private System.Windows.Forms.ToolStripButton GrabberMnu;
		private System.Windows.Forms.ToolStripLabel lblFind;
		private System.Windows.Forms.ToolStripTextBox txtFind;
		private System.Windows.Forms.ToolStripSplitButton SelectMnu;
		private System.Windows.Forms.ToolStripMenuItem OptNoPVCS;
		private System.Windows.Forms.ToolStripMenuItem OptOnlyPVCS;
		private System.Windows.Forms.ToolStripMenuItem OptBoth;
    }
}