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
	public partial class FacturaClient : Form
	{

		public Models.Client client { get; set; }
		public List<Rentado> rentados { get; set; }

		public RentcargokudemonContext context { get; set; }
		public FacturaClient(Models.Client client, List<Rentado> rentados)
		{
			InitializeComponent();
			this.client = client;
			this.rentados = rentados;
			context = new RentcargokudemonContext();
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
			Font font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
			Font headerFont = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
			Pen pen = new Pen(Brushes.Black, 2);
			var pageSettings = e.PageSettings;
			var pageSize = new System.Drawing.Size(pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right,
												pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom);
			var pageBounds = new System.Drawing.Rectangle(new System.Drawing.Point(pageSettings.Margins.Left, pageSettings.Margins.Top), pageSize);

			using (var g = e.Graphics)
			{
				// Encabezados de la tabla
				string[] headers = { "Marca", "Modelo", "Color", "Año", "Precio", "Fecha Inicio", "Fecha Final", "SubTotal" };
				float[] columnWidths = { 100, 100, 100, 100, 100, 100, 100, 100 };
				float tableTop = 100;
				float tableLeft = 50;
				float y = tableTop;

				// Dibujar encabezados
				for (int i = 0; i < headers.Length; i++)
				{
					g.DrawString(headers[i], headerFont, Brushes.Black, tableLeft + (i * columnWidths[i]), y);
				}

				// Incrementar la posición Y
				y += font.GetHeight();

				// Dibujar datos de la tabla
				foreach (Rentado x in rentados)
				{
					var vehiculo = context.Vehiculos.First(v => v.Id == x.IdVehiculo);

					// Dibujar valores de cada columna
					g.DrawString(vehiculo.Marca, font, Brushes.Black, tableLeft + (0 * columnWidths[0]), y);
					g.DrawString(vehiculo.Modelo, font, Brushes.Black, tableLeft + (1 * columnWidths[1]), y);
					g.DrawString(vehiculo.Color, font, Brushes.Black, tableLeft + (2 * columnWidths[2]), y);
					g.DrawString(vehiculo.Anio.ToString(), font, Brushes.Black, tableLeft + (3 * columnWidths[3]), y);
					g.DrawString(vehiculo.PrecioRenta.ToString(), font, Brushes.Black, tableLeft + (4 * columnWidths[4]), y);
					g.DrawString(x.FechaInicio.ToShortDateString(), font, Brushes.Black, tableLeft + (5 * columnWidths[5]), y);
					g.DrawString(x.FechaFinal.ToShortDateString(), font, Brushes.Black, tableLeft + (6 * columnWidths[6]), y);
					g.DrawString(x.TotalPagar.ToString("N2"), font, Brushes.Black, tableLeft + (7 * columnWidths[7]), y);

					// Incrementar la posición Y para la siguiente fila
					y += font.GetHeight();
				}
				// Dibujar una línea debajo de la tabla
				float totalTableHeight = y - tableTop; 
				g.DrawLine(pen, tableLeft, tableTop + totalTableHeight, tableLeft + headers.Length * columnWidths.Last(), tableTop + totalTableHeight);

				// Calcular el total a pagar
				decimal total = rentados.Sum(x => x.TotalPagar);

				// Mostrar el total debajo de la línea
				string totalText = $"Total a pagar: {total.ToString("C")}";
				float totalTextWidth = g.MeasureString(totalText, font).Width;
				float totalTextX = pageBounds.Width - totalTextWidth - tableLeft; // Posición X del texto del total
				g.DrawString(totalText, font, Brushes.Black, totalTextX, tableTop + totalTableHeight + font.GetHeight());
			}
		}

	}
}
