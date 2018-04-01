using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Champignons {
	public partial class frmMain : Form {
		public frmMain() {
			InitializeComponent();

			lblWel1.Text = Properties.str.Wel1 + "JADESON";
			lblWel2.Text = Properties.str.Wel2;
			lblWel3.Text = Properties.str.Wel3;
			lblWel4.Text = Properties.str.Wel4;
			lblWel5.Text = Properties.str.Wel5;
			lblWel6.Text = Properties.str.Wel6;
			btnYes.Text = Properties.str.BtnY;
			btnYes.Visible = true;
		}

		private void btnYes_Click( object sender, EventArgs e ) {
			lblWel7.Text = Properties.str.Wel7;
			pnl1.Cursor = Cursors.AppStarting;
			prgLoad.Visible = true;
			tmrPrg.Start();
			tmrStt.Start();
		}

		private void tmrPrg_Tick( object sender, EventArgs e ) {
			prgLoad.Increment( 10 );
		}

		private void tmrStt_Tick( object sender, EventArgs e ) {
			btnGo.Visible = true;
			pnl1.Cursor = Cursors.Default;
			lblWel7.Visible = false;
			prgLoad.Visible = false;
		}

		private void btnGo_Click( object sender, EventArgs e ) {
			pnl1.Visible = false;
			pnl2.Visible = true;
		}
	}
}
