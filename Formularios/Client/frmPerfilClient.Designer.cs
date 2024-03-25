namespace ProjectFinalLp2.Formularios.Client
{
	partial class frmPerfilClient
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
			components = new System.ComponentModel.Container();
			pictCliente = new PictureBox();
			checkEditar = new CheckBox();
			label2 = new Label();
			tbName = new TextBox();
			tbApellido = new TextBox();
			label3 = new Label();
			label4 = new Label();
			numEdad = new NumericUpDown();
			tabControl1 = new TabControl();
			tabDatosPersonales = new TabPage();
			label15 = new Label();
			tbPassword = new TextBox();
			tabContacto = new TabPage();
			label5 = new Label();
			tbPais = new TextBox();
			tbCiudad = new TextBox();
			label1 = new Label();
			tbDireccion = new TextBox();
			label7 = new Label();
			label8 = new Label();
			tbEmail = new TextBox();
			tbTelefono = new TextBox();
			label6 = new Label();
			tabLicencia = new TabPage();
			cbCategoria = new ComboBox();
			label9 = new Label();
			label10 = new Label();
			getEmisionLicencia = new DateTimePicker();
			label11 = new Label();
			getVencimientoLicencia = new DateTimePicker();
			btnActualizar = new Button();
			toolTip = new ToolTip(components);
			lblAlert = new Label();
			((System.ComponentModel.ISupportInitialize)pictCliente).BeginInit();
			((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
			tabControl1.SuspendLayout();
			tabDatosPersonales.SuspendLayout();
			tabContacto.SuspendLayout();
			tabLicencia.SuspendLayout();
			SuspendLayout();
			// 
			// pictCliente
			// 
			pictCliente.Anchor = AnchorStyles.None;
			pictCliente.Image = Properties.Resources.clientDefaultWhite;
			pictCliente.InitialImage = Properties.Resources.userDefault;
			pictCliente.Location = new Point(267, 42);
			pictCliente.Margin = new Padding(0);
			pictCliente.Name = "pictCliente";
			pictCliente.Size = new Size(117, 95);
			pictCliente.SizeMode = PictureBoxSizeMode.Zoom;
			pictCliente.TabIndex = 5;
			pictCliente.TabStop = false;
			pictCliente.Click += pictCliente_Click;
			// 
			// checkEditar
			// 
			checkEditar.Anchor = AnchorStyles.None;
			checkEditar.AutoSize = true;
			checkEditar.Location = new Point(19, 26);
			checkEditar.Name = "checkEditar";
			checkEditar.Size = new Size(66, 28);
			checkEditar.TabIndex = 6;
			checkEditar.Text = "Editar";
			checkEditar.UseVisualStyleBackColor = true;
			checkEditar.CheckedChanged += checkEditar_CheckedChanged;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Agency FB", 12F);
			label2.ImeMode = ImeMode.NoControl;
			label2.Location = new Point(86, 60);
			label2.Margin = new Padding(0);
			label2.Name = "label2";
			label2.Size = new Size(56, 24);
			label2.TabIndex = 10;
			label2.Text = "Nombre";
			// 
			// tbName
			// 
			tbName.Anchor = AnchorStyles.None;
			tbName.BackColor = Color.FromArgb(224, 224, 224);
			tbName.BorderStyle = BorderStyle.None;
			tbName.Enabled = false;
			tbName.Font = new Font("Agency FB", 14F);
			tbName.ForeColor = SystemColors.ActiveCaptionText;
			tbName.Location = new Point(86, 84);
			tbName.Margin = new Padding(0);
			tbName.MaxLength = 30;
			tbName.Name = "tbName";
			tbName.Size = new Size(125, 28);
			tbName.TabIndex = 9;
			toolTip.SetToolTip(tbName, "Nombre");
			// 
			// tbApellido
			// 
			tbApellido.Anchor = AnchorStyles.None;
			tbApellido.BackColor = Color.FromArgb(224, 224, 224);
			tbApellido.BorderStyle = BorderStyle.FixedSingle;
			tbApellido.Enabled = false;
			tbApellido.Font = new Font("Agency FB", 12F);
			tbApellido.ForeColor = SystemColors.ActiveCaptionText;
			tbApellido.Location = new Point(86, 170);
			tbApellido.Margin = new Padding(0);
			tbApellido.MaxLength = 50;
			tbApellido.Name = "tbApellido";
			tbApellido.Size = new Size(125, 31);
			tbApellido.TabIndex = 11;
			toolTip.SetToolTip(tbApellido, "Apellido");
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Agency FB", 12F);
			label3.ImeMode = ImeMode.NoControl;
			label3.Location = new Point(86, 137);
			label3.Margin = new Padding(0);
			label3.Name = "label3";
			label3.Size = new Size(54, 24);
			label3.TabIndex = 12;
			label3.Text = "Apellido";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Agency FB", 12F);
			label4.ImeMode = ImeMode.NoControl;
			label4.Location = new Point(86, 215);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(38, 24);
			label4.TabIndex = 13;
			label4.Text = "Edad";
			// 
			// numEdad
			// 
			numEdad.Anchor = AnchorStyles.None;
			numEdad.BackColor = Color.FromArgb(224, 224, 224);
			numEdad.Enabled = false;
			numEdad.Font = new Font("Agency FB", 12F);
			numEdad.ForeColor = SystemColors.ActiveCaptionText;
			numEdad.Location = new Point(86, 250);
			numEdad.Margin = new Padding(0);
			numEdad.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
			numEdad.Name = "numEdad";
			numEdad.Size = new Size(125, 31);
			numEdad.TabIndex = 14;
			numEdad.TextAlign = HorizontalAlignment.Center;
			toolTip.SetToolTip(numEdad, "Edad");
			numEdad.Value = new decimal(new int[] { 20, 0, 0, 0 });
			// 
			// tabControl1
			// 
			tabControl1.Anchor = AnchorStyles.None;
			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.Controls.Add(tabDatosPersonales);
			tabControl1.Controls.Add(tabContacto);
			tabControl1.Controls.Add(tabLicencia);
			tabControl1.HotTrack = true;
			tabControl1.Location = new Point(19, 163);
			tabControl1.Margin = new Padding(0);
			tabControl1.Name = "tabControl1";
			tabControl1.Padding = new Point(7, 8);
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(677, 452);
			tabControl1.TabIndex = 15;
			// 
			// tabDatosPersonales
			// 
			tabDatosPersonales.BackColor = Color.Transparent;
			tabDatosPersonales.Controls.Add(label15);
			tabDatosPersonales.Controls.Add(tbPassword);
			tabDatosPersonales.Controls.Add(label2);
			tabDatosPersonales.Controls.Add(tbApellido);
			tabDatosPersonales.Controls.Add(tbName);
			tabDatosPersonales.Controls.Add(label3);
			tabDatosPersonales.Controls.Add(label4);
			tabDatosPersonales.Controls.Add(numEdad);
			tabDatosPersonales.ForeColor = SystemColors.InactiveCaptionText;
			tabDatosPersonales.Location = new Point(4, 46);
			tabDatosPersonales.Name = "tabDatosPersonales";
			tabDatosPersonales.Padding = new Padding(3);
			tabDatosPersonales.Size = new Size(669, 402);
			tabDatosPersonales.TabIndex = 0;
			tabDatosPersonales.Text = "Datos Personales";
			// 
			// label15
			// 
			label15.Anchor = AnchorStyles.None;
			label15.AutoSize = true;
			label15.Font = new Font("Agency FB", 14F);
			label15.ImeMode = ImeMode.NoControl;
			label15.Location = new Point(419, 107);
			label15.Margin = new Padding(0);
			label15.Name = "label15";
			label15.Size = new Size(85, 28);
			label15.TabIndex = 29;
			label15.Text = "Password";
			// 
			// tbPassword
			// 
			tbPassword.Anchor = AnchorStyles.None;
			tbPassword.BackColor = Color.FromArgb(224, 224, 224);
			tbPassword.ForeColor = SystemColors.ActiveCaptionText;
			tbPassword.Location = new Point(419, 135);
			tbPassword.Margin = new Padding(0);
			tbPassword.MaxLength = 15;
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.PlaceholderText = "Password";
			tbPassword.Size = new Size(137, 31);
			tbPassword.TabIndex = 32;
			toolTip.SetToolTip(tbPassword, "Contraseña");
			tbPassword.TextChanged += tbPassword_TextChanged;
			// 
			// tabContacto
			// 
			tabContacto.BackColor = Color.FromArgb(224, 224, 224);
			tabContacto.BorderStyle = BorderStyle.FixedSingle;
			tabContacto.Controls.Add(label5);
			tabContacto.Controls.Add(tbPais);
			tabContacto.Controls.Add(tbCiudad);
			tabContacto.Controls.Add(label1);
			tabContacto.Controls.Add(tbDireccion);
			tabContacto.Controls.Add(label7);
			tabContacto.Controls.Add(label8);
			tabContacto.Controls.Add(tbEmail);
			tabContacto.Controls.Add(tbTelefono);
			tabContacto.Controls.Add(label6);
			tabContacto.ForeColor = SystemColors.InactiveCaptionText;
			tabContacto.Location = new Point(4, 42);
			tabContacto.Name = "tabContacto";
			tabContacto.Padding = new Padding(3);
			tabContacto.RightToLeft = RightToLeft.No;
			tabContacto.Size = new Size(669, 406);
			tabContacto.TabIndex = 1;
			tabContacto.Text = "Contacto";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Agency FB", 14F);
			label5.ForeColor = SystemColors.InactiveCaptionText;
			label5.ImeMode = ImeMode.NoControl;
			label5.Location = new Point(178, 40);
			label5.Margin = new Padding(0);
			label5.Name = "label5";
			label5.Size = new Size(44, 28);
			label5.TabIndex = 19;
			label5.Text = "Pais";
			// 
			// tbPais
			// 
			tbPais.Anchor = AnchorStyles.None;
			tbPais.BorderStyle = BorderStyle.FixedSingle;
			tbPais.Font = new Font("Agency FB", 14F);
			tbPais.ForeColor = SystemColors.InfoText;
			tbPais.Location = new Point(259, 26);
			tbPais.Margin = new Padding(0);
			tbPais.MaxLength = 30;
			tbPais.Name = "tbPais";
			tbPais.Size = new Size(125, 35);
			tbPais.TabIndex = 17;
			toolTip.SetToolTip(tbPais, "Pais");
			// 
			// tbCiudad
			// 
			tbCiudad.Anchor = AnchorStyles.None;
			tbCiudad.BorderStyle = BorderStyle.FixedSingle;
			tbCiudad.Font = new Font("Agency FB", 14F);
			tbCiudad.ForeColor = SystemColors.InfoText;
			tbCiudad.Location = new Point(259, 93);
			tbCiudad.Margin = new Padding(0);
			tbCiudad.MaxLength = 50;
			tbCiudad.Name = "tbCiudad";
			tbCiudad.Size = new Size(125, 35);
			tbCiudad.TabIndex = 20;
			toolTip.SetToolTip(tbCiudad, "Ciudad / Provincia");
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Agency FB", 14F);
			label1.ForeColor = SystemColors.InactiveCaptionText;
			label1.ImeMode = ImeMode.NoControl;
			label1.Location = new Point(178, 107);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(62, 28);
			label1.TabIndex = 21;
			label1.Text = "Ciudad";
			// 
			// tbDireccion
			// 
			tbDireccion.Anchor = AnchorStyles.None;
			tbDireccion.BorderStyle = BorderStyle.FixedSingle;
			tbDireccion.Font = new Font("Agency FB", 14F);
			tbDireccion.ForeColor = SystemColors.InfoText;
			tbDireccion.Location = new Point(259, 156);
			tbDireccion.Margin = new Padding(0);
			tbDireccion.MaxLength = 30;
			tbDireccion.Name = "tbDireccion";
			tbDireccion.Size = new Size(125, 35);
			tbDireccion.TabIndex = 22;
			toolTip.SetToolTip(tbDireccion, "Direccion precisa");
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Agency FB", 14F);
			label7.ForeColor = SystemColors.InactiveCaptionText;
			label7.ImeMode = ImeMode.NoControl;
			label7.Location = new Point(178, 170);
			label7.Margin = new Padding(0);
			label7.Name = "label7";
			label7.Size = new Size(83, 28);
			label7.TabIndex = 23;
			label7.Text = "Dirección";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Agency FB", 14F);
			label8.ForeColor = SystemColors.InactiveCaptionText;
			label8.ImeMode = ImeMode.NoControl;
			label8.Location = new Point(178, 296);
			label8.Margin = new Padding(0);
			label8.Name = "label8";
			label8.Size = new Size(73, 28);
			label8.TabIndex = 27;
			label8.Text = "Telefono";
			// 
			// tbEmail
			// 
			tbEmail.Anchor = AnchorStyles.None;
			tbEmail.BorderStyle = BorderStyle.FixedSingle;
			tbEmail.Font = new Font("Agency FB", 14F);
			tbEmail.ForeColor = SystemColors.InfoText;
			tbEmail.Location = new Point(259, 223);
			tbEmail.Margin = new Padding(0);
			tbEmail.MaxLength = 50;
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(125, 35);
			tbEmail.TabIndex = 24;
			toolTip.SetToolTip(tbEmail, "Email");
			// 
			// tbTelefono
			// 
			tbTelefono.Anchor = AnchorStyles.None;
			tbTelefono.BorderStyle = BorderStyle.FixedSingle;
			tbTelefono.Font = new Font("Agency FB", 14F);
			tbTelefono.ForeColor = SystemColors.InfoText;
			tbTelefono.Location = new Point(259, 282);
			tbTelefono.Margin = new Padding(0);
			tbTelefono.MaxLength = 50;
			tbTelefono.Name = "tbTelefono";
			tbTelefono.Size = new Size(125, 35);
			tbTelefono.TabIndex = 26;
			toolTip.SetToolTip(tbTelefono, "Telefono");
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Agency FB", 14F);
			label6.ForeColor = SystemColors.InactiveCaptionText;
			label6.ImeMode = ImeMode.NoControl;
			label6.Location = new Point(178, 237);
			label6.Margin = new Padding(0);
			label6.Name = "label6";
			label6.Size = new Size(51, 28);
			label6.TabIndex = 25;
			label6.Text = "Email";
			// 
			// tabLicencia
			// 
			tabLicencia.BackColor = SystemColors.AppWorkspace;
			tabLicencia.Controls.Add(cbCategoria);
			tabLicencia.Controls.Add(label9);
			tabLicencia.Controls.Add(label10);
			tabLicencia.Controls.Add(getEmisionLicencia);
			tabLicencia.Controls.Add(label11);
			tabLicencia.Controls.Add(getVencimientoLicencia);
			tabLicencia.ForeColor = SystemColors.InfoText;
			tabLicencia.Location = new Point(4, 42);
			tabLicencia.Name = "tabLicencia";
			tabLicencia.Padding = new Padding(3);
			tabLicencia.Size = new Size(669, 406);
			tabLicencia.TabIndex = 2;
			tabLicencia.Text = "Tab Licencia";
			// 
			// cbCategoria
			// 
			cbCategoria.Anchor = AnchorStyles.None;
			cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
			cbCategoria.FormattingEnabled = true;
			cbCategoria.Location = new Point(342, 32);
			cbCategoria.Margin = new Padding(0);
			cbCategoria.Name = "cbCategoria";
			cbCategoria.Size = new Size(151, 32);
			cbCategoria.TabIndex = 34;
			// 
			// label9
			// 
			label9.Anchor = AnchorStyles.None;
			label9.AutoSize = true;
			label9.Font = new Font("Agency FB", 14F);
			label9.ImeMode = ImeMode.NoControl;
			label9.Location = new Point(155, 30);
			label9.Margin = new Padding(0);
			label9.Name = "label9";
			label9.Size = new Size(149, 28);
			label9.TabIndex = 27;
			label9.Text = "Categoria Licencia";
			// 
			// label10
			// 
			label10.Anchor = AnchorStyles.None;
			label10.AutoSize = true;
			label10.Font = new Font("Agency FB", 14F);
			label10.ImeMode = ImeMode.NoControl;
			label10.Location = new Point(155, 134);
			label10.Margin = new Padding(0);
			label10.Name = "label10";
			label10.Size = new Size(134, 28);
			label10.TabIndex = 28;
			label10.Text = "Emision Licencia";
			// 
			// getEmisionLicencia
			// 
			getEmisionLicencia.Anchor = AnchorStyles.None;
			getEmisionLicencia.Font = new Font("Agency FB", 10F);
			getEmisionLicencia.Location = new Point(154, 175);
			getEmisionLicencia.Margin = new Padding(0);
			getEmisionLicencia.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			getEmisionLicencia.Name = "getEmisionLicencia";
			getEmisionLicencia.Size = new Size(339, 27);
			getEmisionLicencia.TabIndex = 29;
			getEmisionLicencia.Value = new DateTime(2024, 2, 6, 0, 0, 0, 0);
			// 
			// label11
			// 
			label11.Anchor = AnchorStyles.None;
			label11.AutoSize = true;
			label11.Font = new Font("Agency FB", 14F);
			label11.ImeMode = ImeMode.NoControl;
			label11.Location = new Point(154, 247);
			label11.Margin = new Padding(0);
			label11.Name = "label11";
			label11.Size = new Size(166, 28);
			label11.TabIndex = 30;
			label11.Text = "Vencimiento Licencia";
			// 
			// getVencimientoLicencia
			// 
			getVencimientoLicencia.Anchor = AnchorStyles.None;
			getVencimientoLicencia.Font = new Font("Agency FB", 10F);
			getVencimientoLicencia.Location = new Point(155, 303);
			getVencimientoLicencia.Margin = new Padding(0);
			getVencimientoLicencia.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			getVencimientoLicencia.Name = "getVencimientoLicencia";
			getVencimientoLicencia.Size = new Size(339, 27);
			getVencimientoLicencia.TabIndex = 31;
			getVencimientoLicencia.Value = new DateTime(2024, 3, 28, 0, 0, 0, 0);
			// 
			// btnActualizar
			// 
			btnActualizar.Anchor = AnchorStyles.None;
			btnActualizar.FlatStyle = FlatStyle.Flat;
			btnActualizar.ForeColor = Color.WhiteSmoke;
			btnActualizar.Location = new Point(279, 631);
			btnActualizar.Margin = new Padding(0);
			btnActualizar.Name = "btnActualizar";
			btnActualizar.Size = new Size(105, 37);
			btnActualizar.TabIndex = 16;
			btnActualizar.Text = "Actualizar";
			btnActualizar.UseVisualStyleBackColor = true;
			btnActualizar.Visible = false;
			btnActualizar.Click += btnActualizar_Click;
			// 
			// toolTip
			// 
			toolTip.AutoPopDelay = 500;
			toolTip.InitialDelay = 500;
			toolTip.ReshowDelay = 100;
			// 
			// lblAlert
			// 
			lblAlert.AutoSize = true;
			lblAlert.Location = new Point(599, 59);
			lblAlert.Name = "lblAlert";
			lblAlert.Size = new Size(37, 24);
			lblAlert.TabIndex = 17;
			lblAlert.Text = "Alert";
			lblAlert.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// frmPerfilClient
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.FromArgb(25, 43, 56);
			ClientSize = new Size(716, 690);
			Controls.Add(lblAlert);
			Controls.Add(btnActualizar);
			Controls.Add(tabControl1);
			Controls.Add(checkEditar);
			Controls.Add(pictCliente);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ForeColor = SystemColors.Window;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			HelpButton = true;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmPerfilClient";
			ShowInTaskbar = false;
			Text = "frmPerfilClient";
			Load += frmPerfilClient_Load;
			((System.ComponentModel.ISupportInitialize)pictCliente).EndInit();
			((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
			tabControl1.ResumeLayout(false);
			tabDatosPersonales.ResumeLayout(false);
			tabDatosPersonales.PerformLayout();
			tabContacto.ResumeLayout(false);
			tabContacto.PerformLayout();
			tabLicencia.ResumeLayout(false);
			tabLicencia.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictCliente;
		private CheckBox checkEditar;
		private Label label2;
		private TextBox tbName;
		private TextBox tbApellido;
		private Label label3;
		private Label label4;
		private NumericUpDown numEdad;
		private TabControl tabControl1;
		private TabPage tabDatosPersonales;
		private TabPage tabContacto;
		private Label label5;
		private TextBox tbPais;
		private TextBox tbCiudad;
		private Label label1;
		private TextBox tbDireccion;
		private Label label7;
		private Label label8;
		private TextBox tbEmail;
		private TextBox tbTelefono;
		private Label label6;
		private TabPage tabLicencia;
		private ComboBox cbCategoria;
		private Label label9;
		private Label label10;
		private DateTimePicker getEmisionLicencia;
		private Label label11;
		private DateTimePicker getVencimientoLicencia;
		private Label label15;
		private TextBox tbPassword;
		private Button btnActualizar;
		private ToolTip toolTip;
		private Label lblAlert;
	}
}