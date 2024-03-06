using ProjectFinalLp2.Formularios.Aplication;
using ProjectFinalLp2.Models;
using ProjectFinalLp2.Models.GestorData;
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
// My NameSpace
using static ProjectFinalLp2.Models.otherType.funcionesComunes;


// My NameSpace

namespace ProjectFinalLp2.Formularios.Boss
{
	public partial class frmRegisterAdmin : Form
	{
		#region					CONSTRUCTOR
		public frmRegisterAdmin()
		{
			InitializeComponent();
			tbName.Text = Environment.UserName;
		}
		#endregion

		#region						EVENTOS
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			if (VerificaString(tbName.Text) && VerificaString(tbPassword.Text))
			{
				if (gestorAdministrador.InsertaAdmin(new Models.Admin(tbName.Text, tbPassword.Text)))
				{
					tbName.Text = string.Empty;
					tbPassword.Text = string.Empty;
					this.Close();
					new frmlogin().Show();
				}
				else
				{
					tbName.Focus();
				}
			}
			else
			{
				if (!VerificaString(tbName.Text))
				{
					MakeMessage("Campo Nombre vacío", "Nombre vacío", TipoAviso.Warning);
					tbName.Focus();

					return;
				}
				if (!VerificaString(tbPassword.Text))
				{
					MakeMessage("Campo Password vacío", "Password vacío", TipoAviso.Warning);
					tbPassword.Focus();

					return;
				}
			}

		}

		private void tbPassword_TextChanged(object sender, EventArgs e)
		{
			if (tbPassword.Text.Length == 0)
			{
				lblAvisoPassword.Text = string.Empty;
			}
			else if (tbPassword.Text.Length > 15)
			{
				lblAvisoPassword.Text = "Password Muy Larga";
			}
			else if (tbPassword.Text.Length < 4)
			{
				lblAvisoPassword.Text = "Password Muy Corta";
			}
			else if (!tbPassword.Text.Any(x => char.IsDigit(x)))
			{
				lblAvisoPassword.Text = "Password Débil: Introduce al menos un numero";
			}
			else if (!tbPassword.Text.Any(x => char.IsLetter(x)))
			{
				lblAvisoPassword.Text = "Password Débil: Introduce al menos una Letra";
			}
			else
			{
				lblAvisoPassword.Text = string.Empty;
			}
		}

		private void tbName_TextChanged(object sender, EventArgs e)
		{
			RentcargokudemonContext context = new RentcargokudemonContext();
			if (context.Admins.Any(x => x.Nombre == tbName.Text.ToString()))
			{
				lblExistencia.Visible = true;
				btnRegistrar.Enabled = false;
			}
			else
			{
				lblExistencia.Visible = false;
				btnRegistrar.Enabled = true;

			}
		}
		private void btnToLogin_Click(object sender, EventArgs e)
		{
			this.Hide();
			new frmlogin().Show();
		}
		#endregion


	}
}

