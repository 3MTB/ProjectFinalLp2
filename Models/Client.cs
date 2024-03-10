using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Client
{
	public Client(string nombre, string apellido, int edad, string password, byte[] imagen, int idContacto, int idLicencia, Contacto contacto, Licencium licencia)
	{
		Nombre = nombre;
		Apellido = apellido;
		Edad = edad;
		Password = password;
		Imagen = imagen;
		IdContacto = idContacto;
		IdLicencia = idLicencia;
		IdContactoNavigation = contacto;
		IdLicenciaNavigation = licencia;
	}
	public Client()
	{

	}

	public int Id { get; set; }

	public string Nombre { get; set; } = null!;

	public string Apellido { get; set; } = null!;

	public int Edad { get; set; }

	public string Password { get; set; } = null!;

	public byte[] Imagen { get; set; } = null!;

	public int IdContacto { get; set; }

	public int IdLicencia { get; set; }

	public virtual Contacto IdContactoNavigation { get; set; } = null!;

	public virtual Licencium IdLicenciaNavigation { get; set; } = null!;

	public virtual ICollection<Rentado> Rentados { get; set; } = new List<Rentado>();
}
