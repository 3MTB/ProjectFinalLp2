using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Licencium
{
	public Licencium(DateOnly emision, int idTipoLicencia, DateOnly fechaVencimiento, TipoLicencium tipoLicencia)
	{
		Emision = emision;
		IdTipoLicencia = idTipoLicencia;
		FechaVencimiento = fechaVencimiento;
		IdTipoLicenciaNavigation = tipoLicencia;
	}
    public Licencium()
    {
        
    }
    public int Id { get; set; }

	public DateOnly Emision { get; set; }

	public int IdTipoLicencia { get; set; }

	public DateOnly FechaVencimiento { get; set; }

	public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

	public virtual TipoLicencium IdTipoLicenciaNavigation { get; set; } = null!;
}
