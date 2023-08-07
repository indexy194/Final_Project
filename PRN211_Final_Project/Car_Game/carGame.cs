using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using PRN211_Final_Project.Car_Game;
using PRN211_Final_Project.Controller;
using PRN211_Final_Project.MainScreen;
using PRN211_Final_Project.Model;

namespace PRN211_Final_Project
{
	public partial class carGame : Form
	{
		int idCurrent;
		int gameIDCurrent;

		//intital attributes
		int roadSpeed;
		int trafficSpeed;
		int playerSpeed = 12;
		int score;
		int carImage; // change car in resources

		Random rand = new Random();
		Random carPosition = new Random(); // getPosition for two car in game



		bool goLeft, goRight = false; // the player use left and right to control

		//another game space
		Car_Game.ChangeCarType changeYC = new Car_Game.ChangeCarType();


		public carGame()
		{
			InitializeComponent();
			resetGame();


		}

		private void keyIsDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				goLeft = true;
			}
			if (e.KeyCode == Keys.Right)
			{
				goRight = true;
			}

		}

		private void keyIsUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
		
				goLeft = false;
			}
			if (e.KeyCode == Keys.Right)
			{
				goRight = false;
			}
		}

		private void gameTimerTick(object sender, EventArgs e)
		{
			lbScore.Text = $"Score: {score}";
			score++;


			if (goLeft == true & player.Left > 13)
			{
				player.Left -= playerSpeed;
			}
			if (goRight == true && player.Left < 454)
			{
				player.Left += playerSpeed;
			}
			roadTrack1.Top += roadSpeed;
			roadTrack2.Top += roadSpeed;

			if (roadTrack2.Top > 638)
			{
				roadTrack2.Top = -638;
			}
			if (roadTrack1.Top > 638)
			{
				roadTrack1.Top = -638;
			}
			AI1.Top += trafficSpeed;
			AI2.Top += trafficSpeed;


			//reset car type and position
			if (AI1.Top > 649)
			{
				changeAICar(AI1);
			}

			if (AI2.Top > 649)
			{
				changeAICar(AI2);
			}
			// impact with other car
			if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
			{
				gameOver();
				if(score > 0)
				{
					saveScore(score);
				}
			}
			if (score < 50)
			{
				award.Image = Properties.Resources.bronze;

			}
			else if (score < 300)
			{
				award.Image = Properties.Resources.silver;
				roadSpeed = 15;
				trafficSpeed = 18;
				playerSpeed = 14;

			}
			else
			{
				award.Image = Properties.Resources.gold;
				roadSpeed = 30;
				trafficSpeed = 40;

			}
		}



		private void changeAICar(PictureBox tempCar) // change car
		{
			carImage = rand.Next(1, 8);

			switch (carImage)
			{
				case 1:
					tempCar.Image = Properties.Resources.ambulance;
					break;
				case 2:
					tempCar.Image = Properties.Resources.carGreen;
					break;
				case 3:
					tempCar.Image = Properties.Resources.carPink;
					break;
				case 4:
					tempCar.Image = Properties.Resources.TruckWhite;
					break;
				case 5:
					tempCar.Image = Properties.Resources.carOrange;
					break;
				case 6:
					tempCar.Image = Properties.Resources.carGrey;
					break;
				case 7:
					Bitmap carRed = Properties.Resources.CarRed;
					tempCar.Image = carRed;
					break;
				case 8:
					tempCar.Image = Properties.Resources.TruckBlue;
					break;

			}
			tempCar.Top = carPosition.Next(100, 400) * -1;

			if ((string)tempCar.Tag == "carLeft")
			{
				tempCar.Left = carPosition.Next(15, 235);

			}

			if ((string)tempCar.Tag == "carRight")
			{
				tempCar.Left = carPosition.Next(240, 464);
			}

		}

		private void gameOver()
		{

			playSound();
			gameTimer.Stop();
			explosion.Visible = true;
			goLeft = goRight = false;

			player.Controls.Add(explosion);
			explosion.Location = new Point(-8, 3);
			explosion.BackColor = Color.Transparent;

			award.Visible = true;
			award.BringToFront();

			btnStart.Enabled = true;
			btnChangeCar.Enabled = true;
			btnMainScreen.Enabled = true;

		}

		private void resetGame()
		{

			btnStart.Enabled = false;
			btnChangeCar.Enabled = false;
			btnMainScreen.Enabled = false;

			AI1.Visible = true;
			AI2.Visible = true;

			explosion.Visible = false;
			award.Visible = false;
			goLeft = goRight =  false;
			score = 0;
			//reset location
			player.Location = new System.Drawing.Point(234, 532);
			AI1.Location = new System.Drawing.Point(54,148);
			AI2.Location = new System.Drawing.Point(357,148);


			award.Image = Properties.Resources.bronze;


			roadSpeed = 12;
			trafficSpeed = 15;
			playerSpeed = 12;

			gameTimer.Start();
		}

		private void reStart(object sender, EventArgs e)
		{
			resetGame();

		}

		private void playSound()
		{
			System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
			playCrash.Play();

		}

		private void clickChangeCar(object sender, EventArgs e)
		{
			MessageBox.Show("Feature Updating!!!");
			//btnStart.Enabled = false;
			//btnChangeCar.Enabled = false;
			//ChangeCarType carType = new ChangeCarType();
			//carType.ShowDialog();
			//carType.setUserCurrent(idCurrent);
			

		}

		public void changePlayerCar(string args) //receive invoke 
		{
			if (args == "pink")
			{
				player.Image = Properties.Resources.carplayer_pink;
			}
			else if (args == "green")
			{
				player.Image = Properties.Resources.carplayer_green;
			}
			else if (args == "aqua")
			{
				player.Image = Properties.Resources.carplayer_aqua;
			}
			else if (args == "blue")
			{
				player.Image = Properties.Resources.carplayer_blue;
			}
			else
			{
				player.Image = Properties.Resources.carYellow;
			}
			btnStart.Enabled = true;
			btnChangeCar.Enabled = true;
			resetScreen();

		}

		private void mainScreenClicked(object sender, EventArgs e)
		{
			UserScreen userScreen = new UserScreen();
			userScreen.setInforUser(true, idCurrent);
			userScreen.Show();
			this.Close();
		}

		private void resetScreen()
		{
			gameTimer.Stop();
			explosion.Visible = false;
			award.Visible = false;
			AI1.Visible = false;
			AI2.Visible = false;
			goLeft = false;
			goRight = false;
			score = 0;
			player.Location = new System.Drawing.Point(234, 532);

			lbScore.Text = $"Score: {score}";
		}
		public void setUserCurrent(int id, int gameId)
		{
			idCurrent = id;
			gameIDCurrent = gameId;
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
