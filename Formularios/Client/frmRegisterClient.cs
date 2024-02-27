using Guna.UI2.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// My NameSpace
using ProjectFinalLp2.Formularios.Aplication;
using ProjectFinalLp2.Models;
using ProjectFinalLp2.Models.GestorData;
using ProjectFinalLp2.Models.otherType;

using static ProjectFinalLp2.Models.otherType.funcionesComunes;
using MySqlX.XDevAPI;

namespace ProjectFinalLp2.Formularios.Client
{
	public partial class frmRegisterClient : Form
	{

		public int FaseCurrent = 1;
		Guna2GroupBox[] gbDisponibles = new Guna2GroupBox[4];
		RentcargokudemonContext context = new RentcargokudemonContext();


		//! TODO: ADD API FOR COUNTRY AND CITIES -- https://restcountries.com/
		public frmRegisterClient()
		{
			InitializeComponent();

		}


		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			// verificar todos los campos
			// crear todos los objetos necesarios y hacer la insercion
			/*public Client(string nombre, string apellido, int edad, string password, byte[] imagen, int idContacto, int idLicencia, Contacto contacto, Licencium licencia)
				 */
			try
			{
				if (!VerificaString(tbPassword.Text) || tbPassword.Text.Length <4 )
				{
					MessageBox.Show("Debes introducir una contraseña valida [ Mínimo 4 Dígitos ]");
					tbPassword.Focus();
					return;

				}
				string nombre = tbName.Text;
				string apellido = tbApellido.Text;
				int edad = (int)numEdad.Value;

				string password = tbPassword.Text;
				/// obtener image - Contacto  & Licencia
				var imageResponse = ImageToByte(pictImagePerfil);
				var contacto = MakeContacto();
				var licencia = MakeLicencia();

				if (imageResponse.Success && imageResponse.Message != null && contacto != null && licencia != null)
				{
					Models.Client client = new Models.Client(nombre, apellido, edad, password, imageResponse.Message, contacto.Id, licencia.Id, contacto, licencia);

					context.Contactos.Add(contacto);
					context.Licencia.Add(licencia);
					context.SaveChanges();
					context.Clients.Add(client);
					context.SaveChanges();
					this.Hide();
					// Enviar al login
					new frmlogin().Show();
				}
				else
				{
					if (!imageResponse.Success)
					{
						pictImagePerfil.Focus();
					}
					if (contacto == null)
					{
						tbPais.Focus();
					}
					if (licencia == null)
					{
						cbCategoria.Focus();
					}
					return;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Algo  fallo al momento de registrar tus datos :( \n\n{e.ToString()}");
			}
		}
		private Contacto? MakeContacto()
		{
			try
			{
				/*public Contacto(string pais, string ciudad, string direccion, string email, string telefono)
*/
				string pais = tbPais.Text;
				string ciudad = tbCiudad.Text;
				string direccion = tbDireccion.Text;
				string email = tbEmail.Text;
				string telefono = tbTelefono.Text;
				Contacto contacto = new Contacto(pais, ciudad, direccion, email, telefono);
				return contacto;
			}
			catch (Exception e)
			{
				MessageBox.Show($"Algo  fallo al momento de registrar tus datos de contacto :( \n\n{e.ToString()}");
				return null;
			}
		}
		private Licencium? MakeLicencia()
		{
			try
			{
				DateOnly emision = DateOnly.FromDateTime(getEmisionLicencia.Value);
				var categoria = cbCategoria.Text;
				DateOnly vencimiento = DateOnly.FromDateTime(getVencimientoLicencia.Value);
				Licencium add = new Licencium(emision, categoria, vencimiento);
				return add;
			}
			catch (Exception e)
			{
				MessageBox.Show($"Algo  fallo al momento de registrar tu licencia :( \n\n{e.ToString()}");
				return null;
			}
		}

		private void frmRegisterClient_Load(object sender, EventArgs e)
		{
			// CARGA Group Box Existentes al ARRAY
			gbDisponibles[0] = gbPersonalInfo;
			gbDisponibles[1] = gbLicencia;
			gbDisponibles[2] = gbContacto;
			gbDisponibles[3] = gbFinish;
			// CARGA Group Box Existentes al ARRAY
			GestorVisibilidadFase();
		}

		private void GestorVisibilidadFase()
		{
			if (FaseCurrent > gbDisponibles.Length)
			{
				MessageBox.Show("Error Fase no encontrada");
				return;
			}
			// botones que se deben ocultar
			btnPersonalInfo.Visible = FaseCurrent == 1;
			btnGuardarLicencia.Visible = FaseCurrent == 2;
			btnEnviarContacto.Visible = FaseCurrent == 3;


			if (FaseCurrent == 2)
			{
				cbCategoria.DataSource = otherTypeUses.categoriaLicencias;
			}
			if (FaseCurrent == 3)
			{
				// Volver a cargar los datos obtenidos del api de paises o en su defecto los default
			}
			// botones que se deben ocultar

			for (int i = 0; i < gbDisponibles.Length; i++)
			{
				gbDisponibles[i].Visible = i < FaseCurrent;
			}

		}

		private void btnPersonalInfo_Click(object sender, EventArgs e)
		{
			if (VerificaString(tbName.Text) && VerificaString(tbApellido.Text))
			{
				if (!context.Clients.Any(x => x.Nombre == tbName.Text.ToUpper() && x.Apellido == tbApellido.Text))
				{
					if (numEdad.Value >= 18)
					{
						FaseCurrent += 1;
						GestorVisibilidadFase();
					}
					else
					{
						MessageBox.Show("Eres Menor que la edad requerida para registrarse [18].\nPor ende  no puedes Registrarte.", "MENOR DE EDAD REQUERIDA : 18");
						Application.Exit();
					}
				}
				else
				{
					MessageBox.Show($"Ya existe un cliente con las credenciales: {tbName.Text} {tbApellido.Text}", "Registro Encontrado");
					tbName.Focus();
				}
			}
			else
			{
				if (!VerificaString(tbName.Text))
				{
					MessageBox.Show("Campo Nombre vacío", "Nombre vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
					tbName.Focus();
					return;
				}
				if (!VerificaString(tbApellido.Text))
				{
					MessageBox.Show("Campo Password vacío", "Password vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
					tbApellido.Focus();
					return;
				}
			}
		}

		private void btnSinLicencia_Click(object sender, EventArgs e)
		{
			string MessageEliminacion = $"{tbName.Text.ToUpper()}, ¿Estas seguro que NO TIENES Licencia?\n Esto implica que no podrás registrarte ";
			if (MessageBox.Show(MessageEliminacion, "Sin Licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				MessageBox.Show("Sin licencias no puedes conducir, mucho menos rentar un vehículo.");
				// Acciones sino tiene licencia
				Application.Exit();
			}
		}
		private void CambiaPersonalInfoAfter(object sender, EventArgs e)
		{
			if (!VerificaString(tbName.Text) || !VerificaString(tbApellido.Text) || numEdad.Value < 18)
			{
				FaseCurrent = 1;
				GestorVisibilidadFase();
			}
		}
		private void CambiaLicenciaInfo(object sender, EventArgs e)
		{
			if (getEmisionLicencia.Value > DateTime.Now || getEmisionLicencia.Value >= getVencimientoLicencia.Value || getVencimientoLicencia.Value >= getEmisionLicencia.Value || !VerificaString(cbCategoria.Text))
			{
				FaseCurrent = 2;
				GestorVisibilidadFase();
			}
		}
		private void btnGuardarLicencia_Click(object sender, EventArgs e)
		{
			if (getEmisionLicencia.Value <= DateTime.Now &&
			getEmisionLicencia.Value < getVencimientoLicencia.Value &&
			getVencimientoLicencia.Value > getEmisionLicencia.Value &&
			VerificaString(cbCategoria.Text))
			{
				// continuar con el proceso
				FaseCurrent += 1;
				GestorVisibilidadFase();

			}
			else
			{
				#region Categoría
				if (!VerificaString(cbCategoria.Text))
				{
					MessageBox.Show("Debes Seleccionar una categoría");
					getEmisionLicencia.Focus();
					return;
				}
				#endregion

				#region Emisión licencia

				if (getEmisionLicencia.Value > DateTime.Now)
				{
					MessageBox.Show("No puedes tener una licencia Emitida en un tiempo que aun no llega");
					getEmisionLicencia.Focus();
					return;
				}
				else if (getEmisionLicencia.Value >= getVencimientoLicencia.Value)
				{
					MessageBox.Show("No puedes tener una licencia Emitida en un tiempo posterior al de su vencimiento");
					getEmisionLicencia.Focus();
					return;
				}
				#endregion

				#region Vencimiento licencia

				if (getVencimientoLicencia.Value <= getEmisionLicencia.Value)
				{
					MessageBox.Show("No puedes tener una licencia Con fecha de vencimiento Igual o menor a la de Emisión");
					getVencimientoLicencia.Focus();
					return;
				}
				else if (getVencimientoLicencia.Value >= DateTime.Now)
				{
					MessageBox.Show("Tu Licencia, favor renuévala, antes de registrarte....");
					// hacer si esta vencida
					Application.Exit();
				}
				#endregion

			}

		}

		private void btnEnviarContacto_Click(object sender, EventArgs e)
		{
			if (VerificaString(tbPais.Text) && VerificaString(tbCiudad.Text) && VerificaString(tbDireccion.Text) && VerificaString(tbEmail.Text) && VerificaString(tbTelefono.Text))
			{
				FaseCurrent += 1;
				btnEnviarContacto.Visible = false;
				GestorVisibilidadFase();
			}
			else
			{
				if (!VerificaString(tbPais.Text))
				{
					MessageBox.Show("País no puede estar vacío");
					tbPais.Focus();
					return;
				}
				else if (!VerificaString(tbCiudad.Text))
				{
					MessageBox.Show("Ciudad no puede estar vacío");
					tbCiudad.Focus();
					return;
				}
				else if (!VerificaString(tbDireccion.Text))
				{
					MessageBox.Show("Dirección no puede estar vacío");
					tbDireccion.Focus();
					return;
				}
				else if (!VerificaString(tbEmail.Text))
				{
					MessageBox.Show("Email no puede estar vacío");
					tbEmail.Focus();
					return;
				}
				else if (!VerificaString(tbTelefono.Text))
				{
					MessageBox.Show("Teléfono no puede estar vacío");
					tbTelefono.Focus();
					return;
				}
			}
		}

		private void ChangeContactInfo(object sender, EventArgs e)
		{
			FaseCurrent = 3;
			GestorVisibilidadFase();
		}

		private void btnCargaImagen_Click(object sender, EventArgs e)
		{
			CargaImageFromLocal(pictImagePerfil);
		}

		private void tbPassword_TextChanged(object sender, EventArgs e)
		{
			if (VerificaPassword(tbPassword.Text))
			{
				btnRegistrar.Enabled = true;
			}
			else
			{
				btnRegistrar.Enabled = false;
				if (tbPassword.Text.Length == 0)
				{
					lblAvisoPassword.Text = string.Empty;
				}
				else if (tbPassword.Text.Length > 15)
				{
					lblAvisoPassword.Text = "Password Muy Larga";
				}
				else if (tbPassword.Text.Length < 4)
				{
					lblAvisoPassword.Text = "Password Muy Corta";
				}
				else if (!tbPassword.Text.Any(x => char.IsDigit(x)))
				{
					lblAvisoPassword.Text = "Password Débil: Introduce al menos un numero";
				}
				else if (!tbPassword.Text.Any(x => char.IsLetter(x)))
				{
					lblAvisoPassword.Text = "Password Débil: Introduce al menos una Letra";
				}
				else
				{
					lblAvisoPassword.Text = string.Empty;
				}
				tbPassword.Focus();

			}
		}
	}






}

