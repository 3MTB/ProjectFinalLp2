using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Contacto
{
    public int Id { get; set; }

    public string Pais { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
