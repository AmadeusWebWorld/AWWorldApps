namespace AmadeusWeb.IViewer.UI
{
	partial class Lyrics
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
			this.lblLoopNth = new System.Windows.Forms.Label();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.tabLoop = new System.Windows.Forms.TabPage();
			this.rdoLoopSelection = new System.Windows.Forms.RadioButton();
			this.rdoLoopGroup = new System.Windows.Forms.RadioButton();
			this.lblLoopTimes = new System.Windows.Forms.Label();
			this.txtLoopTimes = new System.Windows.Forms.TextBox();
			this.txtEvery = new System.Windows.Forms.TextBox();
			this.rdoLoopEvery = new System.Windows.Forms.RadioButton();
			this.chkLoop = new System.Windows.Forms.CheckBox();
			this.tabControls = new System.Windows.Forms.TabControl();
			this.Items = new System.Windows.Forms.ListBox();
			this.EdMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.IncludeRestMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveToNowMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveFwdByPt1Mnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveBackByPt1Mnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveFwdByPt5Mnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveBackByPt5Mnu = new System.Windows.Forms.ToolStripMenuItem();
			this.tabLoop.SuspendLayout();
			this.tabControls.SuspendLayout();
			this.EdMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLoopNth
			// 
			this.lblLoopNth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLoopNth.AutoSize = true;
			this.lblLoopNth.Location = new System.Drawing.Point(444, 9);
			this.lblLoopNth.Name = "lblLoopNth";
			this.lblLoopNth.Size = new System.Drawing.Size(25, 13);
			this.lblLoopNth.TabIndex = 8;
			this.lblLoopNth.Text = "0 of";
			// 
			// tabGeneral
			// 
			this.tabGeneral.Location = new System.Drawing.Point(4, 25);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(552, 31);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// tabLoop
			// 
			this.tabLoop.Controls.Add(this.lblLoopNth);
			this.tabLoop.Controls.Add(this.rdoLoopSelection);
			this.tabLoop.Controls.Add(this.rdoLoopGroup);
			this.tabLoop.Controls.Add(this.lblLoopTimes);
			this.tabLoop.Controls.Add(this.txtLoopTimes);
			this.tabLoop.Controls.Add(this.txtEvery);
			this.tabLoop.Controls.Add(this.rdoLoopEvery);
			this.tabLoop.Controls.Add(this.chkLoop);
			this.tabLoop.Location = new System.Drawing.Point(4, 25);
			this.tabLoop.Name = "tabLoop";
			this.tabLoop.Padding = new System.Windows.Forms.Padding(3);
			this.tabLoop.Size = new System.Drawing.Size(552, 31);
			this.tabLoop.TabIndex = 1;
			this.tabLoop.Text = "Looping";
			this.tabLoop.UseVisualStyleBackColor = true;
			// 
			// rdoLoopSelection
			// 
			this.rdoLoopSelection.AutoSize = true;
			this.rdoLoopSelection.Location = new System.Drawing.Point(243, 8);
			this.rdoLoopSelection.Name = "rdoLoopSelection";
			this.rdoLoopSelection.Size = new System.Drawing.Size(69, 17);
			this.rdoLoopSelection.TabIndex = 7;
			this.rdoLoopSelection.TabStop = true;
			this.rdoLoopSelection.Text = "&Selection";
			this.rdoLoopSelection.UseVisualStyleBackColor = true;
			// 
			// rdoLoopGroup
			// 
			this.rdoLoopGroup.AutoSize = true;
			this.rdoLoopGroup.Checked = true;
			this.rdoLoopGroup.Location = new System.Drawing.Point(183, 8);
			this.rdoLoopGroup.Name = "rdoLoopGroup";
			this.rdoLoopGroup.Size = new System.Drawing.Size(54, 17);
			this.rdoLoopGroup.TabIndex = 6;
			this.rdoLoopGroup.TabStop = true;
			this.rdoLoopGroup.Text = "&Group";
			this.rdoLoopGroup.UseVisualStyleBackColor = true;
			// 
			// lblLoopTimes
			// 
			this.lblLoopTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLoopTimes.AutoSize = true;
			this.lblLoopTimes.Location = new System.Drawing.Point(509, 9);
			this.lblLoopTimes.Name = "lblLoopTimes";
			this.lblLoopTimes.Size = new System.Drawing.Size(37, 13);
			this.lblLoopTimes.TabIndex = 5;
			this.lblLoopTimes.Text = "time(s)";
			// 
			// txtLoopTimes
			// 
			this.txtLoopTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLoopTimes.Location = new System.Drawing.Point(475, 5);
			this.txtLoopTimes.Name = "txtLoopTimes";
			this.txtLoopTimes.Size = new System.Drawing.Size(28, 20);
			this.txtLoopTimes.TabIndex = 2;
			// 
			// txtEvery
			// 
			this.txtEvery.Location = new System.Drawing.Point(114, 5);
			this.txtEvery.Name = "txtEvery";
			this.txtEvery.Size = new System.Drawing.Size(28, 20);
			this.txtEvery.TabIndex = 2;
			// 
			// rdoLoopEvery
			// 
			this.rdoLoopEvery.AutoSize = true;
			this.rdoLoopEvery.Location = new System.Drawing.Point(62, 7);
			this.rdoLoopEvery.Name = "rdoLoopEvery";
			this.rdoLoopEvery.Size = new System.Drawing.Size(115, 17);
			this.rdoLoopEvery.TabIndex = 4;
			this.rdoLoopEvery.TabStop = true;
			this.rdoLoopEvery.Text = "&Every              lines";
			this.rdoLoopEvery.UseVisualStyleBackColor = true;
			// 
			// chkLoop
			// 
			this.chkLoop.AutoSize = true;
			this.chkLoop.Location = new System.Drawing.Point(6, 7);
			this.chkLoop.Name = "chkLoop";
			this.chkLoop.Size = new System.Drawing.Size(50, 17);
			this.chkLoop.TabIndex = 1;
			this.chkLoop.Text = "Loop";
			this.chkLoop.UseVisualStyleBackColor = true;
			// 
			// tabControls
			// 
			this.tabControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControls.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControls.Controls.Add(this.tabGeneral);
			this.tabControls.Controls.Add(this.tabLoop);
			this.tabControls.Location = new System.Drawing.Point(12, 9);
			this.tabControls.Multiline = true;
			this.tabControls.Name = "tabControls";
			this.tabControls.SelectedIndex = 0;
			this.tabControls.Size = new System.Drawing.Size(560, 60);
			this.tabControls.TabIndex = 6;
			// 
			// Items
			// 
			this.Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.Items.ContextMenuStrip = this.EdMenu;
			this.Items.FormattingEnabled = true;
			this.Items.Location = new System.Drawing.Point(12, 75);
			this.Items.Name = "Items";
			this.Items.Size = new System.Drawing.Size(560, 199);
			this.Items.TabIndex = 5;
			// 
			// EdMenu
			// 
			this.EdMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IncludeRestMnu,
            this.MoveToNowMnu,
            this.MoveFwdByPt1Mnu,
            this.MoveBackByPt1Mnu,
            this.MoveFwdByPt5Mnu,
            this.MoveBackByPt5Mnu});
			this.EdMenu.Name = "ContextMenuStrip1";
			this.EdMenu.Size = new System.Drawing.Size(258, 136);
			// 
			// IncludeRestMnu
			// 
			this.IncludeRestMnu.CheckOnClick = true;
			this.IncludeRestMnu.Name = "IncludeRestMnu";
			this.IncludeRestMnu.ShortcutKeyDisplayString = "Ctrl + I";
			this.IncludeRestMnu.Size = new System.Drawing.Size(257, 22);
			this.IncludeRestMnu.Text = "Include Rest when Moving";
			// 
			// MoveToNowMnu
			// 
			this.MoveToNowMnu.Name = "MoveToNowMnu";
			this.MoveToNowMnu.ShortcutKeyDisplayString = "Insert";
			this.MoveToNowMnu.Size = new System.Drawing.Size(257, 22);
			this.MoveToNowMnu.Text = "Move to where now Playing";
			// 
			// MoveFwdByPt1Mnu
			// 
			this.MoveFwdByPt1Mnu.Name = "MoveFwdByPt1Mnu";
			this.MoveFwdByPt1Mnu.ShortcutKeyDisplayString = "]";
			this.MoveFwdByPt1Mnu.Size = new System.Drawing.Size(257, 22);
			this.MoveFwdByPt1Mnu.Text = "Move Fwd By .1";
			// 
			// MoveBackByPt1Mnu
			// 
			this.MoveBackByPt1Mnu.Name = "MoveBackByPt1Mnu";
			this.MoveBackByPt1Mnu.ShortcutKeyDisplayString = "[";
			this.MoveBackByPt1Mnu.Size = new System.Drawing.Size(257, 22);
			this.MoveBackByPt1Mnu.Text = "Move Back by .1";
			// 
			// MoveFwdByPt5Mnu
			// 
			this.MoveFwdByPt5Mnu.Name = "MoveFwdByPt5Mnu";
			this.MoveFwdByPt5Mnu.ShortcutKeyDisplayString = "Ctrl + ]";
			this.MoveFwdByPt5Mnu.Size = new System.Drawing.Size(257, 22);
			this.MoveFwdByPt5Mnu.Text = "Move Fwd by .5";
			// 
			// MoveBackByPt5Mnu
			// 
			this.MoveBackByPt5Mnu.Name = "MoveBackByPt5Mnu";
			this.MoveBackByPt5Mnu.ShortcutKeyDisplayString = "Ctrl + [";
			this.MoveBackByPt5Mnu.Size = new System.Drawing.Size(257, 22);
			this.MoveBackByPt5Mnu.Text = "Move Back by .5";
			// 
			// Lyrics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 282);
			this.Controls.Add(this.tabControls);
			this.Controls.Add(this.Items);
			//this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Lyrics";
			this.Text = "Lyrics Editor";
			this.tabLoop.ResumeLayout(false);
			this.tabLoop.PerformLayout();
			this.tabControls.ResumeLayout(false);
			this.EdMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Label lblLoopNth;
		internal System.Windows.Forms.TabPage tabGeneral;
		internal System.Windows.Forms.TabPage tabLoop;
		internal System.Windows.Forms.RadioButton rdoLoopSelection;
		internal System.Windows.Forms.RadioButton rdoLoopGroup;
		internal System.Windows.Forms.Label lblLoopTimes;
		internal System.Windows.Forms.TextBox txtLoopTimes;
		internal System.Windows.Forms.TextBox txtEvery;
		internal System.Windows.Forms.RadioButton rdoLoopEvery;
		internal System.Windows.Forms.CheckBox chkLoop;
		internal System.Windows.Forms.TabControl tabControls;
		internal System.Windows.Forms.ListBox Items;
		internal System.Windows.Forms.ContextMenuStrip EdMenu;
		internal System.Windows.Forms.ToolStripMenuItem IncludeRestMnu;
		internal System.Windows.Forms.ToolStripMenuItem MoveToNowMnu;
		internal System.Windows.Forms.ToolStripMenuItem MoveFwdByPt1Mnu;
		internal System.Windows.Forms.ToolStripMenuItem MoveBackByPt1Mnu;
		internal System.Windows.Forms.ToolStripMenuItem MoveFwdByPt5Mnu;
		internal System.Windows.Forms.ToolStripMenuItem MoveBackByPt5Mnu;
	}
}