namespace PRN211_Final_Project.MainScreen
{
	partial class Register
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
			this.lbErrorPass = new System.Windows.Forms.Label();
			this.lbErrorRePass = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.lbFormChange = new System.Windows.Forms.Label();
			this.tbRePass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbErrorPass
			// 
			this.lbErrorPass.ForeColor = System.Drawing.Color.IndianRed;
			this.lbErrorPass.Location = new System.Drawing.Point(341, 250);
			this.lbErrorPass.Name = "lbErrorPass";
			this.lbErrorPass.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lbErrorPass.Size = new System.Drawing.Size(260, 23);
			this.lbErrorPass.TabIndex = 22;
			this.lbErrorPass.Text = "lbError";
			this.lbErrorPass.Visible = false;
			// 
			// lbErrorRePass
			// 
			this.lbErrorRePass.ForeColor = System.Drawing.Color.IndianRed;
			this.lbErrorRePass.Location = new System.Drawing.Point(341, 314);
			this.lbErrorRePass.Name = "lbErrorRePass";
			this.lbErrorRePass.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lbErrorRePass.Size = new System.Drawing.Size(260, 23);
			this.lbErrorRePass.TabIndex = 21;
			this.lbErrorRePass.Text = "lbError";
			this.lbErrorRePass.Visible = false;
			// 
			// btnRegister
			// 
			this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegister.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(344, 358);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(109, 34);
			this.btnRegister.TabIndex = 20;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// lbFormChange
			// 
			this.lbFormChange.BackColor = System.Drawing.Color.Transparent;
			this.lbFormChange.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFormChange.ForeColor = System.Drawing.Color.Black;
			this.lbFormChange.Location = new System.Drawing.Point(172, 58);
			this.lbFormChange.Name = "lbFormChange";
			this.lbFormChange.Size = new System.Drawing.Size(457, 55);
			this.lbFormChange.TabIndex = 19;
			this.lbFormChange.Text = "Register";
			this.lbFormChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbRePass
			// 
			this.tbRePass.Location = new System.Drawing.Point(344, 291);
			this.tbRePass.Name = "tbRePass";
			this.tbRePass.Size = new System.Drawing.Size(257, 20);
			this.tbRePass.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.SteelBlue;
			this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(212, 291);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "Re Password";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbUsername
			// 
			this.tbUsername.Location = new System.Drawing.Point(344, 167);
			this.tbUsername.MaxLength = 30;
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(257, 20);
			this.tbUsername.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.SteelBlue;
			this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(215, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "Username";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbPass
			// 
			this.tbPass.Location = new System.Drawing.Point(344, 227);
			this.tbPass.Name = "tbPass";
			this.tbPass.Size = new System.Drawing.Size(257, 20);
			this.tbPass.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.SteelBlue;
			this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(215, 227);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Password";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnLogin
			// 
			this.btnLogin.Enabled = false;
			this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLogin.Location = new System.Drawing.Point(679, 419);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(109, 28);
			this.btnLogin.TabIndex = 23;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.lbErrorPass);
			this.Controls.Add(this.lbErrorRePass);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.lbFormChange);
			this.Controls.Add(this.tbRePass);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbPass);
			this.Controls.Add(this.label1);
			this.Name = "Register";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbErrorPass;
		private System.Windows.Forms.Label lbErrorRePass;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Label lbFormChange;
		private System.Windows.Forms.TextBox tbRePass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLogin;
	}
}