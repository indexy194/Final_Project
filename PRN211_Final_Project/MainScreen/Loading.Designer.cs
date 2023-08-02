namespace PRN211_Final_Project.MainScreen
{
	partial class Loading
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.loadingBar = new System.Windows.Forms.ProgressBar();
			this.lbLoading = new System.Windows.Forms.Label();
			this.percentImage = new System.Windows.Forms.PictureBox();
			this.loadingTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.percentImage)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(143, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(392, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enjoy Your Life";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(262, 95);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(146, 126);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// loadingBar
			// 
			this.loadingBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.loadingBar.Location = new System.Drawing.Point(34, 337);
			this.loadingBar.Name = "loadingBar";
			this.loadingBar.Size = new System.Drawing.Size(620, 13);
			this.loadingBar.TabIndex = 2;
			// 
			// lbLoading
			// 
			this.lbLoading.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLoading.Location = new System.Drawing.Point(31, 353);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Size = new System.Drawing.Size(113, 23);
			this.lbLoading.TabIndex = 3;
			this.lbLoading.Text = "Loading...";
			this.lbLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// percentImage
			// 
			this.percentImage.BackColor = System.Drawing.Color.Transparent;
			this.percentImage.Image = global::PRN211_Final_Project.Properties.Resources.stella;
			this.percentImage.Location = new System.Drawing.Point(34, 295);
			this.percentImage.Name = "percentImage";
			this.percentImage.Size = new System.Drawing.Size(39, 36);
			this.percentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.percentImage.TabIndex = 4;
			this.percentImage.TabStop = false;
			// 
			// loadingTimer
			// 
			this.loadingTimer.Tick += new System.EventHandler(this.loadingTimerTick);
			// 
			// Loading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 489);
			this.Controls.Add(this.percentImage);
			this.Controls.Add(this.lbLoading);
			this.Controls.Add(this.loadingBar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Loading";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loading";
			this.Load += new System.EventHandler(this.loading);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.percentImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ProgressBar loadingBar;
		private System.Windows.Forms.Label lbLoading;
		private System.Windows.Forms.PictureBox percentImage;
		private System.Windows.Forms.Timer loadingTimer;
	}
}