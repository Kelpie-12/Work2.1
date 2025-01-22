using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
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
					cmd.Connection = conn							;
					cmd.CommandText = "select *from Users where LoginName=@user and Password=@pass";
					cmd.Parameters.AddWithValue("@user", username);
					cmd.Parameters.AddWithValue("@pass", username);
					cmd.CommandType=System.Data.CommandType.Text;
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						return true;
					}
					else
						return false;

				}
			}
		}
	}
}
