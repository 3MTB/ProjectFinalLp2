using Guna.UI2.WinForms.Suite;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalLp2.Models.otherType
{
	internal class otherTypeUses
	{
		private static RentcargokudemonContext context = new RentcargokudemonContext();
		public static string[] roles = new string[] { Roll.Cliente, Roll.Trabajador, Roll.Boos };

		public static TipoLicencium[] categoriaLicencia()
		{
			TipoLicencium[] tipos = new TipoLicencium[0];

			if (!context.TipoLicencia.Any())
			{

				TipoLicencium l1 = new TipoLicencium("01", "Motor de 3 gomas o menos.");
				context.TipoLicencia.Add(l1);
				TipoLicencium l2 = new TipoLicencium("02", "Vehículos de dos ejes livianos.");
				context.TipoLicencia.Add(l2);
				TipoLicencium l3 = new TipoLicencium("03", "Vehículos pesados destinados al transporte de pasajeros[<40] o carga con dos ejes.");
				context.TipoLicencia.Add(l3);
				TipoLicencium l4 = new TipoLicencium("04", "Vehículos destinados al transporte de pasajeros[>40] o cargas pesadas con mas de 2 eje.");
				context.TipoLicencia.Add(l4);
				TipoLicencium l5 = new TipoLicencium("05", "Puede manejar vehículos especiales como tractores, gredas, retro excavadoras, etc.");
				context.TipoLicencia.Add(l5);
				context.SaveChanges();
				MessageBox.Show(@"Auto generación de valores establecida para Tipos Licencia -\./-");
			}
			tipos = context.TipoLicencia.ToArray();

			return tipos;
		}


		public static string[] estadosVehiculos = new string[]{
			RecordEstadosVehiculos.Excelente,
			RecordEstadosVehiculos.MuyBien,
			RecordEstadosVehiculos.Bien,
			RecordEstadosVehiculos.Regular
		};
		public static string[] tiposVehiculos = new string[]{
			RecordTiposVehiculos.Casual,
			RecordTiposVehiculos.ViajesLargos,
			RecordTiposVehiculos.Carga,
			RecordTiposVehiculos.OffRoad,
			RecordTiposVehiculos.TrabajosPesados,
			RecordTiposVehiculos.Adrenalina

		};

	}
	public record ColoresDefault
	{
		public static string Blanco = "Blanco";
		public static string Negro = "Negro";
		public static string Rojo = "Rojo";
		public static string Azul = "Azul";
		public static string Verde = "Verde";

	}
	public record RecordTiposVehiculos
	{
		public static string Casual = "Casual";
		public static string ViajesLargos = "Viajes Largos";
		public static string Carga = "Carga";
		public static string OffRoad = "OffRoad";
		public static string TrabajosPesados = "TrabajosPesados";
		public static string Adrenalina = "Adrenalina";

	}
	public record RecordEstadosVehiculos
	{
		public static string Excelente = "Excelente";
		public static string MuyBien = "Muy Bien";
		public static string Bien = "Bien";
		public static string Regular = "Regular";
	}

	public record ColorDefaults
	{
		public static Color cForegroundActive = Color.FromArgb(255, 255, 255);
		public static Color cForegroundDisable = Color.FromArgb(0, 0, 0);
		public static Color cBackgroundDisable = Color.FromArgb(255, 255, 255);
		public static Color cBackgroundActive = Color.FromArgb(0, 0, 0);
	}
	struct catLicencia
	{
		public const string c1 = "01";
		public const string c2 = "02";
		public const string c3 = "03";
		public const string c4 = "04";
		public const string c5 = "05";
	}
	struct Roll
	{
		public const string Cliente = "Cliente";
		public const string Trabajador = "Trabajador";
		public const string Boos = "Jefe";
	}
	public record responseConversionImage(bool Success, byte[]? Message);
	public record responseGetImage(bool Success, Bitmap? Message);
}
