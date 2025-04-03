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
        public DataTable GetObjectsByType(int type, int offer = 1, int archive = 1)
        {
            return user.GetObjectsByType(type, offer, archive);
        }
        //public int AddNewObjects(int man, int typeObj, int typeOffer, int client)
        //{
        //	return user.AddNewObjects(man, typeObj, typeOffer, client);
        //}
        public void AddNewHouse(string man, int typeObj, int typeOffer, int client, string citi, string street, int house, int areaHouse, int areaPlot, int floor, int rooms, int price, string desc)
        {
            user.AddNewHouse(man, typeObj, typeOffer, client, citi, street, house, areaHouse, areaPlot, floor, rooms, price, desc);
        }
        public DataTable GetAllClient()
        {
            return user.GetAllClient();
        }
        //public void AddNewApartments(int id, string citi, string street, int house, int apart, int floor, int area, int rooms, int price, string desc)
        //{
        //	user.AddNewApartments(id, citi, street, house, apart, floor, area, rooms, price, desc);
        //}

        public void EditObject(Bitmap image, int id, string man, string text, string addCiti, string addStr, int addHome, int type, int addFlat = -1)
        {
            user.EditObject(image, id, man, text, addCiti, addStr, addHome, type, addFlat);
        }
        public DataTable GetAllManager()
        {
            return user.GetClientManger();
        }
        public DataTable GetTypeObjects()
        {
            return user.GetTypeObjects();
        }
        public void DeleteObjects(int id)
        {
            user.DeleteObjects(id);
        }
        public DataTable GetOfferType()
        {
            return user.GetOfferType();
        }
        public DataTable GetCommercialObjectType()
        {
            return user.GetCommercialObjectType();
        }
        public void AddNewLand(string man, int typeObj, int typeOffer, int client, string citi, string street, int house, string coord, string category, int price, int area, string desc)
        {
            user.AddNewLand(man, typeObj, typeOffer, client, citi, street, house, coord, category, price, area, desc);
        }
        public void AddNewApartments(string man, int typeObj, int typeOffer, int client, string citi, string street, int house, int apart, int floor, int area, int rooms, int price, string desc)
        {
            user.AddNewApartments(man, typeObj, typeOffer, client, citi, street, house, apart, floor, area, rooms, price, desc);
        }
        public void AddNewCommercial(string man, int typeObj, int typeOffer, int client, string citi, string street, int house, int commerObjType, int price, int area, int numberOffice, string desc)
        {
            user.AddNewCommercial(man, typeObj, typeOffer, client, citi, street, house, commerObjType, price, area, numberOffice, desc);
        }
        public void AddNewGarage(string man, int typeObj, int typeOffer, int client, string citi, string street, int house, int price, int area, string desc)
        {
            user.AddNewGarage(man, typeObj, typeOffer, client, citi, street, house, price, area, desc);
        }
        public void AddNewDacha(string man, int typeObj, int typeOffer, int client, string citi, string street, int house, int price, int areaHouse, int floor, int areaPlot, string desc)
        {
            user.AddNewDacha(man, typeObj, typeOffer, client, citi, street, house, price, areaHouse, floor, areaPlot, desc);
        }
    }
}
