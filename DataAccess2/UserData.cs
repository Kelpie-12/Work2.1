using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
		public DataTable GetClientManger()
		{
			using (var conn = GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "use ComopanyProgect; select * from Manager ";
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
					cmd.CommandText = "use ComopanyProgect; select Client.Id as [№],Client.FirstName as[Имя], Client.LastName as [Фамилия], Manager.LastName as [Менеджер], Client.TelNumber as [Телефон] from Client,Manager " +
						"where Client.Manager=Manager.Id and ((Client.FirstName like @name +'%')or (Client.LastName like  @last + '%') or (Client.Id =  @id)) ";
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
