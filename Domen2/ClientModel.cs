using DataAccess2;
using Common.Cache;
using System.Data;


namespace Domen2
{
	public class ClientModel
	{
		UserData userData =new UserData();
		public DataTable GetAllClient()
		{
			return userData.GetAllClient();
		}
		public DataTable GetClient(string search) 
		{
			return userData.GetClient(search);
		}
	}
}
