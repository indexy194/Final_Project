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

namespace PRN211_Final_Project.T_Rex_Game
{
	public partial class tRexGame : Form
	{

		int gameIDCurrent = 2;
		int idCurrent;

		//init value
		bool jumping = false;
		bool movingLeft = false;
		bool movingRight = false;

		int leftRightMove = 5;
		int jumpSpeed;

		int force = 12;
		int score = 0;
		int obstacleSpeed = 15;

		Random rand = new Random();

		int position;
		bool isGameOver = false;

		public tRexGame()
		{
			InitializeComponent();
			lbScore.Visible = false;
			tRex.Visible = false;
			btnMainMenu.Enabled = true;

			pictureBox3.Visible = false;
			pictureBox4.Visible = false;

			tRexTimer.Stop();

		}

		private void tRexTickTimer(object sender, EventArgs e)
		{
			if(movingLeft && tRex.Left > 0)
			{
				tRex.Left -= leftRightMove;
			}
			if(movingRight &&  tRex.Right < this.ClientSize.Width)
			{
				tRex.Left += leftRightMove;
			}

			tRex.Top += jumpSpeed;

			lbScore.Text = $"Score: {score}";
			if (jumping && force < 0)
			{
				jumping = false;
			}
			if (jumping)
			{
				jumpSpeed = -12;
				force -= 1;
			}
			else
			{
				jumpSpeed = 12;
			}

			if (tRex.Top > 468 & jumping == false)
			{
				force = 12;
				tRex.Top = 469;
				jumpSpeed = 0;
			}

			foreach(Control x in this.Controls)
			{
				if(x is PictureBox && (string)x.Tag == "obstacle")
				{
					x.Left -= obstacleSpeed;

					if(x.Left < -100)
					{
						x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
						score++;
						
						if(score > 10)
						{
							lbChat.Visible=true;
							lbChat.Text = "Quá đỉnh cao....";
							tRexTimer.Interval = 20;
						}else if (score > 20)
						{
							lbChat.Text = "Chơi quá hay....";
						}

					}
					if(tRex.Bounds.IntersectsWith(x.Bounds))
					{
						tRexTimer.Stop();
						tRex.Image = Properties.Resources.dead;
						isGameOver = true;
						lbNoti.Visible = true;
						btnMainMenu.Enabled = true;
						if(score > 0)
						{
							saveScore(score);
						}
						lbNoti.Text = $"Your Score: {score} \n Press R to restart the game!";

					}

				}
			}
		}

		private void keyisDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space && jumping == false)
			{

				jumping = true;
			}
			if (e.KeyCode == Keys.A)
			{
				movingLeft = true;
			}
			if (e.KeyCode == Keys.D)
			{
				movingRight = true;
			}
		}

		private void keyisUp(object sender, KeyEventArgs e)
		{
			if (jumping)
			{
				jumping = false;
			}
			if (e.KeyCode == Keys.A) movingLeft = false;
			if (e.KeyCode == Keys.D) movingRight = false;
			if (e.KeyCode == Keys.R && isGameOver)
			{
				resetGame();
			}
		}

		private void resetGame()
		{
			force = 12;
			jumpSpeed = 0;
			leftRightMove = 5;

			jumping = false;
			score = 0;
			obstacleSpeed = 20;

			lbScore.Text = $"Score: {score}";
			lbNoti.Visible = false;

			tRex.Image = Properties.Resources.running;
			isGameOver = false;

			btnMainMenu.Enabled = false;


			tRex.Top = 10;
			lbChat.Visible = false;

			tRexTimer.Interval = 40;

			foreach (Control x in this.Controls)
			{
				if (x is PictureBox && (string)x.Tag == "obstacle")
				{
					position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

					x.Left = position;
				}

			}
			tRexTimer.Start();

		}

		private void clickStart(object sender, EventArgs e)
		{
		
			lbScore.Visible = true;
			tRex.Visible = true;
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;

			resetGame();
			tRexStart.Dispose();
			
		}

		private void btnMainMenu_Click(object sender, EventArgs e)
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
