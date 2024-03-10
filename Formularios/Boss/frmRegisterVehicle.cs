using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFinalLp2.Models;
// my namespace
using static ProjectFinalLp2.Models.otherType.funcionesComunes;

namespace ProjectFinalLp2.Formularios.Boss
{
	public partial class frmRegisterVehicle : Form
	{
		public RentcargokudemonContext context { get; set; }
		public Control[] controles { get; set; }
		public frmRegisterVehicle()
		{
			InitializeComponent();
			// Mi inicador
			MyInitializer();
		}
		private void MyInitializer()
		{
			context = new RentcargokudemonContext();
			controles = [
				tbMarca, tbModelo, cbTipoVehiculo, numYear, tbNameColor, cbEstado,rtDescripcion,
				cbLicenciaRequerida
			];
			rtDescripcion.Text = string.Empty;
			pictImagenVehiculo.Image = Properties.Resources.waiting;

		}
		private void frmRegisterVehicle_Load(object sender, EventArgs e)
		{
			numYear.Maximum = DateTime.Now.AddYears(2).Year;
			cbLicenciaRequerida.DataSource = context.TipoLicencia.ToList();
			cbLicenciaRequerida.DisplayMember = "Codigo";
			cbEstado.DataSource = Models.otherType.otherTypeUses.estadosVehiculos;

			cbTipoVehiculo.DataSource = Models.otherType.otherTypeUses.tiposVehiculos;
		}

		private void pictImagenVehiculo_Click(object sender, EventArgs e)
		{
			CargaImageFromLocal(pictImagenVehiculo, Properties.Resources.waiting);
		}

		private void panelColorVehiculo_Click(object sender, EventArgs e)
		{
			ColorDialog color = new ColorDialog();
			if (color.ShowDialog() == DialogResult.OK)
			{
				panelColorVehiculo.BackColor = color.Color;
				tbNameColor.Text = color.Color.Name;
			}
		}

		private void tbNameColor_TextChanged(object sender, EventArgs e)
		{
			var possibleColor = Color.FromName(tbNameColor.Text);
			if (possibleColor.IsKnownColor)
			{
				panelColorVehiculo.BackColor = possibleColor;
				lblAlert.Text = string.Empty;
			}
			else
			{
				lblAlert.Text = "Color no encontrado";
			}
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			revisaDatos();
			RealizaInsercion();
		}
		private void RealizaInsercion()
		{
			if (controles.All(x => !string.IsNullOrWhiteSpace(x.Text)))
			{
				if (pictImagenVehiculo.Image == Properties.Resources.waiting)
				{
					MessageBox.Show("Debes introducir una imagen");
					pictImagenVehiculo.Focus();
					return;

				}
				if (numYear.Value >= DateTime.Now.AddYears(2).Year)
				{
					numYear.Focus();
					MessageBox.Show("Fecha fuera de rango...");
				}
				if (pictImagenVehiculo.Image != Properties.Resources.waiting)
				{
					var licencia = (TipoLicencium)cbLicenciaRequerida.SelectedItem;

					if (licencia != null)
					{
						var image = ImageToByte(pictImagenVehiculo);
						if (image.Success && image.Message != null)
						{

							Vehiculo vehiculo = new Vehiculo(tbMarca.Text, tbModelo.Text, cbTipoVehiculo.Text, (int)numYear.Value, tbNameColor.Text, cbEstado.Text, numPrecioRenta.Value, rtDescripcion.Text, licencia.IdLicencia, image.Message);
							context.Vehiculos.Add(vehiculo);
							context.SaveChanges();
							MessageBox.Show("VEHICULO REGISTRADO");
							clearData();
						}
						else
						{
							MessageBox.Show("Error al CARGAR la IMAGEN");
						}
					}
					else
					{
						MessageBox.Show("Error al obtener la licencia");
					}
				}
				else
				{
					MessageBox.Show("DEBES SELECCIONAR UNA IMAGEN");
				}
			}
		}
		private void clearData()
		{
			tbMarca.Text = string.Empty;
			tbModelo.Text = string.Empty;
			rtDescripcion.Text = string.Empty;
			pictImagenVehiculo.Image = Properties.Resources.waiting;
			numYear.Value = DateTime.Now.AddYears(-3).Year;
			numPrecioRenta.Value = numPrecioRenta.Minimum + 20;
		}
		private void revisaDatos()
		{
			foreach (Control x in controles)
			{
				if (x.GetType() == tbMarca.GetType())
				{
					if (!VerificaString(((TextBox)x).Text))
					{
						MessageBox.Show($"Campo '{x.Tag}' Vacío", "Falta valor");
						x.Focus();
						break;
					}
				}
				else if (x.GetType() == cbTipoVehiculo.GetType())
				{
					if (!VerificaString(((ComboBox)x).Text))
					{
						MessageBox.Show($"Campo '{x.Tag}' Vacío", "Falta valor");
						x.Focus();
						break;
					}
				}
				else if (x.GetType() == rtDescripcion.GetType())
				{
					if (!VerificaString(((RichTextBox)x).Text))
					{
						MessageBox.Show($"Campo '{x.Tag}' Vacío", "Falta valor");
						x.Focus();
						break;
					}
				}
				else if (x.GetType() == numYear.GetType())
				{
					if (!decimal.TryParse(((NumericUpDown)x).Value.ToString(), out _))
					{
						MessageBox.Show($"Campo '{x.Tag}' Con valores incorrectos", "Valor Incorrecto");
						x.Focus();
						break;
					}
				}
				else
				{
					MessageBox.Show($"Campo '{x.Tag}' Con valores incorrectos", "Valor Incorrecto");
					x.Focus();
					break;
				}
			}
		}

		private void rtDescripcion_TextChanged(object sender, EventArgs e)
		{
			SetValueDefaultDescription();
		}
		private void SetValueDefaultDescription()
		{

			rtDescripcion.Text = $"Esta {tbMarca.Text} {tbModelo.Text} - {numYear.Value}, Es una excelente opción para su uso {cbTipoVehiculo.Text}";
		}

		private void tbMarca_TextChanged_1(object sender, EventArgs e)
		{
			SetValueDefaultDescription();
		}

		private void tbModelo_TextChanged(object sender, EventArgs e)
		{
			SetValueDefaultDescription();
		}

		private void cbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetValueDefaultDescription();
		}

		private void numYear_ValueChanged(object sender, EventArgs e)
		{
			SetValueDefaultDescription();
		}
	}
}
