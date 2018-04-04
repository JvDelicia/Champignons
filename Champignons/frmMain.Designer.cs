namespace Champignons {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
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
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.pnl1 = new System.Windows.Forms.Panel();
			this.pnl2 = new System.Windows.Forms.Panel();
			this.lblQst1 = new MaterialSkin.Controls.MaterialLabel();
			this.lblLvl1 = new System.Windows.Forms.Label();
			this.prgLoad = new MaterialSkin.Controls.MaterialProgressBar();
			this.btnYes = new MaterialSkin.Controls.MaterialFlatButton();
			this.lblWel7 = new MaterialSkin.Controls.MaterialLabel();
			this.lblWel6 = new MaterialSkin.Controls.MaterialLabel();
			this.lblWel5 = new MaterialSkin.Controls.MaterialLabel();
			this.lblWel4 = new MaterialSkin.Controls.MaterialLabel();
			this.lblWel3 = new MaterialSkin.Controls.MaterialLabel();
			this.lblWel2 = new MaterialSkin.Controls.MaterialLabel();
			this.lblWel1 = new MaterialSkin.Controls.MaterialLabel();
			this.btnGo = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tmrPrg = new System.Windows.Forms.Timer(this.components);
			this.tmrStt = new System.Windows.Forms.Timer(this.components);
			this.pnl1.SuspendLayout();
			this.pnl2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl1
			// 
			this.pnl1.Controls.Add(this.pnl2);
			this.pnl1.Controls.Add(this.prgLoad);
			this.pnl1.Controls.Add(this.btnYes);
			this.pnl1.Controls.Add(this.lblWel7);
			this.pnl1.Controls.Add(this.lblWel6);
			this.pnl1.Controls.Add(this.lblWel5);
			this.pnl1.Controls.Add(this.lblWel4);
			this.pnl1.Controls.Add(this.lblWel3);
			this.pnl1.Controls.Add(this.lblWel2);
			this.pnl1.Controls.Add(this.lblWel1);
			this.pnl1.Controls.Add(this.btnGo);
			this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl1.Location = new System.Drawing.Point(0, 0);
			this.pnl1.Name = "pnl1";
			this.pnl1.Size = new System.Drawing.Size(800, 500);
			this.pnl1.TabIndex = 0;
			// 
			// pnl2
			// 
			this.pnl2.Controls.Add(this.lblQst1);
			this.pnl2.Controls.Add(this.lblLvl1);
			this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl2.Location = new System.Drawing.Point(0, 0);
			this.pnl2.Name = "pnl2";
			this.pnl2.Size = new System.Drawing.Size(800, 459);
			this.pnl2.TabIndex = 1;
			this.pnl2.Visible = false;
			// 
			// lblQst1
			// 
			this.lblQst1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblQst1.AutoSize = true;
			this.lblQst1.Depth = 0;
			this.lblQst1.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblQst1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblQst1.Location = new System.Drawing.Point(1, 138);
			this.lblQst1.MaximumSize = new System.Drawing.Size(800, 0);
			this.lblQst1.MinimumSize = new System.Drawing.Size(800, 0);
			this.lblQst1.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblQst1.Name = "lblQst1";
			this.lblQst1.Size = new System.Drawing.Size(800, 19);
			this.lblQst1.TabIndex = 1;
			this.lblQst1.Text = "materialLabel1";
			this.lblQst1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLvl1
			// 
			this.lblLvl1.AutoSize = true;
			this.lblLvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLvl1.Location = new System.Drawing.Point(0, 9);
			this.lblLvl1.MaximumSize = new System.Drawing.Size(800, 0);
			this.lblLvl1.MinimumSize = new System.Drawing.Size(800, 0);
			this.lblLvl1.Name = "lblLvl1";
			this.lblLvl1.Size = new System.Drawing.Size(800, 25);
			this.lblLvl1.TabIndex = 0;
			this.lblLvl1.Text = "label1";
			this.lblLvl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// prgLoad
			// 
			this.prgLoad.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.prgLoad.Depth = 0;
			this.prgLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.prgLoad.Location = new System.Drawing.Point(0, 459);
			this.prgLoad.MouseState = MaterialSkin.MouseState.HOVER;
			this.prgLoad.Name = "prgLoad";
			this.prgLoad.Size = new System.Drawing.Size(800, 5);
			this.prgLoad.TabIndex = 9;
			this.prgLoad.Visible = false;
			// 
			// btnYes
			// 
			this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnYes.AutoSize = true;
			this.btnYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnYes.Depth = 0;
			this.btnYes.Icon = null;
			this.btnYes.Location = new System.Drawing.Point(0, 338);
			this.btnYes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnYes.MaximumSize = new System.Drawing.Size(800, 0);
			this.btnYes.MinimumSize = new System.Drawing.Size(800, 0);
			this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnYes.Name = "btnYes";
			this.btnYes.Primary = false;
			this.btnYes.Size = new System.Drawing.Size(800, 36);
			this.btnYes.TabIndex = 8;
			this.btnYes.UseVisualStyleBackColor = true;
			this.btnYes.Visible = false;
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// lblWel7
			// 
			this.lblWel7.AutoSize = true;
			this.lblWel7.Depth = 0;
			this.lblWel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWel7.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblWel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblWel7.Location = new System.Drawing.Point(0, 430);
			this.lblWel7.MaximumSize = new System.Drawing.Size(800, 0);
			this.lblWel7.MinimumSize = new System.Drawing.Size(800, 0);
			this.lblWel7.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblWel7.Name = "lblWel7";
			this.lblWel7.Size = new System.Drawing.Size(800, 19);
			this.lblWel7.TabIndex = 7;
			this.lblWel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWel7.UseMnemonic = false;
			// 
			// lblWel6
			// 
			this.lblWel6.AutoSize = true;
			this.lblWel6.Depth = 0;
			this.lblWel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWel6.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblWel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblWel6.Location = new System.Drawing.Point(0, 313);
			this.lblWel6.MaximumSize = new System.Drawing.Size(800, 0);
			this.lblWel6.MinimumSize = new System.Drawing.Size(800, 0);
			this.lblWel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblWel6.Name = "lblWel6";
			this.lblWel6.Size = new System.Drawing.Size(800, 19);
			this.lblWel6.TabIndex = 6;
			this.lblWel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWel6.UseMnemonic = false;
			// 
			// lblWel5
			// 
			this.lblWel5.AutoSize = true;
			this.lblWel5.Depth = 0;
			this.lblWel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWel5.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblWel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblWel5.Location = new System.Drawing.Point(0, 209);
			this.lblWel5.MaximumSize = new System.Drawing.Size(800, 0);
			this.lblWel5.MinimumSize = new System.Drawing.Size(800, 0);
			this.lblWel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblWel5.Name = "lblWel5";
			this.lblWel5.Size = new System.Drawing.Size(800, 19);
			this.lblWel5.TabIndex = 4;
			this.lblWel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWel5.UseMnemonic = false;
			// 
			// lblWel4
			// 
			this.lblWel4.AutoSize = true;
			this.lblWel4.Depth = 0;
			this.lblWel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWel4.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblWel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblWel4.Location = new System.Drawing.Point(0, 173);
			this.lblWel4.MaximumSize = new System.Drawing.Size(800, 0);
			this.lblWel4.MinimumSize = new System.Drawing.Size(800, 0);
			this.lblWel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblWel4.Name = "lblWel4";
			this.lblWel4.Size = new System.Drawing.Size(800, 19);
			this.lblWel4.TabIndex = 3;
			this.lblWel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWel4.UseMnemonic = false;
			// 
			// lblWel3
			// 
			this.lblWel3.AutoSize = true;
			this.lblWel3.Depth = 0;
			this.lblWel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblWel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblWel3.Location = new System.Drawing.Point(0, 138);
			this.lblWel3.MaximumSize = new System.Drawing.Size(800, 0);
			this.lblWel3.MinimumSize = new System.Drawing.Size(800, 0);
			this.lblWel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblWel3.Name = "lblWel3";
			this.lblWel3.Size = new System.Drawing.Size(800, 19);
			this.lblWel3.TabIndex = 2;
			this.lblWel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWel3.UseMnemonic = false;
			// 
			// lblWel2
			// 
			this.lblWel2.AutoSize = true;
			this.lblWel2.Depth = 0;
			this.lblWel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblWel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblWel2.Location = new System.Drawing.Point(0, 75);
			this.lblWel2.MaximumSize = new System.Drawing.Size(800, 0);
			this.lblWel2.MinimumSize = new System.Drawing.Size(800, 0);
			this.lblWel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblWel2.Name = "lblWel2";
			this.lblWel2.Size = new System.Drawing.Size(800, 19);
			this.lblWel2.TabIndex = 1;
			this.lblWel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWel2.UseMnemonic = false;
			// 
			// lblWel1
			// 
			this.lblWel1.AutoSize = true;
			this.lblWel1.Depth = 0;
			this.lblWel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblWel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblWel1.Location = new System.Drawing.Point(0, 38);
			this.lblWel1.MaximumSize = new System.Drawing.Size(800, 0);
			this.lblWel1.MinimumSize = new System.Drawing.Size(800, 0);
			this.lblWel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblWel1.Name = "lblWel1";
			this.lblWel1.Size = new System.Drawing.Size(800, 19);
			this.lblWel1.TabIndex = 0;
			this.lblWel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWel1.UseMnemonic = false;
			// 
			// btnGo
			// 
			this.btnGo.AutoSize = true;
			this.btnGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGo.Depth = 0;
			this.btnGo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnGo.Icon = null;
			this.btnGo.Location = new System.Drawing.Point(0, 464);
			this.btnGo.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnGo.Name = "btnGo";
			this.btnGo.Primary = true;
			this.btnGo.Size = new System.Drawing.Size(800, 36);
			this.btnGo.TabIndex = 10;
			this.btnGo.Text = "GO!";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Visible = false;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// tmrPrg
			// 
			this.tmrPrg.Interval = 1000;
			this.tmrPrg.Tick += new System.EventHandler(this.tmrPrg_Tick);
			// 
			// tmrStt
			// 
			this.tmrStt.Interval = 10000;
			this.tmrStt.Tick += new System.EventHandler(this.tmrStt_Tick);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.pnl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(800, 500);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Champignons";
			this.pnl1.ResumeLayout(false);
			this.pnl1.PerformLayout();
			this.pnl2.ResumeLayout(false);
			this.pnl2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl1;
		private MaterialSkin.Controls.MaterialLabel lblWel1;
		private MaterialSkin.Controls.MaterialLabel lblWel5;
		private MaterialSkin.Controls.MaterialLabel lblWel4;
		private MaterialSkin.Controls.MaterialLabel lblWel3;
		private MaterialSkin.Controls.MaterialLabel lblWel2;
		private MaterialSkin.Controls.MaterialLabel lblWel7;
		private MaterialSkin.Controls.MaterialLabel lblWel6;
		private MaterialSkin.Controls.MaterialProgressBar prgLoad;
		private MaterialSkin.Controls.MaterialFlatButton btnYes;
		private System.Windows.Forms.Timer tmrPrg;
		private System.Windows.Forms.Timer tmrStt;
		private MaterialSkin.Controls.MaterialRaisedButton btnGo;
		private System.Windows.Forms.Panel pnl2;
		private System.Windows.Forms.Label lblLvl1;
		private MaterialSkin.Controls.MaterialLabel lblQst1;
	}
}