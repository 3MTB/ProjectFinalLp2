using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFinalLp2.Models;

// for me
using ProjectFinalLp2.Models.GestorData;
using ProjectFinalLp2.Models.otherType;
using static ProjectFinalLp2.Models.otherType.funcionesComunes;


namespace ProjectFinalLp2
{
	public partial class frmPrueba : Form
	{
		public frmPrueba()
		{
			InitializeComponent();
			// Mi inicializador
			ActualizaValores();

		}

		//TODO:  Try SUCESS
		private void btnEnviar_Click(object sender, EventArgs e)
		{
			if (gestorAdministrador.InsertaAdmin(new Models.Admin(tbName.Text, tbPassword.Text)))
			{
				tbName.Text = string.Empty;
				tbPassword.Text = string.Empty;
				ActualizaValores();

			}

		}


		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (cbRegistroName.SelectedItem != null)
			{
				if (cbRegistroName.SelectedItem.GetType() == new Admin().GetType())
				{
					var idEliminar = ((Admin)cbRegistroName.SelectedItem).Id;
					gestorAdministrador.DeleteAdmin(idEliminar);
					ActualizaValores();
				}
				else
				{
					MakeMessage("No se proporciono un valor valido a eliminar", "Error Interno", TipoAviso.error);
				}
			}
			else
			{
				MakeMessage("Debes seleccionar un objeto a eliminar", "Error", TipoAviso.error);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (cbRegistroName.SelectedItem != null)
			{
				if (cbRegistroName.SelectedItem.GetType() == new Admin().GetType())
				{
					var idUpdate = ((Admin)cbRegistroName.SelectedItem).Id;
					focusTo focus = gestorAdministrador.UpdateAdmin(idUpdate, new Admin(tbName.Text, tbPassword.Text));
					ActualizaValores();

					if (focus.Name)
					{
						tbName.Focus();
					}
					else if (!focus.Name)
					{
						tbName.Text = string.Empty;
					}
					else if (focus.Password)
					{
						tbPassword.Focus();
					}
					else if (!focus.Password)
					{
						tbPassword.Text = string.Empty;
					}
				}
				else
				{
					MakeMessage("No se proporciono un valor valido a actualizar", "Error Interno", TipoAviso.error);
				}
			}
			else
			{
				MakeMessage("Debes seleccionar un objeto a actualizar", "Error", TipoAviso.error);
			}
		}

		public void ActualizaValores()
		{
			dgData.DataSource = gestorAdministrador.ObtenerAdmin();
			cbRegistroName.DataSource = gestorAdministrador.ObtenerAdmin();
			cbRegistroName.DisplayMember = "Nombre";
		}

	}
}
