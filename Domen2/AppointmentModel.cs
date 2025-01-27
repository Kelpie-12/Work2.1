using DataAccess2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen2
{
	public class AppointmentModel
	{
		UserData userData = new UserData();
		public void AddNewApp(int man, int client, int obj, DateTime date, DateTime time)
		{
			userData.AddNewApp(man, client, obj, date, time);
		}
		public DataTable GetClientManager()
		{
			return userData.GetClientManger();
		}
		public DataTable GetClientForManager(int id)
		{
			return userData.GetClientForManager(id);
		}
		public DataTable GetClientByValue(string search)
		{
			return userData.GetClient(search);
		}
		public DataTable GetAllClient()
		{
			return userData.GetAllClient();
		}
		public DataTable GetManagerByValue(string search)
		{
			return userData.GetManagerByValue(search);
		}
		public DataTable GetObjectByValue(string search)
		{
			return userData.GetObjectByValue(search);
		}
		public DataTable GetAllObject() 
		{
			return userData.GetAllObject(); 
		}

		public DataTable GetAppointmentsByDate(DateTime date)
		{
			return userData.GetAppointmentsByValue(date);
		}
		public int GetCountAppointmentsInDay(DateTime date)
		{
			return userData.GetCountAppointmentsInDay(date);
		}
	}
}
