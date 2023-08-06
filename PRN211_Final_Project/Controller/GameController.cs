using PRN211_Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Final_Project.Controller
{
	internal class GameController
	{
		//Connection to SQL Server
		string connection = "server = (local); database=GameManagement; uid=sa; pwd=sa; TrustServerCertificate=true;";


		//admin role
		public List<Game> games()
		{
			List<Game> list = new List<Game>();
			SqlConnection con = new SqlConnection(connection);

			Game g = new Game();

			con.Open();



			//define the sql statement to detect true user
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select * from Game;";


			cmd.Connection = con;

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						g.Id = Convert.ToInt32(reader.GetInt32(0));
						g.Name = Convert.ToString(reader.GetString(1));
					}
					list.Add(g);
				}
				con.Close();
			}
			catch (SqlException ex)
			{
			}
			return list;
		}
	}
}
