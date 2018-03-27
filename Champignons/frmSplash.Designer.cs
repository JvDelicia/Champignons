namespace Champignons
{
	partial class frmSplash
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.tmrSnd = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblDir = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// picLogo
			// 
			this.picLogo.Image = global::Champignons.Properties.Resources._67_85312;
			this.picLogo.Location = new System.Drawing.Point(43, 12);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(310, 204);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Champignons.Properties.Resources.Load;
			this.pictureBox1.Location = new System.Drawing.Point(92, 246);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(207, 161);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// lblDir
			// 
			this.lblDir.AutoSize = true;
			this.lblDir.Location = new System.Drawing.Point(177, 497);
			this.lblDir.Name = "lblDir";
			this.lblDir.Size = new System.Drawing.Size(35, 13);
			this.lblDir.TabIndex = 2;
			this.lblDir.Text = "label1";
			this.lblDir.Click += new System.EventHandler(this.lblDir_Click);
			// 
			// frmSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(402, 519);
			this.Controls.Add(this.lblDir);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.picLogo);
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmSplash";
			this.Text = "Splash Screen";
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Timer tmrSnd;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblDir;
	}
}

