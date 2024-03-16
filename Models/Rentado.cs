using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Rentado
{
	public Rentado(int idCliente, int idVehiculo, int idTrabajador, DateTime fechaInicio, DateTime fechaFinal, decimal totalPagar)
	{
		IdCliente = idCliente;
		IdVehiculo = idVehiculo;
		IdTrabajador = idTrabajador;
		FechaInicio = fechaInicio;
		FechaFinal = fechaFinal;
		TotalPagar = totalPagar;
	}
	public Rentado()
	{

	}
	public int Id { get; set; }

	public int IdCliente { get; set; }

	public int IdVehiculo { get; set; }

	public int IdTrabajador { get; set; }

	public DateTime FechaInicio { get; set; }

	public DateTime FechaFinal { get; set; }

	public decimal TotalPagar { get; set; }

	public virtual Client IdClienteNavigation { get; set; } = null!;

	public virtual Trabajador IdTrabajadorNavigation { get; set; } = null!;

	public virtual Vehiculo IdVehiculoNavigation { get; set; } = null!;
}
