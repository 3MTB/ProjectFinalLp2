using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace ProjectFinalLp2.Models.otherType
{
	// funciones comundes - verifica String / password
	public partial class funcionesComunes
	{
		// protector para la encritptacion y desencriptacion de la informacion.
		private static IDataProtector protector => new EphemeralDataProtectionProvider().CreateProtector("rentCarGokuDemon");
		// protector para la encritptacion y desencriptacion de la informacion.


		public static bool VerificaString(string str) => !string.IsNullOrWhiteSpace(str);

		public static bool VerificaPassword(string Passowrd)
		{
			return Passowrd.Any(x => Char.IsDigit(x)) && Passowrd.Length >= 4 && Passowrd.Length <= 15;
		}
		// review that
		public static string Encriptar(string str)
		{
			return protector.Protect(str);
		}

		public static string Desencriptar(string str)
		{
			try
			{
				/// Problem here
				var des = protector.Unprotect(str);
				Console.WriteLine($"dEncriptando: {str} ::: {des}");
				return des;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			return ":";
		}
		// review that

		public static void MakeMessage(string description, string Title, MessageBoxIcon tipo)
		{
			MessageBox.Show(description, Title, MessageBoxButtons.OK, tipo);
		}
		public static bool MakeMessage(string description, string Title, MessageBoxIcon tipo, DialogResult correctAnswer)
		{
			return MessageBox.Show(description, Title, MessageBoxButtons.YesNo, tipo) == correctAnswer;
		}

	}

	// Images -- TODO: Try it
	public partial class funcionesComunes
	{
		public static responseConversionImage ImageToByte(PictureBox pict)
		{
			if (pict.Image == null)
			{
				MessageBox.Show("Sin imagen cargada", "Error");
				return new responseConversionImage(false, null);
			}
			try
			{
				MemoryStream ms = new MemoryStream();
				pict.Image.Save(ms, ImageFormat.Png);
				return new responseConversionImage(true, ms.GetBuffer());
			}
			catch (Exception e)
			{
				MessageBox.Show("Error Al Convertir la imagen a guardar", "Error GUARDAR Imagen");
				return new responseConversionImage(false, null);
			}
		}
		public static responseGetImage ByteToImage(byte[] imagenInput)
		{
			try
			{
				MemoryStream ms = new MemoryStream(imagenInput);
				Bitmap bm = new Bitmap(ms);
				return new responseGetImage(true, bm);
			}
			catch (Exception e)
			{
				MessageBox.Show("Error al CARGAR la IMAGEN GUARDAD", "Error Cargar Imagen");
				return new responseGetImage(false, null);
			}
		}
		public static void CargaImageFromLocal(PictureBox pictContenedor)
		{
			try
			{
				OpenFileDialog openFile = new OpenFileDialog();
				openFile.Title = "Selecciona la imagen [ jpg . png ]";
				openFile.Filter = "Cargar Imagen|*.jpg;*.png; *.Jpeg";
				if (openFile.ShowDialog() == DialogResult.OK)
				{
					pictContenedor.Image = Image.FromFile(openFile.FileName);
				}
			}
			catch (Exception e)
			{
				pictContenedor.Image = Properties.Resources.userDefault;
				MessageBox.Show("Error al cargar la imagen", "Error");
			}
		}
	}

	struct TipoAviso
	{
		public const MessageBoxIcon error = MessageBoxIcon.Error;
		public const MessageBoxIcon info = MessageBoxIcon.Information;
		public const MessageBoxIcon Warning = MessageBoxIcon.Warning;
	}

}
