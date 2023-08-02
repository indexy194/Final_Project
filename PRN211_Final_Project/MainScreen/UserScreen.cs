using PRN211_Final_Project.Controller;
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

namespace PRN211_Final_Project.MainScreen
{

	
	public partial class UserScreen : Form
	{

		bool isAuthen = false;
		int idCurrent; // in after login
		string userCurrent;
		long scoreCurrent;
		
		public UserScreen()
		{
		
			InitializeComponent();
			
		}
		
		

		private void userScreenLoad(object sender, EventArgs e)
		{
			setInforForLabel();

		}

		private void changeCarGame(object sender, EventArgs e)
		{

			
			StartCarGame startCarGame = new StartCarGame();
			startCarGame.setUserCurrent(idCurrent);
			startCarGame.Show();
			this.Hide();
		}

		private void changeTRexGame(object sender, EventArgs e)
		{
			T_Rex_Game.tRexGame tRexGame = new T_Rex_Game.tRexGame();
			tRexGame.setUserCurrent(idCurrent);
			tRexGame.Show();
			this.Close();
		}

		private void changeFappyBird(object sender, EventArgs e)
		{
			FlappyBird.flappyBird flappyBird = new FlappyBird.flappyBird();
			flappyBird.setUserCurrent(idCurrent);
			flappyBird.Show();
			this.Close();
		}

		private void changeBXH(object sender, EventArgs e)
		{
			LeaderBoard leaderBoard = new LeaderBoard();
			leaderBoard.setUserCurrent(idCurrent);
			leaderBoard.Show();
			this.Close();
		}


		private void changePassClicked(object sender, EventArgs e)
		{
			changePass changePass = new changePass();
			changePass.setUserCurrent(idCurrent);
			changePass.Show();
			this.Close();
		}

		private void logoutClick(object sender, EventArgs e)
		{
			Login login = new Login();
			idCurrent = 0;
			login.Show();
			this.Close();
		}
		public void setInforUser(bool isAu, int id)
		{
			User user = new User();
			
			long score = 0;
			ScoreController scoreController = new ScoreController();
			score = scoreController.getScoreById(id);

			UserController userController = new UserController();
			user = userController.getUserByID(id);


			isAuthen = isAu;
			idCurrent = id;
			userCurrent = user.UserName;
			scoreCurrent = score;

			checkAuthen();
			setInforForLabel();
			
		}
		private void checkAuthen()
		{
			if (!isAuthen)
			{
				return;
			}
		}

		private void setInforForLabel()
		{
			if (scoreCurrent != 0 && idCurrent != 0)
			{
				lbUsername.Text = userCurrent;
				lbScore.Text = $"Total Score: {scoreCurrent}";

			}else
			{
				lbUsername.Text = userCurrent;
				lbScore.Text = "Total Score: 0";
			}

		}
	}
}
