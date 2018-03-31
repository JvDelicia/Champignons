using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Champignons {
	public partial class frmLogin : Form {
		public frmLogin() {
			InitializeComponent();
			btnLog.Text = Properties.str.Log;
			btnLeave.Text = Properties.str.Leave;
			txtUser.Hint = Properties.str.User;
			txtPass.Hint = Properties.str.Pass;
		}

		private void frmLogin_Load( object sender, EventArgs e ) {
			txtUser.Focus();
		}

		private void btnLeave_Click( object sender, EventArgs e ) {
			if ( MessageBox.Show( Properties.str.ConfLeave, Properties.str.QuestLeave, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 ) == DialogResult.Yes ) {
				Application.Exit();
			} else {
				txtUser.Focus();
			}
		}

		private void btnLog_Click( object sender, EventArgs e ) {
			if ( txtUser.Text == "" ) {
				MessageBox.Show( Properties.str.UserError, Properties.str.Atent, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1 );
				txtUser.Focus();
			} else if ( txtPass.Text == "" ) {
				MessageBox.Show( Properties.str.PassError, Properties.str.Atent, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1 );
			} else {
				LogIn();
			}
		}

		private void txtUser_KeyPress( object sender, KeyPressEventArgs e ) {
			if ( e.KeyChar == 13 ) {
				if ( txtUser.Text == "" ) {
					MessageBox.Show( Properties.str.UserError, Properties.str.Atent, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1 );
					txtUser.Focus();
				} else if ( txtPass.Text == "" ) {
					MessageBox.Show( Properties.str.PassError, Properties.str.Atent, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1 );
				} else {
					LogIn();
				}
			}
		}

		private void txtPass_KeyPress( object sender, KeyPressEventArgs e ) {
			if ( e.KeyChar == 13 ) {
				if ( txtUser.Text == "" ) {
					MessageBox.Show( Properties.str.UserError, Properties.str.Atent, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1 );
					txtUser.Focus();
				} else if ( txtPass.Text == "" ) {
					MessageBox.Show( Properties.str.PassError, Properties.str.Atent, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1 );
				} else {
					LogIn();
				}
			}
		}

		private void LogIn() {
			frmMain Main = new frmMain();
			if ( ValLogIn() == 1 ) {
				Visible = false;
				Main.ShowDialog();
			} else if ( ValLogIn() == 2 ) {
				MessageBox.Show( Properties.str.LogError, Properties.str.Error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1 );
			}
		}

		private byte ValLogIn() {
			string sql = string.Empty, sconn = string.Empty;
			string usu, pwd;

			sconn = "server=sql46.main-hosting.eu;port=3306;uid=u477364118_champ;pwd=champpass99;database=u477364118_champ;sslmode=none;";

			MySqlConnection conn = new MySqlConnection( sconn );

			//try {
				usu = txtUser.Text;
				pwd = txtPass.Text;

				conn.Open();
				sql = "SELECT COUNT(Cod) FROM tbUser WHERE Usr = @Usr and Pss = @Pss";

				MySqlCommand cmd = new MySqlCommand( sql, conn );

				cmd.Parameters.Add( "@Usr", MySqlDbType.VarChar ).Value = usu;
				cmd.Parameters.Add( "@Pss", MySqlDbType.VarChar ).Value = pwd;

				long v = ( long ) cmd.ExecuteScalar();
			if ( v > 0 ) {
					conn.Close();
					return 1;
				} else {
					conn.Close();
					return 2;
				}
			//} catch ( Exception e ) {
			//	MessageBox.Show( Properties.str.ConnError, Properties.str.Error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1 );
			//	MessageBox.Show( e.Message, Properties.str.Error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1 );
			//	try { conn.Close(); } catch { }
			//	return 0;
			//}
		}

		private void btnLog_KeyPress( object sender, KeyPressEventArgs e ) { }
	}
}
