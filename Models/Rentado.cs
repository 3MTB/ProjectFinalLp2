using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Rentado
{
	public Rentado()
	{

	}
	public Rentado(int idCliente, int idVehiculo, DateTime fechaInicio, DateTime fechaFinal, int idTrabajador, Client idClienteNavigation, Trabajador employee, Vehiculo vehicule)
	{
		IdCliente = idCliente;
		IdVehiculo = idVehiculo;
		FechaInicio = fechaInicio;
		FechaFinal = fechaFinal;
		IdTrabajador = idTrabajador;
		IdClienteNavigation = idClienteNavigation;
		IdTrabajadorNavigation = employee;
		IdVehiculoNavigation = vehicule;
	}

	public int Id { get; set; }

	public int IdCliente { get; set; }

	public int IdVehiculo { get; set; }

	public DateTime FechaInicio { get; set; }

	public DateTime FechaFinal { get; set; }

	public int IdTrabajador { get; set; }

	public virtual Client IdClienteNavigation { get; set; } = null!;

	public virtual Trabajador IdTrabajadorNavigation { get; set; } = null!;

	public virtual Vehiculo IdVehiculoNavigation { get; set; } = null!;
}
