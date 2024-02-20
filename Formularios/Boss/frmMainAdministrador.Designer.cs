namespace ProjectFinalLp2.Formularios.Boss
{
	partial class frmMainAdministrador
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
			guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			btnSalir = new Button();
			panelLateral = new Panel();
			btnHome = new Button();
			btnActualizar = new Button();
			btnRentados = new Button();
			panelMain = new Panel();
			guna2GradientPanel1.SuspendLayout();
			panelLateral.SuspendLayout();
			SuspendLayout();
			// 
			// guna2GradientPanel1
			// 
			guna2GradientPanel1.BackColor = Color.FromArgb(20, 50, 90);
			guna2GradientPanel1.Controls.Add(btnSalir);
			guna2GradientPanel1.CustomizableEdges = customizableEdges1;
			guna2GradientPanel1.Dock = DockStyle.Top;
			guna2GradientPanel1.Location = new Point(0, 0);
			guna2GradientPanel1.Name = "guna2GradientPanel1";
			guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
			guna2GradientPanel1.Size = new Size(1114, 56);
			guna2GradientPanel1.TabIndex = 1;
			// 
			// btnSalir
			// 
			btnSalir.BackColor = Color.Black;
			btnSalir.FlatStyle = FlatStyle.Flat;
			btnSalir.ForeColor = Color.White;
			btnSalir.Location = new Point(998, 3);
			btnSalir.Margin = new Padding(0);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(76, 50);
			btnSalir.TabIndex = 10;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = false;
			btnSalir.Click += btnSalir_Click;
			// 
			// panelLateral
			// 
			panelLateral.BackColor = Color.Red;
			panelLateral.Controls.Add(btnHome);
			panelLateral.Controls.Add(btnActualizar);
			panelLateral.Controls.Add(btnRentados);
			panelLateral.Dock = DockStyle.Left;
			panelLateral.Location = new Point(0, 56);
			panelLateral.Name = "panelLateral";
			panelLateral.Size = new Size(182, 753);
			panelLateral.TabIndex = 2;
			// 
			// btnHome
			// 
			btnHome.Location = new Point(3, 262);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(134, 84);
			btnHome.TabIndex = 9;
			btnHome.Text = "Home";
			btnHome.UseVisualStyleBackColor = true;
			btnHome.Click += btnHome_Click_1;
			// 
			// btnActualizar
			// 
			btnActualizar.Location = new Point(-36, 41);
			btnActualizar.Name = "btnActualizar";
			btnActualizar.Size = new Size(173, 78);
			btnActualizar.TabIndex = 7;
			btnActualizar.Text = "Actualizar perfil";
			btnActualizar.UseVisualStyleBackColor = true;
			btnActualizar.Click += btnActualizar_Click_1;
			// 
			// btnRentados
			// 
			btnRentados.Location = new Point(3, 167);
			btnRentados.Name = "btnRentados";
			btnRentados.Size = new Size(160, 66);
			btnRentados.TabIndex = 8;
			btnRentados.Text = "Rentados";
			btnRentados.UseVisualStyleBackColor = true;
			btnRentados.Click += btnRentados_Click_1;
			// 
			// panelMain
			// 
			panelMain.BackColor = Color.FromArgb(10, 90, 80);
			panelMain.Dock = DockStyle.Fill;
			panelMain.Location = new Point(182, 56);
			panelMain.Margin = new Padding(0);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(932, 753);
			panelMain.TabIndex = 3;
			// 
			// frmMainAdministrador
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(10, 25, 50);
			ClientSize = new Size(1114, 809);
			Controls.Add(panelMain);
			Controls.Add(panelLateral);
			Controls.Add(guna2GradientPanel1);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmMainAdministrador";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Main Administrador";
			guna2GradientPanel1.ResumeLayout(false);
			panelLateral.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
		private Panel panelLateral;
		private Button btnHome;
		private Button btnActualizar;
		private Button btnRentados;
		private Panel panelMain;
		private Button btnSalir;
	}
}