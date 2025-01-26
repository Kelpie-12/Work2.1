using Common.Cache;
using Domen2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work2._1
{
	public partial class FormCalendar : Form
	{
		int month, year;
		bool selectMan, selectClient, selectObj;
		AppointmentModel app = new AppointmentModel();
		public FormCalendar()
		{
			InitializeComponent();
			tabControlCalend.TabPages.Remove(tabPageAddNewAppointment);
			tabControlCalend.TabPages.Remove(tabPageSelectClient);
			tabControlCalend.TabPages.Remove(tabPageSelectManager);
			tabControlCalend.TabPages.Remove(tabPageSelectObj);
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
		private void DisplyApp()
		{

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
			LoadManager();
			LoadClient();
			if (UserLoginCache.Position == Positions.Manager)
			{

			}
			//если под сео или админ то выставляются после выбора менеджера
			if (UserLoginCache.Position == Positions.Administrator || UserLoginCache.Position == Positions.CEO)
			{

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
			btnSaveApp.Enabled =  true;

		}

		private void pBBack_Click(object sender, EventArgs e)
		{
			pBBack.Visible = false;
			tabControlCalend.TabPages.Add(tabPageCalendar);
			tabControlCalend.TabPages.Remove(tabPageAddNewAppointment);
			btnMonBack.Visible = btnMonNext.Visible = btnAddNewApp.Visible = true;
			btnMonBack.Enabled = btnMonNext.Enabled = btnAddNewApp.Enabled = true;
			btnSaveApp.Enabled = btnEditApp.Enabled = btnDeleteApp.Enabled = false;

		}

		private void btnSaveApp_Click(object sender, EventArgs e)
		{
			app.AddNewApp(Convert.ToInt32(dGVMS.SelectedRows[0].Cells[0].Value),
				Convert.ToInt32(dGVCS.SelectedRows[0].Cells[0].Value),
				Convert.ToInt32(dGWOS.SelectedRows[0].Cells[0].Value),
				dTPDateApp.Value, dTPTimeApp.Value);
			tabControlCalend.TabPages.Add(tabPageCalendar);
			tabControlCalend.TabPages.Remove(tabPageAddNewAppointment);
			btnMonBack.Enabled = btnMonNext.Enabled = btnAddNewApp.Enabled = false;
			btnSaveApp.Enabled = btnEditApp.Enabled = btnDeleteApp.Enabled = true;
			pBBack.Visible = false;
			lbDate.Text = "Календарь";
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
			lbDate.Text = "Выбрать менеджера";
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
			lbDate.Text = "Выбрать клиента";
		}

		private void tbMangerSearch_TextChanged(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(tbMangerSearch.Text);
			if (emptyValue)
				LoadManager();
			else
				dGVMS.DataSource = app.GetManagerByValue(tbMangerSearch.Text);	
		}

		private void tbClientSearch_TextChanged(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(tbClientSearch.Text);
			if (emptyValue)
				LoadClient();
			else
				dGVCS.DataSource = app.GetClientByValue(tbClientSearch.Text);
		}

		private void tbObjSearch_TextChanged(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(tbObjSearch.Text);
			if (emptyValue)
				dGWOS.DataSource = app.GetAllObject();
			else
				dGVCS.DataSource = app.GetObjectByValue(tbObjSearch.Text);
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
			lbDate.Text = "Выбрать объект";
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
				lbObj.Text = "г. " +dGWOS.SelectedRows[0].Cells[4].Value.ToString()
					+ " у. "+dGWOS.SelectedRows[0].Cells[5].Value.ToString()
					+ " д. "+dGWOS.SelectedRows[0].Cells[5].Value.ToString();
				selectObj = false;
			}
			btnSelect.Visible = false;
			btnMonBack.Enabled = btnMonNext.Enabled = btnAddNewApp.Enabled = false;
			btnSaveApp.Enabled = btnEditApp.Enabled = btnDeleteApp.Enabled = true;
		}

		private void AddControl()
		{
			lbDate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
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
				ucd.Days(i);
				daysContener.Controls.Add(ucd);				
			}
		}
	}
}
