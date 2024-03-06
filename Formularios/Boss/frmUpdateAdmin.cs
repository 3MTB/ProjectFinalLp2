using ProjectFinalLp2.Models;
using ProjectFinalLp2.Models.GestorData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalLp2.Formularios.Boss
{
	public partial class frmUpdateAdmin : Form
	{
		#region					Objetos Generales
		public Admin admin { get; set; }
		#endregion

		#region						CONSTRUCTOR
		public frmUpdateAdmin(Admin admin)
		{
			InitializeComponent();
			this.admin = admin;
			MyIniciador();
		}
		public void MyIniciador()
		{
			ActualizaValores();
		}
		#endregion

		#region						EVENTOS
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			focusTo focus = gestorAdministrador.UpdateAdmin(admin.Id, new Admin(tbName.Text, tbPassword.Text));
			if (focus.Name)
			{
				tbName.Focus();
			}
			else if (!focus.Name)
			{
				lblName.Text = tbName.Text.ToUpper();
				lblName.ForeColor = Color.Green;
				tbName.Text = string.Empty;
			}
			else if (focus.Password)
			{
				tbPassword.Focus();
			}
			else if (!focus.Password)
			{
				//lblPassword.Text = lblPassword.Text;
				lblPassword.ForeColor = Color.Green;
				tbPassword.Text = string.Empty;
			}
			else
			{
				ActualizaValores();
				MessageBox.Show("CAMBIOS CORRECTOS", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void ActualizaValores()
		{
			lblName.Text = admin.Nombre;
			lblPassword.Text = new String('*', admin.Password.Length);

		}
		#endregion

	}
}
