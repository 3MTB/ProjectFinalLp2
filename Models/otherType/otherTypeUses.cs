﻿using Org.BouncyCastle.Crypto.Engines;
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
