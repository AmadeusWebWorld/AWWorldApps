namespace Cselian.IvyUpdater
{
	partial class ViewSettings
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
			this.btnSave = new System.Windows.Forms.Button();
			this.tabSettings = new System.Windows.Forms.TabPage();
			this.cboFrequency = new System.Windows.Forms.ComboBox();
			this.lblFreq = new System.Windows.Forms.Label();
			this.lblNever = new System.Windows.Forms.Label();
			this.chkNever = new System.Windows.Forms.CheckBox();
			this.lblRemindAfter = new System.Windows.Forms.Label();
			this.cboRemind = new System.Windows.Forms.ComboBox();
			this.txtRemind = new System.Windows.Forms.TextBox();
			this.tabAbout = new System.Windows.Forms.TabPage();
			this.lblProgram = new System.Windows.Forms.Label();
			this.txtProgram = new System.Windows.Forms.TextBox();
			this.lblUrl = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.lblSupport = new System.Windows.Forms.Label();
			this.txtSupport = new System.Windows.Forms.TextBox();
			this.tabDates = new System.Windows.Forms.TabPage();
			this.lblNext = new System.Windows.Forms.Label();
			this.txtNext = new System.Windows.Forms.TextBox();
			this.lblLast = new System.Windows.Forms.Label();
			this.txtLast = new System.Windows.Forms.TextBox();
			this.lblLastCheck = new System.Windows.Forms.Label();
			this.txtLastCheck = new System.Windows.Forms.TextBox();
			this.lblLastRemind = new System.Windows.Forms.Label();
			this.txtLastRemind = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabSettings.SuspendLayout();
			this.tabAbout.SuspendLayout();
			this.tabDates.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(165, 111);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tabSettings
			// 
			this.tabSettings.Controls.Add(this.cboFrequency);
			this.tabSettings.Controls.Add(this.btnSave);
			this.tabSettings.Controls.Add(this.lblFreq);
			this.tabSettings.Controls.Add(this.lblNever);
			this.tabSettings.Controls.Add(this.chkNever);
			this.tabSettings.Controls.Add(this.lblRemindAfter);
			this.tabSettings.Controls.Add(this.cboRemind);
			this.tabSettings.Controls.Add(this.txtRemind);
			this.tabSettings.Location = new System.Drawing.Point(4, 22);
			this.tabSettings.Name = "tabSettings";
			this.tabSettings.Size = new System.Drawing.Size(253, 147);
			this.tabSettings.TabIndex = 0;
			this.tabSettings.Text = "Settings";
			this.tabSettings.UseVisualStyleBackColor = true;
			// 
			// cboFrequency
			// 
			this.cboFrequency.FormattingEnabled = true;
			this.cboFrequency.Location = new System.Drawing.Point(117, 19);
			this.cboFrequency.Name = "cboFrequency";
			this.cboFrequency.Size = new System.Drawing.Size(121, 21);
			this.cboFrequency.TabIndex = 6;
			// 
			// lblFreq
			// 
			this.lblFreq.AutoSize = true;
			this.lblFreq.Location = new System.Drawing.Point(6, 22);
			this.lblFreq.Name = "lblFreq";
			this.lblFreq.Size = new System.Drawing.Size(57, 13);
			this.lblFreq.TabIndex = 0;
			this.lblFreq.Text = "Frequency";
			// 
			// lblNever
			// 
			this.lblNever.AutoSize = true;
			this.lblNever.Location = new System.Drawing.Point(6, 48);
			this.lblNever.Name = "lblNever";
			this.lblNever.Size = new System.Drawing.Size(70, 13);
			this.lblNever.TabIndex = 2;
			this.lblNever.Text = "Never Check";
			// 
			// chkNever
			// 
			this.chkNever.AutoSize = true;
			this.chkNever.Location = new System.Drawing.Point(117, 48);
			this.chkNever.Name = "chkNever";
			this.chkNever.Size = new System.Drawing.Size(126, 17);
			this.chkNever.TabIndex = 3;
			this.chkNever.Text = "Only Check Manually";
			this.chkNever.UseVisualStyleBackColor = true;
			// 
			// lblRemindAfter
			// 
			this.lblRemindAfter.AutoSize = true;
			this.lblRemindAfter.Location = new System.Drawing.Point(6, 74);
			this.lblRemindAfter.Name = "lblRemindAfter";
			this.lblRemindAfter.Size = new System.Drawing.Size(68, 13);
			this.lblRemindAfter.TabIndex = 4;
			this.lblRemindAfter.Text = "Remind After";
			// 
			// cboRemind
			// 
			this.cboRemind.FormattingEnabled = true;
			this.cboRemind.Location = new System.Drawing.Point(158, 70);
			this.cboRemind.Name = "cboRemind";
			this.cboRemind.Size = new System.Drawing.Size(80, 21);
			this.cboRemind.TabIndex = 6;
			// 
			// txtRemind
			// 
			this.txtRemind.Location = new System.Drawing.Point(117, 70);
			this.txtRemind.Name = "txtRemind";
			this.txtRemind.Size = new System.Drawing.Size(34, 20);
			this.txtRemind.TabIndex = 5;
			// 
			// tabAbout
			// 
			this.tabAbout.Controls.Add(this.lblProgram);
			this.tabAbout.Controls.Add(this.txtProgram);
			this.tabAbout.Controls.Add(this.lblUrl);
			this.tabAbout.Controls.Add(this.txtUrl);
			this.tabAbout.Controls.Add(this.lblSupport);
			this.tabAbout.Controls.Add(this.txtSupport);
			this.tabAbout.Location = new System.Drawing.Point(4, 22);
			this.tabAbout.Name = "tabAbout";
			this.tabAbout.Size = new System.Drawing.Size(253, 147);
			this.tabAbout.TabIndex = 1;
			this.tabAbout.Text = "About";
			this.tabAbout.UseVisualStyleBackColor = true;
			// 
			// lblProgram
			// 
			this.lblProgram.AutoSize = true;
			this.lblProgram.Location = new System.Drawing.Point(6, 22);
			this.lblProgram.Name = "lblProgram";
			this.lblProgram.Size = new System.Drawing.Size(77, 13);
			this.lblProgram.TabIndex = 0;
			this.lblProgram.Text = "Program Name";
			// 
			// txtProgram
			// 
			this.txtProgram.Location = new System.Drawing.Point(89, 19);
			this.txtProgram.Name = "txtProgram";
			this.txtProgram.Size = new System.Drawing.Size(151, 20);
			this.txtProgram.TabIndex = 1;
			// 
			// lblUrl
			// 
			this.lblUrl.AutoSize = true;
			this.lblUrl.Location = new System.Drawing.Point(6, 48);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(63, 13);
			this.lblUrl.TabIndex = 2;
			this.lblUrl.Text = "Updates Url";
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(89, 45);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(151, 20);
			this.txtUrl.TabIndex = 3;
			// 
			// lblSupport
			// 
			this.lblSupport.AutoSize = true;
			this.lblSupport.Location = new System.Drawing.Point(7, 74);
			this.lblSupport.Name = "lblSupport";
			this.lblSupport.Size = new System.Drawing.Size(44, 13);
			this.lblSupport.TabIndex = 4;
			this.lblSupport.Text = "Support";
			// 
			// txtSupport
			// 
			this.txtSupport.Location = new System.Drawing.Point(89, 71);
			this.txtSupport.Name = "txtSupport";
			this.txtSupport.Size = new System.Drawing.Size(151, 20);
			this.txtSupport.TabIndex = 5;
			// 
			// tabDates
			// 
			this.tabDates.Controls.Add(this.lblNext);
			this.tabDates.Controls.Add(this.txtNext);
			this.tabDates.Controls.Add(this.lblLast);
			this.tabDates.Controls.Add(this.txtLast);
			this.tabDates.Controls.Add(this.lblLastCheck);
			this.tabDates.Controls.Add(this.txtLastCheck);
			this.tabDates.Controls.Add(this.lblLastRemind);
			this.tabDates.Controls.Add(this.txtLastRemind);
			this.tabDates.Location = new System.Drawing.Point(4, 22);
			this.tabDates.Name = "tabDates";
			this.tabDates.Size = new System.Drawing.Size(253, 147);
			this.tabDates.TabIndex = 2;
			this.tabDates.Text = "Dates";
			this.tabDates.UseVisualStyleBackColor = true;
			// 
			// lblNext
			// 
			this.lblNext.AutoSize = true;
			this.lblNext.Location = new System.Drawing.Point(9, 22);
			this.lblNext.Name = "lblNext";
			this.lblNext.Size = new System.Drawing.Size(67, 13);
			this.lblNext.TabIndex = 0;
			this.lblNext.Text = "Next Update";
			// 
			// txtNext
			// 
			this.txtNext.Location = new System.Drawing.Point(117, 19);
			this.txtNext.Name = "txtNext";
			this.txtNext.Size = new System.Drawing.Size(123, 20);
			this.txtNext.TabIndex = 1;
			// 
			// lblLast
			// 
			this.lblLast.AutoSize = true;
			this.lblLast.Location = new System.Drawing.Point(9, 48);
			this.lblLast.Name = "lblLast";
			this.lblLast.Size = new System.Drawing.Size(65, 13);
			this.lblLast.TabIndex = 2;
			this.lblLast.Text = "Last Update";
			// 
			// txtLast
			// 
			this.txtLast.Location = new System.Drawing.Point(117, 45);
			this.txtLast.Name = "txtLast";
			this.txtLast.Size = new System.Drawing.Size(123, 20);
			this.txtLast.TabIndex = 3;
			// 
			// lblLastCheck
			// 
			this.lblLastCheck.AutoSize = true;
			this.lblLastCheck.Location = new System.Drawing.Point(9, 74);
			this.lblLastCheck.Name = "lblLastCheck";
			this.lblLastCheck.Size = new System.Drawing.Size(61, 13);
			this.lblLastCheck.TabIndex = 4;
			this.lblLastCheck.Text = "Last Check";
			// 
			// txtLastCheck
			// 
			this.txtLastCheck.Location = new System.Drawing.Point(117, 71);
			this.txtLastCheck.Name = "txtLastCheck";
			this.txtLastCheck.Size = new System.Drawing.Size(123, 20);
			this.txtLastCheck.TabIndex = 5;
			// 
			// lblLastRemind
			// 
			this.lblLastRemind.AutoSize = true;
			this.lblLastRemind.Location = new System.Drawing.Point(9, 100);
			this.lblLastRemind.Name = "lblLastRemind";
			this.lblLastRemind.Size = new System.Drawing.Size(66, 13);
			this.lblLastRemind.TabIndex = 6;
			this.lblLastRemind.Text = "Last Remind";
			// 
			// txtLastRemind
			// 
			this.txtLastRemind.Location = new System.Drawing.Point(117, 97);
			this.txtLastRemind.Name = "txtLastRemind";
			this.txtLastRemind.Size = new System.Drawing.Size(123, 20);
			this.txtLastRemind.TabIndex = 7;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabSettings);
			this.tabControl1.Controls.Add(this.tabDates);
			this.tabControl1.Controls.Add(this.tabAbout);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(10, 10);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(261, 173);
			this.tabControl1.TabIndex = 7;
			// 
			// ViewSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 193);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ViewSettings";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Updater Settings - ";
			this.tabSettings.ResumeLayout(false);
			this.tabSettings.PerformLayout();
			this.tabAbout.ResumeLayout(false);
			this.tabAbout.PerformLayout();
			this.tabDates.ResumeLayout(false);
			this.tabDates.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TabPage tabSettings;
		private System.Windows.Forms.TabPage tabAbout;
		private System.Windows.Forms.TabPage tabDates;
		private System.Windows.Forms.TextBox txtRemind;
		private System.Windows.Forms.Label lblRemindAfter;
		private System.Windows.Forms.Label lblNever;
		private System.Windows.Forms.Label lblFreq;
		private System.Windows.Forms.TextBox txtSupport;
		private System.Windows.Forms.Label lblSupport;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label lblUrl;
		private System.Windows.Forms.TextBox txtProgram;
		private System.Windows.Forms.Label lblProgram;
		private System.Windows.Forms.TextBox txtLastCheck;
		private System.Windows.Forms.Label lblLastCheck;
		private System.Windows.Forms.TextBox txtLast;
		private System.Windows.Forms.Label lblLast;
		private System.Windows.Forms.TextBox txtNext;
		private System.Windows.Forms.Label lblNext;
		private System.Windows.Forms.CheckBox chkNever;
		private System.Windows.Forms.Label lblLastRemind;
		private System.Windows.Forms.TextBox txtLastRemind;
		private System.Windows.Forms.ComboBox cboFrequency;
		private System.Windows.Forms.ComboBox cboRemind;
		private System.Windows.Forms.TabControl tabControl1;
	}
}