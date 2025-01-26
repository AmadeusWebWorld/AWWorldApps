namespace AmadeusWeb.WinXT
{
	partial class Clocky
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
			this.components = new System.ComponentModel.Container();
			this.dgvClocks = new System.Windows.Forms.DataGridView();
			this.lblEdit = new System.Windows.Forms.Label();
			this.VisualMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.FontMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ColorMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.BackColorMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.WinBgdMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepVis = new System.Windows.Forms.ToolStripSeparator();
			this.EditClocksMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.RefreshClocksMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.lblClose = new System.Windows.Forms.Label();
			this.lblCaption = new System.Windows.Forms.Label();
			this.Ticker = new System.Windows.Forms.Timer(this.components);
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.chkDstRules = new System.Windows.Forms.CheckBox();
			this.chkMove = new System.Windows.Forms.CheckBox();
			this.lblDate = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvClocks)).BeginInit();
			this.VisualMnu.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvClocks
			// 
			this.dgvClocks.AllowUserToAddRows = false;
			this.dgvClocks.AllowUserToDeleteRows = false;
			this.dgvClocks.AllowUserToResizeRows = false;
			this.dgvClocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvClocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvClocks.BackgroundColor = System.Drawing.Color.Ivory;
			this.dgvClocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvClocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClocks.Location = new System.Drawing.Point(13, 13);
			this.dgvClocks.Margin = new System.Windows.Forms.Padding(0);
			this.dgvClocks.Name = "dgvClocks";
			this.dgvClocks.RowHeadersVisible = false;
			this.dgvClocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvClocks.Size = new System.Drawing.Size(254, 134);
			this.dgvClocks.TabIndex = 0;
			this.dgvClocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClocks_CellClick);
			this.dgvClocks.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dgvClocks_CellParsing);
			this.dgvClocks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClocks_CellValueChanged);
			this.dgvClocks.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvClocks_EditingControlShowing);
			// 
			// lblEdit
			// 
			this.lblEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEdit.AutoSize = true;
			this.lblEdit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lblEdit.ContextMenuStrip = this.VisualMnu;
			this.lblEdit.Location = new System.Drawing.Point(242, 0);
			this.lblEdit.Name = "lblEdit";
			this.lblEdit.Size = new System.Drawing.Size(16, 13);
			this.lblEdit.TabIndex = 1;
			this.lblEdit.Text = "...";
			this.ToolTip.SetToolTip(this.lblEdit, "Edit Clock List");
			this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
			// 
			// VisualMnu
			// 
			this.VisualMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontMnu,
            this.ColorMnu,
            this.BackColorMnu,
            this.WinBgdMnu,
            this.SepVis,
            this.EditClocksMnu,
            this.RefreshClocksMnu});
			this.VisualMnu.Name = "VisualMnu";
			this.VisualMnu.Size = new System.Drawing.Size(186, 164);
			// 
			// FontMnu
			// 
			this.FontMnu.Image = global::AmadeusWeb.WinXT.Properties.Resources.font;
			this.FontMnu.Name = "FontMnu";
			this.FontMnu.Size = new System.Drawing.Size(185, 22);
			this.FontMnu.Text = "Clock Font";
			this.FontMnu.Click += new System.EventHandler(this.FontMnu_Click);
			// 
			// ColorMnu
			// 
			this.ColorMnu.Image = global::AmadeusWeb.WinXT.Properties.Resources.colour;
			this.ColorMnu.Name = "ColorMnu";
			this.ColorMnu.Size = new System.Drawing.Size(185, 22);
			this.ColorMnu.Text = "Colour";
			this.ColorMnu.Click += new System.EventHandler(this.ColorMnu_Click);
			// 
			// BackColorMnu
			// 
			this.BackColorMnu.Image = global::AmadeusWeb.WinXT.Properties.Resources.back;
			this.BackColorMnu.Name = "BackColorMnu";
			this.BackColorMnu.Size = new System.Drawing.Size(185, 22);
			this.BackColorMnu.Text = "Text Background";
			this.BackColorMnu.Click += new System.EventHandler(this.BackColorMnu_Click);
			// 
			// WinBgdMnu
			// 
			this.WinBgdMnu.Name = "WinBgdMnu";
			this.WinBgdMnu.Size = new System.Drawing.Size(185, 22);
			this.WinBgdMnu.Text = "Window Background";
			this.WinBgdMnu.Click += new System.EventHandler(this.WinBgdMnu_Click);
			// 
			// SepVis
			// 
			this.SepVis.Name = "SepVis";
			this.SepVis.Size = new System.Drawing.Size(182, 6);
			// 
			// EditClocksMnu
			// 
			this.EditClocksMnu.Name = "EditClocksMnu";
			this.EditClocksMnu.Size = new System.Drawing.Size(185, 22);
			this.EditClocksMnu.Text = "Edit Clocks";
			this.EditClocksMnu.Click += new System.EventHandler(this.EditClocksMnu_Click);
			// 
			// RefreshClocksMnu
			// 
			this.RefreshClocksMnu.Name = "RefreshClocksMnu";
			this.RefreshClocksMnu.Size = new System.Drawing.Size(185, 22);
			this.RefreshClocksMnu.Text = "Refresh Clocks";
			this.RefreshClocksMnu.Click += new System.EventHandler(this.RefreshClocksMnu_Click);
			// 
			// lblClose
			// 
			this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lblClose.Location = new System.Drawing.Point(264, 0);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(16, 13);
			this.lblClose.TabIndex = 2;
			this.lblClose.Text = "x";
			this.lblClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
			// 
			// lblCaption
			// 
			this.lblCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCaption.AutoSize = true;
			this.lblCaption.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.lblCaption.Location = new System.Drawing.Point(121, 0);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(39, 13);
			this.lblCaption.TabIndex = 1;
			this.lblCaption.Text = "Clocky";
			this.lblCaption.Click += new System.EventHandler(this.lblCaption_Click);
			// 
			// Ticker
			// 
			this.Ticker.Enabled = true;
			this.Ticker.Interval = 1000;
			this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
			// 
			// chkDstRules
			// 
			this.chkDstRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkDstRules.AutoSize = true;
			this.chkDstRules.Location = new System.Drawing.Point(265, 27);
			this.chkDstRules.Name = "chkDstRules";
			this.chkDstRules.Size = new System.Drawing.Size(15, 14);
			this.chkDstRules.TabIndex = 4;
			this.ToolTip.SetToolTip(this.chkDstRules, "Show Dst Rules");
			this.chkDstRules.UseVisualStyleBackColor = true;
			this.chkDstRules.Visible = false;
			this.chkDstRules.CheckedChanged += new System.EventHandler(this.chkDstRules_CheckedChanged);
			// 
			// chkMove
			// 
			this.chkMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkMove.AutoSize = true;
			this.chkMove.Location = new System.Drawing.Point(265, 47);
			this.chkMove.Name = "chkMove";
			this.chkMove.Size = new System.Drawing.Size(15, 14);
			this.chkMove.TabIndex = 4;
			this.ToolTip.SetToolTip(this.chkMove, "Move Clock Up Mode");
			this.chkMove.UseVisualStyleBackColor = true;
			this.chkMove.Visible = false;
			this.chkMove.CheckedChanged += new System.EventHandler(this.chkMove_CheckedChanged);
			// 
			// lblDate
			// 
			this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lblDate.AutoSize = true;
			this.lblDate.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.lblDate.Location = new System.Drawing.Point(108, 147);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(64, 13);
			this.lblDate.TabIndex = 3;
			this.lblDate.Text = "today\'s date";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblDate.Resize += new System.EventHandler(this.Clocky_Resize);
			// 
			// Clocky
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(280, 160);
			this.Controls.Add(this.chkDstRules);
			this.Controls.Add(this.chkMove);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblClose);
			this.Controls.Add(this.lblCaption);
			this.Controls.Add(this.lblEdit);
			this.Controls.Add(this.dgvClocks);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Clocky";
			this.Padding = new System.Windows.Forms.Padding(13);
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Clocky";
			this.Resize += new System.EventHandler(this.Clocky_Resize);
			((System.ComponentModel.ISupportInitialize)(this.dgvClocks)).EndInit();
			this.VisualMnu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvClocks;
		private System.Windows.Forms.Label lblEdit;
		private System.Windows.Forms.Label lblClose;
		private System.Windows.Forms.Label lblCaption;
		private System.Windows.Forms.Timer Ticker;
		private System.Windows.Forms.ToolTip ToolTip;
		private System.Windows.Forms.ContextMenuStrip VisualMnu;
		private System.Windows.Forms.ToolStripMenuItem FontMnu;
		private System.Windows.Forms.ToolStripMenuItem ColorMnu;
		private System.Windows.Forms.ToolStripMenuItem BackColorMnu;
		private System.Windows.Forms.ToolStripMenuItem WinBgdMnu;
		private System.Windows.Forms.ToolStripMenuItem EditClocksMnu;
		private System.Windows.Forms.ToolStripSeparator SepVis;
		private System.Windows.Forms.ToolStripMenuItem RefreshClocksMnu;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.CheckBox chkDstRules;
		private System.Windows.Forms.CheckBox chkMove;
	}
}