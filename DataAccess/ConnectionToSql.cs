
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
	//https://www.youtube.com/watch?v=UguPkYd8wa8&list=PLqjdFmR_HdQRJrDT1cfa8e1TzuPcNw5Q6&index=2
	public abstract class ConnectionToSql
	{
		private readonly string connectionString;
		public ConnectionToSql()
		{
			connectionString = "Data Source=DESKTOP-ETJ1P85\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
		}
		protected SqlConnection GetConnection()
		{
			return new SqlConnection(connectionString);
		}

	}
}
