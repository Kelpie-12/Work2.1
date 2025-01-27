using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
					cmd.CommandText = "use ComopanyProgect; select Id as [№],FirstName as [Имя], Manager.LastName as [Фамилия] from Manager ";
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
					cmd.CommandText = "use ComopanyProgect; update Client set FirstName = @name, LastName= @last, Manager=@man,TelNumber=@tel where Id=@id";
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
		public void AddNewApp(int man, int client, int obj, DateTime date, DateTime time)
		{
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
					cmd.Parameters.AddWithValue("@manId", man);
					cmd.Parameters.AddWithValue("@clientId", client);
					cmd.Parameters.AddWithValue("@objId", obj);
					cmd.Parameters.AddWithValue("@date", date);
					cmd.Parameters.AddWithValue("@time", time);

					cmd.ExecuteNonQuery();
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
					cmd.CommandText = "use ComopanyProgect; select [Objects].Id as [№],[Objects].Photo as [Фотo], " +
						" Manager.LastName as [Менеджер], [Objects].[Text] as [Описание]," +
						" [Objects].AddressCiti as [Город],[Objects].AddressStreet as [Улица]," +
						" [Objects].AddressNumberHouse as [Дом]," +
						" [Objects].AdressNumberFlat as [Квартира] " +
						" from Manager,[Objects] where [Objects].ManagerId=Manager.Id ; ";
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
					cmd.CommandText = "use ComopanyProgect; select [Objects].Id as [№],[Objects].Photo as [Фотo], " +
						" Manager.LastName as [Менеджер], [Objects].[Text] as [Описание]," +
						" [Objects].AddressCiti as [Город],[Objects].AddressStreet as [Улица]," +
						" [Objects].AddressNumberHouse as [Дом]," +
						" [Objects].AdressNumberFlat as [Квартира] " +
						" from Manager,[Objects] where [Objects].ManagerId=Manager.Id and" +
						" (([Objects].AddressCiti like @citi +'%')or ([Objects].AddressStreet like @street +'%') or ([Objects].Id like @Id +'%')); ";
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
							"select Manager.LastName, Client.FirstName, [Date], [Time] from Manager,Appointments,Client " +
							"where ([Appointments].ManagerId=Manager.Id  and ClientId=Client.Id and @date=[Date]) " +
							"and Manager.LastName=@man";
						cmd.Parameters.AddWithValue("@man", UserLoginCache.LastName);
					}
					else
					{
						cmd.CommandText = "use ComopanyProgect;" +
							"select Manager.LastName, Client.FirstName, [Date], [Time] from Manager,Appointments,Client " +
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
