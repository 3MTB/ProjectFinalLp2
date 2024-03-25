using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ProjectFinalLp2.Models;

// my Namespace
using static ProjectFinalLp2.Models.otherType.funcionesComunes;

namespace ProjectFinalLp2.Formularios.Aplication
{
	public partial class FrmRegRentarVehiculo : Form
	{
		#region Objetos Generales
		public Vehiculo vehiculo { get; set; }
		public Models.Client cliente { get; set; }
		public decimal totalPagar { get; set; } = 0;
		public bool IsNotDisponible { get; set; }

		public RentcargokudemonContext context { get; set; }

		#endregion

		#region Constructor - Mi Iniciador
		public FrmRegRentarVehiculo(Vehiculo vehiculo, Models.Client cliente, bool IsNotDisponible)
		{
			InitializeComponent();
			this.vehiculo = vehiculo;
			this.cliente = cliente;
			this.IsNotDisponible = IsNotDisponible;
			context = new RentcargokudemonContext();
		}

		private void FrmRegRentarVehiculo_Load(object sender, EventArgs e)
		{
			MiInicializador();
		}
		#endregion

		#region						Eventos
		private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
		{
			dtFechaFinal.MinDate = dtFechaInicio.Value.AddHours(1);

			ActualizaPrecioPagar();
		}

		private void dtFechaFinal_ValueChanged(object sender, EventArgs e)
		{
			if (dtFechaInicio.Value >= dtFechaFinal.Value)
			{
				dtFechaFinal.Value = dtFechaInicio.Value.AddHours(1);

				lblAviso.Text = "Se ha actualizado la fecha final";
			}
			else
			{
				lblAviso.Text = string.Empty;
			}
			dtFechaFinal.MinDate = dtFechaInicio.Value.AddHours(1);
			ActualizaPrecioPagar();

		}

		private void dtFechaFinal_Validating(object sender, CancelEventArgs e)
		{
			if (dtFechaFinal.Value <= dtFechaInicio.Value.AddHours(1))
			{
				MessageBox.Show("No puedes seleccionar una fecha final inferior a la de inicio");
				return;
			}
		}

		private void tbRentar_Click(object sender, EventArgs e)
		{
			try
			{
				Models.Trabajador trabajador = (Models.Trabajador)cbTrabajador.SelectedItem;
				if (trabajador != null)
				{
					Rentado rentar = new Rentado(cliente.Id, vehiculo.Id, trabajador.Id, dtFechaInicio.Value, dtFechaFinal.Value, totalPagar);
					context.Rentados.Add(rentar);
					vehiculo.Disponible = false;
					context.SaveChanges();
					MessageBox.Show("RENTA GUARDADA");
					this.Close();

				}
				else
				{
					MessageBox.Show($"Algo fallo al momento de obtener los datos del empleado: {cbTrabajador.Text}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Algo fallo al momento de la inserción: {ex}");
			}
		}

		#endregion

		#region									Metodos
		private void ActualizaPrecioPagar()
		{
			var time = dtFechaFinal.Value - dtFechaInicio.Value;
			if (time.TotalDays > 2)
			{
				// APLICA DESCUESNTO DE 2%	
				totalPagar = Math.Round((vehiculo.PrecioRenta * (decimal)time.TotalHours) * (0.2m), 2);
				lblDescuentoPagar.Text = "-2%";
				lblAviso.Text = "Aplicando descuento 2%";
			}
			else
			{
				totalPagar = vehiculo.PrecioRenta * (decimal)time.TotalHours;
				lblDescuentoPagar.Text = string.Empty;
				lblAviso.Text = string.Empty;

			}
			lblTotalPagar.Text = totalPagar.ToString();

		}
		private void MiInicializador()
		{
			lblAvisoDisponibilidad.Text = string.Empty;
			try
			{

				if (IsNotDisponible)
				{
					btnRentar.Enabled = false;
					btnRentar.Text = "YA RENTADO";
					btnRentar.BackColor = Color.DarkRed;
					btnRentar.ForeColor = Color.Black;
				}
				VerificaLicencia();
				cbTrabajador.DataSource = context.Trabajadors.Where(x => x.Cargo.ToUpper().Contains("VENDEDOR")).ToList();
				cbTrabajador.DisplayMember = "Name";
				dtFechaInicio.MinDate = DateTime.Now;
				dtFechaFinal.Value = dtFechaInicio.Value.AddDays(3);
				lblPrice.Text = vehiculo.PrecioRenta.ToString();
				lblBrand.Text = vehiculo.Marca;
				lblModel.Text = vehiculo.Modelo;
				lblDescription.Text = vehiculo.Description;
				lblEstado.Text = vehiculo.Estado;
				lblLicenciaRequerida.Text = vehiculo.LicenciaRequerida.ToString();
				lblYear.Text = vehiculo.Anio.ToString();
				lblNameColor.Text = vehiculo.Color;
				var clr = Color.FromName(vehiculo.Color);

				if (clr.IsKnownColor)
				{
					panelColorVehiculo.BackColor = clr;

					var clr2 = Color.FromName(clr.ToString());
					if (clr2.IsKnownColor)
					{
						panelColorVehiculo.BackColor = clr2;
					}
				}
				ActualizaPrecioPagar();

				var imgResponse = ByteToImage(vehiculo.Image);
				if (imgResponse.Success && imgResponse.Message != null)
				{
					pictImage.Image = imgResponse.Message;
				}
				else
				{
					MessageBox.Show($"Error al momento de cargar la foto del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					pictImage.Image = Properties.Resources.userDefault;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Algo fallo al momento de cargar unos valores :(");
			}

		}

		private void VerificaLicencia()
		{
			try
			{
				RentcargokudemonContext context = new RentcargokudemonContext();

				var idTipolicencia = context.Licencia.FirstOrDefault(x => x.Id == cliente.IdLicencia)!.IdTipoLicencia;

				if (idTipolicencia < vehiculo.LicenciaRequerida)
				{
					btnRentar.Enabled = false;

					lblAvisoDisponibilidad.Text = $"Necesitas una licencia CAT: {vehiculo.LicenciaRequerida}";
					btnRentar.Text = "Necesitas otra licencia";
					btnRentar.BackColor = Color.DarkRed;
					btnRentar.ForeColor = Color.Black;

				}

			}
			catch (Exception e)
			{
				MessageBox.Show($"Algo fallo al verificar tus datos de licencia.\n {e}");

			}
		}


		#endregion



	}
}
