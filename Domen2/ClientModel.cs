using DataAccess2;
using Common.Cache;
using System.Data;


namespace Domen2
{
	public class ClientModel
	{
		UserData userData = new UserData();
		public DataTable GetAllClient()
		{
			return userData.GetAllClient();
		}
		public DataTable GetClient(string search)
		{
			return userData.GetClient(search);
		}
		public void EditClient(int id, string name, string last, string man, string tel)
		{
			userData.EditClient(id, name, last, tel, man);
		}
		public DataTable GetClientManager()
		{
			return userData.GetClientManger();
		}
		public void DeleteClient(int id)
		{
			userData.DeletClient(id);
		}
		public void AddNewClient(string name, string last, string man, string tel)
		{
			userData.AddNewClient(name, last, tel, man);
		}
	}
}
