namespace ProjectFinalLp2.Formularios.Client
{
	partial class frmMainClient
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
			panelLateral = new Panel();
			btnPerfil = new Button();
			btnSalir = new Button();
			btnHome = new Button();
			btnRentar = new Button();
			btnMyVehicule = new Button();
			lblNameClient = new Label();
			pictureClient = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			panel1 = new Panel();
			label1 = new Label();
			panelMain = new Panel();
			panelLateral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureClient).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelLateral
			// 
			panelLateral.BackColor = Color.FromArgb(10, 45, 90);
			panelLateral.Controls.Add(btnPerfil);
			panelLateral.Controls.Add(btnSalir);
			panelLateral.Controls.Add(btnHome);
			panelLateral.Controls.Add(btnRentar);
			panelLateral.Controls.Add(btnMyVehicule);
			panelLateral.Controls.Add(lblNameClient);
			panelLateral.Controls.Add(pictureClient);
			panelLateral.Dock = DockStyle.Left;
			panelLateral.Location = new Point(0, 0);
			panelLateral.Name = "panelLateral";
			panelLateral.Size = new Size(221, 774);
			panelLateral.TabIndex = 0;
			// 
			// btnPerfil
			// 
			btnPerfil.Anchor = AnchorStyles.None;
			btnPerfil.Location = new Point(46, 200);
			btnPerfil.Margin = new Padding(0);
			btnPerfil.Name = "btnPerfil";
			btnPerfil.Size = new Size(127, 43);
			btnPerfil.TabIndex = 3;
			btnPerfil.Tag = " ";
			btnPerfil.Text = "Perfil";
			btnPerfil.UseVisualStyleBackColor = true;
			// 
			// btnSalir
			// 
			btnSalir.Anchor = AnchorStyles.None;
			btnSalir.Location = new Point(46, 669);
			btnSalir.Margin = new Padding(0);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(127, 43);
			btnSalir.TabIndex = 3;
			btnSalir.Tag = " ";
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = true;
			btnSalir.Click += btnSalir_Click;
			// 
			// btnHome
			// 
			btnHome.Anchor = AnchorStyles.None;
			btnHome.FlatStyle = FlatStyle.Flat;
			btnHome.ForeColor = Color.White;
			btnHome.Location = new Point(46, 444);
			btnHome.Margin = new Padding(0);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(127, 43);
			btnHome.TabIndex = 3;
			btnHome.Tag = " ";
			btnHome.Text = "Home";
			btnHome.UseVisualStyleBackColor = true;
			btnHome.Click += btnHome_Click;
			// 
			// btnRentar
			// 
			btnRentar.Anchor = AnchorStyles.None;
			btnRentar.Location = new Point(46, 375);
			btnRentar.Margin = new Padding(0);
			btnRentar.Name = "btnRentar";
			btnRentar.Size = new Size(127, 43);
			btnRentar.TabIndex = 3;
			btnRentar.Tag = " ";
			btnRentar.Text = "Rentar";
			btnRentar.UseVisualStyleBackColor = true;
			btnRentar.Click += btnRentar_Click;
			// 
			// btnMyVehicule
			// 
			btnMyVehicule.Anchor = AnchorStyles.None;
			btnMyVehicule.Location = new Point(46, 275);
			btnMyVehicule.Margin = new Padding(0);
			btnMyVehicule.Name = "btnMyVehicule";
			btnMyVehicule.Size = new Size(127, 43);
			btnMyVehicule.TabIndex = 2;
			btnMyVehicule.Tag = " ";
			btnMyVehicule.Text = "Mis Vehiculos";
			btnMyVehicule.UseVisualStyleBackColor = true;
			btnMyVehicule.Click += btnMyVehicule_Click;
			// 
			// lblNameClient
			// 
			lblNameClient.Anchor = AnchorStyles.None;
			lblNameClient.AutoSize = true;
			lblNameClient.Font = new Font("Agency FB", 14F);
			lblNameClient.ForeColor = Color.White;
			lblNameClient.Location = new Point(46, 121);
			lblNameClient.Margin = new Padding(0);
			lblNameClient.Name = "lblNameClient";
			lblNameClient.Size = new Size(119, 28);
			lblNameClient.TabIndex = 1;
			lblNameClient.Text = "Name Of Client";
			// 
			// pictureClient
			// 
			pictureClient.Anchor = AnchorStyles.None;
			pictureClient.ErrorImage = Properties.Resources.admin;
			pictureClient.FillColor = Color.Transparent;
			pictureClient.Image = Properties.Resources.clientDefaultWhite;
			pictureClient.ImageRotate = 0F;
			pictureClient.Location = new Point(67, 31);
			pictureClient.Margin = new Padding(0);
			pictureClient.Name = "pictureClient";
			pictureClient.ShadowDecoration.CustomizableEdges = customizableEdges1;
			pictureClient.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			pictureClient.Size = new Size(80, 80);
			pictureClient.SizeMode = PictureBoxSizeMode.Zoom;
			pictureClient.TabIndex = 0;
			pictureClient.TabStop = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(10, 45, 190);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(221, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(980, 79);
			panel1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Agency FB", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(313, 21);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(104, 53);
			label1.TabIndex = 0;
			label1.Text = "Home";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panelMain
			// 
			panelMain.BackColor = Color.FromArgb(20, 95, 50);
			panelMain.Dock = DockStyle.Fill;
			panelMain.Location = new Point(221, 79);
			panelMain.Margin = new Padding(0);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(980, 695);
			panelMain.TabIndex = 2;
			// 
			// frmMainClient
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(10, 45, 50);
			ClientSize = new Size(1201, 774);
			Controls.Add(panelMain);
			Controls.Add(panel1);
			Controls.Add(panelLateral);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmMainClient";
			Text = "Main Client";
			Load += frmMainClient_Load;
			panelLateral.ResumeLayout(false);
			panelLateral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureClient).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelLateral;
		private Label lblNameClient;
		private Guna.UI2.WinForms.Guna2CirclePictureBox pictureClient;
		private Button btnMyVehicule;
		private Button btnRentar;
		private Button btnPerfil;
		private Button btnSalir;
		private Panel panel1;
		private Label label1;
		private Panel panelMain;
		private Button btnHome;
	}
}