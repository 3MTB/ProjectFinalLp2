using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Vehiculo
{
    public int Id { get; set; }

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int Anio { get; set; }

    public string Color { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public decimal PrecioRenta { get; set; }

    public string Desription { get; set; } = null!;

    public virtual ICollection<Rentado> Rentados { get; set; } = new List<Rentado>();
}
