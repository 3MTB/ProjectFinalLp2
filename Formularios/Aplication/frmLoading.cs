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
	public partial class frmLoading : Form
	{
		public frmLoading()
		{
			InitializeComponent();
		}

		private void timerAnimation_Tick(object sender, EventArgs e)
		{
			if (progressBar.Value < progressBar.Maximum)
			{
				progressBar.Value += 1;
			}
			else
			{
				timerAnimation.Enabled = false;
				this.Hide();
				// llamar al loading
			}
		}
	}
}
