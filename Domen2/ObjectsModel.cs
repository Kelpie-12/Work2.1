using DataAccess2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen2
{
	public class ObjectsModel
	{
		UserData user = new UserData();
		public DataTable GetAllObject()
		{
			return user.GetAllObject();
		}
		public DataTable GetObjectByValue(string search)
		{
			return user.GetObjectByValue(search);
		}
		public void AddNewObjects(Bitmap image, string man, string text, string addCiti, string addStr, int addHome, int addFlat = -1)
		{
			user.AddNewObjects(image, man, text, addCiti, addStr, addHome, addFlat);
		}
		public void EditObject (Bitmap image,int id, string man, string text, string addCiti, string addStr, int addHome, int addFlat = -1)
		{
			user.EditObject(image, id, man, text, addCiti, addStr, addHome, addFlat);
		}
		public DataTable GetAllManager()
		{
			return user.GetClientManger();
		}
		public DataTable GetManagerByValue(string search)
		{
			return user.GetManagerByValue(search);
		}
	}
}
