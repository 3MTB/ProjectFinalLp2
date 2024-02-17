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
		// Posible necesidad de sobreescritura ::: OverWrite
		public static void MakeMessage(string description, string Title, MessageBoxIcon tipo)
		{
			MessageBox.Show(description, Title, MessageBoxButtons.OK, tipo);
		}
		public static bool MakeMessage(string description, string Title, MessageBoxIcon tipo, DialogResult correctAnswer)
		{
			return MessageBox.Show(description, Title, MessageBoxButtons.YesNo, tipo) == correctAnswer;

			//MessageBox.Show(description, Title, MessageBoxButtons.OK, tipo, buttons);
		}
	}
	struct TipoAviso
	{
		public const MessageBoxIcon error = MessageBoxIcon.Error;
		public const MessageBoxIcon info = MessageBoxIcon.Information;
		public const MessageBoxIcon Warning = MessageBoxIcon.Warning;
	}

}
