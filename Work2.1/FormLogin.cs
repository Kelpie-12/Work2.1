using System;
using System.Drawing;
using System.Windows.Forms;
using Common.Cache;
using Domen2;

namespace Work2._1
{
	public partial class FormLogin : Form
	{
		//[DllImport("user32.dll", EntryPoint = "ReleaseCapure")]
		//private extern static void ReleaseCapture();
		//[DllImport("user32.dll", EntryPoint = "SendMessage")]
		//private extern static void SendMessage(IntPtr hwnd, int msg, int wparam, int lparam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		public FormLogin()
		{
			InitializeComponent();
		}

		private void tBoxUserName_Enter(object sender, EventArgs e)
		{
			if (tBoxUserName.Text == "Username")
			{
				tBoxUserName.Text = "";
				tBoxUserName.ForeColor = Color.LightGray;
			}
		}

		private void tBoxUserName_Leave(object sender, EventArgs e)
		{
			if (tBoxUserName.Text == "")
			{
				tBoxUserName.Text = "Username";
				tBoxUserName.ForeColor = Color.DimGray;
			}
		}

		private void tBoxPassword_Enter(object sender, EventArgs e)
		{
			if (tBoxPassword.Text == "Password")
			{
				tBoxPassword.Text = "";
				tBoxPassword.ForeColor = Color.LightGray;
				tBoxPassword.UseSystemPasswordChar = true;
			}
		}

		private void tBoxPassword_Leave(object sender, EventArgs e)
		{
			if (tBoxPassword.Text == "")
			{
				tBoxPassword.Text = "Password";
				tBoxPassword.ForeColor = Color.LightGray;
				tBoxPassword.UseSystemPasswordChar = false;
			}
		}

		private void pBClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pBMinimazed_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			if (tBoxUserName.Text != "Username" && tBoxUserName.TextLength > 2)
			{
				if (tBoxPassword.Text != "Password")
				{
					UserModel user = new UserModel();
					var validLogin = user.LoginUser(tBoxUserName.Text, tBoxPassword.Text);
					if (validLogin == true)
					{
						FormPrincipal mainMenu = new FormPrincipal();
						//	MessageBox.Show("Welcome\n"+UserLoginCache.FirstName+" "+UserLoginCache.LastName);
						mainMenu.Show();
						mainMenu.FormClosed += Logout;
						this.Hide();
					}
					else
					{
						if (UserLoginCache.Archive == 0 && UserLoginCache.Position == 2)
							msgError("This user does not have access rights \nTry again.");
						else
							msgError("Incorrect username ore password \nTry again.");

						tBoxPassword.Text = "Password";
						tBoxPassword.UseSystemPasswordChar = false;
						tBoxUserName.Focus();

					}
				}
				else msgError("Enter password");

			}
			else msgError("Enter username");
		}
		private void msgError(string msg)
		{
			lbErroMessage.Text = msg;
			lbErroMessage.Visible = true;
		}
		private void Logout(object sender, FormClosedEventArgs e)
		{
			tBoxUserName.Text = "Username";
			tBoxPassword.Text = "Password";
			tBoxPassword.UseSystemPasswordChar = false;
			lbErroMessage.Visible = false;
			this.Show();
			//tBoxUserName.Focus();
		}
	}
}
