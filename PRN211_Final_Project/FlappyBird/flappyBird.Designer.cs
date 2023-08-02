namespace PRN211_Final_Project.FlappyBird
{
	partial class flappyBird
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flappyBird));
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.backgroundFB = new System.Windows.Forms.Panel();
			this.btnStartGame = new System.Windows.Forms.Button();
			this.lbNoti = new System.Windows.Forms.Label();
			this.mainChar = new System.Windows.Forms.PictureBox();
			this.lbScore = new System.Windows.Forms.Label();
			this.bar = new System.Windows.Forms.PictureBox();
			this.invertBar = new System.Windows.Forms.PictureBox();
			this.back2 = new System.Windows.Forms.PictureBox();
			this.back1 = new System.Windows.Forms.PictureBox();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.backgroundFB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainChar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invertBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.back2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.back1)).BeginInit();
			this.SuspendLayout();
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimerTick);
			// 
			// backgroundFB
			// 
			this.backgroundFB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.backgroundFB.Controls.Add(this.btnStartGame);
			this.backgroundFB.Controls.Add(this.lbNoti);
			this.backgroundFB.Controls.Add(this.mainChar);
			this.backgroundFB.Controls.Add(this.lbScore);
			this.backgroundFB.Controls.Add(this.bar);
			this.backgroundFB.Controls.Add(this.invertBar);
			this.backgroundFB.Controls.Add(this.back2);
			this.backgroundFB.Controls.Add(this.back1);
			this.backgroundFB.Location = new System.Drawing.Point(4, 6);
			this.backgroundFB.Name = "backgroundFB";
			this.backgroundFB.Size = new System.Drawing.Size(533, 664);
			this.backgroundFB.TabIndex = 0;
			// 
			// btnStartGame
			// 
			this.btnStartGame.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartGame.Location = new System.Drawing.Point(166, 283);
			this.btnStartGame.Name = "btnStartGame";
			this.btnStartGame.Size = new System.Drawing.Size(162, 65);
			this.btnStartGame.TabIndex = 8;
			this.btnStartGame.Text = "Start ";
			this.btnStartGame.UseVisualStyleBackColor = true;
			this.btnStartGame.Click += new System.EventHandler(this.startEvent);
			// 
			// lbNoti
			// 
			this.lbNoti.BackColor = System.Drawing.Color.Transparent;
			this.lbNoti.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNoti.Location = new System.Drawing.Point(81, 255);
			this.lbNoti.Name = "lbNoti";
			this.lbNoti.Padding = new System.Windows.Forms.Padding(10);
			this.lbNoti.Size = new System.Drawing.Size(362, 93);
			this.lbNoti.TabIndex = 7;
			this.lbNoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbNoti.Visible = false;
			// 
			// mainChar
			// 
			this.mainChar.BackColor = System.Drawing.Color.Transparent;
			this.mainChar.Image = global::PRN211_Final_Project.Properties.Resources.stella;
			this.mainChar.Location = new System.Drawing.Point(31, 283);
			this.mainChar.Name = "mainChar";
			this.mainChar.Size = new System.Drawing.Size(100, 65);
			this.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.mainChar.TabIndex = 1;
			this.mainChar.TabStop = false;
			// 
			// lbScore
			// 
			this.lbScore.AutoSize = true;
			this.lbScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScore.ForeColor = System.Drawing.Color.White;
			this.lbScore.Image = global::PRN211_Final_Project.Properties.Resources.e720d057_ec57_48d7_a66f_e40692cbe53e;
			this.lbScore.Location = new System.Drawing.Point(8, 12);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(106, 24);
			this.lbScore.TabIndex = 4;
			this.lbScore.Text = "Score: 0";
			this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bar
			// 
			this.bar.BackColor = System.Drawing.Color.Transparent;
			this.bar.Image = global::PRN211_Final_Project.Properties.Resources.bar;
			this.bar.Location = new System.Drawing.Point(343, 444);
			this.bar.Name = "bar";
			this.bar.Size = new System.Drawing.Size(100, 311);
			this.bar.TabIndex = 3;
			this.bar.TabStop = false;
			// 
			// invertBar
			// 
			this.invertBar.BackColor = System.Drawing.Color.Transparent;
			this.invertBar.Image = global::PRN211_Final_Project.Properties.Resources.invert_bar;
			this.invertBar.Location = new System.Drawing.Point(352, -238);
			this.invertBar.Name = "invertBar";
			this.invertBar.Size = new System.Drawing.Size(81, 400);
			this.invertBar.TabIndex = 2;
			this.invertBar.TabStop = false;
			// 
			// back2
			// 
			this.back2.BackColor = System.Drawing.Color.Transparent;
			this.back2.Image = global::PRN211_Final_Project.Properties.Resources.bg_pic2;
			this.back2.Location = new System.Drawing.Point(312, 491);
			this.back2.Name = "back2";
			this.back2.Size = new System.Drawing.Size(184, 188);
			this.back2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.back2.TabIndex = 6;
			this.back2.TabStop = false;
			this.back2.Visible = false;
			// 
			// back1
			// 
			this.back1.BackColor = System.Drawing.Color.Transparent;
			this.back1.Image = global::PRN211_Final_Project.Properties.Resources.bg_pic1;
			this.back1.Location = new System.Drawing.Point(12, 527);
			this.back1.Name = "back1";
			this.back1.Size = new System.Drawing.Size(260, 188);
			this.back1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.back1.TabIndex = 5;
			this.back1.TabStop = false;
			this.back1.Visible = false;
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Enabled = false;
			this.btnMainMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMainMenu.Location = new System.Drawing.Point(432, 691);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(105, 23);
			this.btnMainMenu.TabIndex = 9;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = true;
			this.btnMainMenu.Click += new System.EventHandler(this.mainMenuClicked);
			// 
			// flappyBird
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 735);
			this.Controls.Add(this.btnMainMenu);
			this.Controls.Add(this.backgroundFB);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "flappyBird";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Flappy Human";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isKeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.isKeyUp);
			this.backgroundFB.ResumeLayout(false);
			this.backgroundFB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainChar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invertBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.back2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.back1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel backgroundFB;
		private System.Windows.Forms.PictureBox bar;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.PictureBox mainChar;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.PictureBox back1;
		private System.Windows.Forms.PictureBox back2;
		private System.Windows.Forms.Label lbNoti;
		private System.Windows.Forms.Button btnMainMenu;
		private System.Windows.Forms.PictureBox invertBar;
		private System.Windows.Forms.Button btnStartGame;
	}
}