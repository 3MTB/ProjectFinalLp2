using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//My NameSpace
using ProjectFinalLp2.Formularios.Aplication;
using ProjectFinalLp2.Models;
using ProjectFinalLp2.Models.otherType;
using static ProjectFinalLp2.Models.otherType.ColorDefaults;
//My NameSpace

namespace ProjectFinalLp2.Formularios.Boss
{
	public partial class frmMainAdministrador : Form
	{
		public Admin adminCurrent { get; set; }
		public Button currentButon { get; set; }
		public Form currentForm { get; set; }
		//public Color cForegroundActive = Color.FromArgb(255, 255, 255);
		//public Color cForegroundDisable = Color.FromArgb(0, 0, 0);
		//public Color cBackgroundDisable = Color.FromArgb(255, 255, 255);
		//public Color cBackgroundActive = Color.FromArgb(0, 0, 0);


		public frmMainAdministrador(Admin admin)
		{
			InitializeComponent();
			adminCurrent = admin;
			MyIniciador();
		}

		private void MyIniciador()
		{
			OpenChildFrom(new frmDefaultAdmin(), btnHome);
		}
		private void btnRentados_Click_1(object sender, EventArgs e)
		{
			if (sender.GetType() == typeof(Button))
			{
				OpenChildFrom(new frmRentados(), (Button)sender);
			}
		}


		private void btnHome_Click_1(object sender, EventArgs e)
		{
			OpenChildFrom(new frmDefaultAdmin(), btnHome);

		}

		private void btnActualizar_Click_1(object sender, EventArgs e)
		{
			if (sender.GetType() == typeof(Button))
			{
				OpenChildFrom(new frmUpdateAdmin(adminCurrent), (Button)sender);
			}
		}
		// Funciones
		private void DisableButtons()
		{
			foreach (Control x in panelLateral.Controls)
			{
				if (x.GetType() == typeof(Button))
				{
					x.BackColor = cBackgroundDisable;
					x.ForeColor = cForegroundDisable;
				}
			}
		}

		public void ActiveButton(Button btnactivar)
		{
			if (currentButon != null)
			{
				if (currentButon != btnactivar)
				{
					currentButon = btnactivar;
					currentButon.BackColor = cBackgroundActive;
					currentButon.ForeColor = cForegroundActive;
				}
			}
		}


		private void OpenChildFrom(Form abrir, Button btnsender)
		{
			if (currentForm != null)
			{
				currentForm.Close();
			}
			DisableButtons();

			ActiveButton(btnsender);
			// review that
			currentForm = abrir;
			currentForm.TopLevel = false;
			currentForm.FormBorderStyle = FormBorderStyle.None;
			currentForm.BringToFront();
			panelMain.Controls.Add(currentForm);
			currentForm.Show();
		}


		private void btnSalir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Seguro que quieres salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnEliminarPerfil_Click(object sender, EventArgs e)
		{
			string MessageEliminacion = $"{adminCurrent.Nombre}, ¿Estas seguro que deseas eliminar tu perfil?\n Esto implica que perderás tu acceso al programa.";
			if (MessageBox.Show(MessageEliminacion, "Eliminación de Perfil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{

				var context = new RentcargokudemonContext();
				context.Admins.Remove(adminCurrent);
				context.SaveChanges();
				this.Hide();

				var open = new frmLoading();
				open.Show();

			}


		}

	}
}
