using PRN211_Final_Project.Controller;
using PRN211_Final_Project.Model;
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
	public partial class LeaderBoard : Form
	{
		int idCurrent;
		BindingSource albumBindingSource = new BindingSource();
		public LeaderBoard()
		{
			InitializeComponent();
		}

		private void loadLeaderboard(object sender, EventArgs e)
		{
			btnMainMenu.Enabled = true;
			ScoreController scoreController = new ScoreController();
			List<Score> scores = scoreController.getLeaderScoreByID(1);
			lbLeaderBoard.Text = changeLB(1);
			displayList(scores);

		}
		private void mainMenuClicked(object sender, EventArgs e)
		{
			UserScreen userScreen = new UserScreen();
			userScreen.setInforUser(true, idCurrent);
			userScreen.Show();
			this.Close();
		}
		public void setUserCurrent(int id)
		{
			idCurrent = id;
		}

		private void carClick(object sender, EventArgs e)
		{
			ScoreController scoreController = new ScoreController();

			List<Score> scores = scoreController.getLeaderScoreByID(1);
			lbLeaderBoard.Text = changeLB(1);
			displayList(scores);
		}

		private void flappyBirdClick(object sender, EventArgs e)
		{
			ScoreController scoreController = new ScoreController();

			List<Score> scores = scoreController.getLeaderScoreByID(3);
			lbLeaderBoard.Text = changeLB(3);
			displayList(scores);

		}

		private void tRexClick(object sender, EventArgs e)
		{
			ScoreController scoreController = new ScoreController();

			List<Score> scores = scoreController.getLeaderScoreByID(2);
			lbLeaderBoard.Text = changeLB(2);
			displayList(scores);
		}

		private void displayList(List<Score> scores)
		{
			DataTable dtTable = new DataTable();
			DataColumn column;
			DataRow row;

			string scoreName = "Highest Score";
			string playerName = "Player Name";

			column = new DataColumn();
			column.ColumnName = scoreName;
			column.DataType = System.Type.GetType("System.String");
			dtTable.Columns.Add(column);

			column = new DataColumn();
			column.ColumnName = playerName;
			column.DataType = System.Type.GetType("System.String");
			dtTable.Columns.Add(column);


			foreach (var item in scores)
			{
				row = dtTable.NewRow();
				row[0] = item.totalScore;
				row[1] = item.userName;
				dtTable.Rows.Add(row);
			}



			dgvLeaderboard.DataSource = dtTable;
		}

		private string changeLB(int idGame)
		{
			string result = String.Empty;
			switch(idGame)
			{
				case 1:
					result = "BXH Car Game";
					break;
				case 2:
					result = "BXH T-Rex Game";
					break;
				case 3:
					result = "BXH Flappy Bird";
					break;
			}

			return result;
		}
	}
}
