namespace Cselian.IViewer.UI
{
	partial class Organizer
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
			this.lblFol = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.tvwItems = new System.Windows.Forms.TreeView();
			this.btnExport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblFol
			// 
			this.lblFol.AutoSize = true;
			this.lblFol.Location = new System.Drawing.Point(9, 16);
			this.lblFol.Name = "lblFol";
			this.lblFol.Size = new System.Drawing.Size(39, 13);
			this.lblFol.TabIndex = 5;
			this.lblFol.Text = "Label1";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefresh.Location = new System.Drawing.Point(391, 11);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 4;
			this.btnRefresh.Text = "&Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// tvwItems
			// 
			this.tvwItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tvwItems.Location = new System.Drawing.Point(12, 40);
			this.tvwItems.Name = "tvwItems";
			this.tvwItems.Size = new System.Drawing.Size(454, 324);
			this.tvwItems.TabIndex = 3;
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.Location = new System.Drawing.Point(310, 11);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 6;
			this.btnExport.Text = "&Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// Organizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 374);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.lblFol);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.tvwItems);
			this.Name = "Organizer";
			this.Text = "Folder Organization";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label lblFol;
		internal System.Windows.Forms.Button btnRefresh;
		internal System.Windows.Forms.TreeView tvwItems;
		internal System.Windows.Forms.Button btnExport;
	}
}