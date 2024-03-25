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
using ProjectFinalLp2.Models.otherType;


// my namespace
using static ProjectFinalLp2.Models.otherType.funcionesComunes;

namespace ProjectFinalLp2.Formularios.Client
{
	public partial class frmPerfilClient : Form
	{
		#region									OBJETOS GENERALES
		public bool IsEditable { get; set; }
		public Models.Client client { get; set; }

		public RentcargokudemonContext context { get; set; }


		#endregion

		#region								CONSTRUCTOR E INICIALIZADOR
		public frmPerfilClient(Models.Client client)
		{
			InitializeComponent();
			this.client = client;
			this.context = new RentcargokudemonContext();
		}
		private void frmPerfilClient_Load(object sender, EventArgs e)
		{
			MyInitializer();
		}
		private void MyInitializer()
		{
			lblAlert.Text = string.Empty;
			IsEditable = false;
			CargaValoresClient();
			GestorActualizacion();
		}
		#endregion

		#region										EVENTOS
		private void pictCliente_Click(object sender, EventArgs e)
		{
			if (IsEditable)
			{
				CargaImageFromLocal(pictCliente);
			}
		}

		private void checkEditar_CheckedChanged(object sender, EventArgs e)
		{
			IsEditable = checkEditar.Checked;
			GestorActualizacion();
		}
		private void tbPassword_TextChanged(object sender, EventArgs e)
		{
			if (VerificaPassword(tbPassword.Text))
			{
				btnActualizar.Enabled = true;
			}
			else
			{
				btnActualizar.Enabled = false;
				tbPassword.Focus();
			}
		}
		#endregion

		#region									Metodos

		private void CargaValoresClient()
		{
			// personal information
			var img = ByteToImage(client.Imagen);
			if (img.Success && img.Message != null && img != null)
			{
				pictCliente.Image = img.Message;
			}
			else
			{
				pictCliente.Image = Properties.Resources.userDefault;
			}
			tbName.Text = client.Nombre;
			tbApellido.Text = client.Apellido;
			numEdad.Value = client.Edad;
			tbPassword.Text = client.Password;

			// contacto
			var contacto = context.Contactos.FirstOrDefault(x => x.Id == client.IdContacto);
			if (contacto is not null)
			{
				tbPais.Text = contacto.Pais;
				tbCiudad.Text = contacto.Ciudad;
				tbDireccion.Text = contacto.Direccion;
				tbEmail.Text = contacto.Email;
				tbTelefono.Text = contacto.Telefono;
			}
			else
			{
				tbPais.Text = "error al cargar";
				tbCiudad.Text = "error al cargar";
				tbDireccion.Text = "error al cargar";
				tbEmail.Text = "error al cargar";
				tbTelefono.Text = "error al cargar";
				MessageBox.Show("Error al obtener tu información de contacto :(", "Error carga de datos");

			}


			// licencia
			cbCategoria.DataSource = otherTypeUses.categoriaLicencia();
			cbCategoria.DisplayMember = "Codigo";

			var licencia = context.Licencia.FirstOrDefault(x => x.Id == client.IdLicencia);
			if (licencia is not null)
			{
				// PONER QUE SEA EL ID DEL QUE TIENE EL USUARIO
				cbCategoria.SelectedIndex = licencia.IdTipoLicencia;
				// PONER QUE SEA EL ID DEL QUE TIENE EL USUARIO
				getEmisionLicencia.Value = new DateTime(licencia.Emision, new TimeOnly(0, 0, 0, 0));
				getVencimientoLicencia.Value = new DateTime(licencia.FechaVencimiento, new TimeOnly(0, 0, 0, 0));
			}
			else
			{
				// PONER QUE SEA EL ID DEL QUE TIENE EL USUARIO
				//cbCategoria.SelectedIndex = client.IdLicencia;
				// PONER QUE SEA EL ID DEL QUE TIENE EL USUARIO
				getEmisionLicencia.Value = DateTime.Now;
				getVencimientoLicencia.Value = DateTime.Now;
				MessageBox.Show("Error al obtener tu información de LICENCIA :(", "Error carga de datos");

			}
		}
		private void GestorActualizacion()
		{
			if (IsEditable)
			{

				cbCategoria.Enabled = true;
				cbCategoria.DataSource = otherTypeUses.categoriaLicencia();
				cbCategoria.DisplayMember = "Codigo";

				tbName.Enabled = true;
				tbApellido.Enabled = true;
				numEdad.Enabled = true;
				tbPassword.Enabled = true;

				tbPais.Enabled = true;
				tbCiudad.Enabled = true;
				tbDireccion.Enabled = true;
				tbEmail.Enabled = true;
				tbTelefono.Enabled = true;

				cbCategoria.Enabled = true;
				getEmisionLicencia.Enabled = true;
				getVencimientoLicencia.Enabled = true;

				btnActualizar.Visible = true;

			}
			else
			{
				cbCategoria.Enabled = false;
				cbCategoria.DataSource = otherTypeUses.categoriaLicencia();
				cbCategoria.DisplayMember = "Codigo";

				tbName.Enabled = false;
				tbApellido.Enabled = false;
				numEdad.Enabled = false;
				tbPassword.Enabled = false;

				tbPais.Enabled = false;
				tbCiudad.Enabled = false;
				tbDireccion.Enabled = false;
				tbEmail.Enabled = false;
				tbTelefono.Enabled = false;

				cbCategoria.Enabled = false;
				getEmisionLicencia.Enabled = false;
				getVencimientoLicencia.Enabled = false;

				btnActualizar.Visible = false;
			}
		}
		#endregion


		private void btnActualizar_Click(object sender, EventArgs e)
		{
			try
			{

				var old = context.Clients.First(x => x.Id == client.Id);

				if (!VerificaString(tbPassword.Text) || tbPassword.Text.Length < 4)
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
				var NuevoImageResponse = ImageToByte(pictCliente);
				var nuevoContacto = MakeContacto();
				var nuevoLicencia = MakeLicencia();

				if (NuevoImageResponse.Success && NuevoImageResponse.Message != null && nuevoLicencia != null && nuevoContacto != null)
				{

					if (client.Imagen != NuevoImageResponse.Message)
					{
						old.Imagen = NuevoImageResponse.Message;
						context.SaveChanges();
						lblAlert.Text = "IMAGEN Actualizada";
					}
				}
				else
				{
					if (!NuevoImageResponse.Success)
					{
						pictCliente.Focus();
					}
					if (nuevoContacto == null)
					{
						tbPais.Focus();
					}
					if (nuevoLicencia == null)
					{
						cbCategoria.Focus();
					}
					return;
				}
				var oldContacto = context.Contactos.FirstOrDefault(X => X.Id == client.IdContacto);
				if (oldContacto != null)
				{
					if (oldContacto.Pais != nuevoContacto.Pais || oldContacto.Ciudad != nuevoContacto.Ciudad ||
					oldContacto.Direccion != nuevoContacto.Direccion || oldContacto.Email != nuevoContacto.Email ||
					oldContacto.Telefono != nuevoContacto.Telefono)
					{
						oldContacto.Pais = nuevoContacto.Pais;
						oldContacto.Ciudad = nuevoContacto.Ciudad;
						oldContacto.Direccion = nuevoContacto.Direccion;
						oldContacto.Telefono = nuevoContacto.Telefono;
						oldContacto.Email = nuevoContacto.Email;

						old.IdContacto = oldContacto.Id;
						context.SaveChanges();
						lblAlert.Text = "CONTACTO ActualizadO";

					}
				}
				else
				{
					MessageBox.Show("Error al obtener acceso al  contacto del cliente");
				}
				var oldLicencia = context.Licencia.FirstOrDefault(X => X.Id == client.IdLicencia);
				if (oldLicencia != null)
				{
					if (oldLicencia.IdTipoLicencia != nuevoLicencia.IdTipoLicencia || oldLicencia.FechaVencimiento != nuevoLicencia.FechaVencimiento ||
					oldLicencia.Emision != nuevoLicencia.Emision)
					{
						oldLicencia.Emision = nuevoLicencia.Emision;
						oldLicencia.IdTipoLicencia = nuevoLicencia.IdTipoLicencia;
						oldLicencia.FechaVencimiento = nuevoLicencia.FechaVencimiento;
						old.IdLicencia = oldLicencia.Id;
						context.SaveChanges();
						lblAlert.Text = "LICENCIA Actualizada";

					}
				}
				else
				{
					MessageBox.Show("Error al obtener acceso a la licencia del cliente");
				}
				if (client.Nombre != nombre)
				{
					old.Nombre = nombre;
					context.SaveChanges();
					lblAlert.Text = "NOMBRE Actualizado";
				}
				if (client.Apellido != apellido)
				{
					old.Apellido = apellido;
					context.SaveChanges();
					lblAlert.Text = "Apellido Actualizado";


				}
				if (client.Edad != edad)
				{
					old.Edad = edad;

					context.SaveChanges();
					lblAlert.Text = "EDAD Actualizada";

				}
				if (client.Password != password)
				{
					if (MessageBox.Show($"Seguro que quieres cambiar tu contraseña actual por esta: {new String('*', password.Length)}", "Confirmar cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						old.Edad = edad;
						context.SaveChanges();
						lblAlert.Text = "Contraseña Actualizado";

						MessageBox.Show("Cambios guardados");
						this.Hide();
						new frmMainClient(client).Show();
					}
				}

				this.Refresh();
			}
			catch (Exception ex)
			{

				MessageBox.Show($"Algo  fallo al momento de Actualizar tus datos :( \n\n{ex.ToString()}");
			}

		}

		private Contacto? MakeContacto()
		{
			try
			{
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
				MessageBox.Show($"Algo  falló al momento de Actualizar tus datos de contacto :( \n\n{e.ToString()}");
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
				var tpl = cbCategoria.SelectedItem as TipoLicencium;
				if (tpl is null)
				{
					MessageBox.Show("ALGO FALLO AL OBTENER EL TIPO DE LICENCIA");
					return null;
				}
				//Licencium ad = new Licencium(emision, tpl.IdLicencia, vencimiento);
				Licencium add = new Licencium(emision, tpl.IdLicencia, vencimiento);
				return add;
			}
			catch (Exception e)
			{
				MessageBox.Show($"Algo  fallo al momento de Actualizar tu licencia :( \n\n{e.ToString()}");
				return null;
			}
		}

	}
}
