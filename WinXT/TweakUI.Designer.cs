namespace Cselian.Utilities.WinXT
{
	partial class TweakUI
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
			this.dgvOptions = new System.Windows.Forms.DataGridView();
			this.txtMore = new System.Windows.Forms.TextBox();
			this.txtMsg = new System.Windows.Forms.TextBox();
			this.lblMsg = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvOptions
			// 
			this.dgvOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvOptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOptions.Location = new System.Drawing.Point(12, 12);
			this.dgvOptions.Name = "dgvOptions";
			this.dgvOptions.RowHeadersVisible = false;
			this.dgvOptions.Size = new System.Drawing.Size(423, 189);
			this.dgvOptions.TabIndex = 0;
			this.dgvOptions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOptions_CellClick);
			// 
			// txtMore
			// 
			this.txtMore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMore.Location = new System.Drawing.Point(46, 232);
			this.txtMore.Name = "txtMore";
			this.txtMore.Size = new System.Drawing.Size(389, 20);
			this.txtMore.TabIndex = 4;
			// 
			// txtMsg
			// 
			this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMsg.Location = new System.Drawing.Point(46, 207);
			this.txtMsg.Name = "txtMsg";
			this.txtMsg.Size = new System.Drawing.Size(389, 20);
			this.txtMsg.TabIndex = 2;
			// 
			// lblMsg
			// 
			this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblMsg.AutoSize = true;
			this.lblMsg.Location = new System.Drawing.Point(13, 210);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(27, 13);
			this.lblMsg.TabIndex = 1;
			this.lblMsg.Text = "&Msg";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 235);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Info";
			// 
			// TweakUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 262);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblMsg);
			this.Controls.Add(this.txtMsg);
			this.Controls.Add(this.txtMore);
			this.Controls.Add(this.dgvOptions);
			this.MaximizeBox = false;
			this.Name = "TweakUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tweak UI";
			((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOptions;
		private System.Windows.Forms.TextBox txtMore;
		private System.Windows.Forms.TextBox txtMsg;
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.Label label2;
	}
}