using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalLp2.Models.otherType
{
	internal class otherTypeUses
	{
		public static string[] roles = new string[] { Roll.Cliente, Roll.Trabajador, Roll.Boos };

		public static string[] categoriaLicencias = new string[] { catLicencia.c1, catLicencia.c2, catLicencia.c3, catLicencia.c4, catLicencia.c5 };

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
			RecordTiposVehiculos.OffRoad
		};

	}
	public record ColoresDefault{
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
