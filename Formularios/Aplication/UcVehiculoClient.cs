﻿using System;
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
		/*public bool IsNotDisponible { get; set; }
*/

		public UCVehiculos(Vehiculo vehiculo, Models.Client client/*, bool IsNotDisponible*/)
		{
			InitializeComponent();
			this.currentVehicule = vehiculo;
			this.currentClient = client;
			/*	this.IsNotDisponible = IsNotDisponible;*/
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

			if (currentClient != null)
			{
				if (currentClient.Rentados.Any(x => x.IdVehiculoNavigation == currentVehicule))
				{
					btnAction.Enabled = false;
					btnAction.Text = "YA RENTADO";
					btnAction.BackColor = Color.DarkRed;
					btnAction.ForeColor = Color.Black;
					panelContenedor.BackColor = Color.IndianRed;
					MessageBox.Show("Ya lo has registrado");
				}
			}
			else
			{
				btnAction.Visible = false;
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
			this.Hide();
			new FrmRegRentarVehiculo(currentVehicule, currentClient).Show();
		}
	}
}
