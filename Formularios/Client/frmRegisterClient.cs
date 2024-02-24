using Guna.UI2.WinForms;
using ProjectFinalLp2.Formularios.Aplication;
using ProjectFinalLp2.Models;
using ProjectFinalLp2.Models.GestorData;
using ProjectFinalLp2.Models.otherType;
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

using static ProjectFinalLp2.Models.otherType.funcionesComunes;

namespace ProjectFinalLp2.Formularios.Client
{
	public partial class frmRegisterClient : Form
	{
		public int FaseCurrent = 1;
		Guna2GroupBox[] gbDisponibles = new Guna2GroupBox[4];
		RentcargokudemonContext context = new RentcargokudemonContext();

		public frmRegisterClient()
		{
			InitializeComponent();

		}
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{

		}
		private void OcultaElementos(object[] perdonados)
		{
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
						btnPersonalInfo.Visible = false;
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





		//private void CargaImagen()
		//{
		//	try
		//	{
		//		OpenFileDialog openfile = new OpenFileDialog();
		//		openfile.Filter = "Imagen|*.jpeg;*.png;";
		//		openfile.Title = "Imagen Perfil [JPEG / PNG]";

		//		if (openfile.ShowDialog() == DialogResult.OK)
		//		{
		//			pictImagePerfil.Image = Image.FromFile(openfile.SafeFileName);
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.ToString(), "Algo Fallo al momento de cargar la imagen");
		//		pictImagePerfil.Image = Properties.Resources.userDefault;
		//	}
		//}


		////private void GuardarImage()
		////{
		////	try
		////	{

		////	}
		////	catch (Exception e)
		////	{
		////		MessageBox.Show("Error Al obtener la imagen a guardar \n POR LO QUE SE CARGARA LA IMAGEN POR DEFECTO.", "Error obtener Imagen");
		////	}
		////}
		//////private responseConversionIamge ImageToString(PictureBox pict)
		//////{
		//////	if (pict.Image == null)
		//////	{
		//////		MessageBox.Show("Sin imagen cargada", "Error");
		//////		return new responseConversionIamge(false, null);
		//////	}
		//////	try
		//////	{
		//////		MemoryStream ms = new MemoryStream();
		//////		pict.Image.Save(ms, ImageFormat.Png);
		//////		return new responseConversionIamge(true, ms.GetBuffer());
		//////	}
		//////	catch (Exception e)
		//////	{
		//////		MessageBox.Show("Error Al Convertir la imagen a guardar \n", "Error GUARDAR Imagen");
		//////		return new responseConversionIamge(false, null);

		//////	}
		//////}


		//private void Gestor



	}





	public record responseConversionIamge(bool Success, byte[]? Message);

}

