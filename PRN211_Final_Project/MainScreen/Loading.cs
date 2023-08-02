using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Final_Project.MainScreen
{
	public partial class Loading : Form
	{
		Login login = new Login();
		int percent = 0;
		int imageSpeed = 6;

		public Loading()
		{
			InitializeComponent();
		}
		
		private void loadingTimerTick(object sender, EventArgs e)
		{

			percent += 1;
			percentImage.Left += imageSpeed;

			loadingBar.Value = percent;
			if(loadingBar.Value == 100)
			{
				lbLoading.Visible = percentImage.Visible = false;

				loadingBar.Value = 0;
				loadingTimer.Stop();
				login.Show();
				this.Hide();

			}
		}

		private void loading(object sender, EventArgs e)
		{
			loadingTimer.Start();
		}
	}
}
