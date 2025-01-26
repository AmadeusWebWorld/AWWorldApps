namespace AmadeusWeb.Updater
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.btnClose = new System.Windows.Forms.Button();
			this.picProduct = new System.Windows.Forms.PictureBox();
			this.pbarWorking = new System.Windows.Forms.ProgressBar();
			this.lblAction = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.AutoSize = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(694, 301);
			this.btnClose.Name = "btnClose";
			this.btnClose.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.btnClose.Size = new System.Drawing.Size(78, 22);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// picProduct
			// 
			this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picProduct.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picProduct.ErrorImage")));
			this.picProduct.Location = new System.Drawing.Point(12, 12);
			this.picProduct.Name = "picProduct";
			this.picProduct.Size = new System.Drawing.Size(300, 300);
			this.picProduct.TabIndex = 5;
			this.picProduct.TabStop = false;
			// 
			// pbarWorking
			// 
			this.pbarWorking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbarWorking.Location = new System.Drawing.Point(318, 226);
			this.pbarWorking.Name = "pbarWorking";
			this.pbarWorking.Size = new System.Drawing.Size(450, 50);
			this.pbarWorking.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.pbarWorking.TabIndex = 2;
			this.pbarWorking.Visible = false;
			// 
			// lblAction
			// 
			this.lblAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAction.Location = new System.Drawing.Point(318, 12);
			this.lblAction.Name = "lblAction";
			this.lblAction.Size = new System.Drawing.Size(450, 80);
			this.lblAction.TabIndex = 0;
			this.lblAction.Text = "Action";
			// 
			// lblMessage
			// 
			this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.Location = new System.Drawing.Point(318, 119);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(450, 80);
			this.lblMessage.TabIndex = 1;
			this.lblMessage.Text = "Status";
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.AutoSize = true;
			this.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnNext.Location = new System.Drawing.Point(610, 302);
			this.btnNext.Name = "btnNext";
			this.btnNext.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.btnNext.Size = new System.Drawing.Size(78, 22);
			this.btnNext.TabIndex = 3;
			this.btnNext.Text = "&Next";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 336);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.lblAction);
			this.Controls.Add(this.pbarWorking);
			this.Controls.Add(this.picProduct);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnClose);
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.PictureBox picProduct;
		private System.Windows.Forms.ProgressBar pbarWorking;
		private System.Windows.Forms.Label lblAction;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Button btnNext;
	}
}