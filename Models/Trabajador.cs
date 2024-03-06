using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Trabajador
{
	public Trabajador(string name, string password, string cargo)
	{
		Name = name;
		Password = password;
		Cargo = cargo;
	}
	public Trabajador()
	{

	}

	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public string Password { get; set; } = null!;

	public string Cargo { get; set; } = null!;

	public virtual ICollection<Rentado> Rentados { get; set; } = new List<Rentado>();
}
