using ProjectFinalLp2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// My NameSpace
using static ProjectFinalLp2.Models.otherType.funcionesComunes;
using static ProjectFinalLp2.Models.otherType.ColorDefaults;
using ProjectFinalLp2.Formularios.Aplication;
using ProjectFinalLp2.Formularios.Boss;

namespace ProjectFinalLp2.Formularios.Client
{
	public partial class frmMainClient : Form
	{
		#region					OBJETOS GENERALES

		public GestorTransformacionPanel gestorPanel { get; set; }

		public Models.Client clientCurrent { get; set; }
		#endregion

		#region									Constructor - INICIADOR
		public frmMainClient(Models.Client clientCurrent)
		{
			InitializeComponent();
			this.clientCurrent = clientCurrent;

		}
		private void MyInitializer()
		{
			try
			{
				gestorPanel = new GestorTransformacionPanel(new frmMainClient(clientCurrent), panelMain, panelLateral, lblPlace);
				gestorPanel.OpenChildFrom(new frmCatalogo(clientCurrent), btnHome);

				lblNameClient.Text = $"{clientCurrent.Nombre} {clientCurrent.Apellido}";
				var img = ByteToImage(clientCurrent.Imagen);
				if (img.Success && img.Message != null)
				{
					pictureClient.Image = img.Message;
				}
				else
				{
					pictureClient.Image = Properties.Resources.userDefault;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al momento de cargar los datos del usuarios.\n\nError: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmMainClient_Load(object sender, EventArgs e)
		{

			MyInitializer();
		}
		#endregion

		#region							Eventos
		private void btnSalir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Seguro que quieres salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnMyVehicule_Click(object sender, EventArgs e)
		{
			if (sender.GetType() == btnMyVehicule.GetType())
			{
				gestorPanel.OpenChildFrom(new frmRentadosClient(clientCurrent), btnMyVehicule);
			}
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			if (sender.GetType() == btnHome.GetType())
			{
				gestorPanel.OpenChildFrom(new frmCatalogo(clientCurrent), btnMyVehicule);
			}
		}

		private void btnRentar_Click(object sender, EventArgs e)
		{
			if (sender.GetType() == btnRentar.GetType())
			{

				gestorPanel.OpenChildFrom(new frmCatalogo(clientCurrent), btnMyVehicule);
			}
		}

		private void btnPerfil_Click(object sender, EventArgs e)
		{
			if (sender.GetType() == btnPerfil.GetType())
			{

				MessageBox.Show("Función no desarrollada 0- Rentar");
				//gestorPanel.OpenChildFrom(new frmRentados(), btnMyVehicule);
			}
		}
		#endregion

	}
}
