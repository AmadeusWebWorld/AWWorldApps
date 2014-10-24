namespace Cselian.Utilities.WinXT.Addins
{
	partial class ExNViewer
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
			this.TxtCtl = new System.Windows.Forms.TextBox();
			this.SplitCtl.Panel2.SuspendLayout();
			this.SplitCtl.SuspendLayout();
			this.SuspendLayout();
			// 
			// SplitCtl
			// 
			this.SplitCtl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitCtl.Location = new System.Drawing.Point(0, 0);
			this.SplitCtl.Name = "SplitCtl";
			// 
			// SplitCtl.Panel2
			// 
			this.SplitCtl.Panel2.Controls.Add(this.TxtCtl);
			this.SplitCtl.Size = new System.Drawing.Size(420, 150);
			this.SplitCtl.SplitterDistance = 140;
			this.SplitCtl.TabIndex = 0;
			// 
			// TxtCtl
			// 
			this.TxtCtl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtCtl.Location = new System.Drawing.Point(0, 0);
			this.TxtCtl.MaxLength = 0;
			this.TxtCtl.Multiline = true;
			this.TxtCtl.Name = "TxtCtl";
			this.TxtCtl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TxtCtl.Size = new System.Drawing.Size(276, 150);
			this.TxtCtl.TabIndex = 0;
			// 
			// ExNViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.SplitCtl);
			this.Name = "ExNViewer";
			this.Size = new System.Drawing.Size(420, 150);
			this.SplitCtl.Panel2.ResumeLayout(false);
			this.SplitCtl.Panel2.PerformLayout();
			this.SplitCtl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer SplitCtl;
		private System.Windows.Forms.TextBox TxtCtl;
	}
}
