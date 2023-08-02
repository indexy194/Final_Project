using PRN211_Final_Project.Controller;
using PRN211_Final_Project.Model;
using System;
using System.Windows.Forms;



namespace PRN211_Final_Project.MainScreen
{
	public partial class Login : Form
	{
		bool isAuthentication = false;

		UserController userController = new UserController();

		public Login()
		{
			InitializeComponent();
		}


		private void loginClick(object sender, EventArgs e)
		{
			

			if (txtUsername.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Information cannot be left blank.");
				isAuthentication = false;
			}else
			{
				string userTxt = txtUsername.Text.Trim();
				string passTxt = txtPassword.Text.Trim();
				User user = new User();
				user = userController.checkUser(userTxt, passTxt);
				if (user.UserName != null) {
					//check role
					if(user.Role == 1)
					{
						isAuthentication= true;
						//redirect to admin page
						MessageBox.Show("Admin dep trai ne");
					}else
					{
						//check block account or not
						if(user.Status == "block")
						{
							MessageBox.Show("Nap tien de choi tiep");
							isAuthentication= false;
						}else if(user.Status == "active")
						{
							isAuthentication = true;
							
							MessageBox.Show($"Chao mung {user.UserName}");
							UserScreen userScreen = new UserScreen();
					
							userScreen.setInforUser(isAuthentication, user.Id);


							userScreen.Show();
							this.Close();
							//direct to user page
						}
					}


				}else
				{
					MessageBox.Show("Wrong Username or Password");
				}
			}
		}

		private void registerClicked(object sender, EventArgs e)
		{
			Register register = new Register();
			register.Show();
			this.Close();
		}
	}
}
