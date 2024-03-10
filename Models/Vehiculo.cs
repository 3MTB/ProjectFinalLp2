using System;
using System.Collections.Generic;

namespace ProjectFinalLp2.Models;

public partial class Vehiculo
{
	public Vehiculo(string marca, string modelo, string tipo, int anio, string color, string estado, decimal precioRenta, string description, int licenciaRequerida, byte[] image)
	{
		Marca = marca;
		Modelo = modelo;
		Tipo = tipo;
		Anio = anio;
		Color = color;
		Estado = estado;
		PrecioRenta = precioRenta;
		Description = description;
		LicenciaRequerida = licenciaRequerida;
		Image = image;
	}
	public Vehiculo()
	{

	}

	public int Id { get; set; }

	public string Marca { get; set; } = null!;

	public string Modelo { get; set; } = null!;

	public string Tipo { get; set; } = null!;

	public int Anio { get; set; }

	public string Color { get; set; } = null!;

	public string Estado { get; set; } = null!;

	public decimal PrecioRenta { get; set; }

	public string Description { get; set; } = null!;

	public int LicenciaRequerida { get; set; }

	public byte[] Image { get; set; } = null!;

	public virtual ICollection<Rentado> Rentados { get; set; } = new List<Rentado>();
}
