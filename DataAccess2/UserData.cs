using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Remoting;
using System.Xml.Linq;
using Common.Cache;
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
						}
						return true;
					}
					else
						return false;

				}
			}
		}
		public DataTable GetAllClient()
		{
			using (var conn = GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					if (Positions.Manager == UserLoginCache.Position)
					{
						cmd.CommandText = "use ComopanyProgect; select Client.Id as [№],Client.FirstName as[Имя], Client.LastName as [Фамилия], Manager.LastName as [Менеджер], Client.TelNumber as [Телефон] from Client,Manager where Client.Manager=Manager.Id and  Manager.LastName=@cacheMan";
						cmd.Parameters.AddWithValue("@cacheMan", UserLoginCache.LastName);
					}
					else
						cmd.CommandText = "use ComopanyProgect; select Client.Id as [№],Client.FirstName as[Имя], Client.LastName as [Фамилия], Manager.LastName as [Менеджер], Client.TelNumber as [Телефон] from Client,Manager where Client.Manager=Manager.Id ";
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
						return table;
					}
					else
						return table;

				}
			}
		}
		public DataTable GetClientManger()//получить менеджеров
		{
			using (var conn = GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "use ComopanyProgect; select Id as [№],FirstName as [Имя], " +
						"Manager.LastName as [Фамилия] from Manager ";
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
						return table;
					}
					else
						return table;

				}
			}
		}
		public DataTable GetManagerByValue(string search)
		{
			int Id = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
			string LastName = search;
			string FirstName = search;
			using (var conn = GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "use ComopanyProgect; select Id as [№],FirstName as [Имя], Manager.LastName as [Фамилия] from Manager " +
						"where ((Manager.FirstName like @name +'%')or (Manager.LastName like  @last + '%') or (Manager.Id =  @id)) ";
					cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
					cmd.Parameters.Add("@name", SqlDbType.NVarChar, 150).Value = FirstName;
					cmd.Parameters.Add("@last", SqlDbType.NVarChar, 150).Value = LastName;
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
					//else
					//	return table;

				}
			}
		}
		public DataTable GetClient(string search)
		{
			int Id = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
			string LastName = search;
			string FirstName = search;
			using (var conn = GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					if (Positions.Manager == UserLoginCache.Position)
					{
						cmd.CommandText = "use ComopanyProgect; select Client.Id as [№],Client.FirstName as[Имя], Client.LastName as [Фамилия], Manager.LastName as [Менеджер], Client.TelNumber as [Телефон] from Client,Manager " +
								"where Client.Manager=Manager.Id and ((Client.FirstName like @name +'%')or (Client.LastName like  @last + '%') or (Client.Id =  @id)) and Manager.LastName=@cacheMan}";
						cmd.Parameters.AddWithValue("@cacheMan", UserLoginCache.LastName);
					}
					else
					{
						cmd.CommandText = "use ComopanyProgect; select Client.Id as [№],Client.FirstName as[Имя], Client.LastName as [Фамилия], Manager.LastName as [Менеджер], Client.TelNumber as [Телефон] from Client,Manager " +
							"where Client.Manager=Manager.Id and ((Client.FirstName like @name +'%')or (Client.LastName like  @last + '%') or (Client.Id =  @id)) ";

					}
					cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
					cmd.Parameters.Add("@name", SqlDbType.NVarChar, 150).Value = FirstName;
					cmd.Parameters.Add("@last", SqlDbType.NVarChar, 150).Value = LastName;
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
					//else
					//	return table;

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
					cmd.CommandText = "use ComopanyProgect; delete from Client where Id=@id ";
					cmd.CommandType = System.Data.CommandType.Text;
					cmd.Parameters.AddWithValue("@id", id);
					SqlDataReader reader = cmd.ExecuteReader();
				}
			}
		}

		public DataTable GetClientForManager(int man)
		{
			using (var conn = GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "use ComopanyProgect; select  Client.LastName,Client.Id " +
						"from Client,Manager where Client.Manager=Manager.Id and Manager.Id=@id";
					cmd.Parameters.AddWithValue("@id", man);
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
						return table;
					}
					else
						return table;

				}
			}
		}

		public DataTable GetAllObject()
		{
			using (var conn = GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					if (UserLoginCache.Position == Positions.Manager)
					{
						cmd.CommandText = "use ComopanyProgect; select [Objects].Id as [№], " +
						" Manager.LastName as [Менеджер], [Objects].[Text] as [Описание]," +
						" [Objects].AddressCiti as [Город],[Objects].AddressStreet as [Улица]," +
						" [Objects].AddressNumberHouse as [Дом]," +
						" [Objects].AdressNumberFlat as [Квартира],TypeObjects.name as [Тип]" +
						" from Manager,[Objects],TypeObjects where [Objects].ManagerId=Manager.Id and Manager.LastName=@man and [Objects].TypeObjects=TypeObjects.id; ";
						cmd.Parameters.AddWithValue("@man", UserLoginCache.LastName);
					}
					else
					{
						cmd.CommandText = "use ComopanyProgect; select [Objects].Id as [№], " +
							" Manager.LastName as [Менеджер], [Objects].[Text] as [Описание]," +
							" [Objects].AddressCiti as [Город],[Objects].AddressStreet as [Улица]," +
							" [Objects].AddressNumberHouse as [Дом]," +
							" [Objects].AdressNumberFlat as [Квартира], TypeObjects.name as [Тип] " +
							" from Manager,[Objects],TypeObjects where [Objects].ManagerId=Manager.Id and [Objects].TypeObjects=TypeObjects.id; ";
					}
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
						return table;
					}
					else
						return table;

				}
			}
		}
		public DataTable GetObjectByValue(string search)
		{
			int Id = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
			string citi = search;
			string street = search;
			using (var conn = GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					if (UserLoginCache.Position == Positions.Manager)
					{

						cmd.CommandText = "use ComopanyProgect; select [Objects].Id as [№], " +
							" Manager.LastName as [Менеджер], [Objects].[Text] as [Описание]," +
							" [Objects].AddressCiti as [Город],[Objects].AddressStreet as [Улица]," +
							" [Objects].AddressNumberHouse as [Дом]," +
							" [Objects].AdressNumberFlat as [Квартира] " +
							" from Manager,[Objects] where Manager.id=[Objects].ManagerId and Manager.LastName=@man and " +
							" ([Objects].AddressCiti like @citi + '%' or [Objects].AddressStreet like @street + '%')";// or [Objects].Id like @Id + '%';
						cmd.Parameters.AddWithValue("@man", UserLoginCache.LastName);
					}
					else
					{
						cmd.CommandText = "use ComopanyProgect; select [Objects].Id as [№], " +
							" Manager.LastName as [Менеджер], [Objects].[Text] as [Описание]," +
							" [Objects].AddressCiti as [Город],[Objects].AddressStreet as [Улица]," +
							" [Objects].AddressNumberHouse as [Дом]," +
							" [Objects].AdressNumberFlat as [Квартира] " +
							" from Manager,[Objects] where Manager.id=[Objects].ManagerId and " +
							" ([Objects].AddressCiti like @citi + '%' or [Objects].AddressStreet like @street + '%')";
					}

					cmd.Parameters.AddWithValue("@citi", citi);
					cmd.Parameters.AddWithValue("@street", street);
					cmd.Parameters.AddWithValue("@Id", Id);
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
					cmd.Connection = conn;
					if (Positions.Manager == UserLoginCache.Position)
					{
						cmd.CommandText = "use ComopanyProgect;" +
							"select Appointments.Id as [Номер встречи],Client.LastName as [Фамилия клиента], Client.FirstName as [Имя клиента], " +
							"[Date] as [Дата], [Time] as [Время],Appointments.ObjectId as [ID объекта] " +
							"from Manager,Appointments,Client " +
							"where ([Appointments].ManagerId=Manager.Id  and ClientId=Client.Id and @date=[Date]) " +
							"and Manager.LastName=@man";
						cmd.Parameters.AddWithValue("@man", UserLoginCache.LastName);
					}
					else
					{
						cmd.CommandText = "use ComopanyProgect;" +
							"select Appointments.Id as [Номер встречи], Client.LastName as [Фамилия клиента], Client.FirstName as [Имя клиента], " +
							"[Date] as [Дата], [Time] as [Время], Appointments.ObjectId as [ID объекта], " +
							"Manager.LastName as [Фамилия менеджера] from Manager,Appointments,Client " +
							"where [Appointments].ManagerId=Manager.Id  and ClientId=Client.Id and @date=[Date]";
					}
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
		public void AddNewObjects(Bitmap image, string man, string text, string addCiti, string addStr, int addHome,  int type,int addFlat = -1)
		{
			DataTable table = GetManClientIdByName(man, "-1");
			using (var con = GetConnection())
			{
				con.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = con;
					cmd.CommandText = " use ComopanyProgect; begin if not exists (select * from [Objects] " +
						"where ManagerId=@manId and AddressCiti=@citi and AddressStreet=@street and AddressNumberHouse=@home and AdressNumberFlat=@flat) " +
						"begin insert into [Objects] (ManagerId,Text,AddressCiti,AddressStreet,AddressNumberHouse,AdressNumberFlat,TypeObjects)" +
						" values (@manId,@text,@citi,@street,@home,@flat,@typeObj) end end";
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
					cmd.Parameters.AddWithValue("@typeObj", type);
					cmd.Parameters.AddWithValue("@text", text);
					cmd.Parameters.AddWithValue("@citi", addCiti);
					cmd.Parameters.AddWithValue("@street", addStr);
					cmd.Parameters.AddWithValue("@home", addHome);
					if (addFlat == -1)
						cmd.Parameters.AddWithValue("@flat", DBNull.Value);
					else
						cmd.Parameters.AddWithValue("@flat", addFlat);

					cmd.ExecuteNonQuery();
				}
			}
		}
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
					cmd.CommandText = "use ComopanyProgect; delete from Objects where Id=@id ";
					cmd.CommandType = System.Data.CommandType.Text;
					cmd.Parameters.AddWithValue("@id", id);
					SqlDataReader reader = cmd.ExecuteReader();
				}
			}
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
					cmd.CommandText = "use ComopanyProgect; delete from Appointments where Id=@id ";
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
