namespace PRN211_Final_Project
{
	partial class carGame
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
			System.Windows.Forms.Label lbIntro;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carGame));
			this.panel1 = new System.Windows.Forms.Panel();
			this.explosion = new System.Windows.Forms.PictureBox();
			this.award = new System.Windows.Forms.PictureBox();
			this.player = new System.Windows.Forms.PictureBox();
			this.AI2 = new System.Windows.Forms.PictureBox();
			this.AI1 = new System.Windows.Forms.PictureBox();
			this.roadTrack2 = new System.Windows.Forms.PictureBox();
			this.roadTrack1 = new System.Windows.Forms.PictureBox();
			this.lbScore = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.btnStart = new System.Windows.Forms.Button();
			this.btnChangeCar = new System.Windows.Forms.Button();
			this.lbStart = new System.Windows.Forms.Label();
			this.lbChangeCar = new System.Windows.Forms.Label();
			this.btnMainScreen = new System.Windows.Forms.Button();
			lbIntro = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbIntro
			// 
			lbIntro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lbIntro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			lbIntro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			lbIntro.Location = new System.Drawing.Point(3, 783);
			lbIntro.Name = "lbIntro";
			lbIntro.Size = new System.Drawing.Size(536, 28);
			lbIntro.TabIndex = 4;
			lbIntro.Text = "Press Left and Right to move the Car.\r\n\r\n\r\n";
			lbIntro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.explosion);
			this.panel1.Controls.Add(this.award);
			this.panel1.Controls.Add(this.player);
			this.panel1.Controls.Add(this.AI2);
			this.panel1.Controls.Add(this.AI1);
			this.panel1.Controls.Add(this.roadTrack2);
			this.panel1.Controls.Add(this.roadTrack1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(517, 648);
			this.panel1.TabIndex = 0;
			// 
			// explosion
			// 
			this.explosion.Image = global::PRN211_Final_Project.Properties.Resources.explosion;
			this.explosion.Location = new System.Drawing.Point(86, 495);
			this.explosion.Name = "explosion";
			this.explosion.Size = new System.Drawing.Size(64, 64);
			this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.explosion.TabIndex = 2;
			this.explosion.TabStop = false;
			// 
			// award
			// 
			this.award.Image = global::PRN211_Final_Project.Properties.Resources.bronze;
			this.award.Location = new System.Drawing.Point(139, 282);
			this.award.Name = "award";
			this.award.Size = new System.Drawing.Size(250, 100);
			this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.award.TabIndex = 2;
			this.award.TabStop = false;
			// 
			// player
			// 
			this.player.Image = global::PRN211_Final_Project.Properties.Resources.carYellow;
			this.player.Location = new System.Drawing.Point(234, 532);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(50, 99);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.player.TabIndex = 2;
			this.player.TabStop = false;
			// 
			// AI2
			// 
			this.AI2.Image = ((System.Drawing.Image)(resources.GetObject("AI2.Image")));
			this.AI2.Location = new System.Drawing.Point(357, 148);
			this.AI2.Name = "AI2";
			this.AI2.Size = new System.Drawing.Size(50, 101);
			this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.AI2.TabIndex = 2;
			this.AI2.TabStop = false;
			this.AI2.Tag = "carRight";
			// 
			// AI1
			// 
			this.AI1.Image = ((System.Drawing.Image)(resources.GetObject("AI1.Image")));
			this.AI1.Location = new System.Drawing.Point(54, 148);
			this.AI1.Name = "AI1";
			this.AI1.Size = new System.Drawing.Size(50, 100);
			this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.AI1.TabIndex = 2;
			this.AI1.TabStop = false;
			this.AI1.Tag = "carLeft";
			// 
			// roadTrack2
			// 
			this.roadTrack2.Image = global::PRN211_Final_Project.Properties.Resources.roadTrack;
			this.roadTrack2.Location = new System.Drawing.Point(0, 0);
			this.roadTrack2.Name = "roadTrack2";
			this.roadTrack2.Size = new System.Drawing.Size(517, 648);
			this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.roadTrack2.TabIndex = 1;
			this.roadTrack2.TabStop = false;
			// 
			// roadTrack1
			// 
			this.roadTrack1.Image = global::PRN211_Final_Project.Properties.Resources.roadTrack;
			this.roadTrack1.Location = new System.Drawing.Point(0, -648);
			this.roadTrack1.Name = "roadTrack1";
			this.roadTrack1.Size = new System.Drawing.Size(517, 648);
			this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.roadTrack1.TabIndex = 0;
			this.roadTrack1.TabStop = false;
			// 
			// lbScore
			// 
			this.lbScore.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lbScore.Location = new System.Drawing.Point(3, 663);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(546, 23);
			this.lbScore.TabIndex = 2;
			this.lbScore.Text = "Score: 0";
			this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gameTimer
			// 
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimerTick);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.Azure;
			this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
			this.btnStart.Location = new System.Drawing.Point(98, 700);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(120, 50);
			this.btnStart.TabIndex = 1;
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.reStart);
			// 
			// btnChangeCar
			// 
			this.btnChangeCar.BackColor = System.Drawing.Color.Azure;
			this.btnChangeCar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangeCar.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeCar.Image")));
			this.btnChangeCar.Location = new System.Drawing.Point(330, 700);
			this.btnChangeCar.Name = "btnChangeCar";
			this.btnChangeCar.Size = new System.Drawing.Size(120, 50);
			this.btnChangeCar.TabIndex = 5;
			this.btnChangeCar.UseVisualStyleBackColor = false;
			this.btnChangeCar.Click += new System.EventHandler(this.clickChangeCar);
			// 
			// lbStart
			// 
			this.lbStart.AutoSize = true;
			this.lbStart.Location = new System.Drawing.Point(148, 684);
			this.lbStart.Name = "lbStart";
			this.lbStart.Size = new System.Drawing.Size(29, 13);
			this.lbStart.TabIndex = 6;
			this.lbStart.Text = "Start";
			// 
			// lbChangeCar
			// 
			this.lbChangeCar.AutoSize = true;
			this.lbChangeCar.Location = new System.Drawing.Point(346, 684);
			this.lbChangeCar.Name = "lbChangeCar";
			this.lbChangeCar.Size = new System.Drawing.Size(88, 13);
			this.lbChangeCar.TabIndex = 7;
			this.lbChangeCar.Text = "Change Your Car";
			// 
			// btnMainScreen
			// 
			this.btnMainScreen.Location = new System.Drawing.Point(464, 836);
			this.btnMainScreen.Name = "btnMainScreen";
			this.btnMainScreen.Size = new System.Drawing.Size(75, 23);
			this.btnMainScreen.TabIndex = 8;
			this.btnMainScreen.Text = "Main Screen";
			this.btnMainScreen.UseVisualStyleBackColor = true;
			this.btnMainScreen.Click += new System.EventHandler(this.mainScreenClicked);
			// 
			// carGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Ivory;
			this.ClientSize = new System.Drawing.Size(541, 862);
			this.Controls.Add(this.btnMainScreen);
			this.Controls.Add(this.lbChangeCar);
			this.Controls.Add(this.lbStart);
			this.Controls.Add(this.btnChangeCar);
			this.Controls.Add(lbIntro);
			this.Controls.Add(this.lbScore);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "carGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Car Game - Indexy";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.PictureBox roadTrack1;
		private System.Windows.Forms.PictureBox roadTrack2;
		private System.Windows.Forms.PictureBox AI1;
		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.PictureBox AI2;
		private System.Windows.Forms.PictureBox explosion;
		private System.Windows.Forms.PictureBox award;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Button btnChangeCar;
		private System.Windows.Forms.Label lbStart;
		private System.Windows.Forms.Label lbChangeCar;
		private System.Windows.Forms.Button btnMainScreen;
	}
}

