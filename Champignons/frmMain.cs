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
			lblLvl1.Text = Properties.str.Lvl1.ToUpper();
			lblQst1.Text = Properties.str.Qst1;
			bntQ11.Text = Properties.str.Qst1Res1;
			bntQ12.Text = Properties.str.Qst1Res2;
			bntQ13.Text = Properties.str.Qst1Res3;
			bntQ14.Text = Properties.str.Qst1Res4;
			lblLvl2.Text = Properties.str.Lvl2.ToUpper();
			lblQst2.Text = Properties.str.Qst2;
			btnQ21.Text = Properties.str.Qst2Res1;
			btnQ22.Text = Properties.str.Qst2Res2;
			btnQ23.Text = Properties.str.Qst2Res3;
			btnQ24.Text = Properties.str.Qst2Res4;
			lblLvl3.Text = Properties.str.Lvl3.ToUpper();
			lblQst3.Text = Properties.str.Qst3;
			btnQst3.Text = Properties.str.Qst3Res;
			lblLvl4.Text = Properties.str.Lvl4.ToUpper();
			lblQst4.Text = Properties.str.Qst4;
			btnQst4.Text = Properties.str.Qst3Res;
			lblLvl5.Text = Properties.str.Lvl5.ToUpper();
			lblQst5.Text = Properties.str.Qst5;
			btnQst5.Text = Properties.str.Qst3Res;
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

		private void Wrong() {
			MessageBox.Show( Properties.str.SRRY, Properties.str.Wng, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1 );
		}

		private void bntQ11_Click( object sender, EventArgs e ) {
			Wrong();
		}

		private void bntQ12_Click( object sender, EventArgs e ) {
			Wrong();
		}

		private void bntQ14_Click( object sender, EventArgs e ) {
			Wrong();
		}

		private void bntQ13_Click( object sender, EventArgs e ) {
			pnl2.Visible = false;
			pnl3.Visible = true;
		}

		private void btnQ21_Click( object sender, EventArgs e ) {
			Wrong();
			pnl3.Visible = false;
			pnl2.Visible = true;
		}

		private void btnQ23_Click( object sender, EventArgs e ) {
			Wrong();
			pnl3.Visible = false;
			pnl2.Visible = true;
		}

		private void btnQ24_Click( object sender, EventArgs e ) {
			Wrong();
			pnl3.Visible = false;
			pnl2.Visible = true;
		}

		private void btnQ22_Click( object sender, EventArgs e ) {
			pnl3.Visible = false;
			pnl4.Visible = true;
		}

		private void btnQst3_Click( object sender, EventArgs e ) {
			if ( txtQst3.Text.ToUpper().Equals("ATEISM") ) {
				pnl4.Visible = false;
				pnl5.Visible = true;
			} else {
				Wrong();
				pnl4.Visible = false;
				pnl2.Visible = true;
			}
		}

		private void btnQst4_Click( object sender, EventArgs e ) {
			if ( txtQst4.Text.ToUpper().Equals( "HISTORY" ) ) {
				pnl5.Visible = false;
				pnl6.Visible = true;
			} else {
				Wrong();
				pnl5.Visible = false;
				pnl2.Visible = true;
			}
		}

		private void btnQst5_Click( object sender, EventArgs e ) {
			if ( txtQst4.Text.ToUpper().Equals( "HISTORY" ) ) {
				Win();
			} else {
				Wrong();
				pnl6.Visible = false;
				pnl2.Visible = true;
			}
		}

		private void Win() {
			MessageBox.Show( "CONGRATULATIONS!!!!\nYOU WIN THE GAME!\n\n\n\nnow your computer will shutdown :)", "You Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1 );
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "shutdown /h";
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
