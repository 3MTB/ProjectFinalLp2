using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// MY NAMESPACE
using static ProjectFinalLp2.Models.otherType.ColorDefaults;


namespace ProjectFinalLp2.Formularios.Aplication
{
	public class GestorTransformacionPanel
	{
		public GestorTransformacionPanel(Form currentForm, Panel panelMain, Panel panelLateral, Label lblNameFrmCurrent)
		{
			this.currentForm = currentForm;
			this.panelMain = panelMain;
			this.panelLateral = panelLateral;
			this.lblNameFrmCurrent = lblNameFrmCurrent;
		}

		private Button currentButon { get; set; }
		private Form currentForm { get; set; }
		private Panel panelMain { get; set; }
		private Panel panelLateral { get; set; }
		private Label lblNameFrmCurrent { get; set; }

		public void OpenChildFrom(Form abrir, Button btnsender)
		{
			try
			{
				if (currentForm != null)
				{
					currentForm.Close();
				}
				DisableButtons();

				ActiveButton(btnsender);
				currentForm = abrir;
				currentForm.TopLevel = false;
				currentForm.FormBorderStyle = FormBorderStyle.None;
				currentForm.StartPosition = FormStartPosition.WindowsDefaultBounds;
				currentForm.BringToFront();
				panelMain.Controls.Add(currentForm);
				currentForm.Show();
				lblNameFrmCurrent.Text = currentForm.Text;
			}
			catch (Exception e)
			{
				MessageBox.Show($"ALGO fallo al momento de cargar el formulario :(\n {e.Message}", "Error");
			}
		}
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
		private void ActiveButton(Button btnactivar)
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
	}
}
