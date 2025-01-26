namespace AmadeusWeb.WinXT
{
	partial class Edit
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblPath = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.chkRoot = new System.Windows.Forms.CheckBox();
			this.chkIndex = new System.Windows.Forms.CheckBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.chkFavorite = new System.Windows.Forms.CheckBox();
			this.btnPath = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 15);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(18, 41);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(29, 13);
			this.lblPath.TabIndex = 2;
			this.lblPath.Text = "Path";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(53, 12);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(128, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(53, 38);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(276, 20);
			this.txtPath.TabIndex = 3;
			this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// chkRoot
			// 
			this.chkRoot.AutoSize = true;
			this.chkRoot.Location = new System.Drawing.Point(53, 64);
			this.chkRoot.Name = "chkRoot";
			this.chkRoot.Size = new System.Drawing.Size(92, 17);
			this.chkRoot.TabIndex = 5;
			this.chkRoot.Text = "Open as &Root";
			this.chkRoot.UseVisualStyleBackColor = true;
			// 
			// chkIndex
			// 
			this.chkIndex.AutoSize = true;
			this.chkIndex.Location = new System.Drawing.Point(267, 64);
			this.chkIndex.Name = "chkIndex";
			this.chkIndex.Size = new System.Drawing.Size(105, 17);
			this.chkIndex.TabIndex = 7;
			this.chkIndex.Text = "&Index Subfolders";
			this.chkIndex.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(297, 10);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 8;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// chkFavorite
			// 
			this.chkFavorite.AutoSize = true;
			this.chkFavorite.Location = new System.Drawing.Point(174, 64);
			this.chkFavorite.Name = "chkFavorite";
			this.chkFavorite.Size = new System.Drawing.Size(64, 17);
			this.chkFavorite.TabIndex = 6;
			this.chkFavorite.Text = "&Favorite";
			this.chkFavorite.UseVisualStyleBackColor = true;
			// 
			// btnPath
			// 
			this.btnPath.Location = new System.Drawing.Point(335, 38);
			this.btnPath.Name = "btnPath";
			this.btnPath.Size = new System.Drawing.Size(37, 20);
			this.btnPath.TabIndex = 4;
			this.btnPath.Text = "...";
			this.btnPath.UseVisualStyleBackColor = true;
			this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
			// 
			// Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 93);
			this.Controls.Add(this.btnPath);
			this.Controls.Add(this.chkFavorite);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblPath);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.chkRoot);
			this.Controls.Add(this.chkIndex);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "Edit";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Folder - ";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Edit_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.CheckBox chkRoot;
		private System.Windows.Forms.CheckBox chkIndex;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.CheckBox chkFavorite;
		private System.Windows.Forms.Button btnPath;
	}
}