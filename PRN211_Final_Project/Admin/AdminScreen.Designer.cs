namespace PRN211_Final_Project.Admin
{
	partial class AdminScreen
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
			this.btnListScore = new System.Windows.Forms.Button();
			this.btnListAccount = new System.Windows.Forms.Button();
			this.btnListGame = new System.Windows.Forms.Button();
			this.dgvAdminRole = new System.Windows.Forms.DataGridView();
			this.lbAdmin = new System.Windows.Forms.Label();
			this.btnLogOut = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdminRole)).BeginInit();
			this.SuspendLayout();
			// 
			// btnListScore
			// 
			this.btnListScore.Location = new System.Drawing.Point(803, 158);
			this.btnListScore.Name = "btnListScore";
			this.btnListScore.Size = new System.Drawing.Size(108, 43);
			this.btnListScore.TabIndex = 0;
			this.btnListScore.Text = "List Score";
			this.btnListScore.UseVisualStyleBackColor = true;
			// 
			// btnListAccount
			// 
			this.btnListAccount.Location = new System.Drawing.Point(803, 84);
			this.btnListAccount.Name = "btnListAccount";
			this.btnListAccount.Size = new System.Drawing.Size(108, 43);
			this.btnListAccount.TabIndex = 1;
			this.btnListAccount.Text = "List Account";
			this.btnListAccount.UseVisualStyleBackColor = true;
			// 
			// btnListGame
			// 
			this.btnListGame.Location = new System.Drawing.Point(803, 234);
			this.btnListGame.Name = "btnListGame";
			this.btnListGame.Size = new System.Drawing.Size(108, 43);
			this.btnListGame.TabIndex = 2;
			this.btnListGame.Text = "List Game";
			this.btnListGame.UseVisualStyleBackColor = true;
			// 
			// dgvAdminRole
			// 
			this.dgvAdminRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdminRole.Location = new System.Drawing.Point(12, 84);
			this.dgvAdminRole.Name = "dgvAdminRole";
			this.dgvAdminRole.Size = new System.Drawing.Size(726, 389);
			this.dgvAdminRole.TabIndex = 3;
			// 
			// lbAdmin
			// 
			this.lbAdmin.AutoSize = true;
			this.lbAdmin.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAdmin.Location = new System.Drawing.Point(264, 35);
			this.lbAdmin.Name = "lbAdmin";
			this.lbAdmin.Size = new System.Drawing.Size(207, 28);
			this.lbAdmin.TabIndex = 4;
			this.lbAdmin.Text = "Admin Dashboard";
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(803, 430);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(108, 43);
			this.btnLogOut.TabIndex = 5;
			this.btnLogOut.Text = "Log Out";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.logoutAdmin);
			// 
			// AdminScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 509);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.lbAdmin);
			this.Controls.Add(this.dgvAdminRole);
			this.Controls.Add(this.btnListGame);
			this.Controls.Add(this.btnListAccount);
			this.Controls.Add(this.btnListScore);
			this.Name = "AdminScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminScreen";
			this.Load += new System.EventHandler(this.adminDashboard);
			((System.ComponentModel.ISupportInitialize)(this.dgvAdminRole)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnListScore;
		private System.Windows.Forms.Button btnListAccount;
		private System.Windows.Forms.Button btnListGame;
		private System.Windows.Forms.DataGridView dgvAdminRole;
		private System.Windows.Forms.Label lbAdmin;
		private System.Windows.Forms.Button btnLogOut;
	}
}