using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// My NameSpace
using ProjectFinalLp2.Models;


namespace ProjectFinalLp2.Formularios.Client
{
	public partial class frmRentadosClient : Form
	{
		public Models.Client clientCurrent { get; set; }
		RentcargokudemonContext context = new RentcargokudemonContext();
		public frmRentadosClient(Models.Client client)
		{
			InitializeComponent();
			this.clientCurrent = client;
		}

		private void frmRentadosClient_Load(object sender, EventArgs e)
		{
			var obt = context.Rentados.Where(x => x.IdCliente == clientCurrent.Id);
			tbCantidad.Text = obt.Count().ToString();

			if (obt == null || !obt.Any())
			{
				dgRentados.Visible = false;
				lblAlert.Text = "NO TIENES VEHICULOS RENTADOS";
				lblAlert.Visible = true;
				// aparecer boton para rentar vehiculo
			}
			else
			{
				dgRentados.DataSource = obt.ToList();
			}
		}


	}
}
