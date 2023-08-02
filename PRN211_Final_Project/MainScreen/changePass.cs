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
	public partial class changePass : Form
	{
		int idCurrent;
		public changePass()
		{
			InitializeComponent();
			btnMainMenu.Enabled = true;
		}

		internal void setUserCurrent(int id)
		{
			idCurrent = id;
		}

		private void mainMenuClicked(object sender, EventArgs e)
		{
			UserScreen userScreen = new UserScreen();
			userScreen.setInforUser(true, idCurrent);
			userScreen.Show();
			this.Close();
		}

		private void changePassClick(object sender, EventArgs e)
		{
			if (tbUsername.Text == "" || tbPass.Text == "" || tbRePass.Text == "")
			{
				MessageBox.Show("Can't empty");
				return;
			}

			UserController userController = new UserController();
			string userName = tbUsername.Text.Trim();
			string oldPass = tbPass.Text.Trim();
			string newPass = tbRePass.Text.Trim();
			int result = userController.changePass(userName, oldPass, newPass);
			if (result == 1)
			{
				MessageBox.Show("Change Successfully!");
				Login login = new Login();
				login.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Old Password or Username not exists. Try again!");
			}



		}
		private void checkValidPass(object sender, EventArgs e)
		{
			lbErrorPass.Visible = true;
			if (checkEmpty(tbPass.Text))
			{
				lbErrorPass.ForeColor = Color.IndianRed;
				lbErrorPass.Text = "Can't Empty";
				return;
			}
			lbErrorPass.ForeColor = Color.Green;
			lbErrorPass.Text = "Valid Password";

		}


		private void checkValidRePass(object sender, EventArgs e)
		{
			lbErrorRePass.Visible = true;

			if (checkEmpty(tbRePass.Text))
			{
				lbErrorRePass.ForeColor = Color.IndianRed;
				lbErrorRePass.Text = "Can't Empty";
				return;
			}
			lbErrorRePass.ForeColor = Color.Green;
			lbErrorRePass.Text = "Valid Password";
		}
		private bool checkEmpty(string str)
		{
			if (str == "")
			{
				return true;
			}
			return false;
		}
	}

}
