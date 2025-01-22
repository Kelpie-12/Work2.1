using DataAccess2;
using Common.Cache;
using System.Data;

namespace Domen2
{
	public class UserModel
	{
		UserData userData = new UserData();
		public bool LoginUser(string username, string password)
		{
			return userData.Login(username, password);
		}		
		 
		public void AnyMethod()
		{

			if (UserLoginCache.Position == Positions.Administrator)
			{
				//
			}
			if (UserLoginCache.Position == Positions.Manager)
			{

			}
			if (UserLoginCache.Position == Positions.CEO)
			{

			}
		}
	}
}
