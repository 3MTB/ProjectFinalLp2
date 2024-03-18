using static ProjectFinalLp2.Models.otherType.funcionesComunes;

namespace ProjectFinalLp2.Models.GestorData
{
	public class gestorAdministrador
	{
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
				MessageBox.Show($"Administrador Registrado", "Administrador Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;
			}
			else if (!context.Admins.Any(x => x.Nombre == insert.Nombre))
			{
				context.Admins.Add(insert);
				context.SaveChanges();

				MessageBox.Show($"Administrador Registrado", "Administrador Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else
			{
				MessageBox.Show($"Ya existe un Administrador con nombre: {insert.Nombre}", "Error de Existencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			}
		}

		public static focusTo UpdateAdmin(int idOld, Admin update)
		{
			focusTo devolver = new focusTo();
			var usar = context.Admins.FirstOrDefault(x => x.Id == idOld);
			if (usar != null)
			{

				if (!VerificaString(update.Nombre) && !VerificaString(update.Password))
				{
					MessageBox.Show("Debes ingresar nuevos valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

					devolver.Name = true;
					devolver.Password = true;
				}
				if (VerificaString(update.Nombre))
				{
					if (usar.Nombre != update.Nombre)
					{
						if (update.Nombre.Length <= 30)
						{
							if (!context.Admins.Any(x => x.Nombre == update.Nombre))
							{
								if (MessageBox.Show($"Seguro que quieres Modificar al nombre del administrador {usar.Nombre} por: {update.Nombre}", "Confirmación de Actualización Nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
								{
									usar.Nombre = update.Nombre;
									context.SaveChanges();
									devolver.Name = false;
								}
							}
							else
							{
								MessageBox.Show($"Ya existe un Administrador con nombre: {update.Nombre}", "Error de Existencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

								devolver.Name = true;
							}
						}
						else
						{
							MessageBox.Show($"El campo nombre no cumple las reglas: <=30 caracteres.\n Por lo que no se puede realizar la actualización de: {usar.Nombre} => {update.Nombre}", "Error de Datos - Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);

							devolver.Name = true;
						}
					}
					else
					{
						MessageBox.Show("Sin cambios en Nombre", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				if (VerificaString(update.Password))
				{
					if (update.Password.Length <= 15)
					{
						if (usar.Password != update.Password)
						{

							if (MessageBox.Show($"Seguro que quieres Modificar la password {usar.Password} por {new String('*', update.Password.Length)}", "Confirmación de Actualización Contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
							{
								usar.Password = update.Password;
								context.SaveChanges();
								devolver.Password = false;
							}
						}
						else
						{

							MessageBox.Show("Sin cambios en Contraseña", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							devolver.Password = true;
						}
					}
					else
					{
						MessageBox.Show("El campo Contraseña no cumple las reglas: <=15 caracteres", "Error de Datos - Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

						devolver.Password = true;

					}
				}
			}
			else
			{
				MessageBox.Show("No se encontró el Administrador seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return devolver;

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
					MessageBox.Show("El campo Contraseña no cumple las reglas: <=15 caracteres", "Error de Datos - Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
			else
			{
				MessageBox.Show($"El campo nombre no cumple las reglas: <=30 caracteres", "Error de Datos - Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
