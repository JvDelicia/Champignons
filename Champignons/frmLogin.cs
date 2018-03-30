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
				MessageBox.Show( "Você precisa digitar um usuário!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1 );
				txtUser.Focus();
			} else if ( txtPass.Text == "" ) {
				MessageBox.Show( "Você precisa digitar uma senha!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1 );
			} else {
				LogIn();
			}
		}

		private void LogIn() {
			frmMain Main = new frmMain();
			if ( ValLogIn() ) {
				Visible = false;
				Main.ShowDialog();
			} else {
				MessageBox.Show( "O Usuário/Senha está incorreto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1 );
			}
		}

		private bool ValLogIn() {
			SqlConnection sqlConn = null;
			string _Sql = string.Empty;

			sqlConn = new SqlConnection( Properties.Settings.Default.cs1 );
			string usu, pwd;

			usu = txtUser.Text;
			pwd = txtPass.Text;

			_Sql = "SELECT COUNT(CodFnc) FROM tbFnc WHERE UsernameFnc = @User and PssFnc = @Pass";

			try {
				sqlConn.Open();
			} catch {
				MessageBox.Show( "Ocorreu um erro em conectar. A conexão ao Banco de Dados não funcionou!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1 );
			}

			SqlCommand cmd = new SqlCommand( _Sql, sqlConn );

			cmd.Parameters.Add( "@User", SqlDbType.VarChar ).Value = usu;
			cmd.Parameters.Add( "@Pass", SqlDbType.VarChar ).Value = pwd;

			int v = ( int ) cmd.ExecuteScalar();

			if ( v > 0 ) {
				return true;
			} else {
				return false;
			}
			sqlConn.Close();
		}
	}
}
