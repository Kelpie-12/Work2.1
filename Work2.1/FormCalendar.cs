using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work2._1
{
	public partial class FormCalendar : Form
	{
		int month,year;
		public FormCalendar()
		{
			InitializeComponent();			
		}


		private void FormCalendar_Load(object sender, EventArgs e)
		{
			DisplyDays();
		}
		private void DisplyDays()
		{
			DateTime now= DateTime.Now;
			month= now.Month;
			year= now.Year;
			//получить 1 день месяца
			DateTime startMonth = new DateTime(year, month, 1);
			int days=DateTime.DaysInMonth(year, month);
			int dayOfTheWeek = Convert.ToInt32(startMonth.DayOfWeek.ToString("d"));
			for (int i = 1; i < dayOfTheWeek; i++)
			{
				UserControlBlank blank = new UserControlBlank();
				daysContener.Controls.Add(blank);
			}

			for (int i = 1; i <= days; i++)
			{
				UserControlDays ucd = new UserControlDays();
				ucd.Days(i);
				daysContener.Controls.Add(ucd);
			}
		}
	}
}
