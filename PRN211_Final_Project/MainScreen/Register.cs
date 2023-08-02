using PRN211_Final_Project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Final_Project.MainScreen
{
	public partial class Register : Form
	{
		public Register()
		{
			InitializeComponent();
			btnLogin.Enabled = true;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Close();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			if (tbUsername.Text.Trim() == "" || tbPass.Text.Trim() == "" || tbRePass.Text.Trim() == "")
			{
				MessageBox.Show("Can't empty");
				return;
			}
			if(!checkExistUsername(tbUsername.Text.Trim()))
			{
				MessageBox.Show("Username not valid");
				return;
			}

			if(tbPass.Text == tbRePass.Text)
			{
				UserController userController = new UserController();
				string userName = tbUsername.Text.Trim();
				string oldPass = tbPass.Text.Trim();
				string newPass = tbRePass.Text.Trim();
				int result = userController.registerUser(userName, newPass);
				if (result == 1)
				{
					MessageBox.Show("Create Successfully!");
					Login login = new Login();
					login.Show();
					this.Close();
				}
				else
				{
					MessageBox.Show("Can't create account. Try again!");
				}
			}else
			{
				MessageBox.Show("Old Password and New Password must be the same. Try again!");
			}
		}
		private bool checkExistUsername(string username)
		{
			bool result = false;
			UserController userController = new UserController();
			int rowEffected = userController.checkExistUserName(username);
			if(rowEffected == 0)
			{
				result = true;
			}else
			{
				result = false;
			}


			return result;
		}


	}
}
