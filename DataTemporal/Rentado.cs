using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Data;
public partial class Rentado
{
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
