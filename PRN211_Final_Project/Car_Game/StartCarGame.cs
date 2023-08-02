using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Final_Project
{
	public partial class StartCarGame : Form
	{
		int ID;
		public StartCarGame()
		{
			InitializeComponent();
		}

		private void clickStart(object sender, EventArgs e)
		{
			carGame carGame = new carGame();
			carGame.setUserCurrent(ID, 1);
			carGame.Show();
			this.Close();
			this.Dispose();
		
		}
		public void setUserCurrent(int id)
		{
			ID = id;
		}
	}
}
