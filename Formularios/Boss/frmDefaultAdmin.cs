using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalLp2.Formularios.Boss
{
	public partial class frmDefaultAdmin : Form
	{
		public frmDefaultAdmin()
		{
			InitializeComponent();
		}

		private void timerDateTime_Tick(object sender, EventArgs e)
		{
			var date = DateTime.Now;
			lblDateMain.Text = date.GetDateTimeFormats()[1];
			lblTimeMain.Text = $"{date.Hour}:{date.Minute}:{date.Second}";
		}
	}
}
