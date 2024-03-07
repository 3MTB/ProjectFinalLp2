using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFinalLp2.Formularios.Aplication;
//My NameSpace
using ProjectFinalLp2.Formularios.Boss;

namespace ProjectFinalLp2.Formularios.Trabajador
{
	public partial class frmTrabajadorMain : Form
	{
		public GestorTransformacionPanel gestorPanel { get; set; } = null!;
		public frmTrabajadorMain()
		{
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Seguro que quieres salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void frmTrabajadorMain_Load(object sender, EventArgs e)
		{
			gestorPanel = new GestorTransformacionPanel(new frmDefaultAdmin(), panelMain, panelLateral, lblNamefrmActual);
			gestorPanel.OpenChildFrom(new frmDefaultAdmin(), btnHome);
		}
		private void btnHome_Click(object sender, EventArgs e)
		{
			gestorPanel.OpenChildFrom(new frmDefaultAdmin(), btnHome);
		}

		private void btnCatalogo_Click(object sender, EventArgs e)
		{
			gestorPanel.OpenChildFrom(new frmCatalogo(null), btnCatalogo);

		}

		private void btnRentados_Click(object sender, EventArgs e)
		{
			gestorPanel.OpenChildFrom(new frmRentados(), btnRentados);

		}
	}
}
