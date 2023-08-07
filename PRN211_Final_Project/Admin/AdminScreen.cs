using PRN211_Final_Project.Controller;
using PRN211_Final_Project.MainScreen;
using PRN211_Final_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Final_Project.Admin
{
	public partial class AdminScreen : Form
	{
		public AdminScreen()
		{
			InitializeComponent();
		}

		private void adminDashboard(object sender, EventArgs e)
		{
			List<User> users = new List<User>();
			UserController userController = new UserController();
			users = userController.getAllUsers();
			MessageBox.Show(users.Count.ToString());
			displayList(users);
		}

		private void displayList(List<User> users)
		{
			DataTable dtTable = new DataTable();
			DataColumn column;
			DataRow row;

			string userID = "User ID";
			string userName = "User Name";
			string status = "Status";
			string role = "Role";
			string action = "Action";


			


			column = new DataColumn();
			column.ColumnName = userID;
			column.DataType = System.Type.GetType("System.Int32");
			dtTable.Columns.Add(column);

			column = new DataColumn();
			column.ColumnName = userName;
			column.DataType = System.Type.GetType("System.String");
			dtTable.Columns.Add(column);
			
			column = new DataColumn();
			column.ColumnName = status;
			column.DataType = System.Type.GetType("System.String");
			dtTable.Columns.Add(column);
			
			column = new DataColumn();
			column.ColumnName = role;
			column.DataType = System.Type.GetType("System.Int32");
			dtTable.Columns.Add(column);

			column = new DataColumn();
			column.ColumnName = action;
			dtTable.Columns.Add(column);

			DataGridViewButtonColumn btnCell = new DataGridViewButtonColumn();
			btnCell.Name = action;
			btnCell.Text = "Ban";
			dgvAdminRole.Columns.Add(btnCell);




			foreach (var item in users)
			{
				row = dtTable.NewRow();
				row[0] = item.Id;
				row[1] = item.UserName;
				row[2] = item.Status;
				row[3] = item.Role;


				dtTable.Rows.Add(row);
			}



			dgvAdminRole.DataSource = dtTable;
		}



		private void logoutAdmin(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Close();
		}
	}
}
