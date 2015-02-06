namespace Cselian.ScheduleCatcher
{
    partial class Area
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
			this.btnSelect = new System.Windows.Forms.Button();
			this.picRegion = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picRegion)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSelect.Location = new System.Drawing.Point(0, 236);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(259, 23);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// picRegion
			// 
			this.picRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.picRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picRegion.Location = new System.Drawing.Point(0, 0);
			this.picRegion.Name = "picRegion";
			this.picRegion.Size = new System.Drawing.Size(282, 230);
			this.picRegion.TabIndex = 2;
			this.picRegion.TabStop = false;
			// 
			// Area
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.picRegion);
			this.Controls.Add(this.btnSelect);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Area";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Select Screen Area";
			((System.ComponentModel.ISupportInitialize)(this.picRegion)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.PictureBox picRegion;

	}
}

