namespace ProjectFinalLp2.Formularios.Client
{
	partial class frmRegisterClient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterClient));
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			tbName = new TextBox();
			label1 = new Label();
			label2 = new Label();
			tbApellido = new TextBox();
			label3 = new Label();
			numEdad = new NumericUpDown();
			label4 = new Label();
			tbCiudad = new TextBox();
			label5 = new Label();
			tbPais = new TextBox();
			label6 = new Label();
			tbEmail = new TextBox();
			label7 = new Label();
			tbDireccion = new TextBox();
			label8 = new Label();
			tbTelefono = new TextBox();
			label9 = new Label();
			label10 = new Label();
			getEmisionLicencia = new DateTimePicker();
			getVencimientoLicencia = new DateTimePicker();
			label11 = new Label();
			btnRegistrar = new Button();
			pictImagePerfil = new PictureBox();
			btnCargaImagen = new Button();
			gbPersonalInfo = new Guna.UI2.WinForms.Guna2GroupBox();
			btnPersonalInfo = new Button();
			gbLicencia = new Guna.UI2.WinForms.Guna2GroupBox();
			cbCategoria = new ComboBox();
			btnGuardarLicencia = new Button();
			btnSinLicencia = new Button();
			gbContacto = new Guna.UI2.WinForms.Guna2GroupBox();
			btnEnviarContacto = new Button();
			gbFinish = new Guna.UI2.WinForms.Guna2GroupBox();
			lblAvisoPassword = new Label();
			label15 = new Label();
			tbPassword = new TextBox();
			((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictImagePerfil).BeginInit();
			gbPersonalInfo.SuspendLayout();
			gbLicencia.SuspendLayout();
			gbContacto.SuspendLayout();
			gbFinish.SuspendLayout();
			SuspendLayout();
			// 
			// tbName
			// 
			resources.ApplyResources(tbName, "tbName");
			tbName.BorderStyle = BorderStyle.FixedSingle;
			tbName.Name = "tbName";
			tbName.TextChanged += CambiaPersonalInfoAfter;
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.Name = "label2";
			// 
			// tbApellido
			// 
			resources.ApplyResources(tbApellido, "tbApellido");
			tbApellido.BorderStyle = BorderStyle.FixedSingle;
			tbApellido.Name = "tbApellido";
			tbApellido.TextChanged += CambiaPersonalInfoAfter;
			// 
			// label3
			// 
			resources.ApplyResources(label3, "label3");
			label3.Name = "label3";
			// 
			// numEdad
			// 
			resources.ApplyResources(numEdad, "numEdad");
			numEdad.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
			numEdad.Name = "numEdad";
			numEdad.Value = new decimal(new int[] { 20, 0, 0, 0 });
			numEdad.ValueChanged += CambiaPersonalInfoAfter;
			// 
			// label4
			// 
			resources.ApplyResources(label4, "label4");
			label4.Name = "label4";
			// 
			// tbCiudad
			// 
			resources.ApplyResources(tbCiudad, "tbCiudad");
			tbCiudad.BorderStyle = BorderStyle.FixedSingle;
			tbCiudad.Name = "tbCiudad";
			tbCiudad.TextChanged += ChangeContactInfo;
			// 
			// label5
			// 
			resources.ApplyResources(label5, "label5");
			label5.Name = "label5";
			// 
			// tbPais
			// 
			resources.ApplyResources(tbPais, "tbPais");
			tbPais.BorderStyle = BorderStyle.FixedSingle;
			tbPais.Name = "tbPais";
			tbPais.TextChanged += ChangeContactInfo;
			// 
			// label6
			// 
			resources.ApplyResources(label6, "label6");
			label6.Name = "label6";
			// 
			// tbEmail
			// 
			resources.ApplyResources(tbEmail, "tbEmail");
			tbEmail.BorderStyle = BorderStyle.FixedSingle;
			tbEmail.Name = "tbEmail";
			tbEmail.TextChanged += ChangeContactInfo;
			// 
			// label7
			// 
			resources.ApplyResources(label7, "label7");
			label7.Name = "label7";
			// 
			// tbDireccion
			// 
			resources.ApplyResources(tbDireccion, "tbDireccion");
			tbDireccion.BorderStyle = BorderStyle.FixedSingle;
			tbDireccion.Name = "tbDireccion";
			tbDireccion.TextChanged += ChangeContactInfo;
			// 
			// label8
			// 
			resources.ApplyResources(label8, "label8");
			label8.Name = "label8";
			// 
			// tbTelefono
			// 
			resources.ApplyResources(tbTelefono, "tbTelefono");
			tbTelefono.BorderStyle = BorderStyle.FixedSingle;
			tbTelefono.Name = "tbTelefono";
			tbTelefono.TextChanged += ChangeContactInfo;
			// 
			// label9
			// 
			resources.ApplyResources(label9, "label9");
			label9.Name = "label9";
			// 
			// label10
			// 
			resources.ApplyResources(label10, "label10");
			label10.Name = "label10";
			// 
			// getEmisionLicencia
			// 
			resources.ApplyResources(getEmisionLicencia, "getEmisionLicencia");
			getEmisionLicencia.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			getEmisionLicencia.Name = "getEmisionLicencia";
			getEmisionLicencia.Value = new DateTime(2024, 2, 8, 0, 0, 0, 0);
			getEmisionLicencia.ValueChanged += CambiaLicenciaInfo;
			// 
			// getVencimientoLicencia
			// 
			resources.ApplyResources(getVencimientoLicencia, "getVencimientoLicencia");
			getVencimientoLicencia.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			getVencimientoLicencia.Name = "getVencimientoLicencia";
			getVencimientoLicencia.Value = new DateTime(2024, 2, 7, 0, 0, 0, 0);
			getVencimientoLicencia.ValueChanged += CambiaLicenciaInfo;
			// 
			// label11
			// 
			resources.ApplyResources(label11, "label11");
			label11.Name = "label11";
			// 
			// btnRegistrar
			// 
			resources.ApplyResources(btnRegistrar, "btnRegistrar");
			btnRegistrar.ForeColor = Color.White;
			btnRegistrar.Name = "btnRegistrar";
			btnRegistrar.UseVisualStyleBackColor = true;
			btnRegistrar.Click += btnRegistrar_Click;
			// 
			// pictImagePerfil
			// 
			pictImagePerfil.ErrorImage = Properties.Resources.userDefault;
			pictImagePerfil.Image = Properties.Resources.clientDefaultWhite;
			pictImagePerfil.InitialImage = Properties.Resources.clientDefaultWhite;
			resources.ApplyResources(pictImagePerfil, "pictImagePerfil");
			pictImagePerfil.Name = "pictImagePerfil";
			pictImagePerfil.TabStop = false;
			// 
			// btnCargaImagen
			// 
			resources.ApplyResources(btnCargaImagen, "btnCargaImagen");
			btnCargaImagen.ForeColor = Color.White;
			btnCargaImagen.Name = "btnCargaImagen";
			btnCargaImagen.UseVisualStyleBackColor = true;
			btnCargaImagen.Click += btnCargaImagen_Click;
			// 
			// gbPersonalInfo
			// 
			resources.ApplyResources(gbPersonalInfo, "gbPersonalInfo");
			gbPersonalInfo.BackColor = Color.FromArgb(10, 25, 24);
			gbPersonalInfo.Controls.Add(btnPersonalInfo);
			gbPersonalInfo.Controls.Add(label1);
			gbPersonalInfo.Controls.Add(tbName);
			gbPersonalInfo.Controls.Add(tbApellido);
			gbPersonalInfo.Controls.Add(label2);
			gbPersonalInfo.Controls.Add(label3);
			gbPersonalInfo.Controls.Add(numEdad);
			gbPersonalInfo.CustomBorderThickness = new Padding(0);
			customizableEdges1.BottomLeft = false;
			customizableEdges1.BottomRight = false;
			customizableEdges1.TopLeft = false;
			customizableEdges1.TopRight = false;
			gbPersonalInfo.CustomizableEdges = customizableEdges1;
			gbPersonalInfo.FillColor = Color.Transparent;
			gbPersonalInfo.ForeColor = Color.FromArgb(125, 137, 149);
			gbPersonalInfo.Name = "gbPersonalInfo";
			gbPersonalInfo.ShadowDecoration.CustomizableEdges = customizableEdges2;
			gbPersonalInfo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			// 
			// btnPersonalInfo
			// 
			resources.ApplyResources(btnPersonalInfo, "btnPersonalInfo");
			btnPersonalInfo.ForeColor = Color.White;
			btnPersonalInfo.Name = "btnPersonalInfo";
			btnPersonalInfo.UseVisualStyleBackColor = true;
			btnPersonalInfo.Click += btnPersonalInfo_Click;
			// 
			// gbLicencia
			// 
			resources.ApplyResources(gbLicencia, "gbLicencia");
			gbLicencia.BackColor = Color.FromArgb(10, 25, 24);
			gbLicencia.Controls.Add(cbCategoria);
			gbLicencia.Controls.Add(btnGuardarLicencia);
			gbLicencia.Controls.Add(btnSinLicencia);
			gbLicencia.Controls.Add(label9);
			gbLicencia.Controls.Add(label10);
			gbLicencia.Controls.Add(getEmisionLicencia);
			gbLicencia.Controls.Add(label11);
			gbLicencia.Controls.Add(getVencimientoLicencia);
			gbLicencia.CustomBorderThickness = new Padding(0);
			customizableEdges3.BottomLeft = false;
			customizableEdges3.BottomRight = false;
			customizableEdges3.TopLeft = false;
			customizableEdges3.TopRight = false;
			gbLicencia.CustomizableEdges = customizableEdges3;
			gbLicencia.FillColor = Color.Transparent;
			gbLicencia.ForeColor = Color.FromArgb(125, 137, 149);
			gbLicencia.Name = "gbLicencia";
			gbLicencia.ShadowDecoration.CustomizableEdges = customizableEdges4;
			gbLicencia.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			// 
			// cbCategoria
			// 
			resources.ApplyResources(cbCategoria, "cbCategoria");
			cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
			cbCategoria.FormattingEnabled = true;
			cbCategoria.Name = "cbCategoria";
			cbCategoria.SelectedIndexChanged += CambiaLicenciaInfo;
			// 
			// btnGuardarLicencia
			// 
			resources.ApplyResources(btnGuardarLicencia, "btnGuardarLicencia");
			btnGuardarLicencia.ForeColor = Color.Green;
			btnGuardarLicencia.Name = "btnGuardarLicencia";
			btnGuardarLicencia.UseVisualStyleBackColor = true;
			btnGuardarLicencia.Click += btnGuardarLicencia_Click;
			// 
			// btnSinLicencia
			// 
			resources.ApplyResources(btnSinLicencia, "btnSinLicencia");
			btnSinLicencia.ForeColor = Color.Red;
			btnSinLicencia.Name = "btnSinLicencia";
			btnSinLicencia.UseVisualStyleBackColor = true;
			btnSinLicencia.Click += btnSinLicencia_Click;
			// 
			// gbContacto
			// 
			resources.ApplyResources(gbContacto, "gbContacto");
			gbContacto.BackColor = Color.FromArgb(10, 25, 24);
			gbContacto.Controls.Add(btnEnviarContacto);
			gbContacto.Controls.Add(label5);
			gbContacto.Controls.Add(tbPais);
			gbContacto.Controls.Add(tbCiudad);
			gbContacto.Controls.Add(label4);
			gbContacto.Controls.Add(tbDireccion);
			gbContacto.Controls.Add(label7);
			gbContacto.Controls.Add(label8);
			gbContacto.Controls.Add(tbEmail);
			gbContacto.Controls.Add(tbTelefono);
			gbContacto.Controls.Add(label6);
			gbContacto.CustomBorderThickness = new Padding(0);
			customizableEdges5.BottomLeft = false;
			customizableEdges5.BottomRight = false;
			customizableEdges5.TopLeft = false;
			customizableEdges5.TopRight = false;
			gbContacto.CustomizableEdges = customizableEdges5;
			gbContacto.FillColor = Color.Transparent;
			gbContacto.ForeColor = Color.FromArgb(125, 137, 149);
			gbContacto.Name = "gbContacto";
			gbContacto.ShadowDecoration.CustomizableEdges = customizableEdges6;
			gbContacto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			// 
			// btnEnviarContacto
			// 
			resources.ApplyResources(btnEnviarContacto, "btnEnviarContacto");
			btnEnviarContacto.ForeColor = Color.Red;
			btnEnviarContacto.Name = "btnEnviarContacto";
			btnEnviarContacto.UseVisualStyleBackColor = true;
			btnEnviarContacto.Click += btnEnviarContacto_Click;
			// 
			// gbFinish
			// 
			resources.ApplyResources(gbFinish, "gbFinish");
			gbFinish.BackColor = Color.FromArgb(10, 25, 24);
			gbFinish.Controls.Add(lblAvisoPassword);
			gbFinish.Controls.Add(label15);
			gbFinish.Controls.Add(tbPassword);
			gbFinish.Controls.Add(pictImagePerfil);
			gbFinish.Controls.Add(btnRegistrar);
			gbFinish.Controls.Add(btnCargaImagen);
			gbFinish.CustomBorderThickness = new Padding(0);
			customizableEdges7.BottomLeft = false;
			customizableEdges7.BottomRight = false;
			customizableEdges7.TopLeft = false;
			customizableEdges7.TopRight = false;
			gbFinish.CustomizableEdges = customizableEdges7;
			gbFinish.FillColor = Color.Transparent;
			gbFinish.ForeColor = Color.FromArgb(125, 137, 149);
			gbFinish.Name = "gbFinish";
			gbFinish.ShadowDecoration.CustomizableEdges = customizableEdges8;
			gbFinish.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			// 
			// lblAvisoPassword
			// 
			resources.ApplyResources(lblAvisoPassword, "lblAvisoPassword");
			lblAvisoPassword.Name = "lblAvisoPassword";
			// 
			// label15
			// 
			resources.ApplyResources(label15, "label15");
			label15.Name = "label15";
			// 
			// tbPassword
			// 
			resources.ApplyResources(tbPassword, "tbPassword");
			tbPassword.Name = "tbPassword";
			tbPassword.TextChanged += tbPassword_TextChanged;
			// 
			// frmRegisterClient
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(10, 25, 94);
			BackgroundImage = Properties.Resources.Frost;
			Controls.Add(gbFinish);
			Controls.Add(gbContacto);
			Controls.Add(gbLicencia);
			Controls.Add(gbPersonalInfo);
			Name = "frmRegisterClient";
			Load += frmRegisterClient_Load;
			((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
			((System.ComponentModel.ISupportInitialize)pictImagePerfil).EndInit();
			gbPersonalInfo.ResumeLayout(false);
			gbPersonalInfo.PerformLayout();
			gbLicencia.ResumeLayout(false);
			gbLicencia.PerformLayout();
			gbContacto.ResumeLayout(false);
			gbContacto.PerformLayout();
			gbFinish.ResumeLayout(false);
			gbFinish.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TextBox tbName;
		private Label label1;
		private Label label2;
		private TextBox tbApellido;
		private Label label3;
		private NumericUpDown numEdad;
		private Label label4;
		private TextBox tbCiudad;
		private Label label5;
		private TextBox tbPais;
		private Label label6;
		private TextBox tbEmail;
		private Label label7;
		private TextBox tbDireccion;
		private Label label8;
		private TextBox tbTelefono;
		private Label label9;
		private Label label10;
		private DateTimePicker getEmisionLicencia;
		private DateTimePicker getVencimientoLicencia;
		private Label label11;
		private Button btnRegistrar;
		private Button btnCargaImagen;
		private Guna.UI2.WinForms.Guna2GroupBox gbPersonalInfo;
		private Button btnPersonalInfo;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private Guna.UI2.WinForms.Guna2GroupBox gbLicencia;
		private Button btnGuardarLicencia;
		private Button btnSinLicencia;
		private Guna.UI2.WinForms.Guna2GroupBox gbContacto;
		private Guna.UI2.WinForms.Guna2GroupBox gbFinish;
		private Button btnEnviarContacto;
		private Button button1;
		private Label label12;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label13;
		private Label label14;
		private NumericUpDown numericUpDown1;
		private ComboBox cbCategoria;
		private Label label15;
		private TextBox tbPassword;
		private Label lblAvisoPassword;
		public PictureBox pictImagePerfil;
	}
}