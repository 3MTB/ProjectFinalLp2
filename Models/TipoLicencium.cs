using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class TipoLicencium
{
	public TipoLicencium(string codigo, string description)
	{
		Codigo = codigo;
		Description = description;
	}
	public TipoLicencium()
	{

	}
	public int IdLicencia { get; set; }

	public string Codigo { get; set; } = null!;

	public string Description { get; set; } = null!;

	public virtual ICollection<Licencium> Licencia { get; set; } = new List<Licencium>();
}
