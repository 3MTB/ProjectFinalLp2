using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Admin
{
	public Admin()
	{

	}
	public Admin(string nombre, string password)
	{
		Nombre = nombre;
		Password = password;
	}


	public int Id { get; set; }

	public string Nombre { get; set; } = null!;

	public string Password { get; set; } = null!;
}
