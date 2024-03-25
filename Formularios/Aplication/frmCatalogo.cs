using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml.Permissions;

// My NameSpace
using ProjectFinalLp2.Models;

namespace ProjectFinalLp2.Formularios.Aplication
{
	public partial class frmCatalogo : Form
	{
		#region				                   	OBJETOS
		public Models.Client client { get; set; } = null;
		public RentcargokudemonContext context { get; set; }

		#endregion

		#region                                     Contructor e inicializador

		public frmCatalogo(Models.Client client, Size size)
		{
			InitializeComponent();
			this.client = client;
			this.context = new RentcargokudemonContext();
			this.Size = size;
			this.Size = size;
		}
		private void frmCatalogo_Load(object sender, EventArgs e)
		{

			var panelwidth = panelLayout.Width - 5;
			var objWith = new UCVehiculos().Width + 10;
			panelLayout.ColumnCount = (int)panelwidth / objWith;

			lblCantidad.Text = context.Vehiculos.Count().ToString();
			var renta = context.Rentados.ToArray();
			if (context.Vehiculos.Any())
			{
				foreach (var x in context.Vehiculos)
				{
					bool IsNotDisponible = renta.Any(r => r.IdVehiculo == x.Id);
					var card = new UCVehiculos(x, client, IsNotDisponible);

					panelLayout.Controls.Add(card);
				}
			}
			else
			{
				MessageBox.Show("SIN VEHICULOS DISPONIBLES");
			}

		}

		#endregion


	}
}
