using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Xml.Linq;
using Common.Cache;
using static System.Net.Mime.MediaTypeNames;
namespace DataAccess2
{
    public class UserData : ConnectionToSql
    {
        public bool Login(string username, string password)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect; select *from Users where LoginName=@user and Password=@pass";
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    //cmd.Parameters.AddWithValue("@id", UserLoginCache.IdUser);
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Email = reader.GetString(5);
                            UserLoginCache.Position = reader.GetInt32(6);
                            UserLoginCache.Archive = reader.GetInt32(7);
                            if (UserLoginCache.Archive == 0 && UserLoginCache.Position == 2)
                                return false;
                        }
                        return true;
                    }
                    else
                        return false;

                }
            }
        }
        public DataTable GetAllClient(int archive = 1)//хранимая процедура
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    string sql = string.Empty;
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (Positions.Manager == UserLoginCache.Position)
                    {
                        cmd.CommandText = $"get_clients_by_manager";
                        cmd.Parameters.Add(new SqlParameter("@manager_last_name", UserLoginCache.LastName));
                    }
                    else
                    {
                        cmd.CommandText = $"get_clients_all";
                    }
                    cmd.Parameters.Add(new SqlParameter("@archive", archive));
                    //sql += "use ComopanyProgect; select Client.Id as [№],Client.FirstName as[Имя], " +
                    //   "Client.LastName as [Фамилия], Manager.LastName as [Менеджер], Client.TelNumber as [Телефон] " +
                    //   "from Client,Manager where Client.Manager=Manager.Id ";
                    //if (Positions.Manager == UserLoginCache.Position)
                    //{ sql += " and Manager.LastName=@cacheMan "; cmd.Parameters.AddWithValue("@cacheMan", UserLoginCache.LastName); }
                    //sql += $" and Client.Archive={archive}";
                    //cmd.CommandText = sql;
                    //cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                        //return table;
                    }

                    return table;

                }
            }
        }        //			

        public DataTable GetClientManger(int archive = 1)//получить менеджеров//хранимая процедура
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = $"get_all_manager";
                    cmd.Parameters.Add(new SqlParameter("@archive", archive));
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                        return table;
                    }
                    else
                        return table;

                }
            }
        }

        public void AddNewClient(string name, string last, string telefon, string manager)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = " use ComopanyProgect; begin if not exists (select * from Client " +
                        "where FirstName=@name and LastName=@last) " +
                        "begin insert into Client (FirstName,LastName,Manager,TelNumber)" +
                        " values (@name,@last,@man,@tel) end end";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@last", last);
                    cmd.Parameters.AddWithValue("@man", manager);
                    cmd.Parameters.AddWithValue("@tel", telefon);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditClient(int id, string name, string last, string telefon, string manager)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect; " +
                        "update Client set FirstName = @name, LastName= @last, Manager=@man,TelNumber=@tel " +
                        "where Id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@last", last);
                    cmd.Parameters.AddWithValue("@man", manager);
                    cmd.Parameters.AddWithValue("@tel", telefon);
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                }
            }
        }
        public void DeletClient(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect; update Client set Client.Archive =0 where Id=@id ";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                }
            }
        }
        public DataTable GetAllObject(int archive = 1)//хранимая процедура
        {
            using (var conn = GetConnection())
            {
                string sql = string.Empty;
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (Positions.Manager == UserLoginCache.Position)
                    {
                        cmd.CommandText = $"get_objects_by_manager";
                        cmd.Parameters.Add(new SqlParameter("@manager_last_name", UserLoginCache.LastName));
                    }
                    else
                    {
                        cmd.CommandText = $"get_objects_all";
                    }
                    cmd.Parameters.Add(new SqlParameter("@archive", archive));
                    //sql += "use ComopanyProgect; select [Objects].Id as [№], " +
                    //" Manager.LastName as [Менеджер], " +
                    //" TypeObjects.name as [Тип объекта], Offer.name as [Тип сделки]" +
                    //" from Manager,[Objects],TypeObjects,Offer where [Objects].ManagerId=Manager.Id ";
                    //if (UserLoginCache.Position == Positions.Manager)
                    //{ sql += " and Manager.LastName=@man "; cmd.Parameters.AddWithValue("@man", UserLoginCache.LastName); }
                    //sql += $" and [Objects].TypeObjects=TypeObjects.id and [Objects].Archive={archive} and [Objects].TypeOffer=Offer.id; ";
                    //cmd.CommandText = sql;
                    //cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                        return table;
                    }
                    else
                        return table;

                }
            }
        }
        public DataTable GetObjectsByType(int type, int offer = 1, int archive = 1)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    string sql = string.Empty;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (type == 0)//квартиры
                    {
                        if (UserLoginCache.Position == Positions.Manager)
                            cmd.CommandText = $"get_objects_apartments_by_manager";
                        else
                            cmd.CommandText = $"get_objects_apartments_all";

                        /*sql += "use ComopanyProgect; select [Apartments].IdObject as [ID],  ";
                        //if (UserLoginCache.Position != Positions.Manager)
                        //sql += " Manager.LastName as [Манеджер], ";
                        //sql += "Apartments.Citi as [Город], [Apartments].[Street] as [Улица], " +
                        //"[Apartments].House as [Дом],[Apartments].Apartment as [Квартира], " +
                        //"[Apartments].[Floor] as [Этаж], [Apartments].AreaHouse as [Площадь (М)], " +
                        //"Apartments.Rooms as [Кол-во комнат], Apartments.Price as [Цена]  " +
                        //"from Apartments " +
                        //"left join [Objects] on Apartments.IdObject=[Objects].Id " +
                        //"left join Manager on [Objects].ManagerId=Manager.Id " +
                        //"where ";
                        //if (UserLoginCache.Position == Positions.Manager)
                        //sql += " Manager.LastName=@man and [Objects].ManagerId=@manId and";
                        sql += $" [Objects].Archive={archive} and Objects.TypeOffer={offer};";*/
                        /*sql = "use ComopanyProgect; select [Apartments].IdObject as [ID], ";
						//if (UserLoginCache.Position != Positions.Manager)
						//sql += " Manager.LastName as [Манеджер], ";
						//sql += " Apartments.Citi as [Город], [Apartments].[Street] as [Улица]," +
						//" [Apartments].House as [Дом],[Apartments].Apartment as [Квартира]," +
						//" [Apartments].Floor as [Этаж]," +
						//" [Apartments].AreaHouse as [Площадь (М)],Apartments.Rooms as [Кол-во комнат], Apartments.Price as [Цена] " +
						//" from Apartments,Manager,[Objects] where ";
						//if (UserLoginCache.Position == Positions.Manager)
						//sql += " Manager.LastName=@man and [Objects].ManagerId=@manId and";
						//else
						//sql += " [Objects].ManagerId=Manager.Id and";
						//sql += " Apartments.IdObject=[Objects].Id " +
						$" and [Objects].Archive={archive} and Objects.TypeOffer={offer}";*/
                    }
                    else if (type == 1)//Дома
                    {
                        if (UserLoginCache.Position == Positions.Manager)
                            cmd.CommandText = $"get_objects_house_by_manger";
                        else
                            cmd.CommandText = $"get_objects_house_all";

                        /*sql = "use ComopanyProgect; select [House].IdObject as [ID], ";
                        if (UserLoginCache.Position != Positions.Manager)
                            sql += " Manager.LastName as [Манеджер], ";
                        sql += " House.Citi as [Город], [House].[Street] as [Улица]," +
                        " [House].House as [Дом],[House].AreaHouse as [Площадь дома (М)]," +
                        " [House].AreaPlot as [Площадь участка (М)]," +
                        " [House].Floor as [Этаж],House.Rooms as [Кол-во комнат], House.Price as [Цена]" +
                        " from House " +
                        " left join [Objects] on House.IdObject=[Objects].Id " +
                        " left join Manager on [Objects].ManagerId=Manager.Id " +
                        " where ";
                        if (UserLoginCache.Position == Positions.Manager)
                            sql += " Manager.LastName=@man and [Objects].ManagerId=@manId and";
                        sql += $" [Objects].Archive={archive} and Objects.TypeOffer={offer};";*/
                    }
                    else if (type == 2)//Земельные участки
                    {
                        if (UserLoginCache.Position == Positions.Manager)
                            cmd.CommandText = $"get_objects_land_by_manager";
                        else
                            cmd.CommandText = $"get_objects_land_all";

                        /*   sql = "use ComopanyProgect; select [Land].IdObjects as [ID], ";
                           if (UserLoginCache.Position != Positions.Manager)
                               sql += " Manager.LastName as [Манеджер], ";
                           sql += " Land.Citi as [Город], [Land].[Street] as [Улица]," +
                           " [Land].House as [Дом], [Land].Coordinates as [Координаты]," +
                           " Land.LandCategory as [Категория земель],Land.Area as [Площадь (м)], Land.Price as [Цена] " +
                           " from Land " +
                           " left join [Objects] on Land.IdObjects=[Objects].Id" +
                           " left join Manager on [Objects].ManagerId=Manager.Id " +
                           " where ";
                           if (UserLoginCache.Position == Positions.Manager)
                               sql += " Manager.LastName=@man and [Objects].ManagerId=@manId and";//добавить манеджера для админа					
                           sql += $"  [Objects].Archive={archive} and Objects.TypeOffer={offer};";*/

                    }
                    else if (type == 3)//коммерческая недвижимость
                    {
                        if (UserLoginCache.Position == Positions.Manager)
                            cmd.CommandText = $"get_objects_commercial_by_manager";
                        else
                            cmd.CommandText = $"get_objects_commercial_all";

                        /*sql = "use ComopanyProgect; select [CommercialRealEstates].IdObjects as [ID], ";
                        if (UserLoginCache.Position != Positions.Manager)
                            sql += " Manager.LastName as [Манеджер], ";
                        sql += " CommercialRealEstates.Citi as [Город], [CommercialRealEstates].[Street] as [Улица]," +
                            " [CommercialRealEstates].House as [Дом], [TypeCommercialObject].name as [Тип недвижимости]," +
                            " CommercialRealEstates.Area as [Площадь (м)], CommercialRealEstates.Price as [Цена] " +
                            " from CommercialRealEstates " +
                            " left join TypeCommercialObject on TypeCommercialObject.id=CommercialRealEstates.CommercialObjectType" +
                            " left join [Objects] on CommercialRealEstates.IdObjects=[Objects].Id" +
                            " left join Manager on [Objects].ManagerId=Manager.Id" +
                            " where ";
                        if (UserLoginCache.Position == Positions.Manager)
                            sql += " Manager.LastName=@man and [Objects].ManagerId=@manId and ";//добавить манеджера для админа
                        sql += $" [Objects].Archive={archive} and Objects.TypeOffer={offer};";*/
                    }
                    else if (type == 4)//гараж
                    {
                        if (UserLoginCache.Position == Positions.Manager)
                            cmd.CommandText = $"get_objects_garage_by_manager";
                        else
                            cmd.CommandText = $"get_objects_garage_all";
                        /*sql = "use ComopanyProgect; select [Garage].IdObjects as [ID], ";
                        if (UserLoginCache.Position != Positions.Manager)
                            sql += " Manager.LastName as [Манеджер], ";
                        sql += " Garage.Citi as [Город], [Garage].[Street] as [Улица]," +
                            " [Garage].House as [Дом], " + //[TypeObjects].name as [Тип недвижимости], TypeObjects
                            " Garage.Area as [Площадь (м)], Garage.Price as [Цена], Garage.Description as [Описание]" +
                            " from Garage" +
                            " left join [Objects] on Garage.IdObjects=[Objects].Id" +
                            " left join Manager on [Objects].ManagerId=Manager.Id" +
                            " where ";
                        if (UserLoginCache.Position == Positions.Manager)
                            sql += " Manager.LastName=@man and [Objects].ManagerId=@manId and ";//добавить манеджера для 
                        sql += $"  [Objects].Archive={archive} and [Objects].TypeOffer={offer};";*/
                    }
                    else if (type == 5)//дачные участки
                    {
                        if (UserLoginCache.Position == Positions.Manager)
                            cmd.CommandText = $"get_objects_dacha_by_manager";
                        else
                            cmd.CommandText = $"get_objects_dacha_all";

                        /*sql = "use ComopanyProgect; select [Dacha].IdObjects as [ID], ";
                        if (UserLoginCache.Position != Positions.Manager)
                            sql += " Manager.LastName as [Манеджер], ";
                        sql += " Dacha.Citi as [Город], [Dacha].[Street] as [Улица]," +
                            " [Dacha].House as [Дом], " + //[TypeObjects].name as [Тип недвижимости], TypeObjects
                            " Dacha.AreaHouse as [Площадь дома (м)],Dacha.AreaPlot as [Площадь участка (м)]," +
                            " Dacha.Floor as [Этажность], Dacha.Price as [Цена], Dacha.Description as [Описание]" +
                            " from Dacha" +
                            " left join [Objects] on Dacha.IdObjects=[Objects].Id" +
                            " left join Manager on [Objects].ManagerId=Manager.Id" +
                            " where ";//вставить вклейку если ищет админ
                        if (UserLoginCache.Position == Positions.Manager)
                            sql += " Manager.LastName=@man and [Objects].ManagerId=@manId and ";//добавить манеджера для админа					
                        sql += $" [Objects].Archive={archive} and [Objects].TypeOffer={offer};";*/
                    }
                    else
                    {
                        sql = "use ComopanyProgect; select * from TypeObjects";
                    }
                    if (UserLoginCache.Position == Positions.Manager)
                        cmd.Parameters.Add(new SqlParameter("@manager_last_name", UserLoginCache.LastName));
                    cmd.Parameters.Add(new SqlParameter("@archive", archive));
                    cmd.Parameters.Add(new SqlParameter("@offer", offer));
                    /*cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@man", UserLoginCache.LastName);
                    if (UserLoginCache.Position == Positions.Manager)
                        cmd.Parameters.AddWithValue("@manId", GetManClientIdByName(UserLoginCache.LastName, "-1").Rows[0][0]);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@type", type);*/
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                        return table;
                    }
                    else
                        return table;

                }
            }
        }
        public DataTable GetAppointmentsByValue(DateTime date)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    string sql = string.Empty;
                    cmd.Connection = conn;

                    sql += "use ComopanyProgect;" +
                            "select Appointments.Id as [Номер встречи],Client.LastName as [Фамилия клиента]," +
                            " Client.FirstName as [Имя клиента], " +
                            "[Date] as [Дата], [Time] as [Время],Appointments.ObjectId as [ID объекта] ";
                    if (Positions.Manager != UserLoginCache.Position)
                        sql += ",Manager.LastName as [Фамилия менеджера] ";
                    sql += "from Manager,Appointments,Client " +
                        "where ([Appointments].ManagerId=Manager.Id  and ClientId=Client.Id and @date=[Date]) ";
                    if (Positions.Manager == UserLoginCache.Position)
                    { sql += " and Manager.LastName=@man"; cmd.Parameters.AddWithValue("@man", UserLoginCache.LastName); }
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                    }
                    return table;
                }
            }

        }
        public void AddNewApartments(string man, int typeObj, int typeOffer, int client, string citi, string street, int house, int apart, int floor, int area, int rooms, int price, string desc)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "create_new_object_apartment";
                    //
                    /*cmd.CommandText = " use ComopanyProgect; begin if not exists (select * from [Apartments] " +
                        "where Citi=@citi and Street=@street and House=@home and Apartment=@flat) " +
                        "begin insert into [Apartments] (IdObject,Citi,Street,House,Apartment,Floor,AreaHouse,Rooms,Price,Description)" +
                        " values (@id,@citi,@street,@home,@flat,@floor,@area,@room,@price,@text) end end";*/
                    cmd.Parameters.Add(new SqlParameter("@manager_lastname", man));
                    cmd.Parameters.Add(new SqlParameter("@type_object", typeObj));
                    cmd.Parameters.Add(new SqlParameter("@type_offer", typeOffer));
                    cmd.Parameters.Add(new SqlParameter("@client_id", client));

                    cmd.Parameters.Add(new SqlParameter("@citi", citi));
                    cmd.Parameters.Add(new SqlParameter("@street", street));
                    cmd.Parameters.Add(new SqlParameter("@home", house));
                    cmd.Parameters.Add(new SqlParameter("@apart", apart));
                    cmd.Parameters.Add(new SqlParameter("@floor", floor));
                    cmd.Parameters.Add(new SqlParameter("@areaHouse", area));
                    cmd.Parameters.Add(new SqlParameter("@rooms", rooms));
                    cmd.Parameters.Add(new SqlParameter("@price", price));
                    cmd.Parameters.Add(new SqlParameter("@description", desc));

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AddNewHouse(string man, int typeObj, int typeOffer, int client, string citi, string street, int house, int areaHouse, int areaPlot, int floor, int rooms, int price, string desc)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "create_new_object_house";
                    cmd.Parameters.Add(new SqlParameter("@manager_lastname", man));

                    cmd.Parameters.Add(new SqlParameter("@type_object", typeObj));
                    cmd.Parameters.Add(new SqlParameter("@type_offer", typeOffer));
                    cmd.Parameters.Add(new SqlParameter("@client_id", client));

                    /* cmd.CommandText = " use ComopanyProgect; begin if not exists (select * from [House] " +
                         "where Citi=@citi and Street=@street and House=@home ) " +
                         "begin insert into [House] (IdObject,Citi,Street,House,AreaHouse,AreaPlot,Floor,Rooms,Price,Description)" +
                         " values (@id,@citi,@street,@home,@area,@areap,@floor,@room,@price,@text) end end";*/
                    cmd.Parameters.Add(new SqlParameter("@citi", citi));
                    cmd.Parameters.Add(new SqlParameter("@street", street));
                    cmd.Parameters.Add(new SqlParameter("@home", house));
                    cmd.Parameters.Add(new SqlParameter("@areaHouse", areaHouse));
                    cmd.Parameters.Add(new SqlParameter("@areaPlot", areaPlot));
                    cmd.Parameters.Add(new SqlParameter("@rooms", rooms));
                    cmd.Parameters.Add(new SqlParameter("@floor", floor));
                    cmd.Parameters.Add(new SqlParameter("@price", price));
                    cmd.Parameters.Add(new SqlParameter("@description", desc));

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AddNewLand(string man, int typeObj, int typeOffer, int client, string citi, string street, int house, string coord, string category, int price, int area, string desc)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "create_new_object_land";
                    cmd.Parameters.Add(new SqlParameter("@manager_lastname", man));
                    cmd.Parameters.Add(new SqlParameter("@type_object", typeObj));
                    cmd.Parameters.Add(new SqlParameter("@type_offer", typeOffer));
                    cmd.Parameters.Add(new SqlParameter("@client_id", client));

                    cmd.Parameters.Add(new SqlParameter("@citi", citi));
                    cmd.Parameters.Add(new SqlParameter("@street", street));
                    cmd.Parameters.Add(new SqlParameter("@home", house));
                    cmd.Parameters.Add(new SqlParameter("@coord", coord));
                    cmd.Parameters.Add(new SqlParameter("@categore", category));
                    cmd.Parameters.Add(new SqlParameter("@price", price));
                    cmd.Parameters.Add(new SqlParameter("@area", area));
                    cmd.Parameters.Add(new SqlParameter("@description", desc));
                    /*cmd.CommandText = " use ComopanyProgect; begin if not exists (select * from [House] " +
                    //"where Citi=@citi and Street=@street and House=@home ) " +
                    //"begin insert into [House] (IdObject,Citi,Street,House,AreaHouse,AreaPlot,Floor,Rooms,Price,Description)" +
                    //" values (@id,@citi,@street,@home,@area,@areap,@floor,@room,@price,@text) end end";
                    //cmd.Parameters.AddWithValue("@text", desc);
                    //cmd.Parameters.AddWithValue("@citi", citi);
                    //cmd.Parameters.AddWithValue("@street", street);
                    //cmd.Parameters.AddWithValue("@home", house);
                    //cmd.Parameters.AddWithValue("@id", id);
                    //cmd.Parameters.AddWithValue("@floor", floor);
                    //cmd.Parameters.AddWithValue("@area", areaHouse);
                    //cmd.Parameters.AddWithValue("@areap", areaPlot);
                    //cmd.Parameters.AddWithValue("@room", rooms);
                    //cmd.Parameters.AddWithValue("@price", price);*/
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /*public int AddNewObjects(int man, int typeObj, int typeOffer, int client)
        //{
        //    int id = -1;
        //    using (var con = GetConnection())
        //    {
        //        con.Open();
        //        using (var cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = $"create_new_obj";
        //            cmd.Parameters.Add(new SqlParameter("@man", man));
        //            cmd.Parameters.Add(new SqlParameter("@typeOffer", typeOffer));
        //            cmd.Parameters.Add(new SqlParameter("@typeObj", typeObj));
        //            cmd.Parameters.Add(new SqlParameter("@client", client));
        //            SqlParameter ir = new SqlParameter("idObj", SqlDbType.Int);
        //            ir.Direction = ParameterDirection.Output;
        //            cmd.Parameters.Add(ir);
        //            cmd.ExecuteNonQuery();
        //            id = Convert.ToInt32(ir.Value);
        //        }
        //    }
        //    return id;
        }*/
        public void EditObject(Bitmap image, int id, string man, string text, string addCiti, string addStr, int addHome, int type, int addFlat = -1)
        {
            DataTable table = GetManClientIdByName(man, "-1");
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect; " +
                        "update [Objects] set ManagerId=@manId,Text=@text,AddressCiti=@citi," +
                        "AddressStreet=@street,AddressNumberHouse=@home,AdressNumberFlat=@flat, TypeObjects=@typeObj " +
                        "where [Objects].Id=@id";

                    using (var memoryStream = new MemoryStream())
                    {
                        if (image == null)
                        {
                            //image.Save(memoryStream, ImageFormat.Jpeg);
                            //memoryStream.Position = 0;
                            var sqlParameter = new SqlParameter("@image", SqlDbType.VarBinary, (int)memoryStream.Length)
                            { Value = DBNull.Value };
                            cmd.Parameters.Add(sqlParameter);
                        }
                        else
                        {
                            image.Save(memoryStream, ImageFormat.Jpeg);
                            memoryStream.Position = 0;
                            var sqlParameter = new SqlParameter("@image", SqlDbType.VarBinary, (int)memoryStream.Length)
                            { Value = memoryStream.ToArray() };
                            cmd.Parameters.Add(sqlParameter);
                        }
                    }

                    cmd.Parameters.AddWithValue("@manId", table.Rows[0][0]);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@typeObj", type);
                    cmd.Parameters.AddWithValue("@text", text);
                    cmd.Parameters.AddWithValue("@citi", addCiti);
                    cmd.Parameters.AddWithValue("@street", addStr);
                    cmd.Parameters.AddWithValue("@home", addHome);
                    if (addFlat == -1)
                        cmd.Parameters.AddWithValue("@flat", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@flat", addFlat);
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                }
            }
        }
        public void DeleteObjects(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect; update Objects set Objects.Archive=0  where Id=@id ";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                }
            }
        }
        public DataTable GetCommercialObjectType()
        {
            DataTable table = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect;" +
                        "select * from TypeCommercialObject ";
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                    }
                }
            }
            return table;
        }
        public int GetCountAppointmentsInDay(DateTime date)
        {
            int res = 0;
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    if (Positions.Manager == UserLoginCache.Position)
                    {
                        cmd.CommandText = "use ComopanyProgect;" +
                            "select count([Time]) from Manager,Appointments,Client " +
                            "where ([Appointments].ManagerId=Manager.Id  and ClientId=Client.Id and @date=[Date]) " +
                            "and Manager.LastName=@man";
                        cmd.Parameters.AddWithValue("@man", UserLoginCache.LastName);
                    }
                    else
                    {
                        cmd.CommandText = "use ComopanyProgect;" +
                            "select count([Time]) from Manager,Appointments,Client " +
                            "where [Appointments].ManagerId=Manager.Id  and ClientId=Client.Id and @date=[Date]";
                    }
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();

                    //DataTable table = new DataTable();
                    if (reader.HasRows)
                    {
                        //for (int i = 0; i < reader.FieldCount; i++)
                        //	table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            res = Convert.ToInt32(reader[0]);
                            //DataRow row = table.NewRow();
                            //for (int i = 0; i < reader.FieldCount; i++)
                            //{
                            //	row[i] = reader[i];
                            //	res += row[i].ToString();
                            //	res += " ";
                            //}
                            //table.Rows.Add(row);
                        }
                    }
                }
            }
            return res;
        }
        public void AddNewApp(string man, string client, int obj, DateTime date, DateTime time)
        {
            DataTable table = GetManClientIdByName(man, client);
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = " use ComopanyProgect; begin if not exists (select * from Appointments " +
                        "where ManagerId=@manId and ClientId=@clientId) " +
                        "begin insert into Appointments (ManagerId,ClientId,Date,Time,ObjectId)" +
                        " values (@manId,@clientId,@date,@time,@objId) end end";
                    cmd.Parameters.AddWithValue("@manId", table.Rows[0][0]);
                    cmd.Parameters.AddWithValue("@clientId", table.Rows[0][1]);
                    cmd.Parameters.AddWithValue("@objId", obj);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@time", time);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditAppoint(int appointId, string man, string client, int objId, DateTime date, DateTime time)
        {
            DataTable table = GetManClientIdByName(man, client);
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect; " +
                        "update Appointments set Appointments.ManagerId=@manId," +
                        "Appointments.ClientId=@clientId, Appointments.[Date]=@dateA," +
                        "Appointments.[Time]=@timeA, Appointments.ObjectId=@objId " +
                        "where Appointments.Id = @id";
                    cmd.Parameters.AddWithValue("@id", appointId);
                    cmd.Parameters.AddWithValue("@manId", Convert.ToInt32(table.Rows[0][0]));
                    cmd.Parameters.AddWithValue("@clientId", Convert.ToInt32(table.Rows[0][1]));
                    cmd.Parameters.AddWithValue("@dateA", date);
                    cmd.Parameters.AddWithValue("@timeA", time);
                    cmd.Parameters.AddWithValue("@objId", objId);
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                }
            }
        }
        public void DeleteAppoint(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect; update Appointments set Appointments.Archive=0 where Id=@id ";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                }
            }
        }
        private DataTable GetManClientIdByName(string man, string client)
        {
            DataTable table = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    if (client == "-1")
                    {
                        cmd.CommandText = "use ComopanyProgect;" +
                            "select Manager.Id as [Manager] ,Client.Id as [Client] from Manager,Client " +
                            "where Manager.LastName=@man";
                    }
                    else if (man == "-1")
                    {
                        cmd.CommandText = "use ComopanyProgect;" +
                            "select Manager.Id as [Manager] ,Client.Id as [Client] from Manager,Client " +
                            "where  Client.LastName=@client";
                    }
                    else
                    {
                        cmd.CommandText = "use ComopanyProgect;" +
                            "select Manager.Id as [Manager] ,Client.Id as [Client] from Manager,Client " +
                            "where Manager.LastName=@man and Client.LastName=@client";

                    }

                    cmd.Parameters.AddWithValue("@man", man);
                    cmd.Parameters.AddWithValue("@client", client);
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                    }
                }
            }
            return table;
        }
        public DataTable GetTypeObjects()
        {
            DataTable table = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect;" +
                        "select * from TypeObjects ";
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                    }
                }
            }
            return table;
        }
        public DataTable GetOfferType()
        {
            DataTable table = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "use ComopanyProgect;" +
                        "select * from Offer ";
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                    }
                }
            }
            return table;
        }
        public void AnyMethod()
        {
            DataTable table = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "get_manager";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));
                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = reader[i];
                            table.Rows.Add(row);
                        }
                    }
                }
            }

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
