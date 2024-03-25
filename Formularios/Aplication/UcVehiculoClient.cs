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
using ProjectFinalLp2.Models;
// my namespace
using static ProjectFinalLp2.Models.otherType.funcionesComunes;


namespace ProjectFinalLp2
{
	public partial class UCVehiculos : UserControl
	{
		public Vehiculo currentVehicule { get; set; }
		public Models.Client currentClient { get; set; }
		public bool IsNotDisponible { get; set; }


		public UCVehiculos(Vehiculo vehiculo, Models.Client client, bool IsNotDisponible)
		{
			InitializeComponent();
			this.currentVehicule = vehiculo;
			this.currentClient = client;
			this.IsNotDisponible = IsNotDisponible;
		}

		private void btnRentar_Click(object sender, EventArgs e)
		{
			SeeRentar();
		}
		private void cargaValores()
		{
			lblBrand.Text = currentVehicule.Marca;
			lblModel.Text = currentVehicule.Modelo;
			lblPrice.Text = currentVehicule.PrecioRenta.ToString();
			// cargar la imagen
			var img = ByteToImage(currentVehicule.Image);
			if (img.Success && img.Message != null)
			{
				pictImage.Image = img.Message;
			}
			else
			{
				MessageBox.Show($"Error al momento de cargar la foto del AUTO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				pictImage.Image = Properties.Resources.error;
			}
			if (IsNotDisponible)
			{
				btnAction.Enabled = false;
				btnAction.Text = "YA RENTADO";
				btnAction.BackColor = Color.DarkRed;
				btnAction.ForeColor = Color.Black;
			}
			else
			{
				btnAction.Enabled = true;
			}
			VerificaLicencia();




		}

		private void VerificaLicencia()
		{
			try
			{
				RentcargokudemonContext context = new RentcargokudemonContext();

				var idTipolicencia = context.Licencia.FirstOrDefault(x => x.Id == currentClient.IdLicencia)!.IdTipoLicencia;

				if (idTipolicencia < currentVehicule.LicenciaRequerida)
				{
					lblALert.Text = $"Necesitas una licencia CAT: {currentVehicule.LicenciaRequerida}";
					btnAction.Enabled = false;
					btnAction.Text = "Necesitas otra licencia";
					btnAction.BackColor = Color.DarkRed;
					btnAction.ForeColor = Color.Black;
				}
				else
				{
					btnAction.Enabled = true;
					lblALert.Text = string.Empty;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"Algo fallo al verificar tus datos de licencia.\n {e}");

			}
		}
		private void UCVehiculos_Load(object sender, EventArgs e)
		{
			cargaValores();
		}

		private void btnMoreInformation_Click(object sender, EventArgs e)
		{
			SeeRentar();
		}
		private void SeeRentar()
		{

			new FrmRegRentarVehiculo(currentVehicule, currentClient, IsNotDisponible).Show();
		}

		private void panelContenedor_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
