using System;
using System.Windows.Forms;

namespace Work2._1
{
	public partial class FormViewPhoro : Form
	{
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();
		public FormViewPhoro()
		{
			InitializeComponent();
		}
		public FormViewPhoro(int id):base()
		{
			
		}

		private void pBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void panelTop_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
	}
}

