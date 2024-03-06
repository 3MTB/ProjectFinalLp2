using ProjectFinalLp2.Models;
using ProjectFinalLp2.Models.otherType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ME
using ProjectFinalLp2.Formularios;
using static ProjectFinalLp2.Models.otherType.funcionesComunes;
using ProjectFinalLp2.Formularios.Trabajador;
using ProjectFinalLp2.Formularios.Client;
using ProjectFinalLp2.Formularios.Boss;

namespace ProjectFinalLp2.Formularios.Aplication
{
	public partial class frmlogin : Form
	{
		#region					Objetos Generales
		public RentcargokudemonContext dbContext = new RentcargokudemonContext();
		public bool IsUpAnimation { get; set; } = false;
		#endregion

		#region					Constructor
		public frmlogin()
		{
			// Inicalizador por defecto
			InitializeComponent();
			// Inicalizador por defecto

			// Mi inicalizador personal
			MyInitializer();
			// Mi inicalizador personal
		}

		public void MyInitializer()
		{
			cbRoll.DataSource = otherTypeUses.roles;
			cbUser.DataSource = dbContext.Clients.ToList();
			cbUser.DisplayMember = "Nombre";
		}
		#endregion

		#region							Eventos
		private void timerAnimation_Tick(object sender, EventArgs e)
		{
			if (IsUpAnimation)
			{
				if (pgbHorizontal.Value < pgbHorizontal.Maximum - 2)
				{
					pgbHorizontal.Value += 2;
					pgbVertical.Value += 2;
				}
				else
				{
					IsUpAnimation = false;
				}
			}
			else
			{
				pgbHorizontal.Value -= 2;
				pgbVertical.Value -= 2;

				if (pgbHorizontal.Value <= pgbHorizontal.Minimum + 1)
				{
					IsUpAnimation = true;
				}
			}
		}
		private void btnOut_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Seguro que quiere salir?", "Confirmación SALIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		private void btnEntrar_Click(object sender, EventArgs e)
		{
			verificaRegistro();
		}
		private void cbRoll_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbRoll.Text == Roll.Trabajador)
			{
				lblAlert.Text = dbContext.Trabajadors.Any() ? string.Empty : $"⚠️Alert: Sin registros de: {Roll.Trabajador}";

				cbUser.DataSource = dbContext.Trabajadors.ToList();
				cbUser.DisplayMember = "Nombre";
				btnRegistrar.Text = $"Reg. {Roll.Trabajador}";
				lblUser.Text = Roll.Trabajador;
			}
			else if (cbRoll.Text == Roll.Cliente)
			{
				bool r = dbContext.Clients.Any();

				lblAlert.Text = dbContext.Clients.Any() ? string.Empty : $"⚠️Alert: Sin registros de: {Roll.Cliente}";

				cbUser.DataSource = dbContext.Clients.ToList();
				cbUser.DisplayMember = "Nombre";
				btnRegistrar.Text = $"Reg. {Roll.Cliente}";
				lblUser.Text = Roll.Cliente;
			}
			else if (cbRoll.Text == Roll.Boos)
			{
				lblAlert.Text = dbContext.Admins.Any() ? string.Empty : $"⚠️Alert: Sin registros de: {Roll.Boos}";

				cbUser.DataSource = dbContext.Admins.ToList();
				cbUser.DisplayMember = "Nombre";
				btnRegistrar.Text = $"Reg. {Roll.Boos}";
				lblUser.Text = Roll.Boos;

			}
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			GoToRegistrar();
		}
		#endregion

		#region						  Metodos Auxiliares
		private void verificaRegistro()
		{
			if (VerificaString(tbPassword.Text))
			{
				//									Es un EMPLEADO
				if (cbRoll.Text == Roll.Trabajador)
				{
					var trabajador = dbContext.Trabajadors.FirstOrDefault(x => x == cbUser.SelectedValue);
					if (trabajador != null)
					{
						if (trabajador.Password == tbPassword.Text)
						{
							this.Hide();
							new frmTrabajadorMain().Show();
						}
						else
						{
							MessageBox.Show("Contraseña Incorrecta");
							tbPassword.Focus();
						}
					}
					else
					{
						MessageBox.Show($"No se encontró el {Roll.Trabajador} seleccionado");
					}
				}
				//									Es un CLIENTE

				else if (cbRoll.Text == Roll.Cliente)
				{
					var client = dbContext.Clients.FirstOrDefault(x => x == cbUser.SelectedItem);
					if (client != null)
					{
						if (client.Password == tbPassword.Text)
						{
							this.Hide();
							new frmMainClient(client).Show();
						}
						else
						{
							MessageBox.Show("Contraseña Incorrecta");

							tbPassword.Focus();
						}
					}
					else
					{
						MessageBox.Show($"No se encontró el {Roll.Cliente} seleccionado");
					}
				}
				//									Es un JEFE

				else if (cbRoll.Text == Roll.Boos)
				{
					var boss = dbContext.Admins.FirstOrDefault(x => x == cbUser.SelectedItem);
					if (boss != null)
					{
						if (boss.Password == tbPassword.Text)
						{
							this.Hide();
							new frmMainAdministrador(boss).Show();
						}
						else
						{
							MessageBox.Show("Contraseña Incorrecta");
							tbPassword.Focus();
						}
					}
					else
					{
						MessageBox.Show($"No se encontró el {Roll.Boos}  seleccionado");
					}
				}
			}
			else
			{
				MessageBox.Show("Debes ingresar una contraseña");
				tbPassword.Focus();
			}
		}
		private void GoToRegistrar()
		{
			if (cbRoll.Text == Roll.Trabajador)
			{
				MessageBox.Show("FUNCION EN CONSCTRUCCION :: Registrar Trabajador");
			}
			else if (cbRoll.Text == Roll.Cliente)
			{
				this.Hide();
				new frmRegisterClient().Show();
			}
			else if (cbRoll.Text == Roll.Boos)
			{
				this.Hide();
				new frmRegisterAdmin().Show();
			}
		}
		#endregion
	}
}
