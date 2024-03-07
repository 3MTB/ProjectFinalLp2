namespace ProjectFinalLp2.Formularios.Trabajador
{
	partial class frmTrabajadorMain
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
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			panelMain = new Panel();
			panelLateral = new Panel();
			btnCatalogo = new Button();
			btnHome = new Button();
			btnRentados = new Button();
			guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			btnSalir = new Button();
			lblNamefrmActual = new Label();
			panelLateral.SuspendLayout();
			guna2GradientPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelMain
			// 
			panelMain.BackColor = Color.FromArgb(10, 90, 80);
			panelMain.Dock = DockStyle.Fill;
			panelMain.Location = new Point(182, 81);
			panelMain.Margin = new Padding(0);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(993, 648);
			panelMain.TabIndex = 6;
			// 
			// panelLateral
			// 
			panelLateral.BackColor = Color.DarkGray;
			panelLateral.Controls.Add(btnCatalogo);
			panelLateral.Controls.Add(btnHome);
			panelLateral.Controls.Add(btnRentados);
			panelLateral.Dock = DockStyle.Left;
			panelLateral.Location = new Point(0, 81);
			panelLateral.Name = "panelLateral";
			panelLateral.Size = new Size(182, 648);
			panelLateral.TabIndex = 5;
			// 
			// btnCatalogo
			// 
			btnCatalogo.Location = new Point(12, 90);
			btnCatalogo.Name = "btnCatalogo";
			btnCatalogo.Size = new Size(160, 66);
			btnCatalogo.TabIndex = 10;
			btnCatalogo.Text = "Catalogo";
			btnCatalogo.UseVisualStyleBackColor = true;
			btnCatalogo.Click += btnCatalogo_Click;
			// 
			// btnHome
			// 
			btnHome.Location = new Point(29, 355);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(134, 84);
			btnHome.TabIndex = 9;
			btnHome.Text = "Home";
			btnHome.UseVisualStyleBackColor = true;
			btnHome.Click += btnHome_Click;
			// 
			// btnRentados
			// 
			btnRentados.Location = new Point(12, 244);
			btnRentados.Name = "btnRentados";
			btnRentados.Size = new Size(160, 66);
			btnRentados.TabIndex = 8;
			btnRentados.Text = "Rentados";
			btnRentados.UseVisualStyleBackColor = true;
			btnRentados.Click += btnRentados_Click;
			// 
			// guna2GradientPanel1
			// 
			guna2GradientPanel1.BackColor = Color.FromArgb(20, 50, 90);
			guna2GradientPanel1.Controls.Add(lblNamefrmActual);
			guna2GradientPanel1.Controls.Add(btnSalir);
			guna2GradientPanel1.CustomizableEdges = customizableEdges1;
			guna2GradientPanel1.Dock = DockStyle.Top;
			guna2GradientPanel1.Location = new Point(0, 0);
			guna2GradientPanel1.Name = "guna2GradientPanel1";
			guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
			guna2GradientPanel1.Size = new Size(1175, 81);
			guna2GradientPanel1.TabIndex = 4;
			// 
			// btnSalir
			// 
			btnSalir.Anchor = AnchorStyles.None;
			btnSalir.BackColor = Color.Black;
			btnSalir.FlatStyle = FlatStyle.Flat;
			btnSalir.ForeColor = Color.White;
			btnSalir.Location = new Point(910, 21);
			btnSalir.Margin = new Padding(0);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(76, 50);
			btnSalir.TabIndex = 11;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = false;
			btnSalir.Click += btnSalir_Click;
			// 
			// lblNamefrmActual
			// 
			lblNamefrmActual.AutoSize = true;
			lblNamefrmActual.ForeColor = SystemColors.ControlLightLight;
			lblNamefrmActual.Location = new Point(225, 36);
			lblNamefrmActual.Name = "lblNamefrmActual";
			lblNamefrmActual.Size = new Size(52, 20);
			lblNamefrmActual.TabIndex = 12;
			lblNamefrmActual.Text = "HOME";
			// 
			// frmTrabajadorMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1175, 729);
			Controls.Add(panelMain);
			Controls.Add(panelLateral);
			Controls.Add(guna2GradientPanel1);
			Name = "frmTrabajadorMain";
			Text = "Trabajador Main";
			Load += frmTrabajadorMain_Load;
			panelLateral.ResumeLayout(false);
			guna2GradientPanel1.ResumeLayout(false);
			guna2GradientPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelMain;
		private Panel panelLateral;
		private Button btnHome;
		private Button btnRentados;
		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
		private Button btnSalir;
		private Button btnCatalogo;
		private Label lblNamefrmActual;
	}
}