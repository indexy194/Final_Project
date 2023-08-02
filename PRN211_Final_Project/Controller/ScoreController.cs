
using PRN211_Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Final_Project.Controller
{
	internal class ScoreController
	{
		//Connection to SQL Server
		string connection = "server = (local); database=GameManagement; uid=sa; pwd=sa; TrustServerCertificate=true;";

		public List<Score> getLeaderScoreByID(int id)
		{
			List<Score> scores = new List<Score>();	
			SqlConnection con = new SqlConnection(connection);

			User u = new User();

			con.Open();
			//define the sql statement to detect true user
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select top(10) a.score_id, a.total_score, c.users_id, c.username, b.game_name from Score as a \r\n\tjoin Game as b on a.game_id = b.game_id \r\n\tjoin Users as c on a.users_id = c.users_id \r\n\twhere a.game_id = @gameID\r\n\tgroup by a.score_id, a.total_score, c.users_id, c.username, b.game_name \r\n\torder by a.total_score desc";

			cmd.Parameters.AddWithValue("@gameID", id);

			cmd.Connection = con;

			using(SqlDataReader reader = cmd.ExecuteReader())
			{
				while(reader.Read())
				{
					Score score = new Score
					{
						id = reader.GetInt32(0),
						totalScore = reader.GetInt64(1),
						userID = reader.GetInt32(2),
						userName = reader.GetString(3),
						gameName = reader.GetString(4)
					};
					scores.Add(score);
				}
			}
			con.Close();

			return scores;
		} 
		public long getScoreById(int id)
		{
		
			long result = 0;
			SqlConnection sqlConnection = new SqlConnection(connection);

			sqlConnection.Open();

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select sum(total_score) from Score where users_id = @usersID;";

			cmd.Parameters.AddWithValue("@usersID", id);

			cmd.Connection = sqlConnection;


			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						
						if (!reader.IsDBNull(0))
						{
							result = reader.GetInt64(0);
						}
					}
					else
					{
				
						result = 0; 
					}
				}
				sqlConnection.Close();
			}
			catch (SqlException ex)
			{
			}


			return result;
		}
		internal int addNewRecordSCore(Score score)
		{
		
			if(score == null)
			{
				return 0;
			}
			SqlConnection sqlConnection = new SqlConnection(connection);

			sqlConnection.Open();

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "INSERT INTO Score (users_id, game_id, total_score) VALUES (@UserID, @GameID, @TotalScore)";
			cmd.Connection = sqlConnection;

				cmd.Parameters.AddWithValue("@UserID", score.userID);
				cmd.Parameters.AddWithValue("@GameID", score.gameID);
				cmd.Parameters.AddWithValue("@TotalScore", score.totalScore);

				int newRow = cmd.ExecuteNonQuery();

			sqlConnection.Close();

			return newRow;


		}


	}
}
