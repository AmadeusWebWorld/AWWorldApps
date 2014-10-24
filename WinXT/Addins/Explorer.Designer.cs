namespace Cselian.Utilities.WinXT.Addins
{
	partial class Explorer
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SplitCtl = new System.Windows.Forms.SplitContainer();
			this.XplCtl = new System.Windows.Forms.TreeView();
			this.FileCtl = new System.Windows.Forms.ListView();
			this.FilterCtl = new System.Windows.Forms.TextBox();
			this.ExtnCtl = new System.Windows.Forms.TextBox();
			this.SplitCtl.Panel1.SuspendLayout();
			this.SplitCtl.Panel2.SuspendLayout();
			this.SplitCtl.SuspendLayout();
			this.SuspendLayout();
			// 
			// SplitCtl
			// 
			this.SplitCtl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitCtl.Location = new System.Drawing.Point(0, 0);
			this.SplitCtl.Name = "SplitCtl";
			this.SplitCtl.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// SplitCtl.Panel1
			// 
			this.SplitCtl.Panel1.Controls.Add(this.XplCtl);
			// 
			// SplitCtl.Panel2
			// 
			this.SplitCtl.Panel2.Controls.Add(this.ExtnCtl);
			this.SplitCtl.Panel2.Controls.Add(this.FilterCtl);
			this.SplitCtl.Panel2.Controls.Add(this.FileCtl);
			this.SplitCtl.Size = new System.Drawing.Size(150, 150);
			this.SplitCtl.SplitterDistance = 78;
			this.SplitCtl.TabIndex = 0;
			// 
			// XplCtl
			// 
			this.XplCtl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.XplCtl.Location = new System.Drawing.Point(0, 0);
			this.XplCtl.Name = "XplCtl";
			this.XplCtl.Size = new System.Drawing.Size(150, 78);
			this.XplCtl.TabIndex = 0;
			// 
			// FileCtl
			// 
			this.FileCtl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.FileCtl.Location = new System.Drawing.Point(0, 26);
			this.FileCtl.MultiSelect = false;
			this.FileCtl.Name = "FileCtl";
			this.FileCtl.Size = new System.Drawing.Size(150, 42);
			this.FileCtl.TabIndex = 0;
			this.FileCtl.UseCompatibleStateImageBehavior = false;
			this.FileCtl.View = System.Windows.Forms.View.List;
			// 
			// FilterCtl
			// 
			this.FilterCtl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.FilterCtl.Location = new System.Drawing.Point(0, 2);
			this.FilterCtl.Name = "FilterCtl";
			this.FilterCtl.Size = new System.Drawing.Size(108, 20);
			this.FilterCtl.TabIndex = 1;
			// 
			// ExtnCtl
			// 
			this.ExtnCtl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ExtnCtl.Location = new System.Drawing.Point(114, 0);
			this.ExtnCtl.Name = "ExtnCtl";
			this.ExtnCtl.Size = new System.Drawing.Size(36, 20);
			this.ExtnCtl.TabIndex = 1;
			// 
			// Explorer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.SplitCtl);
			this.Name = "Explorer";
			this.SplitCtl.Panel1.ResumeLayout(false);
			this.SplitCtl.Panel2.ResumeLayout(false);
			this.SplitCtl.Panel2.PerformLayout();
			this.SplitCtl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer SplitCtl;
		private System.Windows.Forms.TreeView XplCtl;
		private System.Windows.Forms.ListView FileCtl;
		private System.Windows.Forms.TextBox ExtnCtl;
		private System.Windows.Forms.TextBox FilterCtl;

	}
}
