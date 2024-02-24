using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Licencium
{
	public Licencium()
	{
	}

	public Licencium(DateOnly emision, string categoria, DateOnly fechaVencimiento)
	{
		Emision = emision;
		Categoria = categoria;
		FechaVencimiento = fechaVencimiento;
	}


	public int Id { get; set; }

	public DateOnly Emision { get; set; }

	public string Categoria { get; set; } = null!;

	public DateOnly FechaVencimiento { get; set; }

	public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
