namespace Champignons
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblPass = new System.Windows.Forms.Label();
			this.btnLeave = new System.Windows.Forms.Button();
			this.btnLog = new System.Windows.Forms.Button();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Champignons.Properties.Resources._67_85312;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// lblUser
			// 
			resources.ApplyResources(this.lblUser, "lblUser");
			this.lblUser.Name = "lblUser";
			// 
			// lblPass
			// 
			resources.ApplyResources(this.lblPass, "lblPass");
			this.lblPass.Name = "lblPass";
			// 
			// btnLeave
			// 
			resources.ApplyResources(this.btnLeave, "btnLeave");
			this.btnLeave.Name = "btnLeave";
			this.btnLeave.UseVisualStyleBackColor = true;
			// 
			// btnLog
			// 
			resources.ApplyResources(this.btnLog, "btnLog");
			this.btnLog.Name = "btnLog";
			this.btnLog.UseVisualStyleBackColor = true;
			// 
			// txtUser
			// 
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.txtUser, "txtUser");
			this.txtUser.Name = "txtUser";
			// 
			// txtPass
			// 
			resources.ApplyResources(this.txtPass, "txtPass");
			this.txtPass.Name = "txtPass";
			// 
			// frmLogin
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.LightCoral;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.btnLog);
			this.Controls.Add(this.btnLeave);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.Button btnLeave;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
	}
}