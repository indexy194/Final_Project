using PRN211_Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRN211_Final_Project.Controller
{

	internal class UserController
	{
		//Connection to SQL Server
		string connection = "server = (local); database=GameManagement; uid=sa; pwd=sa; TrustServerCertificate=true;";
		

		public User checkUser(string user, string pass)
		{
			SqlConnection con = new SqlConnection(connection);
			
			User u = new User();

			con.Open();

			String userCMD = user;
			String passCMD = pass;

			//define the sql statement to detect true user
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select * from Users where username = @user and passwords = @pass";
			cmd.Parameters.AddWithValue("@user", userCMD);
			cmd.Parameters.AddWithValue("@pass", passCMD);

			cmd.Connection = con;

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if(reader.Read())
					{
						u.Id = reader.GetInt32(0);
						u.UserName = reader.GetString(1);
						u.Password = reader.GetString(2);
						if(!reader.IsDBNull(3))
						{
							u.Status = reader.GetString(3);
						}
						u.Role = reader.GetInt32(4);
					}
				}
				con.Close();
			}
			catch (SqlException ex)
			{
			}

			return u;
		}
		public User getUserByID(int id)
		{
			SqlConnection con = new SqlConnection(connection);

			User u = new User();

			con.Open();

			//define the sql statement to detect true user
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select * from Users where users_id = @userID";
			cmd.Parameters.AddWithValue("@userID", id);

			cmd.Connection = con;

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						u.Id = reader.GetInt32(0);
						u.UserName = reader.GetString(1);
						u.Password = reader.GetString(2);
						if (!reader.IsDBNull(3))
						{
							u.Status = reader.GetString(3);
						}
						u.Role = reader.GetInt32(4);
					}
				}
				con.Close();
			}
			catch (SqlException ex)
			{
			}

			return u;
		}
		public int changePass(string username, string oldPass, string newPass)
		{
			int rowChanged = 0;
			SqlConnection con = new SqlConnection(connection);

			User u = new User();

			con.Open();

			//define the sql statement to detect true user
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "update Users set passwords = @newPass where username = @userName and passwords = @oldPass";
			cmd.Parameters.AddWithValue("@newPass", newPass);
			cmd.Parameters.AddWithValue("@userName", username);
			cmd.Parameters.AddWithValue("@oldPass", oldPass);

			cmd.Connection = con;

			rowChanged = cmd.ExecuteNonQuery();
			con.Close();
			

			return rowChanged;
		}

		public int registerUser(string username, string pass)
		{
			int rowChanged = 0;
			int ROLE = 2;
			string STATUS = "active";

			SqlConnection con = new SqlConnection(connection);

			User u = new User();

			con.Open();

			//define the sql statement to detect true user
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "INSERT INTO Users (username, passwords,status, role) VALUES (@userName,@pass,@status, @role)";
			cmd.Parameters.AddWithValue("@userName", username);
			cmd.Parameters.AddWithValue("@pass", pass);
			cmd.Parameters.AddWithValue("@status", STATUS);
			cmd.Parameters.AddWithValue("@role", ROLE);

			cmd.Connection = con;

			rowChanged = cmd.ExecuteNonQuery();
			con.Close();

			return rowChanged;
		}
		public int checkExistUserName(string username)
		{
			int result = 0;
			SqlConnection con = new SqlConnection(connection);
			con.Open();

			string user = username.Trim();

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select count(*) from users where username = @userName";
			cmd.Parameters.AddWithValue("@userName", user);

			cmd.Connection = con;
			result = (int)cmd.ExecuteScalar();

			return result;
		}

		//admin role
		public List<User> getAllUsers()
		{
			List<User> list = new List<User>();
			SqlConnection con = new SqlConnection(connection);
			con.Open();



			//define the sql statement to detect true user
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select * from Users;";


			cmd.Connection = con;

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						User u = new User();
						u.Id = reader.GetInt32(0);
						u.UserName = reader.GetString(1);
						u.Password = reader.GetString(2);
						if (!reader.IsDBNull(3))
						{
							u.Status = reader.GetString(3);
						}else
						{
							u.Status = "ADMIN";
						}
						u.Role = reader.GetInt32(4);
						list.Add(u);
					}
				}
				con.Close();
			}
			catch (SqlException ex)
			{
				
			}
			return list;
		}

		public bool updateStatus(int id, string status)
		{
			bool result = false;
			string STATUS_OFF = "block";
			string STATUS_ON = "active";
			int intResult = 0;

			if(status.Trim().Equals(STATUS_OFF))
			{
				status = STATUS_ON;
			}else
			{
				status = STATUS_OFF;
			}

			SqlConnection con = new SqlConnection(connection);

			User u = new User();

			con.Open();

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "update Users set status = @status where users_id = @id;";
			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@status", status);

			cmd.Connection = con;

			intResult = cmd.ExecuteNonQuery();
			con.Close();

			if(intResult < 1 || intResult > 1)
			{
				result = false;
			}else
			{
				result = true;
			}




			return result;
		}



	}
}
