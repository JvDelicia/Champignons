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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
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
			resources.ApplyResources(this.picLogo, "picLogo");
			this.picLogo.Image = global::Champignons.Properties.Resources._67_85312;
			this.picLogo.Name = "picLogo";
			this.picLogo.TabStop = false;
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Image = global::Champignons.Properties.Resources.Load;
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// lblDir
			// 
			resources.ApplyResources(this.lblDir, "lblDir");
			this.lblDir.Name = "lblDir";
			this.lblDir.Click += new System.EventHandler(this.lblDir_Click);
			// 
			// frmSplash
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ControlBox = false;
			this.Controls.Add(this.lblDir);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.picLogo);
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSplash";
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

