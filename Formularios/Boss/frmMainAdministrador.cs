﻿using System;
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
		#region							Objetos Generales
		public Admin adminCurrent { get; set; }
		public Button currentButon { get; set; }
		public Form currentForm { get; set; }
		public GestorTransformacionPanel gestorPanel { get; set; }
		private void MyIniciador()
		{
			lblName.Text = $" >{adminCurrent.Nombre}<";
			gestorPanel = new GestorTransformacionPanel(new frmMainAdministrador(adminCurrent), panelMain, panelLateral, lblPlace);
			gestorPanel.OpenChildFrom(new frmDefaultHour(), btnHome);
		}
		#endregion

		#region							CONSTRUCTOR  - Iniciador
		public frmMainAdministrador(Admin admin)
		{
			InitializeComponent();
			adminCurrent = admin;
		}
		private void frmMainAdministrador_Load(object sender, EventArgs e)
		{
			MyIniciador();

		}
		#endregion

		#region													Eventos




		private void btnRentados_Click(object sender, EventArgs e)
		{
			if (sender.GetType() == typeof(Button))
			{
				gestorPanel.OpenChildFrom(new frmRentados(), (Button)sender);

			}
		}

		private void btnEliminarPerfil_Click_1(object sender, EventArgs e)
		{
			string MessageEliminacion = $"{adminCurrent.Nombre}, ¿Estas seguro que deseas eliminar tu perfil?\n Esto implica que perderás tu acceso al programa.";
			if (MessageBox.Show(MessageEliminacion, "Eliminación de Perfil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{

				var context = new RentcargokudemonContext();
				context.Admins.Remove(adminCurrent);
				context.SaveChanges();
				this.Hide();

				new frmLoading().Show();

			}
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			if (sender.GetType() == typeof(Button))
			{
				gestorPanel.OpenChildFrom(new frmUpdateAdmin(adminCurrent), (Button)sender);
			}
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			if (sender.GetType() == typeof(Button))
			{
				gestorPanel.OpenChildFrom(new frmDefaultHour(), (Button)sender);
			}
		}


		#endregion

	}
}
