namespace Cselian.ScheduleCatcher
{
	partial class Test
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
			this.btnSelected = new System.Windows.Forms.Button();
			this.picImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSelected
			// 
			this.btnSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelected.Location = new System.Drawing.Point(12, 8);
			this.btnSelected.Name = "btnSelected";
			this.btnSelected.Size = new System.Drawing.Size(260, 31);
			this.btnSelected.TabIndex = 2;
			this.btnSelected.Text = "Selected";
			this.btnSelected.UseVisualStyleBackColor = true;
			this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
			// 
			// picImage
			// 
			this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picImage.Location = new System.Drawing.Point(12, 45);
			this.picImage.Name = "picImage";
			this.picImage.Size = new System.Drawing.Size(260, 205);
			this.picImage.TabIndex = 3;
			this.picImage.TabStop = false;
			this.picImage.Click += new System.EventHandler(this.picImage_Click);
			// 
			// Test
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.picImage);
			this.Controls.Add(this.btnSelected);
			this.MaximizeBox = false;
			this.Name = "Test";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Test Schedule Catcher";
			((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSelected;
		private System.Windows.Forms.PictureBox picImage;

	}
}

