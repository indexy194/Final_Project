namespace PRN211_Final_Project.MainScreen
{
	partial class LeaderBoard
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
			this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.btnCar = new System.Windows.Forms.Button();
			this.btnFlappyBird = new System.Windows.Forms.Button();
			this.btnTRex = new System.Windows.Forms.Button();
			this.lbLeaderBoard = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvLeaderboard
			// 
			this.dgvLeaderboard.AllowUserToResizeColumns = false;
			this.dgvLeaderboard.AllowUserToResizeRows = false;
			this.dgvLeaderboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvLeaderboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLeaderboard.Location = new System.Drawing.Point(167, 101);
			this.dgvLeaderboard.Name = "dgvLeaderboard";
			this.dgvLeaderboard.Size = new System.Drawing.Size(475, 362);
			this.dgvLeaderboard.TabIndex = 0;
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Enabled = false;
			this.btnMainMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMainMenu.Location = new System.Drawing.Point(683, 492);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(105, 23);
			this.btnMainMenu.TabIndex = 9;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = true;
			this.btnMainMenu.Click += new System.EventHandler(this.mainMenuClicked);
			// 
			// btnCar
			// 
			this.btnCar.Location = new System.Drawing.Point(69, 12);
			this.btnCar.Name = "btnCar";
			this.btnCar.Size = new System.Drawing.Size(82, 23);
			this.btnCar.TabIndex = 10;
			this.btnCar.Text = "BXH Car";
			this.btnCar.UseVisualStyleBackColor = true;
			this.btnCar.Click += new System.EventHandler(this.carClick);
			// 
			// btnFlappyBird
			// 
			this.btnFlappyBird.Location = new System.Drawing.Point(325, 12);
			this.btnFlappyBird.Name = "btnFlappyBird";
			this.btnFlappyBird.Size = new System.Drawing.Size(125, 23);
			this.btnFlappyBird.TabIndex = 11;
			this.btnFlappyBird.Text = "BXH Flappy Bird";
			this.btnFlappyBird.UseVisualStyleBackColor = true;
			this.btnFlappyBird.Click += new System.EventHandler(this.flappyBirdClick);
			// 
			// btnTRex
			// 
			this.btnTRex.Location = new System.Drawing.Point(651, 12);
			this.btnTRex.Name = "btnTRex";
			this.btnTRex.Size = new System.Drawing.Size(82, 23);
			this.btnTRex.TabIndex = 12;
			this.btnTRex.Text = "BXH T-Rex";
			this.btnTRex.UseVisualStyleBackColor = true;
			this.btnTRex.Click += new System.EventHandler(this.tRexClick);
			// 
			// lbLeaderBoard
			// 
			this.lbLeaderBoard.AutoSize = true;
			this.lbLeaderBoard.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLeaderBoard.Location = new System.Drawing.Point(360, 65);
			this.lbLeaderBoard.Name = "lbLeaderBoard";
			this.lbLeaderBoard.Size = new System.Drawing.Size(94, 24);
			this.lbLeaderBoard.TabIndex = 13;
			this.lbLeaderBoard.Text = "BXH Car";
			// 
			// LeaderBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 527);
			this.Controls.Add(this.lbLeaderBoard);
			this.Controls.Add(this.btnTRex);
			this.Controls.Add(this.btnFlappyBird);
			this.Controls.Add(this.btnCar);
			this.Controls.Add(this.btnMainMenu);
			this.Controls.Add(this.dgvLeaderboard);
			this.Name = "LeaderBoard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LeaderBoard";
			this.Load += new System.EventHandler(this.loadLeaderboard);
			((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvLeaderboard;
		private System.Windows.Forms.Button btnMainMenu;
		private System.Windows.Forms.Button btnCar;
		private System.Windows.Forms.Button btnFlappyBird;
		private System.Windows.Forms.Button btnTRex;
		private System.Windows.Forms.Label lbLeaderBoard;
	}
}