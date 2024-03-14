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

namespace ProjectFinalLp2.Formularios.Aplication
{
	public partial class frmCatalogo : Form
	{
		public Models.Client? client { get; set; } = null;
		public RentcargokudemonContext context { get; set; }
		public frmCatalogo(Models.Client? clienteOpc)
		{
			InitializeComponent();
			this.client = clienteOpc;
			this.context = new RentcargokudemonContext();
		}
		private void frmCatalogo_Load(object sender, EventArgs e)
		{
			lblCantidad.Text = context.Vehiculos.Count().ToString();
			if (context.Vehiculos.Any())
			{
				foreach (var x in context.Vehiculos)
				{
					//var card = new UCVehiculos(x, client);
					//card.Dock = DockStyle.Top;
					//panelMain.Controls.Add(card);
				}
			}
			else
			{
				MessageBox.Show("SIN VEHICULOS DISPONIBLES");
			}

		}

	}
}
