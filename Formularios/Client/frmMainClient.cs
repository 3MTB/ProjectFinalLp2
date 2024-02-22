﻿using ProjectFinalLp2.Models;
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

namespace ProjectFinalLp2.Formularios.Client
{
	public partial class frmMainClient : Form
	{
		public ProjectFinalLp2.Models.Client clientCurrent { get; set; }
		public frmMainClient(ProjectFinalLp2.Models.Client clientCurrent)
		{
			InitializeComponent();
			this.clientCurrent = clientCurrent;
			MyInitializer();
		}
		private void MyInitializer()
		{
			// Pasar de byte[] a image
			//pictureClient.Image =
			try
			{
				lblNameClient.Text = $"{clientCurrent.Nombre} {clientCurrent.Apellido}";
				pictureClient.Image = stringToImage(clientCurrent.Imagen);
				//						Review that
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al momento de cargar los datos del usuarios.\n\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


	}
}
