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
			this.dvsLog = new MaterialSkin.Controls.MaterialDivider();
			this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btnLog = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnLeave = new MaterialSkin.Controls.MaterialRaisedButton();
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
			// dvsLog
			// 
			this.dvsLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.dvsLog.Depth = 0;
			resources.ApplyResources(this.dvsLog, "dvsLog");
			this.dvsLog.MouseState = MaterialSkin.MouseState.HOVER;
			this.dvsLog.Name = "dvsLog";
			// 
			// txtUser
			// 
			this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUser.Depth = 0;
			this.txtUser.Hint = "";
			resources.ApplyResources(this.txtUser, "txtUser");
			this.txtUser.MaxLength = 32767;
			this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtUser.Name = "txtUser";
			this.txtUser.PasswordChar = '\0';
			this.txtUser.SelectedText = "";
			this.txtUser.SelectionLength = 0;
			this.txtUser.SelectionStart = 0;
			this.txtUser.TabStop = false;
			this.txtUser.UseSystemPasswordChar = false;
			this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
			// 
			// txtPass
			// 
			this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPass.Depth = 0;
			this.txtPass.Hint = "";
			resources.ApplyResources(this.txtPass, "txtPass");
			this.txtPass.MaxLength = 32767;
			this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '\0';
			this.txtPass.SelectedText = "";
			this.txtPass.SelectionLength = 0;
			this.txtPass.SelectionStart = 0;
			this.txtPass.TabStop = false;
			this.txtPass.UseSystemPasswordChar = true;
			// 
			// btnLog
			// 
			resources.ApplyResources(this.btnLog, "btnLog");
			this.btnLog.Depth = 0;
			this.btnLog.Icon = null;
			this.btnLog.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnLog.Name = "btnLog";
			this.btnLog.Primary = true;
			this.btnLog.UseVisualStyleBackColor = true;
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			this.btnLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLog_KeyPress);
			// 
			// btnLeave
			// 
			resources.ApplyResources(this.btnLeave, "btnLeave");
			this.btnLeave.Depth = 0;
			this.btnLeave.Icon = null;
			this.btnLeave.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnLeave.Name = "btnLeave";
			this.btnLeave.Primary = true;
			this.btnLeave.UseVisualStyleBackColor = true;
			this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.LightCoral;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.btnLeave);
			this.Controls.Add(this.btnLog);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dvsLog);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private MaterialSkin.Controls.MaterialDivider dvsLog;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
		private MaterialSkin.Controls.MaterialRaisedButton btnLog;
		private MaterialSkin.Controls.MaterialRaisedButton btnLeave;
	}
}