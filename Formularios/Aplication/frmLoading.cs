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
		#region								Constructor
		public frmLoading()
		{
			InitializeComponent();
		}
		#endregion
		#region						Eventos --- Gestor Animacion
		private void timerAnimation_Tick(object sender, EventArgs e)
		{
			if (progressBar.Value < progressBar.Maximum)
			{
				progressBar.Value += 2;
			}
			else
			{
				timerAnimation.Enabled = false;
				this.Hide();
				new frmlogin().Show();
			}
		}
		#endregion
	}
}
