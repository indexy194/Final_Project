namespace PRN211_Final_Project.T_Rex_Game
{
	partial class tRexGame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tRexGame));
			this.lbScore = new System.Windows.Forms.Label();
			this.tRexTimer = new System.Windows.Forms.Timer(this.components);
			this.tRexStart = new System.Windows.Forms.Button();
			this.lbNoti = new System.Windows.Forms.Label();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.lbChat = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.tRex = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tRex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbScore
			// 
			this.lbScore.AutoSize = true;
			this.lbScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScore.Location = new System.Drawing.Point(12, 9);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(106, 24);
			this.lbScore.TabIndex = 4;
			this.lbScore.Text = "Score: 0";
			// 
			// tRexTimer
			// 
			this.tRexTimer.Enabled = true;
			this.tRexTimer.Interval = 20;
			this.tRexTimer.Tick += new System.EventHandler(this.tRexTickTimer);
			// 
			// tRexStart
			// 
			this.tRexStart.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tRexStart.Location = new System.Drawing.Point(374, 203);
			this.tRexStart.Name = "tRexStart";
			this.tRexStart.Size = new System.Drawing.Size(259, 86);
			this.tRexStart.TabIndex = 5;
			this.tRexStart.Text = "Start";
			this.tRexStart.UseVisualStyleBackColor = true;
			this.tRexStart.Click += new System.EventHandler(this.clickStart);
			// 
			// lbNoti
			// 
			this.lbNoti.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNoti.Location = new System.Drawing.Point(306, 196);
			this.lbNoti.Name = "lbNoti";
			this.lbNoti.Padding = new System.Windows.Forms.Padding(10);
			this.lbNoti.Size = new System.Drawing.Size(362, 93);
			this.lbNoti.TabIndex = 6;
			this.lbNoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbNoti.Visible = false;
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Enabled = false;
			this.btnMainMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMainMenu.Location = new System.Drawing.Point(867, 552);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(105, 23);
			this.btnMainMenu.TabIndex = 8;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = true;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			// 
			// lbChat
			// 
			this.lbChat.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbChat.Location = new System.Drawing.Point(508, 9);
			this.lbChat.Name = "lbChat";
			this.lbChat.Size = new System.Drawing.Size(464, 24);
			this.lbChat.TabIndex = 9;
			this.lbChat.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lbChat.Visible = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::PRN211_Final_Project.Properties.Resources.obstacle_2;
			this.pictureBox4.Location = new System.Drawing.Point(671, 479);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(32, 33);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Tag = "obstacle";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::PRN211_Final_Project.Properties.Resources.obstacle_1;
			this.pictureBox3.Location = new System.Drawing.Point(591, 466);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 46);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "obstacle";
			// 
			// tRex
			// 
			this.tRex.Image = global::PRN211_Final_Project.Properties.Resources.running;
			this.tRex.Location = new System.Drawing.Point(122, 469);
			this.tRex.Name = "tRex";
			this.tRex.Size = new System.Drawing.Size(40, 43);
			this.tRex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.tRex.TabIndex = 1;
			this.tRex.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Location = new System.Drawing.Point(-10, 513);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1003, 75);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tRexGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 587);
			this.Controls.Add(this.lbChat);
			this.Controls.Add(this.btnMainMenu);
			this.Controls.Add(this.lbNoti);
			this.Controls.Add(this.tRexStart);
			this.Controls.Add(this.lbScore);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.tRex);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "tRexGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "T Rex Game";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tRex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox tRex;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.Timer tRexTimer;
		private System.Windows.Forms.Button tRexStart;
		private System.Windows.Forms.Label lbNoti;
		private System.Windows.Forms.Button btnMainMenu;
		private System.Windows.Forms.Label lbChat;
	}
}