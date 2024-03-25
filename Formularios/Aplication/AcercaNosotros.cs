using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalLp2.Formularios.Aplication
{
	public partial class AcercaNosotros : Form
	{
		public AcercaNosotros()
		{
			InitializeComponent();
		}

		private void pictRepositorio_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(@"https://github.com/3MTB/ProjectFinalLp2");
		}

		private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Clipboard.SetText(@"https://github.com/3MTB/ProjectFinalLp2");

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
