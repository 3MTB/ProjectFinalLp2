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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainClient));
			panelLateral = new Panel();
			btnAboutWe = new Button();
			btnPerfil = new Button();
			pictureBox1 = new PictureBox();
			pictCliente = new PictureBox();
			btnHome = new Button();
			btnRentar = new Button();
			btnMyVehicule = new Button();
			lblNameClient = new Label();
			btnLogOut = new Button();
			panel1 = new Panel();
			lblPlace = new Label();
			panelMain = new Panel();
			panelLateral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictCliente).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelLateral
			// 
			panelLateral.BackColor = Color.FromArgb(10, 5, 45);
			panelLateral.Controls.Add(btnAboutWe);
			panelLateral.Controls.Add(btnPerfil);
			panelLateral.Controls.Add(pictureBox1);
			panelLateral.Controls.Add(pictCliente);
			panelLateral.Controls.Add(btnHome);
			panelLateral.Controls.Add(btnRentar);
			panelLateral.Controls.Add(btnMyVehicule);
			panelLateral.Controls.Add(lblNameClient);
			panelLateral.Dock = DockStyle.Left;
			panelLateral.Location = new Point(0, 0);
			panelLateral.Name = "panelLateral";
			panelLateral.Size = new Size(221, 769);
			panelLateral.TabIndex = 0;
			// 
			// btnAboutWe
			// 
			btnAboutWe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAboutWe.FlatStyle = FlatStyle.Flat;
			btnAboutWe.ForeColor = Color.WhiteSmoke;
			btnAboutWe.Location = new Point(0, 571);
			btnAboutWe.Margin = new Padding(0);
			btnAboutWe.Name = "btnAboutWe";
			btnAboutWe.Size = new Size(84, 37);
			btnAboutWe.TabIndex = 3;
			btnAboutWe.Text = "About We";
			btnAboutWe.UseVisualStyleBackColor = true;
			btnAboutWe.Click += btnAboutWe_Click;
			// 
			// btnPerfil
			// 
			btnPerfil.Anchor = AnchorStyles.None;
			btnPerfil.FlatStyle = FlatStyle.Flat;
			btnPerfil.ForeColor = Color.White;
			btnPerfil.Location = new Point(50, 216);
			btnPerfil.Margin = new Padding(0);
			btnPerfil.Name = "btnPerfil";
			btnPerfil.Size = new Size(127, 43);
			btnPerfil.TabIndex = 7;
			btnPerfil.Tag = " ";
			btnPerfil.Text = "Perfi;";
			btnPerfil.UseVisualStyleBackColor = true;
			btnPerfil.Click += btnPerfil_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Dock = DockStyle.Bottom;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 608);
			pictureBox1.Margin = new Padding(0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(221, 161);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// pictCliente
			// 
			pictCliente.Anchor = AnchorStyles.None;
			pictCliente.Image = Properties.Resources.clientDefaultWhite;
			pictCliente.InitialImage = Properties.Resources.userDefault;
			pictCliente.Location = new Point(60, 50);
			pictCliente.Margin = new Padding(0);
			pictCliente.Name = "pictCliente";
			pictCliente.Size = new Size(117, 95);
			pictCliente.SizeMode = PictureBoxSizeMode.Zoom;
			pictCliente.TabIndex = 4;
			pictCliente.TabStop = false;
			// 
			// btnHome
			// 
			btnHome.Anchor = AnchorStyles.None;
			btnHome.FlatStyle = FlatStyle.Flat;
			btnHome.ForeColor = Color.White;
			btnHome.Location = new Point(47, 440);
			btnHome.Margin = new Padding(0);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(127, 43);
			btnHome.TabIndex = 3;
			btnHome.Tag = " ";
			btnHome.Text = " Home";
			btnHome.UseVisualStyleBackColor = true;
			btnHome.Click += btnHome_Click;
			// 
			// btnRentar
			// 
			btnRentar.Anchor = AnchorStyles.None;
			btnRentar.Location = new Point(47, 356);
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
			btnMyVehicule.Location = new Point(47, 272);
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
			lblNameClient.Location = new Point(36, 145);
			lblNameClient.Margin = new Padding(0);
			lblNameClient.Name = "lblNameClient";
			lblNameClient.Size = new Size(122, 28);
			lblNameClient.TabIndex = 1;
			lblNameClient.Text = "Name Of CLient";
			// 
			// btnLogOut
			// 
			btnLogOut.Anchor = AnchorStyles.None;
			btnLogOut.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
			btnLogOut.FlatStyle = FlatStyle.Flat;
			btnLogOut.Font = new Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLogOut.ForeColor = Color.White;
			btnLogOut.Location = new Point(566, 23);
			btnLogOut.Margin = new Padding(0);
			btnLogOut.Name = "btnLogOut";
			btnLogOut.Size = new Size(127, 43);
			btnLogOut.TabIndex = 3;
			btnLogOut.Tag = " ";
			btnLogOut.Text = "Salir";
			btnLogOut.UseVisualStyleBackColor = true;
			btnLogOut.Click += btnSalir_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(10, 5, 60);
			panel1.Controls.Add(lblPlace);
			panel1.Controls.Add(btnLogOut);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(221, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(716, 79);
			panel1.TabIndex = 1;
			// 
			// lblPlace
			// 
			lblPlace.Anchor = AnchorStyles.None;
			lblPlace.AutoSize = true;
			lblPlace.Font = new Font("Agency FB", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPlace.ForeColor = Color.White;
			lblPlace.Location = new Point(306, 13);
			lblPlace.Margin = new Padding(0);
			lblPlace.Name = "lblPlace";
			lblPlace.Size = new Size(104, 53);
			lblPlace.TabIndex = 0;
			lblPlace.Text = "Home";
			lblPlace.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panelMain
			// 
			panelMain.BackColor = Color.FromArgb(9, 38, 53);
			panelMain.Dock = DockStyle.Fill;
			panelMain.Location = new Point(221, 79);
			panelMain.Margin = new Padding(0);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(716, 690);
			panelMain.TabIndex = 2;
			// 
			// frmMainClient
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(10, 45, 50);
			ClientSize = new Size(937, 769);
			Controls.Add(panelMain);
			Controls.Add(panel1);
			Controls.Add(panelLateral);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(3, 4, 3, 4);
			MinimumSize = new Size(955, 816);
			Name = "frmMainClient";
			Tag = "Main Client";
			Text = "Client";
			Load += frmMainClient_Load;
			panelLateral.ResumeLayout(false);
			panelLateral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictCliente).EndInit();
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
		private Button btnLogOut;
		private Panel panel1;
		private Label lblPlace;
		private Panel panelMain;
		private Button btnHome;
		private PictureBox pictCliente;
		private PictureBox pictureBox1;
		private Button btnPerfil;
		private Button btnAboutWe;
		//private PictureBox pictureClient;
	}
}