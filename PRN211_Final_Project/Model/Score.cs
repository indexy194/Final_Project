using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Final_Project.Model
{
	internal class Score
	{
		public Score() { }

		public int id { get; set; }	
		public long totalScore { get; set; }


		public int userID { get; set; }

		public int gameID { get; set; }

		public string userName { get; set; }
		public string gameName { get; set; }
	}
}
