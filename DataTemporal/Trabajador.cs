﻿using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Data;

public partial class Trabajador
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public virtual ICollection<Rentado> Rentados { get; set; } = new List<Rentado>();
}
