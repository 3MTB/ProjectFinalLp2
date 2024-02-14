using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectFinalLp2.Models.otherType
{
	public class funcionesComunes
	{
		public static bool VerificaString(string str) => !string.IsNullOrWhiteSpace(str);

		public static bool VerificaPassword(string Passowrd)
		{
			return Passowrd.Any(x => Char.IsDigit(x)) && Passowrd.Length >= 4 && Passowrd.Length <= 15;
		}
	}
}
