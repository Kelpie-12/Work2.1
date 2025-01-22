using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess2
{
	public abstract class ConnectionToSql
	{
		private readonly string connectionString;
		public ConnectionToSql()
		{
			connectionString = "Data Source=DESKTOP-ETJ1P85\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		}
		protected SqlConnection GetConnection()
		{
			return new SqlConnection(connectionString);
		}

	}
}
