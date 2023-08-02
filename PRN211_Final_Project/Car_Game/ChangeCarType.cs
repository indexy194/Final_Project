using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Final_Project.Car_Game
{
	partial class ChangeCarType : Form
	{
		public ChangeCarType()
		{
			InitializeComponent();
		}
		protected string tempCar = null;
		public event EventHandler<string> OKButtonClicked;

		private void changeType1(object sender, EventArgs e)
		{
			pictureType.Image = Properties.Resources.carplayer_green;
			txtDescription.Text = "- Chọn xe này thì bạn là người bình thường";
			defaultColor();
			lbCarType1.BackColor = Color.White;
			lbCarType1.ForeColor = Color.Black;
			tempCar = "green";
			
		}
		private void changeType2(object sender, EventArgs e)
		{
			pictureType.Image = Properties.Resources.carplayer_pink;
			txtDescription.Text = "zzz";
			defaultColor();
			lbCarType2.BackColor = Color.White;
			lbCarType2.ForeColor = Color.Black;
			tempCar = "pink";
		}
		private void changeType3(object sender, EventArgs e)
		{
			pictureType.Image = Properties.Resources.carplayer_aqua;
			txtDescription.Text = "- Xe hợp với ai là đỉnh xã hội";
			defaultColor();
			lbCarType3.BackColor = Color.White;
			lbCarType3.ForeColor = Color.Black;
			tempCar = "aqua";
		}
		private void changeType4(object sender, EventArgs e)
		{
			pictureType.Image = Properties.Resources.carplayer_blue;
			txtDescription.Text = "- Loại xe cho người nghèo";
			defaultColor();
			lbCarType4.BackColor = Color.White;
			lbCarType4.ForeColor = Color.Black;
			tempCar = "blue";
		}

		private void defaultColor()
		{
			var colorDefault = Color.Black;
			var foreColorDefault = Color.White;

			lbCarType1.BackColor = lbCarType2.BackColor =lbCarType3.BackColor = lbCarType4.BackColor = colorDefault;
			lbCarType1.ForeColor= lbCarType2.ForeColor= lbCarType3.ForeColor= lbCarType4.ForeColor= foreColorDefault;
		}
		
		private void clickOK(object sender, EventArgs e)
		{
			carGame carGame = new carGame();
			OKButtonClicked?.Invoke(this, tempCar);


			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
