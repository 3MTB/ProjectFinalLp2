using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Contacto
{
	public Contacto(string pais, string ciudad, string direccion, string email, string telefono)
	{
		Pais = pais;
		Ciudad = ciudad;
		Direccion = direccion;
		Email = email;
		Telefono = telefono;
	}
	public Contacto()
	{

	}

	public int Id { get; set; }

	public string Pais { get; set; } = null!;

	public string Ciudad { get; set; } = null!;

	public string Direccion { get; set; } = null!;

	public string Email { get; set; } = null!;

	public string Telefono { get; set; } = null!;

	public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
