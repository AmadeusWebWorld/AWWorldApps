namespace Cselian.IViewer.UI
{
	partial class Splash
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
            this.lblSite = new System.Windows.Forms.LinkLabel();
            this.lblMail = new System.Windows.Forms.LinkLabel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.BackColor = System.Drawing.Color.White;
            this.lblSite.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblSite.LinkColor = System.Drawing.Color.Teal;
            this.lblSite.Location = new System.Drawing.Point(123, 248);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(227, 14);
            this.lblSite.TabIndex = 6;
            this.lblSite.TabStop = true;
            this.lblSite.Text = "http://yieldmore.org/iviewer/";
            this.lblSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.White;
            this.lblMail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMail.LinkColor = System.Drawing.Color.Teal;
            this.lblMail.Location = new System.Drawing.Point(234, 147);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(135, 14);
            this.lblMail.TabIndex = 7;
            this.lblMail.TabStop = true;
            this.lblMail.Text = "imran@yieldmore.org";
            this.lblMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.White;
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Maroon;
            this.lblMsg.Location = new System.Drawing.Point(13, 198);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(432, 42);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "IViewer is absolutely FREE!\r\n(c) 2000 - {0} - All Rights Reserved.";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.White;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(106, 174);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(247, 14);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "version: 5.2. build: 424 of 10 Jan 2013";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.BackColor = System.Drawing.Color.White;
            this.lblBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBy.ForeColor = System.Drawing.Color.Gray;
            this.lblBy.Location = new System.Drawing.Point(97, 147);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(131, 14);
            this.lblBy.TabIndex = 3;
            this.lblBy.Text = "by Imran Ali Namazi.";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 271);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.LinkLabel lblSite;
		internal System.Windows.Forms.LinkLabel lblMail;
		internal System.Windows.Forms.Label lblMsg;
		internal System.Windows.Forms.Label lblVersion;
		internal System.Windows.Forms.Label lblBy;

	}
}