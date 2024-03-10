namespace ProjectFinalLp2.Formularios.Aplication
{
	partial class frmCatalogo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panelMain = new Panel();
			lblCantidad = new Label();
			label1 = new Label();
			panelMain.SuspendLayout();
			SuspendLayout();
			// 
			// panelMain
			// 
			panelMain.AutoScroll = true;
			panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panelMain.BackColor = Color.Transparent;
			panelMain.Controls.Add(lblCantidad);
			panelMain.Controls.Add(label1);
			panelMain.Dock = DockStyle.Fill;
			panelMain.Location = new Point(0, 0);
			panelMain.Margin = new Padding(0);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(1473, 723);
			panelMain.TabIndex = 2;
			// 
			// lblCantidad
			// 
			lblCantidad.AutoSize = true;
			lblCantidad.BackColor = Color.Transparent;
			lblCantidad.Location = new Point(275, 58);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(17, 20);
			lblCantidad.TabIndex = 6;
			lblCantidad.Text = "0";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Location = new Point(74, 58);
			label1.Name = "label1";
			label1.Size = new Size(185, 20);
			label1.TabIndex = 5;
			label1.Text = "VEHICULOS REGISTRADOS";
			// 
			// frmCatalogo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(1473, 723);
			Controls.Add(panelMain);
			ForeColor = SystemColors.ActiveBorder;
			Name = "frmCatalogo";
			Text = "frmCatalogo";
			Load += frmCatalogo_Load;
			panelMain.ResumeLayout(false);
			panelMain.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel panelMain;
		private Label lblCantidad;
		private Label label1;
	}
}