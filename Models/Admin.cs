using System;
using System.Collections.Generic;
// My NameSpace Used
using Microsoft.AspNetCore.DataProtection;

using static ProjectFinalLp2.Models.otherType.funcionesComunes;
// My NameSpace Used

namespace ProjectFinalLp2.Models;

public partial class Admin
{
	public Admin(string nombre, string password)
	{
		this.Nombre = nombre.ToUpper();
		this.Password = password;
	}
	public Admin()
	{
	}
	public int Id { get; set; }

	public string Nombre { get; set; } = null!;

	public string Password
	{
		get;
		set;
	}

}
