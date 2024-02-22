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
		public RentcargokudemonContext dbContext = new RentcargokudemonContext();
		public bool IsUpAnimation { get; set; } = false;
		public frmlogin()
		{
			// Inicalizador por defecto
			InitializeComponent();
			// Inicalizador por defecto

			// Mi inicalizador personal
			MyInitilaizer();
			// Mi inicalizador personal

		}
		public void MyInitilaizer()
		{
			cbRoll.DataSource = otherTypeUses.roles;
			cbUser.DataSource = dbContext.Clients.ToList();
			cbUser.DisplayMember = "Nombre";

		}

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
			if (MessageBox.Show("Seguro que quiere salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
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
				cbUser.DataSource = dbContext.Trabajadors.ToList();
				cbUser.DisplayMember = "Nombre";
			}
			else if (cbRoll.Text == Roll.Cliente)
			{
				cbUser.DataSource = dbContext.Clients.ToList();
				cbUser.DisplayMember = "Nombre";
			}
			else if (cbRoll.Text == Roll.Boos)
			{
				cbUser.DataSource = dbContext.Admins.ToList();
				cbUser.DisplayMember = "Nombre";
			}
		}


		private void verificaRegistro()
		{
			if (VerificaString(tbPassword.Text))
			{


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
							MessageBox.Show("Incorrect Password");
							tbPassword.Focus();
						}
					}
					else
					{
						MessageBox.Show("No se encontro el trabajador seleccionado");
					}
				}
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
							MessageBox.Show("Incorrect Password");
							tbPassword.Focus();
						}
					}
					else
					{
						MessageBox.Show("No se encontro el Cliente seleccionado");
					}
				}
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
							MessageBox.Show("Incorrect Password");
							tbPassword.Focus();
						}
					}
					else
					{
						MessageBox.Show("No se encontro el Adminstrados seleccionado");
					}
				}
			}
			else
			{
				MessageBox.Show("Debes ingresa una contrasena");
				tbPassword.Focus();
			}
		}

	}
}
