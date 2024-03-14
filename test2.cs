using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFinalLp2.Models;

namespace ProjectFinalLp2
{
	public partial class test2 : Form
	{
		public RentcargokudemonContext context { get; set; }

		public test2()
		{
			InitializeComponent();
		}

		private void test2_Load(object sender, EventArgs e)
		{
			this.context = new RentcargokudemonContext();
			if (context.Vehiculos.Any())
			{
				foreach (var x in context.Vehiculos)
				{
					//var card = new UCVehiculos(x, null);
					//card.Dock = DockStyle.Top;
					//table.Controls.Add(card);
				}
			}
			else
			{
				MessageBox.Show("SIN VEHICULOS DISPONIBLES");
			}

		}
	}
}
