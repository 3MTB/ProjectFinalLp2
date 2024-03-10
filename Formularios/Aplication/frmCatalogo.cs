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
		public frmCatalogo(Models.Client? clienteOpc)
		{
			InitializeComponent();
			this.client = clienteOpc;
		}
		private void OpcionRentar()
		{
			MessageBox.Show("Rentando");
		}

		private void btnRentarPorsche_Click(object sender, EventArgs e)
		{
			OpcionRentar();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Vehiculo vh = new Vehiculo("Toyota", "Prado", "CARRO", 2024, "Bengro", "Excelente", 340, "Vehiculo para disfrutar", 2, new byte['-']);

			UCVehiculos g2 = new UCVehiculos(vh, client);
			g2.Dock = DockStyle.Top;

			panelMain.Controls.Add(g2);
		}

		private void frmCatalogo_Load(object sender, EventArgs e)
		{
			Vehiculo vh = new Vehiculo("BMW", "X6", "CARRO", 2021, "Blanco", "Excelente", 240, "Vehiculo para disfrutar", 2, new byte[',']);
			UCVehiculos g = new UCVehiculos(vh, client);
			g.Dock = DockStyle.Top;
			panelMain.Controls.Add(g);

		}

	}
}
