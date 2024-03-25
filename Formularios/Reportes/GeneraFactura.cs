using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFinalLp2.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectFinalLp2.Formularios.Reportes
{
	public partial class GeneraFactura : Form
	{

		public List<Rentado> rentados { get; set; }

		public RentcargokudemonContext context { get; set; }
		public string Message { get; set; }

		public bool IsAdmin { get; set; }
		public GeneraFactura(List<Rentado> rentados, string Message, bool IsAdmin)
		{
			InitializeComponent();
			this.rentados = rentados;
			context = new RentcargokudemonContext();
			this.IsAdmin = IsAdmin;
		}

		private void FacturaClient_Load(object sender, EventArgs e)
		{
			if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			imprimir(sender, e);
		}
		private void imprimir(object sender, PrintPageEventArgs e)
		{
			Font fontTitle = new Font("Arial", 22, FontStyle.Bold, GraphicsUnit.Point);
			Font font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
			Font headerFont = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
			Pen pen = new Pen(Brushes.Black, 2);
			var pageSettings = e.PageSettings;
			var pageSize = new System.Drawing.Size(pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right,
												pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom);
			var pageBounds = new System.Drawing.Rectangle(new System.Drawing.Point(pageSettings.Margins.Left, pageSettings.Margins.Top), pageSize);


			int positionY = 100;
			e.Graphics.DrawImage(Properties.Resources.logo, new Point((pageSize.Width / 4), positionY));
			positionY += 220;

			PointF pf = new Point(pageSize.Width / 4, positionY);
			e.Graphics.DrawString(Message, fontTitle, Brushes.Black, pf);
			positionY += (int)fontTitle.GetHeight() + 20;

			using (var g = e.Graphics)
			{
				string[] headers = { };
				float[] columnWidths = { };


				if (IsAdmin)
				{
					headers = new string[] { "Marca", "Modelo", "Precio", "Fecha Inicio", "Fecha Final", "SubTotal", "Cliente" };
					columnWidths = new float[] { 100, 100, 100, 100, 100, 100,100 };

				}
				else
				{

					headers = new string[] { "Marca", "Modelo", "Color", "Año", "Precio", "Fecha Inicio", "Fecha Final", "SubTotal" };
					columnWidths = new float[] { 100, 100, 100, 100, 100, 100, 100, 100 };
				}
				float tableTop = positionY;
				float tableLeft = 50;
				float y = tableTop;

				for (int i = 0; i < headers.Length; i++)
				{
					g.DrawString(headers[i], headerFont, Brushes.Black, tableLeft + (i * columnWidths[i]), positionY);
				}

				y += font.GetHeight() + 3;
				foreach (Rentado x in rentados)
				{
					var vehiculo = context.Vehiculos.First(v => v.Id == x.IdVehiculo);
					if (IsAdmin)
					{

						g.DrawString(vehiculo.Marca, font, Brushes.Black, tableLeft + (0 * columnWidths[0]), y);
						g.DrawString(vehiculo.Modelo, font, Brushes.Black, tableLeft + (1 * columnWidths[1]), y);
						g.DrawString(vehiculo.PrecioRenta.ToString(), font, Brushes.Green, tableLeft + (2 * columnWidths[2]), y);
						g.DrawString(x.FechaInicio.ToShortDateString(), font, Brushes.Black, tableLeft + (3 * columnWidths[3]), y);
						g.DrawString(x.FechaFinal.ToShortDateString(), font, Brushes.Black, tableLeft + (4 * columnWidths[4]), y);
						g.DrawString(x.TotalPagar.ToString("N2"), font, Brushes.Black, tableLeft + (5 * columnWidths[5]), y);
						g.DrawString(context.Clients.First(c => c.Id == x.IdCliente).Nombre, font, Brushes.Black, tableLeft + (6 * columnWidths[6]), y);
					}
					else{
						g.DrawString(vehiculo.Marca, font, Brushes.Black, tableLeft + (0 * columnWidths[0]), y);
						g.DrawString(vehiculo.Modelo, font, Brushes.Black, tableLeft + (1 * columnWidths[1]), y);
						g.DrawString(vehiculo.Color, font, Brushes.Black, tableLeft + (2 * columnWidths[2]), y);
						g.DrawString(vehiculo.Anio.ToString(), font, Brushes.Black, tableLeft + (3 * columnWidths[3]), y);
						g.DrawString(vehiculo.PrecioRenta.ToString(), font, Brushes.Green, tableLeft + (4 * columnWidths[4]), y);
						g.DrawString(x.FechaInicio.ToShortDateString(), font, Brushes.Black, tableLeft + (5 * columnWidths[5]), y);
						g.DrawString(x.FechaFinal.ToShortDateString(), font, Brushes.Black, tableLeft + (6 * columnWidths[6]), y);
						g.DrawString(x.TotalPagar.ToString("N2"), font, Brushes.Black, tableLeft + (7 * columnWidths[7]), y);
					}
					
					y += font.GetHeight() + 4;
				}
				float totalTableHeight = y - tableTop;
				g.DrawLine(pen, tableLeft, tableTop + totalTableHeight, tableLeft + headers.Length * columnWidths.Last(), tableTop + totalTableHeight);

				decimal total = rentados.Sum(x => x.TotalPagar);

				Font fontTotal = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Point);

				string totalText = $"Total a pagar: {total.ToString("C")}";
				float totalTextWidth = g.MeasureString(totalText, fontTotal).Width;
				float totalTextX = pageBounds.Width - totalTextWidth - tableLeft;
				g.DrawString(totalText, fontTotal, Brushes.Black, totalTextX, tableTop + totalTableHeight + fontTotal.GetHeight());

				y += fontTotal.GetHeight() + 50;



				g.DrawString("Gracias Por Preferirnos", headerFont, Brushes.Black, pageSize.Width / 3, y);

				this.Hide();
			}


		}

	}
}
