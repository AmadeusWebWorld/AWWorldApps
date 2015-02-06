namespace Cselian.ScheduleCatcher
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
			this.txtX = new System.Windows.Forms.TextBox();
			this.lblX = new System.Windows.Forms.Label();
			this.txtY = new System.Windows.Forms.TextBox();
			this.lblH = new System.Windows.Forms.Label();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.lblW = new System.Windows.Forms.Label();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.txtColor = new System.Windows.Forms.TextBox();
			this.btnColor = new System.Windows.Forms.Button();
			this.lblY = new System.Windows.Forms.Label();
			this.btnArea = new System.Windows.Forms.Button();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.txtCol = new System.Windows.Forms.TextBox();
			this.btnTest = new System.Windows.Forms.Button();
			this.lblMsg = new System.Windows.Forms.Label();
			this.txtMouseCol = new System.Windows.Forms.TextBox();
			this.chkTrack = new System.Windows.Forms.CheckBox();
			this.txtStep = new System.Windows.Forms.TextBox();
			this.lblStep = new System.Windows.Forms.Label();
			this.lblWhere = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtX
			// 
			this.txtX.BackColor = System.Drawing.SystemColors.Window;
			this.txtX.Location = new System.Drawing.Point(62, 121);
			this.txtX.Name = "txtX";
			this.txtX.ReadOnly = true;
			this.txtX.Size = new System.Drawing.Size(37, 20);
			this.txtX.TabIndex = 10;
			// 
			// lblX
			// 
			this.lblX.AutoSize = true;
			this.lblX.Location = new System.Drawing.Point(42, 124);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(14, 13);
			this.lblX.TabIndex = 9;
			this.lblX.Text = "X";
			// 
			// txtY
			// 
			this.txtY.BackColor = System.Drawing.SystemColors.Window;
			this.txtY.Location = new System.Drawing.Point(164, 121);
			this.txtY.Name = "txtY";
			this.txtY.ReadOnly = true;
			this.txtY.Size = new System.Drawing.Size(37, 20);
			this.txtY.TabIndex = 14;
			// 
			// lblH
			// 
			this.lblH.AutoSize = true;
			this.lblH.Location = new System.Drawing.Point(18, 153);
			this.lblH.Name = "lblH";
			this.lblH.Size = new System.Drawing.Size(38, 13);
			this.lblH.TabIndex = 11;
			this.lblH.Text = "Height";
			// 
			// txtHeight
			// 
			this.txtHeight.BackColor = System.Drawing.SystemColors.Window;
			this.txtHeight.Location = new System.Drawing.Point(62, 150);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.ReadOnly = true;
			this.txtHeight.Size = new System.Drawing.Size(37, 20);
			this.txtHeight.TabIndex = 12;
			// 
			// lblW
			// 
			this.lblW.AutoSize = true;
			this.lblW.Location = new System.Drawing.Point(123, 153);
			this.lblW.Name = "lblW";
			this.lblW.Size = new System.Drawing.Size(35, 13);
			this.lblW.TabIndex = 15;
			this.lblW.Text = "Width";
			// 
			// txtWidth
			// 
			this.txtWidth.BackColor = System.Drawing.SystemColors.Window;
			this.txtWidth.Location = new System.Drawing.Point(164, 150);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.ReadOnly = true;
			this.txtWidth.Size = new System.Drawing.Size(37, 20);
			this.txtWidth.TabIndex = 16;
			// 
			// txtColor
			// 
			this.txtColor.BackColor = System.Drawing.SystemColors.Window;
			this.txtColor.Location = new System.Drawing.Point(62, 216);
			this.txtColor.Name = "txtColor";
			this.txtColor.ReadOnly = true;
			this.txtColor.Size = new System.Drawing.Size(77, 20);
			this.txtColor.TabIndex = 19;
			// 
			// btnColor
			// 
			this.btnColor.Location = new System.Drawing.Point(45, 187);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(67, 23);
			this.btnColor.TabIndex = 17;
			this.btnColor.Text = "&Color:";
			this.btnColor.UseVisualStyleBackColor = true;
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// lblY
			// 
			this.lblY.AutoSize = true;
			this.lblY.Location = new System.Drawing.Point(144, 124);
			this.lblY.Name = "lblY";
			this.lblY.Size = new System.Drawing.Size(14, 13);
			this.lblY.TabIndex = 13;
			this.lblY.Text = "Y";
			// 
			// btnArea
			// 
			this.btnArea.Location = new System.Drawing.Point(45, 92);
			this.btnArea.Name = "btnArea";
			this.btnArea.Size = new System.Drawing.Size(67, 23);
			this.btnArea.TabIndex = 8;
			this.btnArea.Text = "&Area:";
			this.btnArea.UseVisualStyleBackColor = true;
			this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
			// 
			// btnStartStop
			// 
			this.btnStartStop.Location = new System.Drawing.Point(22, 12);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(90, 23);
			this.btnStartStop.TabIndex = 0;
			this.btnStartStop.Text = "[[&Start]]";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
			// 
			// txtCol
			// 
			this.txtCol.BackColor = System.Drawing.SystemColors.Window;
			this.txtCol.Location = new System.Drawing.Point(118, 190);
			this.txtCol.Name = "txtCol";
			this.txtCol.ReadOnly = true;
			this.txtCol.Size = new System.Drawing.Size(21, 20);
			this.txtCol.TabIndex = 18;
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(126, 12);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 1;
			this.btnTest.Text = "&Test";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// lblMsg
			// 
			this.lblMsg.Location = new System.Drawing.Point(45, 68);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(156, 13);
			this.lblMsg.TabIndex = 0;
			this.lblMsg.Text = "started at ";
			// 
			// txtMouseCol
			// 
			this.txtMouseCol.BackColor = System.Drawing.SystemColors.Window;
			this.txtMouseCol.Location = new System.Drawing.Point(164, 190);
			this.txtMouseCol.Name = "txtMouseCol";
			this.txtMouseCol.ReadOnly = true;
			this.txtMouseCol.Size = new System.Drawing.Size(21, 20);
			this.txtMouseCol.TabIndex = 2;
			// 
			// chkTrack
			// 
			this.chkTrack.AutoSize = true;
			this.chkTrack.Location = new System.Drawing.Point(45, 43);
			this.chkTrack.Name = "chkTrack";
			this.chkTrack.Size = new System.Drawing.Size(50, 17);
			this.chkTrack.TabIndex = 3;
			this.chkTrack.Text = "track";
			this.chkTrack.UseVisualStyleBackColor = true;
			// 
			// txtStep
			// 
			this.txtStep.BackColor = System.Drawing.SystemColors.Window;
			this.txtStep.Location = new System.Drawing.Point(164, 41);
			this.txtStep.Name = "txtStep";
			this.txtStep.Size = new System.Drawing.Size(37, 20);
			this.txtStep.TabIndex = 5;
			this.txtStep.Text = "5";
			// 
			// lblStep
			// 
			this.lblStep.AutoSize = true;
			this.lblStep.Location = new System.Drawing.Point(131, 44);
			this.lblStep.Name = "lblStep";
			this.lblStep.Size = new System.Drawing.Size(27, 13);
			this.lblStep.TabIndex = 4;
			this.lblStep.Text = "step";
			// 
			// lblWhere
			// 
			this.lblWhere.AutoSize = true;
			this.lblWhere.Location = new System.Drawing.Point(146, 219);
			this.lblWhere.Name = "lblWhere";
			this.lblWhere.Size = new System.Drawing.Size(57, 13);
			this.lblWhere.TabIndex = 6;
			this.lblWhere.Text = "@701,555";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(215, 246);
			this.Controls.Add(this.chkTrack);
			this.Controls.Add(this.lblWhere);
			this.Controls.Add(this.lblMsg);
			this.Controls.Add(this.btnStartStop);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.btnArea);
			this.Controls.Add(this.lblX);
			this.Controls.Add(this.txtX);
			this.Controls.Add(this.lblStep);
			this.Controls.Add(this.lblY);
			this.Controls.Add(this.txtStep);
			this.Controls.Add(this.txtY);
			this.Controls.Add(this.lblH);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.lblW);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.btnColor);
			this.Controls.Add(this.txtCol);
			this.Controls.Add(this.txtColor);
			this.Controls.Add(this.txtMouseCol);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Main";
			this.Text = "Schedule Catcher";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.Label lblH;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.Label lblW;
		private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.TextBox txtColor;
		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.Button btnArea;
		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.TextBox txtCol;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.TextBox txtMouseCol;
		private System.Windows.Forms.CheckBox chkTrack;
		private System.Windows.Forms.TextBox txtStep;
		private System.Windows.Forms.Label lblStep;
		private System.Windows.Forms.Label lblWhere;
	}
}