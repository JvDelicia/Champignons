using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Champignons {
	public partial class frmSplash : Form {
		public frmSplash() {
			InitializeComponent();
			lblDir.Text = Properties.str.Rights;
		}

		private void label1_Click( object sender, EventArgs e ) { }

		private void lblDir_Click( object sender, EventArgs e ) { }

		private void frmSplash_Load( object sender, EventArgs e ) {
			SoundPlayer snpLoad = new SoundPlayer( Properties.Resources.sndLoad );
			//snpLoad.Play();
		}

		private void tmrSplash_Tick( object sender, EventArgs e ) {
			tmrSplash.Enabled = false;
			Visible = false;
			frmLogin login = new frmLogin();
			login.ShowDialog();
		}
	}
}

