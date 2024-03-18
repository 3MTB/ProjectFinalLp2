using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalLp2.Formularios.Aplication
{
	public partial class frmDefaultHour : Form
	{
		public frmDefaultHour()
		{
			InitializeComponent();
		}

		

		private void timerDateTime_Tick_1(object sender, EventArgs e)
		{
			var date = DateTime.Now;

			lblDateMain.Text = date.ToString("dd MMMM yyyy").Trim();
			lblTimeMain.Text = date.ToString("hh:mm:ss tt").Trim();
		}
	}
}
