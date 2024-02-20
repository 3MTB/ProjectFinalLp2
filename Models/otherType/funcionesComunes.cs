using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace ProjectFinalLp2.Models.otherType
{
	public class funcionesComunes
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
	struct TipoAviso
	{
		public const MessageBoxIcon error = MessageBoxIcon.Error;
		public const MessageBoxIcon info = MessageBoxIcon.Information;
		public const MessageBoxIcon Warning = MessageBoxIcon.Warning;
	}

}
