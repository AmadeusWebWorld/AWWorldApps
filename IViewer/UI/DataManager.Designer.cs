namespace AmadeusWeb.IViewer.UI
{
	partial class DataManager
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
			this.txtExclude = new System.Windows.Forms.TextBox();
			this.txtRemove = new System.Windows.Forms.TextBox();
			this.txtRaw = new System.Windows.Forms.TextBox();
			this.txtClean = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtExclude
			// 
			this.txtExclude.Location = new System.Drawing.Point(12, 12);
			this.txtExclude.Multiline = true;
			this.txtExclude.Name = "txtExclude";
			this.txtExclude.Size = new System.Drawing.Size(399, 119);
			this.txtExclude.TabIndex = 0;
			// 
			// txtRemove
			// 
			this.txtRemove.Location = new System.Drawing.Point(417, 12);
			this.txtRemove.Multiline = true;
			this.txtRemove.Name = "txtRemove";
			this.txtRemove.Size = new System.Drawing.Size(375, 119);
			this.txtRemove.TabIndex = 0;
			// 
			// txtRaw
			// 
			this.txtRaw.Location = new System.Drawing.Point(12, 137);
			this.txtRaw.Multiline = true;
			this.txtRaw.Name = "txtRaw";
			this.txtRaw.Size = new System.Drawing.Size(399, 197);
			this.txtRaw.TabIndex = 0;
			this.txtRaw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRaw_KeyDown);
			// 
			// txtClean
			// 
			this.txtClean.Location = new System.Drawing.Point(417, 169);
			this.txtClean.Multiline = true;
			this.txtClean.Name = "txtClean";
			this.txtClean.Size = new System.Drawing.Size(375, 165);
			this.txtClean.TabIndex = 0;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(417, 137);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "&Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(498, 137);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// DataManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 346);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.txtClean);
			this.Controls.Add(this.txtRaw);
			this.Controls.Add(this.txtRemove);
			this.Controls.Add(this.txtExclude);
			this.Name = "DataManager";
			this.Text = "DataManager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtExclude;
		private System.Windows.Forms.TextBox txtRemove;
		private System.Windows.Forms.TextBox txtRaw;
		private System.Windows.Forms.TextBox txtClean;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
	}
}