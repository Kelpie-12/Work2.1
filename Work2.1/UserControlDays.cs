using Domen2;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Work2._1
{
	public partial class UserControlDays : UserControl
	{
		AppointmentModel app = new AppointmentModel();
		public UserControlDays()
		{
			InitializeComponent();
		}
		public int day, m, y, count;
		public void Days(int day, int m, int y)
		{
			DateTime date = new DateTime(y, m, day);
			this.day = day;
			this.m = m;
			this.y = y;
			lbDays.Text = day.ToString();
			count = app.GetCountAppointmentsInDay(date);
			if (count > 0)
			{
				this.BackColor = Color.Red;
				lbEvent.BackColor = Color.Transparent;
				lbEvent.Text ="Event: " +count.ToString();
			}
			else			
				lbEvent.Text = "Event: -";			
		}
		


		//добавить отдельную форму для отрисовки всех ивентов за день

	}
}
