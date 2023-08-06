using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Final_Project
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new FlappyBird.flappyBird());
			//Application.Run(new T_Rex_Game.tRexGame());
			//Application.Run(new carGame());
			//Application.Run(new StartCarGame());

			//Main thread
			Application.Run(new MainScreen.Loading());
			//Application.Run(new Admin.AdminScreen());

			//Application.Run(new MainScreen.changePass());





		}
	}
}
