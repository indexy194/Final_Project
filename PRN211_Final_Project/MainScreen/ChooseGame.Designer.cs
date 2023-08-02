namespace PRN211_Final_Project.MainScreen
{
	partial class UserScreen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserScreen));
			this.sideBar = new System.Windows.Forms.Panel();
			this.lbChangePass = new System.Windows.Forms.Label();
			this.leaderBoard = new System.Windows.Forms.Label();
			this.lbScore = new System.Windows.Forms.Label();
			this.avatar = new System.Windows.Forms.PictureBox();
			this.lbUsername = new System.Windows.Forms.Label();
			this.lbLogOut = new System.Windows.Forms.Label();
			this.flappyBird = new System.Windows.Forms.Label();
			this.tRexGame = new System.Windows.Forms.Label();
			this.carGame = new System.Windows.Forms.Label();
			this.sideBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
			this.SuspendLayout();
			// 
			// sideBar
			// 
			this.sideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.sideBar.Controls.Add(this.lbChangePass);
			this.sideBar.Controls.Add(this.leaderBoard);
			this.sideBar.Controls.Add(this.lbScore);
			this.sideBar.Controls.Add(this.avatar);
			this.sideBar.Controls.Add(this.lbUsername);
			this.sideBar.Controls.Add(this.lbLogOut);
			this.sideBar.Controls.Add(this.flappyBird);
			this.sideBar.Controls.Add(this.tRexGame);
			this.sideBar.Controls.Add(this.carGame);
			this.sideBar.Location = new System.Drawing.Point(2, 3);
			this.sideBar.Name = "sideBar";
			this.sideBar.Size = new System.Drawing.Size(454, 569);
			this.sideBar.TabIndex = 0;
			// 
			// lbChangePass
			// 
			this.lbChangePass.BackColor = System.Drawing.Color.SteelBlue;
			this.lbChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbChangePass.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbChangePass.Location = new System.Drawing.Point(166, 394);
			this.lbChangePass.Name = "lbChangePass";
			this.lbChangePass.Size = new System.Drawing.Size(144, 41);
			this.lbChangePass.TabIndex = 8;
			this.lbChangePass.Text = "Change Password";
			this.lbChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbChangePass.Click += new System.EventHandler(this.changePassClicked);
			// 
			// leaderBoard
			// 
			this.leaderBoard.BackColor = System.Drawing.Color.SteelBlue;
			this.leaderBoard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.leaderBoard.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.leaderBoard.Location = new System.Drawing.Point(166, 319);
			this.leaderBoard.Name = "leaderBoard";
			this.leaderBoard.Size = new System.Drawing.Size(144, 41);
			this.leaderBoard.TabIndex = 7;
			this.leaderBoard.Text = "LeaderBoard";
			this.leaderBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.leaderBoard.Click += new System.EventHandler(this.changeBXH);
			// 
			// lbScore
			// 
			this.lbScore.BackColor = System.Drawing.Color.Transparent;
			this.lbScore.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScore.Location = new System.Drawing.Point(60, 64);
			this.lbScore.Name = "lbScore";
			this.lbScore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lbScore.Size = new System.Drawing.Size(127, 15);
			this.lbScore.TabIndex = 6;
			this.lbScore.Text = "Total Score: 100";
			this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// avatar
			// 
			this.avatar.BackColor = System.Drawing.Color.Transparent;
			this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
			this.avatar.Location = new System.Drawing.Point(11, 23);
			this.avatar.Name = "avatar";
			this.avatar.Size = new System.Drawing.Size(43, 41);
			this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.avatar.TabIndex = 1;
			this.avatar.TabStop = false;
			// 
			// lbUsername
			// 
			this.lbUsername.BackColor = System.Drawing.Color.SteelBlue;
			this.lbUsername.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.Location = new System.Drawing.Point(60, 23);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lbUsername.Size = new System.Drawing.Size(127, 41);
			this.lbUsername.TabIndex = 5;
			this.lbUsername.Text = "Indexy";
			this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbLogOut
			// 
			this.lbLogOut.BackColor = System.Drawing.Color.Transparent;
			this.lbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbLogOut.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLogOut.Location = new System.Drawing.Point(166, 507);
			this.lbLogOut.Name = "lbLogOut";
			this.lbLogOut.Size = new System.Drawing.Size(144, 41);
			this.lbLogOut.TabIndex = 4;
			this.lbLogOut.Text = "Logout";
			this.lbLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lbLogOut.Click += new System.EventHandler(this.logoutClick);
			// 
			// flappyBird
			// 
			this.flappyBird.BackColor = System.Drawing.Color.SteelBlue;
			this.flappyBird.Cursor = System.Windows.Forms.Cursors.Hand;
			this.flappyBird.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flappyBird.Location = new System.Drawing.Point(166, 250);
			this.flappyBird.Name = "flappyBird";
			this.flappyBird.Size = new System.Drawing.Size(144, 41);
			this.flappyBird.TabIndex = 3;
			this.flappyBird.Text = "Flappy Bird";
			this.flappyBird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.flappyBird.Click += new System.EventHandler(this.changeFappyBird);
			// 
			// tRexGame
			// 
			this.tRexGame.BackColor = System.Drawing.Color.SteelBlue;
			this.tRexGame.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tRexGame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tRexGame.Location = new System.Drawing.Point(166, 185);
			this.tRexGame.Name = "tRexGame";
			this.tRexGame.Size = new System.Drawing.Size(144, 41);
			this.tRexGame.TabIndex = 2;
			this.tRexGame.Text = "T Rex Game";
			this.tRexGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tRexGame.Click += new System.EventHandler(this.changeTRexGame);
			// 
			// carGame
			// 
			this.carGame.BackColor = System.Drawing.Color.GreenYellow;
			this.carGame.Cursor = System.Windows.Forms.Cursors.Hand;
			this.carGame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carGame.Location = new System.Drawing.Point(166, 118);
			this.carGame.Name = "carGame";
			this.carGame.Size = new System.Drawing.Size(144, 41);
			this.carGame.TabIndex = 1;
			this.carGame.Text = "Car Game";
			this.carGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.carGame.Click += new System.EventHandler(this.changeCarGame);
			// 
			// UserScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 577);
			this.Controls.Add(this.sideBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "UserScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Game";
			this.Load += new System.EventHandler(this.userScreenLoad);
			this.sideBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel sideBar;
		private System.Windows.Forms.Label lbLogOut;
		private System.Windows.Forms.Label flappyBird;
		private System.Windows.Forms.Label tRexGame;
		private System.Windows.Forms.Label carGame;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.PictureBox avatar;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.Label leaderBoard;
		private System.Windows.Forms.Label lbChangePass;
	}
}