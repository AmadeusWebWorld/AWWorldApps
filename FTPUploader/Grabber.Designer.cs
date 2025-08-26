namespace AmadeusWeb.SmartSiteUploader
{
	partial class Grabber
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "{1}",
            "{0} {2}",
            "{3}",
            "Formatter"}, -1);
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGrab = new System.Windows.Forms.Button();
            this.btnBuildNav = new System.Windows.Forms.Button();
            this.lvwPages = new System.Windows.Forms.ListView();
            this.colUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtProject = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(62, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGrab
            // 
            this.btnGrab.Location = new System.Drawing.Point(80, 9);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(62, 23);
            this.btnGrab.TabIndex = 2;
            this.btnGrab.Text = "&Grab";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // btnBuildNav
            // 
            this.btnBuildNav.Location = new System.Drawing.Point(148, 9);
            this.btnBuildNav.Name = "btnBuildNav";
            this.btnBuildNav.Size = new System.Drawing.Size(62, 23);
            this.btnBuildNav.TabIndex = 3;
            this.btnBuildNav.Text = "Build &Nav";
            this.btnBuildNav.UseVisualStyleBackColor = true;
            this.btnBuildNav.Click += new System.EventHandler(this.btnBuildNav_Click);
            // 
            // lvwPages
            // 
            this.lvwPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPages.CheckBoxes = true;
            this.lvwPages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUrl,
            this.colName,
            this.colDesc,
            this.colStatus});
            listViewItem1.StateImageIndex = 0;
            this.lvwPages.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvwPages.Location = new System.Drawing.Point(12, 38);
            this.lvwPages.Name = "lvwPages";
            this.lvwPages.Size = new System.Drawing.Size(640, 211);
            this.lvwPages.TabIndex = 4;
            this.lvwPages.UseCompatibleStateImageBehavior = false;
            this.lvwPages.View = System.Windows.Forms.View.Details;
            // 
            // colUrl
            // 
            this.colUrl.Text = "Url";
            this.colUrl.Width = 325;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 100;
            // 
            // colDesc
            // 
            this.colDesc.Text = "Description";
            this.colDesc.Width = 104;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // txtProject
            // 
            this.txtProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProject.BackColor = System.Drawing.SystemColors.Window;
            this.txtProject.Location = new System.Drawing.Point(284, 9);
            this.txtProject.Name = "txtProject";
            this.txtProject.ReadOnly = true;
            this.txtProject.Size = new System.Drawing.Size(368, 20);
            this.txtProject.TabIndex = 5;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(216, 9);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(62, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // Grabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 261);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.lvwPages);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnBuildNav);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.btnLoad);
            this.MinimumSize = new System.Drawing.Size(680, 300);
            this.Name = "Grabber";
            this.Text = "Grabber";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnGrab;
		private System.Windows.Forms.Button btnBuildNav;
		private System.Windows.Forms.ListView lvwPages;
		private System.Windows.Forms.ColumnHeader colUrl;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colDesc;
		private System.Windows.Forms.ColumnHeader colStatus;
		private System.Windows.Forms.TextBox txtProject;
		private System.Windows.Forms.Button btnReplace;
	}
}