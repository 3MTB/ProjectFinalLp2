using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Data;

public partial class Client
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Edad { get; set; }

    public string Password { get; set; } = null!;

    public byte[] Imagen { get; set; } = null!;

    public int IdContacto { get; set; }

    public virtual Contacto IdContactoNavigation { get; set; } = null!;

    public virtual ICollection<Rentado> Rentados { get; set; } = new List<Rentado>();
}
