

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// Add for me
using ProjectFinalLp2.Formularios.Aplication;
using ProjectFinalLp2.Formularios.Boss;
using ProjectFinalLp2.Formularios.Client;
using ProjectFinalLp2.Models;

namespace ProjectFinalLp2
{
	internal static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Clear that
			Admin adminDefault = new RentcargokudemonContext().Admins.First();
			//Client clientDefault = new RentcargokudemonContext().Clients.First();
			// Clear that




			// Programa inicial
			//Application.Run(new frmMainAdministrador(adminDefault));
			//Application.Run(new frmMainClient(clientDefault));
			Application.Run(new frmLoading());
		}
	}
}
