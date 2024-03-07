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
using ProjectFinalLp2.Models;

namespace ProjectFinalLp2.Formularios.Aplication
{
	public partial class frmCatalogo : Form
	{
		public Models.Client? client { get; set; } = null;
		public frmCatalogo(Models.Client? clienteOpc)
		{
			InitializeComponent();
			this.client = clienteOpc;
		}
	}
}
