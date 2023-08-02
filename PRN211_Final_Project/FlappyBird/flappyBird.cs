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

namespace PRN211_Final_Project.FlappyBird
{
	public partial class flappyBird : Form
	{
		int idCurrent;
		int gameIDCurrent = 3;

		int pipeSpeed = 5;
		int gravity = 2;
		int score = 0;
		int backSpeed = 50;

		bool isGameOver = false;

		Random rand = new Random();

		public flappyBird()
		{
			InitializeComponent();
			resetAll();


		}

		private void resetAll()
		{
			pipeSpeed = 5;
			gravity = 2;
			score = 0;
			btnMainMenu.Enabled = true;

			isGameOver = false;

			lbScore.Visible = false;
			lbNoti.Visible = false;

			bar.Visible = false;
			invertBar.Visible = false;

			gameTimer.Stop();

		}
		private void isKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				
				gravity = -5;

			}

		}
		private void isKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				gravity = 5;
			}
			if(e.KeyCode == Keys.R)
			{
				resetGameForClick();
			}

		}
		private void gameTimerTick(object sender, EventArgs e)
		{
			mainChar.Top += gravity;
			bar.Left -= pipeSpeed;
			invertBar.Left -= pipeSpeed;

			//back1.Left = back2.Left -= backSpeed;

			lbScore.Text = $"Score: {score}";
			//if (back1.Left < -30)
			//{
			//	changeRanBack(back1);
			//	back1.Left = 560;

			//}
			//if (back2.Left < -30)
			//{
			//	changeRanBack(back2);
			//	back2.Left = 560;
			//}

			if (bar.Left < -55) {
				bar.Left = 560;
				score++;
				
			}
			if(invertBar.Left < -55) {
				invertBar.Left = 560;
				score++;
				
			}
			if (mainChar.Bounds.IntersectsWith(bar.Bounds) ||
				mainChar.Bounds.IntersectsWith(invertBar.Bounds) ||  mainChar.Top < -15 || mainChar.Top > 620)
			{
				isGameOver = true;
				endGame();

			}
			
			if (score > 10)
			{

				pipeSpeed = 25;
				invertBar.Top = -208;
				bar.Top = 404;
			}


		}
		private void endGame()
		{
			gameTimer.Stop();
			btnMainMenu.Enabled = true;
			lbNoti.Visible = true;
			if (score > 0)
			{
				saveScore(score);
			}
			lbNoti.Text = $"Your Score: {score} \n Press R to restart the game!";
		}
		private void resetGameForClick()
		{
			
			pipeSpeed = 5;
			gravity = 2;
			score = 0;
			backSpeed = 50;
			btnMainMenu.Enabled = false;

			isGameOver = false;

			changeMainChar(mainChar);
			mainChar.Visible = bar.Visible = invertBar.Visible = lbScore.Visible = true;

			lbNoti.Visible = false;

			lbScore.Text = $"Score: {score}";



			mainChar.Location = new Point(41, 283);
			bar.Location = new Point(430, 443);
			invertBar.Location = new Point(443, -238);

			gameTimer.Start();
		}
		private void changeMainChar(PictureBox changePic)
		{
			int result = rand.Next(1, 2);
			switch(result)
			{
				case 1:
					changePic.Image = Properties.Resources.stella;
					break;
				case 2:
					changePic.Image = Properties.Resources.cealus;
					break;
				
			}
		}

		private void startEvent(object sender, EventArgs e)
		{
			resetGameForClick();
			btnStartGame.Enabled = false;
			btnStartGame.Visible = false;
			btnStartGame.Dispose();

		}

		private void mainMenuClicked(object sender, EventArgs e)
		{
			UserScreen userScreen = new UserScreen();
			userScreen.setInforUser(true, idCurrent);
			userScreen.Show();
			this.Close();
		}

		public void setUserCurrent(int id)
		{
			idCurrent = id;
		}
		private void saveScore(int score)
		{
			Score scoreObj = new Score
			{
				gameID = gameIDCurrent,
				userID = idCurrent,
				totalScore = score
			};
			ScoreController scoreController = new ScoreController();
			scoreController.addNewRecordSCore(scoreObj);

		}
	}
}
