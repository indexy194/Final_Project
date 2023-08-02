namespace PRN211_Final_Project.Car_Game
{
	partial class ChangeCarType
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCarType));
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.pictureType = new System.Windows.Forms.PictureBox();
			this.lbCarType1 = new System.Windows.Forms.Label();
			this.lbCarType2 = new System.Windows.Forms.Label();
			this.lbCarType3 = new System.Windows.Forms.Label();
			this.lbCarType4 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureType)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
			this.tableLayoutPanel.Controls.Add(this.pictureType, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.lbCarType1, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.lbCarType2, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.lbCarType3, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.lbCarType4, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.txtDescription, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(417, 265);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// pictureType
			// 
			this.pictureType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureType.Image = global::PRN211_Final_Project.Properties.Resources.carplayer_green;
			this.pictureType.Location = new System.Drawing.Point(3, 3);
			this.pictureType.Name = "pictureType";
			this.tableLayoutPanel.SetRowSpan(this.pictureType, 6);
			this.pictureType.Size = new System.Drawing.Size(131, 259);
			this.pictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureType.TabIndex = 12;
			this.pictureType.TabStop = false;
			// 
			// lbCarType1
			// 
			this.lbCarType1.AutoSize = true;
			this.lbCarType1.BackColor = System.Drawing.Color.Black;
			this.lbCarType1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbCarType1.ForeColor = System.Drawing.Color.White;
			this.lbCarType1.Location = new System.Drawing.Point(143, 0);
			this.lbCarType1.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.lbCarType1.MaximumSize = new System.Drawing.Size(0, 17);
			this.lbCarType1.Name = "lbCarType1";
			this.lbCarType1.Size = new System.Drawing.Size(271, 17);
			this.lbCarType1.TabIndex = 19;
			this.lbCarType1.Text = "Xe Xanh (HOT)";
			this.lbCarType1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbCarType1.Click += new System.EventHandler(this.changeType1);
			// 
			// lbCarType2
			// 
			this.lbCarType2.BackColor = System.Drawing.Color.Black;
			this.lbCarType2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbCarType2.ForeColor = System.Drawing.Color.White;
			this.lbCarType2.Location = new System.Drawing.Point(143, 26);
			this.lbCarType2.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.lbCarType2.MaximumSize = new System.Drawing.Size(0, 17);
			this.lbCarType2.Name = "lbCarType2";
			this.lbCarType2.Size = new System.Drawing.Size(271, 17);
			this.lbCarType2.TabIndex = 0;
			this.lbCarType2.Text = "Xe Hồng Nữ Tính";
			this.lbCarType2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbCarType2.Click += new System.EventHandler(this.changeType2);
			// 
			// lbCarType3
			// 
			this.lbCarType3.BackColor = System.Drawing.Color.Black;
			this.lbCarType3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbCarType3.ForeColor = System.Drawing.Color.White;
			this.lbCarType3.Location = new System.Drawing.Point(143, 52);
			this.lbCarType3.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.lbCarType3.MaximumSize = new System.Drawing.Size(0, 17);
			this.lbCarType3.Name = "lbCarType3";
			this.lbCarType3.Size = new System.Drawing.Size(271, 17);
			this.lbCarType3.TabIndex = 21;
			this.lbCarType3.Text = "Xe Cho Wibu";
			this.lbCarType3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbCarType3.Click += new System.EventHandler(this.changeType3);
			// 
			// lbCarType4
			// 
			this.lbCarType4.BackColor = System.Drawing.Color.Black;
			this.lbCarType4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbCarType4.ForeColor = System.Drawing.Color.White;
			this.lbCarType4.Location = new System.Drawing.Point(143, 78);
			this.lbCarType4.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.lbCarType4.MaximumSize = new System.Drawing.Size(0, 17);
			this.lbCarType4.Name = "lbCarType4";
			this.lbCarType4.Size = new System.Drawing.Size(271, 17);
			this.lbCarType4.TabIndex = 22;
			this.lbCarType4.Text = "Xe Săt Vụn";
			this.lbCarType4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbCarType4.Click += new System.EventHandler(this.changeType4);
			// 
			// txtDescription
			// 
			this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDescription.Location = new System.Drawing.Point(143, 107);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDescription.Size = new System.Drawing.Size(271, 126);
			this.txtDescription.TabIndex = 23;
			this.txtDescription.TabStop = false;
			this.txtDescription.Text = "- Cách bạn chọn xe quyết định con người của bạn .";
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new System.Drawing.Point(339, 239);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 24;
			this.okButton.Text = "OK ";
			this.okButton.Click += new System.EventHandler(this.clickOK);
			// 
			// ChangeCarType
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 283);
			this.Controls.Add(this.tableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChangeCarType";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Đổi loại xe";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureType)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox pictureType;
		private System.Windows.Forms.Label lbCarType1;
		private System.Windows.Forms.Label lbCarType2;
		private System.Windows.Forms.Label lbCarType3;
		private System.Windows.Forms.Label lbCarType4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button okButton;
	}
}
