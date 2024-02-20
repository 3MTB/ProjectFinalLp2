using ProjectFinalLp2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalLp2.Formularios.Aplication
{
	public partial class frmRentados : Form
	{
		public frmRentados()
		{
			InitializeComponent();
		}

		private void frmRentados_Load(object sender, EventArgs e)
		{
			dgRentados.DataSource = new RentcargokudemonContext().Rentados.ToList();
		}

		// Funciones
	
	}
}
