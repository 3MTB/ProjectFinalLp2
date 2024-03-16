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
		public Models.Client clientCurrent { get; set; }
		#endregion

		#region Constructor
		public frmMainClient(Models.Client clientCurrent)
		{
			InitializeComponent();
			this.clientCurrent = clientCurrent;
			MyInitializer();
		}
		private void MyInitializer()
		{
			try
			{
				lblNameClient.Text = $"{clientCurrent.Nombre} {clientCurrent.Apellido}";
				OpenChildFrom(new frmCatalogo(clientCurrent), btnHome);
				var img = ByteToImage(clientCurrent.Imagen);
				if (img.Success && img.Message != null)
				{
					pictureClient.Image = img.Message;
				}
				else
				{
					MessageBox.Show($"Error al momento de cargar la foto del usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					pictureClient.Image = Properties.Resources.userDefault;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al momento de cargar los datos del usuarios.\n\nError: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Menu dinámico
		public Button currentButon { get; set; }
		public Form currentForm { get; set; }
		private void DisableButtons()
		{
			foreach (Control x in panelLateral.Controls)
			{
				if (x.GetType() == typeof(Button))
				{
					x.BackColor = cBackgroundDisable;
					x.ForeColor = cForegroundDisable;
				}
			}
		}
		public void ActiveButton(Button btnactivar)
		{
			if (currentButon != null)
			{
				if (currentButon != btnactivar)
				{
					currentButon = btnactivar;
					currentButon.BackColor = cBackgroundActive;
					currentButon.ForeColor = cForegroundActive;
				}
			}
		}
		private void OpenChildFrom(Form abrir, Button btnsender)
		{
			if (currentForm != null)
			{
				currentForm.Close();
			}
			DisableButtons();

			ActiveButton(btnsender);
			// review that
			currentForm = abrir;
			currentForm.TopLevel = false;
			currentForm.FormBorderStyle = FormBorderStyle.None;
			currentForm.BringToFront();
			panelMain.Controls.Add(currentForm);
			currentForm.Show();
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
				lblPlace.Text = "Mis Rentados";
				OpenChildFrom(new frmRentadosClient(clientCurrent), btnMyVehicule);
			}
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			// cambiat por home
			if (sender.GetType() == btnHome.GetType())
			{
				lblPlace.Text = "HOME";
				OpenChildFrom(new frmDefaultAdmin(), btnMyVehicule);
			}
			// cargar vehivulos para rentat
		}

		private void btnRentar_Click(object sender, EventArgs e)
		{
			if (sender.GetType() == btnRentar.GetType())
			{
				lblPlace.Text = "Rentar";

				OpenChildFrom(new frmCatalogo( clientCurrent), btnMyVehicule);
			}
		}

		private void btnPerfil_Click(object sender, EventArgs e)
		{
			if (sender.GetType() == btnPerfil.GetType())
			{
				lblPlace.Text = "Perfil";

				MessageBox.Show("Función no desarrollada 0- Rentar");
				//OpenChildFrom(new frmRentados(), btnMyVehicule);
			}
		}
		#endregion

	}
}
