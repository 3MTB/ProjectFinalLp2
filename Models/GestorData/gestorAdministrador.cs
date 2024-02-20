using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;
using ProjectFinalLp2.Models.otherType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static ProjectFinalLp2.Models.otherType.funcionesComunes;

namespace ProjectFinalLp2.Models.GestorData
{
	public class gestorAdministrador
	{
		//! TODO: PROBAR ESTO
		private static RentcargokudemonContext context = new RentcargokudemonContext();

		public static bool InsertaAdmin(Admin insert)
		{
			if (!verificaCaracteristicasAdmin(insert))
			{
				return false;
			}
			if (!context.Admins.Any())
			{
				context.Admins.Add(insert);
				context.SaveChanges();
				MakeMessage($"Administrador Registrado", "Administrador Guardado", MessageBoxIcon.Information);
				return true;
			}
			else if (!context.Admins.Any(x => x.Nombre == insert.Nombre))
			{
				context.Admins.Add(insert);
				context.SaveChanges();
				MakeMessage($"Administrador Registrado", "Administrador Guardado", MessageBoxIcon.Information);
				return true;
			}
			else
			{
				MakeMessage($"Ya existe un Administrador con nombre: {insert.Nombre}", "Error de Existencia", TipoAviso.error);
				return false;
			}
		}

		public static focusTo UpdateAdmin(int idOld, Admin update)
		{
			focusTo devolver = new focusTo();
			var usar = context.Admins.FirstOrDefault(x => x.Id == idOld);
			if (usar != null)
			{
				if (string.IsNullOrWhiteSpace(update.Nombre) && string.IsNullOrWhiteSpace(update.Password))
				{
					MakeMessage("Debes ingresar nuevos valores", "Error", TipoAviso.error);
					devolver.Name = true;
					devolver.Password = true;
				}
				if (!string.IsNullOrWhiteSpace(update.Nombre))
				{
					if (usar.Nombre != update.Nombre)
					{
						if (update.Nombre.Length <= 30)
						{
							if (!context.Admins.Any(x => x.Nombre == update.Nombre))
							{
								if (MakeMessage($"Seguro que quieres Modificar al nombre del administrador {usar.Nombre} por: {update.Nombre}", "Confirmación de Actualización Nombre", MessageBoxIcon.Question, DialogResult.Yes))
								{
									usar.Nombre = update.Nombre;
									context.SaveChanges();
									devolver.Name = false;
								}
							}
							else
							{
								MakeMessage($"Ya existe un Administrador con nombre: {update.Nombre}", "Error de Existencia", TipoAviso.error);
								devolver.Name = true;
							}
						}
						else
						{
							MakeMessage($"El campo nombre no cumple las reglas: <=30 caracteres.\n Por lo que no se puede realizar la actualización de: {usar.Nombre} => {update.Nombre}", "Error de Datos - Nombre", TipoAviso.error);
							devolver.Name = true;
						}
					}
					else
					{
						MakeMessage("Sin cambios en Nombre", "Sin cambios", TipoAviso.Warning);
						devolver.Name = true;
					}
				}
				if (!string.IsNullOrWhiteSpace(update.Password))
				{
					if (update.Password.Length <= 15)
					{
						if (usar.Password != update.Password)
						{
							if (MakeMessage($"Seguro que quieres Modificar la password del a: {update.Password}", "Confirmación de Actualización Contraseña", MessageBoxIcon.Question, DialogResult.Yes))
							{
								usar.Password = update.Password;
								context.SaveChanges();
								devolver.Password = false;
							}
						}
						else
						{
							MakeMessage("Sin cambios en Contraseña", "Sin cambios", TipoAviso.Warning);
							devolver.Password = true;
						}
					}
					else
					{
						MakeMessage($"El campo Contraseña no cumple las reglas: <=15 caracteres", "Error de Datos - Password", TipoAviso.error);
						devolver.Password = true;

					}
				}
			}
			else
			{
				MakeMessage("No se encontró el Administrador seleccionado", "Error", TipoAviso.error);
			}
			return devolver;

		}

		public static void DeleteAdmin(int Id)
		{
			var eliminar = context.Admins.FirstOrDefault(x => x.Id == Id);
			if (eliminar != null)
			{
				if (MakeMessage($"Seguro que quieres eliminar el Administrador: {eliminar.Nombre}", "Confirmación de Eliminación Admin", MessageBoxIcon.Question, DialogResult.Yes))
				{
					context.Admins.Remove(eliminar);
					context.SaveChanges();
				}
			}
			else
			{
				MakeMessage("No se encontró el Administrador a eliminar", "Error", TipoAviso.error);
			}
		}

		public static List<Admin> ObtenerAdmin()
		{
			context.SaveChanges();
			return context.Admins.ToList();
		}

		// Other Methods
		private static bool verificaCaracteristicasAdmin(Admin verificar)
		{
			if (!string.IsNullOrWhiteSpace(verificar.Nombre) && verificar.Nombre.Length <= 30)
			{
				if (!string.IsNullOrWhiteSpace(verificar.Password) && verificar.Password.Length <= 15)
				{
					return true;
				}
				else
				{
					MakeMessage($"El campo PASSWORD no cumple las reglas: <=15 caracteres", "Error de Datos - Password", TipoAviso.error);
				}
			}
			else
			{
				MakeMessage($"El campo nombre no cumple las reglas: <=30 caracteres", "Error de Datos - Nombre", TipoAviso.error);
			}
			return false;

		}

	}
	public record focusTo
	{
		public bool Name { get; set; } = false;
		public bool Password { get; set; } = false;
	}
}
