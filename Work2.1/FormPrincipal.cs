using Common.Cache;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Work2._1
{
	public partial class FormPrincipal : Form
	{
		public FormPrincipal()
		{
			InitializeComponent();
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.DoubleBuffered = true;
		}
		#region Кнопочки, стиль окна 
		// МЕТОД RESIZE ДЛЯ ИЗМЕНЕНИЯ РАЗМЕРА/ИЗМЕНЕНИЯ РАЗМЕРА ФОРМЫ ВО ВРЕМЯ ВЫПОЛНЕНИЯ
		private int tolerance = 12;
		private const int WM_NCHITTEST = 132;
		private const int HTBOTTOMRIGHT = 17;
		private Rectangle sizeGripRectangle;
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case WM_NCHITTEST:
					base.WndProc(ref m);
					var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
					if (sizeGripRectangle.Contains(hitPoint))
						m.Result = new IntPtr(HTBOTTOMRIGHT);
					break;
				default:
					base.WndProc(ref m);
					break;
			}
		}
		//НАРИСОВАТЬ ПРЯМОУГОЛЬНИК / ИСКЛЮЧИТЬ УГОЛ ПАНЕЛИ
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
			sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
			region.Exclude(sizeGripRectangle);
			this.panelConnector.Region = region;
			this.Invalidate();
		}
		//ЦВЕТ И РУЧКА НИЖНЕГО ПРЯМОУГОЛЬНИКА
		protected override void OnPaint(PaintEventArgs e)
		{
			SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
			e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
			base.OnPaint(e);
			ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
		}
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();


		private void pBoxClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		int lx, ly;
		int sw, sh;

		private void panelBarTool_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void panelMenu_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void panelForm_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void pBoxMinimazed_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void pBoxMaximazed_Click(object sender, EventArgs e)
		{
			lx = this.Location.X;
			ly = this.Location.Y;
			sw = this.Size.Width;
			sh = this.Size.Height;
			pBoxMaximazed.Visible = false;
			pBoxCollapse.Visible = true;
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;
			this.Location = Screen.PrimaryScreen.WorkingArea.Location;
		}

		private void btnProfil_Click(object sender, EventArgs e)
		{
			OpenForm<FormProfil>();
			//изменить цвет кнопки после открытия
			btnProfil.BackColor = Color.FromArgb(12, 61, 92);
		}

		private void pBoxCollapse_Click(object sender, EventArgs e)
		{
			pBoxMaximazed.Visible = true;
			pBoxCollapse.Visible = false;
			this.Size = new Size(sw, sh);
			this.Location = new Point(lx, ly);
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void FormPrincipal_Load(object sender, EventArgs e)
		{
			LoadUserData();
			if (UserLoginCache.Position == Positions.Administrator)
			{
				btnChart.Enabled = false;
			}
			if (UserLoginCache.Position == Positions.Manager)
			{
				btnChart.Enabled = false;
				btnSetting.Enabled = false; 
			}
		}
		private void LoadUserData()
		{
			if (UserLoginCache.Position == 0)
				{ labelPosition.Text = "CEO"; labelMenu.Text = "Menu CEO"; }
			if (UserLoginCache.Position == 1)
				{labelPosition.Text = "Administrator"; labelMenu.Text = "Menu Administrator"; }
			if (UserLoginCache.Position == 2)
				{ labelPosition.Text = "Manager"; labelMenu.Text = "Menu Manager"; }
			labelLogin.Text = UserLoginCache.FirstName + " " + UserLoginCache.LastName;
			labelEmail.Text = UserLoginCache.Email;
			
		}
		#endregion
		//открывать новую форму с различными настройками
		private void OpenForm<TForm>() where TForm : Form, new()
		{
			Form form;
			form = panelForm.Controls.OfType<TForm>().FirstOrDefault();//Busca en la colecion el formulario
																	   //si el formulario/instancia no existe
			if (form == null)
			{
				form = new TForm();
				form.TopLevel = false;
				form.FormBorderStyle = FormBorderStyle.None;
				form.Dock = DockStyle.Fill;
				panelForm.Controls.Add(form);
				panelForm.Tag = form;
				form.Show();
				form.BringToFront();
				form.FormClosed += new FormClosedEventHandler(CloseForms);
			}
			else
			{
				form.BringToFront();
			}
		}
		private void CloseForms(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms["FormProfil"] == null)
				btnProfil.BackColor = Color.FromArgb(4, 41, 68);
		}
	}
}
