using Common.Cache;
using Domen2;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Work2._1
{
	public partial class FormCalendar : Form
	{
		int month, year, selectedAppoint;
		bool selectMan, selectClient, selectObj, editApp;
		DateTime date;
		AppointmentModel app = new AppointmentModel();
		public FormCalendar()
		{
			InitializeComponent();
			tabControlCalend.TabPages.Remove(tabPageAddNewAppointment);
			tabControlCalend.TabPages.Remove(tabPageSelectClient);
			tabControlCalend.TabPages.Remove(tabPageSelectManager);
			tabControlCalend.TabPages.Remove(tabPageSelectObj);
			tabControlCalend.TabPages.Remove(tabPageAppInDay);
			selectClient = selectMan = selectObj = false;

		}

		private void FormCalendar_Load(object sender, EventArgs e)
		{
			DisplyDays();

		}
		private void DisplyDays()
		{
			DateTime now = DateTime.Now;
			month = now.Month;
			year = now.Year;
			//получить 1 день месяца
			AddControl();

		}
		private void pBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMonNext_Click(object sender, EventArgs e)
		{
			daysContener.Controls.Clear();
			month++;
			if (month >= 12)
			{
				month = 1;
				year++;
			}
			AddControl();
		}
		void LoadManager()
		{
			//	this.Controls.Add(cBoxManager);
			//tabPageAddNewAppointment.Invalidate();
			dGVMS.DataSource = app.GetClientManager();
		}
		void LoadClient()
		{
			dGVCS.DataSource = app.GetAllClient();
		}

		private void LoadAppParameters()
		{
			//если зашли под менеджерем то сразу выставляюся позиции клентов и объектов
			LoadClient();
			if (UserLoginCache.Position == Positions.Manager)
			{
				lbMan.Text = UserLoginCache.LastName;
				btnSelectManger.Visible = false;
			}
			//если под сео или админ то выставляются после выбора менеджера
			if (UserLoginCache.Position == Positions.Administrator || UserLoginCache.Position == Positions.CEO)
			{
				LoadManager();
			}
		}

		private void btnMonBack_Click(object sender, EventArgs e)
		{
			daysContener.Controls.Clear();
			month--;
			if (month <= 0)
			{
				month = 12;
				year--;
			}
			AddControl();
		}

		private void btnAddNewClient_Click(object sender, EventArgs e)
		{
			LoadAppParameters();
			pBBack.Visible = true;
			btnMonBack.Visible = btnMonNext.Visible = false;
			tabControlCalend.TabPages.Add(tabPageAddNewAppointment);
			tabControlCalend.TabPages.Remove(tabPageCalendar);
			btnEditApp.Enabled = btnDeleteApp.Enabled = btnAddNewApp.Enabled = false;
			btnSaveApp.Enabled = true;
			lbHeader.Text = "Добавить новую встречу";

		}

		private void pBBack_Click(object sender, EventArgs e)
		{
			pBBack.Visible = false;
			tabControlCalend.TabPages.Add(tabPageCalendar);
			tabControlCalend.TabPages.Remove(tabPageAddNewAppointment);
			tabControlCalend.TabPages.Remove(tabPageAppInDay);
			btnMonBack.Visible = btnMonNext.Visible = btnAddNewApp.Visible = true;
			btnMonBack.Enabled = btnMonNext.Enabled = btnAddNewApp.Enabled = true;
			btnSaveApp.Enabled = btnEditApp.Enabled = btnDeleteApp.Enabled = false;
			lbHeader.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;

		}

		private void btnSaveApp_Click(object sender, EventArgs e)
		{
			if (editApp == true)
			{
				app.EditAppoint(selectedAppoint, lbMan.Text, lbClient.Text, Convert.ToInt32(lbObjId.Text), dTPDateApp.Value, dTPTimeApp.Value);
				editApp = false;
			}
			else
			{
				app.AddNewApp(lbMan.Text, lbClient.Text,
					Convert.ToInt32(dGWOS.SelectedRows[0].Cells[0].Value),
					dTPDateApp.Value, dTPTimeApp.Value);
			}
			tabControlCalend.TabPages.Add(tabPageCalendar);
			tabControlCalend.TabPages.Remove(tabPageAddNewAppointment);
			btnMonBack.Visible = btnMonNext.Visible = btnMonBack.Enabled = btnMonNext.Enabled = btnAddNewApp.Enabled = true;
			btnSaveApp.Enabled = btnEditApp.Enabled = btnDeleteApp.Enabled = false;
			pBBack.Visible = false;
			lbHeader.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
			daysContener.Controls.Clear();
			AddControl();
		}

		private void btnSelectManger_Click(object sender, EventArgs e)
		{
			tabControlCalend.TabPages.Add(tabPageSelectManager);
			tabControlCalend.TabPages.Remove(tabPageCalendar);
			tabControlCalend.TabPages.Remove(tabPageAddNewAppointment);
			tabControlCalend.TabPages.Remove(tabPageSelectClient);
			tabControlCalend.TabPages.Remove(tabPageSelectObj);
			btnMonBack.Visible = btnMonNext.Visible = pBBack.Visible = false;
			btnSelect.Visible = selectMan = true;
			btnAddNewApp.Enabled = btnSaveApp.Enabled = btnEditApp.Enabled = btnDeleteApp.Enabled = false;
			dGVMS.DataSource = app.GetClientManager();
			lbHeader.Text = "Выбрать менеджера";
		}

		private void btnSelectClient_Click(object sender, EventArgs e)
		{
			tabControlCalend.TabPages.Add(tabPageSelectClient);
			tabControlCalend.TabPages.Remove(tabPageCalendar);
			tabControlCalend.TabPages.Remove(tabPageAddNewAppointment);
			tabControlCalend.TabPages.Remove(tabPageSelectManager);
			tabControlCalend.TabPages.Remove(tabPageSelectObj);
			btnMonBack.Visible = btnMonNext.Visible = pBBack.Visible = false;
			btnSelect.Visible = selectClient = true;
			btnAddNewApp.Enabled = btnSaveApp.Enabled = btnEditApp.Enabled = btnDeleteApp.Enabled = false;
			dGVCS.DataSource = app.GetAllClient();
			lbHeader.Text = "Выбрать клиента";
		}

		private void tbMangerSearch_TextChanged(object sender, EventArgs e)
		{
			string[] values = (sender as TextBox).Text.Split(' ');
			if (values.Length > 1)
				values = values.Where(v => v != "").ToArray();
			switch (values.Length)
			{
				case 1:
					{
						(dGVMS.DataSource as DataTable).DefaultView.RowFilter =
				string.Format("(Фамилия like '{0}%') or (Имя like '{0}%')", values[0]); //searchPattern = $"(last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%') OR middle_name LIKE ('{values[0]}%'))"; break;
						break;
					}
				case 2:
					{
						(dGVMS.DataSource as DataTable).DefaultView.RowFilter =
							string.Format("(Фамилия like '{0}%' or Имя like '{0}%') and (Фамилия like '{1}%' or Имя like '{1}%')", values[0], values[1]); //searchPattern = $"(last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%') OR middle_name LIKE ('{values[0]}%'))"; break;

						break;
					}//searchPattern = $"((last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%')) AND (first_name LIKE  ('{values[1]}%') OR middle_name LIKE ('{values[1]}%')))"; break;
					 //case 3: searchPattern = $"(last_name LIKE ('{values[0]}%') AND first_name LIKE ('{values[1]}%') OR middle_name LIKE ('{values[2]}%'))"; break;
			}			
		}

		private void tbClientSearch_TextChanged(object sender, EventArgs e)
		{
			string[] values = (sender as TextBox).Text.Split(' ');
			if (values.Length > 1)
				values = values.Where(v => v != "").ToArray();
			switch (values.Length)
			{
				case 1:
					{
						(dGVCS.DataSource as DataTable).DefaultView.RowFilter =
							string.Format("(Имя like '{0}%' or Фамилия like '{0}%')", values[0]);
						//searchPattern = $"(last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%') OR middle_name LIKE ('{values[0]}%'))"; break;
						break;
					}
				case 2:
					{
						(dGVCS.DataSource as DataTable).DefaultView.RowFilter =
							string.Format("(Имя like '{0}%' or Фамилия like '{0}%') and (Имя like '{1}%' or Фамилия like '{1}%')", values[0], values[1]);
						break;
					}//searchPattern = $"((last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%')) AND (first_name LIKE  ('{values[1]}%') OR middle_name LIKE ('{values[1]}%')))"; break;
					 //	case 3: searchPattern = $"(last_name LIKE ('{values[0]}%') AND first_name LIKE ('{values[1]}%') OR middle_name LIKE ('{values[2]}%'))"; break;
			}
		}

		private void tbObjSearch_TextChanged(object sender, EventArgs e)
		{
			string[] values = (sender as TextBox).Text.Split(' ');
			if (values.Length > 1)
				values = values.Where(v => v != "").ToArray();
			switch (values.Length)
			{
				case 1:
					{
						(dGWOS.DataSource as DataTable).DefaultView.RowFilter =
							string.Format("(Город like '{0}%' or Улица like '{0}%')", values[0]);
						//searchPattern = $"(last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%') OR middle_name LIKE ('{values[0]}%'))"; break;
						break;
					}
				case 2:
					{
						(dGWOS.DataSource as DataTable).DefaultView.RowFilter =
							string.Format("(Город like '{0}%' or Улица like '{0}%') and (Город like '{1}%' or Улица like '{1}%')", values[0], values[1]);
						break;
					}//searchPattern = $"((last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%')) AND (first_name LIKE  ('{values[1]}%') OR middle_name LIKE ('{values[1]}%')))"; break;
					 //	case 3: searchPattern = $"(last_name LIKE ('{values[0]}%') AND first_name LIKE ('{values[1]}%') OR middle_name LIKE ('{values[2]}%'))"; break;
			}
		}

		private void btnDeleteApp_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Удалить встречу?", "Удаление", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				app.DeleteAppoint(Convert.ToInt32(dGVA.SelectedRows[0].Cells[0].Value));
				MessageBox.Show("Встреча удалена");
				dGVA.DataSource = app.GetAppointmentsByDate(date);
				AddControl();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			tabControlCalend.TabPages.Add(tabPageSelectObj);
			tabControlCalend.TabPages.Remove(tabPageCalendar);
			tabControlCalend.TabPages.Remove(tabPageAddNewAppointment);
			tabControlCalend.TabPages.Remove(tabPageSelectManager);
			tabControlCalend.TabPages.Remove(tabPageSelectClient);
			btnMonBack.Visible = btnMonNext.Visible = pBBack.Visible = false;
			btnAddNewApp.Enabled = btnSaveApp.Enabled = btnEditApp.Enabled = btnDeleteApp.Enabled = false;
			btnSelect.Visible = selectObj = true;
			dGWOS.DataSource = app.GetAllObject();
			lbHeader.Text = "Выбрать объект";
		}

		private void btnEditApp_Click(object sender, EventArgs e)
		{
			//редакировать евент
			lbHeader.Text = "Редактировать";

			editApp = true;
			selectedAppoint = Convert.ToInt32(dGVA.SelectedRows[0].Cells[0].Value);
			if (UserLoginCache.Position == Positions.Manager)
			{
				lbMan.Text = UserLoginCache.LastName;
				btnSelectManger.Visible = false;
			}
			else
			{
				lbMan.Text = dGVA.SelectedRows[0].Cells[6].Value.ToString();
			}
			lbClient.Text = dGVA.SelectedRows[0].Cells[1].Value.ToString();
			dTPDateApp.Value = Convert.ToDateTime(dGVA.SelectedRows[0].Cells[3].Value);
			dTPTimeApp.Value = Convert.ToDateTime(dGVA.SelectedRows[0].Cells[4].Value);
			lbObjId.Text = dGVA.SelectedRows[0].Cells[5].Value.ToString();
			pBBack.Visible = true;
			btnMonBack.Visible = btnMonNext.Visible = false;
			tabControlCalend.TabPages.Add(tabPageAddNewAppointment);
			tabControlCalend.TabPages.Remove(tabPageAppInDay);
			btnEditApp.Enabled = btnAddNewApp.Enabled = false;
			btnSaveApp.Enabled = btnDeleteApp.Enabled = true;

		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			tabControlCalend.TabPages.Add(tabPageAddNewAppointment);
			tabControlCalend.TabPages.Remove(tabPageCalendar);
			tabControlCalend.TabPages.Remove(tabPageSelectObj);
			tabControlCalend.TabPages.Remove(tabPageSelectManager);
			tabControlCalend.TabPages.Remove(tabPageSelectClient);
			if (selectMan)
			{
				lbMan.Text = dGVMS.SelectedRows[0].Cells[2].Value.ToString();
				selectMan = false;
			}
			if (selectClient)
			{
				lbClient.Text = dGVCS.SelectedRows[0].Cells[2].Value.ToString();
				selectClient = false;
			}
			if (selectObj)
			{
				lbObjId.Text = dGWOS.SelectedRows[0].Cells[0].Value.ToString();
				lbObj.Text = "г. " + dGWOS.SelectedRows[0].Cells[4].Value.ToString()
					+ " у. " + dGWOS.SelectedRows[0].Cells[5].Value.ToString()
					+ " д. " + dGWOS.SelectedRows[0].Cells[6].Value.ToString();
				selectObj = false;
			}
			btnSelect.Visible = false;
			btnMonBack.Enabled = btnMonNext.Enabled = btnAddNewApp.Enabled = false;
			btnSaveApp.Enabled = btnEditApp.Enabled = btnDeleteApp.Enabled = true;
		}

		private void AddControl()
		{
			lbHeader.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
			DateTime startMonth = new DateTime(year, month, 1);
			int days = DateTime.DaysInMonth(year, month);
			int dayOfTheWeek = Convert.ToInt32(startMonth.DayOfWeek.ToString("d"));
			for (int i = 1; i < dayOfTheWeek; i++)
			{
				UserControlBlank blank = new UserControlBlank();
				daysContener.Controls.Add(blank);
			}

			for (int i = 1; i <= days; i++)
			{
				UserControlDays ucd = new UserControlDays();
				ucd.Days(i, month, year);
				//ucd.Anchor=AnchorStyles.Top| AnchorStyles.Bottom | AnchorStyles.Left|AnchorStyles.Right;
				daysContener.Controls.Add(ucd);

				ucd.Click += SelectDay;
			}
			
		}
		private void SelectDay(object sender, EventArgs e)
		{
			var info = (UserControlDays)sender;
			date = new DateTime(info.y, info.m, info.day);
			if (info.count == 0)
				MessageBox.Show("Встречи " + date.Date.ToShortDateString() + "\nне запланированны", " ", MessageBoxButtons.OK);
			else
			{
				lbHeader.Text = "Встречи за " + date.Date.ToShortDateString();// + info.day + '.' + info.m + '.' + info.y;
				pBBack.Visible = true;
				btnMonBack.Visible = btnMonNext.Visible = false;
				tabControlCalend.TabPages.Remove(tabPageCalendar);
				tabControlCalend.TabPages.Add(tabPageAppInDay);
				btnEditApp.Enabled = btnDeleteApp.Enabled = btnAddNewApp.Enabled = true;
				btnSaveApp.Enabled = btnAddNewApp.Enabled = false;
				dGVA.DataSource = app.GetAppointmentsByDate(date);
			}
		}
	}
}
