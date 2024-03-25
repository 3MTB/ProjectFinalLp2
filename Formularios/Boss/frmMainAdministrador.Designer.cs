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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAdministrador));
			panelMain = new Panel();
			panelLateral = new Panel();
			pictureBox1 = new PictureBox();
			lblName = new Label();
			label1 = new Label();
			btnEliminarPerfil = new Button();
			btnHome = new Button();
			btnActualizar = new Button();
			btnRentados = new Button();
			panel1 = new Panel();
			btnAboutWe = new Button();
			btnAddVehicle = new Button();
			lblPlace = new Label();
			btnCerrarSeccion = new Button();
			panelLateral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelMain
			// 
			panelMain.AutoScroll = true;
			panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panelMain.BackColor = Color.FromArgb(9, 38, 53);
			panelMain.Dock = DockStyle.Fill;
			panelMain.Location = new Point(250, 0);
			panelMain.Margin = new Padding(0);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(971, 833);
			panelMain.TabIndex = 3;
			// 
			// panelLateral
			// 
			panelLateral.BackColor = Color.FromArgb(49, 54, 63);
			panelLateral.BackgroundImage = Properties.Resources.Frost;
			panelLateral.Controls.Add(btnCerrarSeccion);
			panelLateral.Controls.Add(pictureBox1);
			panelLateral.Controls.Add(lblName);
			panelLateral.Controls.Add(label1);
			panelLateral.Controls.Add(btnEliminarPerfil);
			panelLateral.Controls.Add(btnHome);
			panelLateral.Controls.Add(btnActualizar);
			panelLateral.Controls.Add(btnRentados);
			panelLateral.Dock = DockStyle.Left;
			panelLateral.Location = new Point(0, 0);
			panelLateral.Name = "panelLateral";
			panelLateral.Size = new Size(250, 833);
			panelLateral.TabIndex = 1;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Dock = DockStyle.Bottom;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 646);
			pictureBox1.Margin = new Padding(0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(250, 187);
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Agency FB", 19F);
			lblName.ForeColor = Color.White;
			lblName.Location = new Point(61, 42);
			lblName.Margin = new Padding(0);
			lblName.Name = "lblName";
			lblName.Size = new Size(73, 40);
			lblName.TabIndex = 4;
			lblName.Text = "Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(56, 111);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(143, 36);
			label1.TabIndex = 1;
			label1.Text = "Administrador";
			// 
			// btnEliminarPerfil
			// 
			btnEliminarPerfil.BackColor = Color.FromArgb(10, 56, 67);
			btnEliminarPerfil.FlatAppearance.BorderColor = Color.Black;
			btnEliminarPerfil.FlatAppearance.BorderSize = 2;
			btnEliminarPerfil.FlatAppearance.MouseDownBackColor = Color.Red;
			btnEliminarPerfil.FlatAppearance.MouseOverBackColor = Color.Yellow;
			btnEliminarPerfil.FlatStyle = FlatStyle.System;
			btnEliminarPerfil.Font = new Font("Agency FB", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
			btnEliminarPerfil.ForeColor = Color.White;
			btnEliminarPerfil.Location = new Point(61, 503);
			btnEliminarPerfil.Margin = new Padding(0);
			btnEliminarPerfil.Name = "btnEliminarPerfil";
			btnEliminarPerfil.Size = new Size(138, 89);
			btnEliminarPerfil.TabIndex = 3;
			btnEliminarPerfil.Tag = "Eliminar Perfil";
			btnEliminarPerfil.Text = "Eliminar Perfil";
			btnEliminarPerfil.UseVisualStyleBackColor = false;
			btnEliminarPerfil.Click += btnEliminarPerfil_Click_1;
			// 
			// btnHome
			// 
			btnHome.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
			btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
			btnHome.FlatStyle = FlatStyle.System;
			btnHome.Font = new Font("Agency FB", 12F);
			btnHome.Location = new Point(61, 405);
			btnHome.Margin = new Padding(0);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(138, 89);
			btnHome.TabIndex = 0;
			btnHome.Tag = "Inicio";
			btnHome.Text = "Inicio";
			btnHome.UseVisualStyleBackColor = true;
			btnHome.Click += btnHome_Click;
			// 
			// btnActualizar
			// 
			btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
			btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
			btnActualizar.FlatStyle = FlatStyle.System;
			btnActualizar.Location = new Point(61, 286);
			btnActualizar.Margin = new Padding(0);
			btnActualizar.Name = "btnActualizar";
			btnActualizar.Size = new Size(138, 89);
			btnActualizar.TabIndex = 2;
			btnActualizar.Tag = "Actualizar Perfil";
			btnActualizar.Text = "Actualizar perfil";
			btnActualizar.UseVisualStyleBackColor = true;
			btnActualizar.Click += btnActualizar_Click;
			// 
			// btnRentados
			// 
			btnRentados.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
			btnRentados.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
			btnRentados.FlatStyle = FlatStyle.System;
			btnRentados.Location = new Point(61, 167);
			btnRentados.Margin = new Padding(0);
			btnRentados.Name = "btnRentados";
			btnRentados.Size = new Size(138, 89);
			btnRentados.TabIndex = 1;
			btnRentados.Tag = "Rentados";
			btnRentados.Text = "Rentados";
			btnRentados.UseVisualStyleBackColor = true;
			btnRentados.Click += btnRentados_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(34, 40, 49);
			panel1.Controls.Add(btnAboutWe);
			panel1.Controls.Add(btnAddVehicle);
			panel1.Controls.Add(lblPlace);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(250, 0);
			panel1.Margin = new Padding(0);
			panel1.Name = "panel1";
			panel1.Size = new Size(971, 73);
			panel1.TabIndex = 5;
			// 
			// btnAboutWe
			// 
			btnAboutWe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAboutWe.FlatStyle = FlatStyle.Flat;
			btnAboutWe.ForeColor = Color.WhiteSmoke;
			btnAboutWe.Location = new Point(726, 23);
			btnAboutWe.Margin = new Padding(0);
			btnAboutWe.Name = "btnAboutWe";
			btnAboutWe.Size = new Size(84, 37);
			btnAboutWe.TabIndex = 2;
			btnAboutWe.Text = "About We";
			btnAboutWe.UseVisualStyleBackColor = true;
			btnAboutWe.Click += btnAboutWe_Click;
			// 
			// btnAddVehicle
			// 
			btnAddVehicle.Anchor = AnchorStyles.None;
			btnAddVehicle.FlatStyle = FlatStyle.System;
			btnAddVehicle.Location = new Point(32, 3);
			btnAddVehicle.Name = "btnAddVehicle";
			btnAddVehicle.Size = new Size(133, 67);
			btnAddVehicle.TabIndex = 1;
			btnAddVehicle.Text = "Reg Vehiculo";
			btnAddVehicle.UseVisualStyleBackColor = true;
			btnAddVehicle.Click += btnAddVehicle_Click_1;
			// 
			// lblPlace
			// 
			lblPlace.AutoSize = true;
			lblPlace.Font = new Font("Agency FB", 18F);
			lblPlace.ForeColor = Color.White;
			lblPlace.Location = new Point(454, 24);
			lblPlace.Margin = new Padding(0);
			lblPlace.Name = "lblPlace";
			lblPlace.Size = new Size(62, 36);
			lblPlace.TabIndex = 0;
			lblPlace.Text = "Inicio";
			// 
			// btnCerrarSeccion
			// 
			btnCerrarSeccion.FlatStyle = FlatStyle.Flat;
			btnCerrarSeccion.ForeColor = Color.WhiteSmoke;
			btnCerrarSeccion.Location = new Point(0, 613);
			btnCerrarSeccion.Margin = new Padding(0);
			btnCerrarSeccion.Name = "btnCerrarSeccion";
			btnCerrarSeccion.Size = new Size(250, 33);
			btnCerrarSeccion.TabIndex = 6;
			btnCerrarSeccion.Text = "Cerrar Seccion";
			btnCerrarSeccion.UseVisualStyleBackColor = true;
			btnCerrarSeccion.Click += btnCerrarSeccion_Click;
			// 
			// frmMainAdministrador
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(10, 25, 50);
			ClientSize = new Size(1221, 833);
			Controls.Add(panel1);
			Controls.Add(panelMain);
			Controls.Add(panelLateral);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Margin = new Padding(3, 4, 3, 4);
			MaximumSize = new Size(1239, 880);
			MinimumSize = new Size(1239, 880);
			Name = "frmMainAdministrador";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Main Administrador";
			TransparencyKey = Color.FromArgb(255, 128, 0);
			Load += frmMainAdministrador_Load;
			panelLateral.ResumeLayout(false);
			panelLateral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel panelMain;
		private Panel panelLateral;
		private Button btnEliminarPerfil;
		private Button btnHome;
		private Button btnActualizar;
		private Button btnRentados;
		private Label label1;
		private Label lblName;
		private PictureBox pictureBox1;
		private Panel panel1;
		private Button btnAddVehicle;
		private Label lblPlace;
		private Button btnAboutWe;
		private Button btnCerrarSeccion;
	}
}