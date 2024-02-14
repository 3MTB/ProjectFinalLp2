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
	}
	struct Roll
	{
		public const string Cliente = "Cliente";
		public const string Trabajador = "Trabajador";
		public const string Boos = "Jefe";
	}
}
