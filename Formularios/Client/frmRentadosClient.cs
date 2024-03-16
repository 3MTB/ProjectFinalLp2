using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFinalLp2.Formularios.Aplication;

// My NameSpace
using ProjectFinalLp2.Models;


namespace ProjectFinalLp2.Formularios.Client
{
	public partial class frmRentadosClient : Form
	{
		#region					Objetos Generales
		public Models.Client clientCurrent { get; set; }
		RentcargokudemonContext context = new RentcargokudemonContext();
		#endregion

		#region					Constructor
		public frmRentadosClient(Models.Client client)
		{
			InitializeComponent();
			this.clientCurrent = client;
		}
		#endregion
		
		#region							EVENTOS
		private void frmRentadosClient_Load(object sender, EventArgs e)
		{
			var obt = context.Rentados.Where(x => x.IdCliente == clientCurrent.Id);
			tbCantidad.Text = obt.Count().ToString();

			if (obt == null || !obt.Any())
			{
				dgRentados.Visible = false;
				lblAlert.Text = "SIN VEHICULOS RENTADOS";
				lblAlert.Visible = true;
				btnRentar.Focus();
			}
			else
			{
				dgRentados.DataSource = obt.ToList();
			}
		}

		private void btnRentar_Click(object sender, EventArgs e)
		{
			this.Close();
			/*new FrmRegRentarVehiculo(CLIEN).Show();*/
		}
		#endregion
	}
}
