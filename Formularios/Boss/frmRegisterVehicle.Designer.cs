namespace ProjectFinalLp2.Formularios.Boss
{
	partial class frmRegisterVehicle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterVehicle));
			tbMarca = new TextBox();
			label1 = new Label();
			label2 = new Label();
			tbModelo = new TextBox();
			label3 = new Label();
			cbTipoVehiculo = new ComboBox();
			numYear = new NumericUpDown();
			label4 = new Label();
			label5 = new Label();
			cbEstado = new ComboBox();
			label6 = new Label();
			label7 = new Label();
			numPrecioRenta = new NumericUpDown();
			rtDescripcion = new RichTextBox();
			label8 = new Label();
			label9 = new Label();
			cbLicenciaRequerida = new ComboBox();
			pictImagenVehiculo = new PictureBox();
			label10 = new Label();
			btnRegistrar = new Button();
			panelColorVehiculo = new Panel();
			tbNameColor = new TextBox();
			lblAlert = new Label();
			AyudaToolTip = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
			((System.ComponentModel.ISupportInitialize)numPrecioRenta).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictImagenVehiculo).BeginInit();
			SuspendLayout();
			// 
			// tbMarca
			// 
			tbMarca.Anchor = AnchorStyles.None;
			tbMarca.Location = new Point(174, 139);
			tbMarca.Margin = new Padding(0);
			tbMarca.MaxLength = 25;
			tbMarca.Name = "tbMarca";
			tbMarca.PlaceholderText = "Marca";
			tbMarca.Size = new Size(125, 31);
			tbMarca.TabIndex = 0;
			tbMarca.Tag = "Marca";
			AyudaToolTip.SetToolTip(tbMarca, "Introduce la Marca");
			tbMarca.TextChanged += tbMarca_TextChanged_1;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Location = new Point(118, 139);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(46, 24);
			label1.TabIndex = 1;
			label1.Text = "Marca";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Location = new Point(118, 200);
			label2.Margin = new Padding(0);
			label2.Name = "label2";
			label2.Size = new Size(50, 24);
			label2.TabIndex = 3;
			label2.Text = "Modelo";
			// 
			// tbModelo
			// 
			tbModelo.Anchor = AnchorStyles.None;
			tbModelo.Location = new Point(174, 200);
			tbModelo.Margin = new Padding(0);
			tbModelo.MaxLength = 29;
			tbModelo.Name = "tbModelo";
			tbModelo.PlaceholderText = "Modelo";
			tbModelo.Size = new Size(125, 31);
			tbModelo.TabIndex = 2;
			tbModelo.Tag = "Modelo";
			AyudaToolTip.SetToolTip(tbModelo, "Modelo");
			tbModelo.TextChanged += tbModelo_TextChanged;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Location = new Point(118, 269);
			label3.Margin = new Padding(0);
			label3.Name = "label3";
			label3.Size = new Size(32, 24);
			label3.TabIndex = 5;
			label3.Text = "Tipo";
			// 
			// cbTipoVehiculo
			// 
			cbTipoVehiculo.Anchor = AnchorStyles.None;
			cbTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTipoVehiculo.FormattingEnabled = true;
			cbTipoVehiculo.Location = new Point(174, 269);
			cbTipoVehiculo.Margin = new Padding(0);
			cbTipoVehiculo.MaxLength = 20;
			cbTipoVehiculo.Name = "cbTipoVehiculo";
			cbTipoVehiculo.Size = new Size(125, 32);
			cbTipoVehiculo.TabIndex = 6;
			cbTipoVehiculo.Tag = "Tipo Vehiculo";
			AyudaToolTip.SetToolTip(cbTipoVehiculo, "Tipo de uso que puede ofrecer");
			cbTipoVehiculo.SelectedIndexChanged += cbTipoVehiculo_SelectedIndexChanged;
			// 
			// numYear
			// 
			numYear.Anchor = AnchorStyles.None;
			numYear.Location = new Point(175, 331);
			numYear.Margin = new Padding(0);
			numYear.Maximum = new decimal(new int[] { 2400, 0, 0, 0 });
			numYear.Minimum = new decimal(new int[] { 1885, 0, 0, 0 });
			numYear.Name = "numYear";
			numYear.Size = new Size(125, 31);
			numYear.TabIndex = 7;
			numYear.Tag = "Año";
			numYear.ThousandsSeparator = true;
			AyudaToolTip.SetToolTip(numYear, "Año Fabricacion");
			numYear.Value = new decimal(new int[] { 1885, 0, 0, 0 });
			numYear.ValueChanged += numYear_ValueChanged;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.Location = new Point(119, 333);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(31, 24);
			label4.TabIndex = 8;
			label4.Text = "Año";
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.None;
			label5.AutoSize = true;
			label5.Location = new Point(114, 390);
			label5.Margin = new Padding(0);
			label5.Name = "label5";
			label5.Size = new Size(41, 24);
			label5.TabIndex = 10;
			label5.Text = "Color";
			// 
			// cbEstado
			// 
			cbEstado.Anchor = AnchorStyles.None;
			cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
			cbEstado.FormattingEnabled = true;
			cbEstado.Location = new Point(178, 440);
			cbEstado.Margin = new Padding(0);
			cbEstado.MaxLength = 12;
			cbEstado.Name = "cbEstado";
			cbEstado.Size = new Size(125, 32);
			cbEstado.TabIndex = 14;
			cbEstado.Tag = "Estado";
			AyudaToolTip.SetToolTip(cbEstado, "Estado del vehículo");
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.None;
			label6.AutoSize = true;
			label6.Location = new Point(118, 443);
			label6.Margin = new Padding(0);
			label6.Name = "label6";
			label6.Size = new Size(49, 24);
			label6.TabIndex = 13;
			label6.Text = "Estado";
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.None;
			label7.AutoSize = true;
			label7.Location = new Point(449, 146);
			label7.Margin = new Padding(0);
			label7.Name = "label7";
			label7.Size = new Size(48, 24);
			label7.TabIndex = 16;
			label7.Text = "Precio";
			// 
			// numPrecioRenta
			// 
			numPrecioRenta.Anchor = AnchorStyles.None;
			numPrecioRenta.AutoSize = true;
			numPrecioRenta.DecimalPlaces = 2;
			numPrecioRenta.Increment = new decimal(new int[] { 50, 0, 0, 0 });
			numPrecioRenta.Location = new Point(505, 144);
			numPrecioRenta.Margin = new Padding(0);
			numPrecioRenta.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			numPrecioRenta.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
			numPrecioRenta.Name = "numPrecioRenta";
			numPrecioRenta.Size = new Size(125, 31);
			numPrecioRenta.TabIndex = 15;
			numPrecioRenta.Tag = "Precio";
			numPrecioRenta.TextAlign = HorizontalAlignment.Center;
			numPrecioRenta.ThousandsSeparator = true;
			AyudaToolTip.SetToolTip(numPrecioRenta, "Precio renta del vehiculo Por HORA");
			numPrecioRenta.Value = new decimal(new int[] { 50, 0, 0, 0 });
			// 
			// rtDescripcion
			// 
			rtDescripcion.Anchor = AnchorStyles.None;
			rtDescripcion.Location = new Point(449, 301);
			rtDescripcion.Margin = new Padding(0);
			rtDescripcion.MaxLength = 299;
			rtDescripcion.Name = "rtDescripcion";
			rtDescripcion.Size = new Size(181, 84);
			rtDescripcion.TabIndex = 17;
			rtDescripcion.Tag = "Descripción";
			rtDescripcion.Text = " ";
			AyudaToolTip.SetToolTip(rtDescripcion, "Descripcion breve sobre este vehículo");
			rtDescripcion.TextChanged += rtDescripcion_TextChanged;
			// 
			// label8
			// 
			label8.Anchor = AnchorStyles.None;
			label8.AutoSize = true;
			label8.Location = new Point(449, 277);
			label8.Margin = new Padding(0);
			label8.Name = "label8";
			label8.Size = new Size(79, 24);
			label8.TabIndex = 18;
			label8.Text = "Descripción";
			// 
			// label9
			// 
			label9.Anchor = AnchorStyles.None;
			label9.AutoSize = true;
			label9.Location = new Point(409, 226);
			label9.Margin = new Padding(0);
			label9.Name = "label9";
			label9.Size = new Size(119, 24);
			label9.TabIndex = 20;
			label9.Text = "Licencia Requerida";
			// 
			// cbLicenciaRequerida
			// 
			cbLicenciaRequerida.Anchor = AnchorStyles.None;
			cbLicenciaRequerida.DropDownStyle = ComboBoxStyle.DropDownList;
			cbLicenciaRequerida.FormattingEnabled = true;
			cbLicenciaRequerida.Location = new Point(536, 218);
			cbLicenciaRequerida.Margin = new Padding(0);
			cbLicenciaRequerida.MaxLength = 30;
			cbLicenciaRequerida.Name = "cbLicenciaRequerida";
			cbLicenciaRequerida.Size = new Size(125, 32);
			cbLicenciaRequerida.TabIndex = 21;
			cbLicenciaRequerida.Tag = "Licencia requerida";
			// 
			// pictImagenVehiculo
			// 
			pictImagenVehiculo.Anchor = AnchorStyles.None;
			pictImagenVehiculo.BackColor = Color.Transparent;
			pictImagenVehiculo.BorderStyle = BorderStyle.FixedSingle;
			pictImagenVehiculo.Cursor = Cursors.Hand;
			pictImagenVehiculo.ErrorImage = Properties.Resources.error;
			pictImagenVehiculo.Image = Properties.Resources.waiting;
			pictImagenVehiculo.InitialImage = (Image)resources.GetObject("pictImagenVehiculo.InitialImage");
			pictImagenVehiculo.Location = new Point(462, 450);
			pictImagenVehiculo.Name = "pictImagenVehiculo";
			pictImagenVehiculo.Size = new Size(125, 93);
			pictImagenVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
			pictImagenVehiculo.TabIndex = 22;
			pictImagenVehiculo.TabStop = false;
			pictImagenVehiculo.Tag = "Imagen Vehiculo";
			AyudaToolTip.SetToolTip(pictImagenVehiculo, "Cargar Imagen del Vehículo");
			pictImagenVehiculo.Click += pictImagenVehiculo_Click;
			// 
			// label10
			// 
			label10.Anchor = AnchorStyles.None;
			label10.AutoSize = true;
			label10.Location = new Point(409, 411);
			label10.Margin = new Padding(0);
			label10.Name = "label10";
			label10.Size = new Size(52, 24);
			label10.TabIndex = 23;
			label10.Text = "Imagen";
			// 
			// btnRegistrar
			// 
			btnRegistrar.Anchor = AnchorStyles.None;
			btnRegistrar.BackColor = Color.FromArgb(161, 195, 152);
			btnRegistrar.Location = new Point(298, 566);
			btnRegistrar.Margin = new Padding(0);
			btnRegistrar.Name = "btnRegistrar";
			btnRegistrar.Size = new Size(126, 60);
			btnRegistrar.TabIndex = 24;
			btnRegistrar.Text = "Registrar";
			AyudaToolTip.SetToolTip(btnRegistrar, "Registrar Vehículo");
			btnRegistrar.UseVisualStyleBackColor = false;
			btnRegistrar.Click += btnRegistrar_Click;
			// 
			// panelColorVehiculo
			// 
			panelColorVehiculo.Anchor = AnchorStyles.None;
			panelColorVehiculo.BackColor = Color.White;
			panelColorVehiculo.BorderStyle = BorderStyle.FixedSingle;
			panelColorVehiculo.Location = new Point(167, 387);
			panelColorVehiculo.Name = "panelColorVehiculo";
			panelColorVehiculo.Size = new Size(36, 31);
			panelColorVehiculo.TabIndex = 25;
			AyudaToolTip.SetToolTip(panelColorVehiculo, "Color del vehículo");
			panelColorVehiculo.Click += panelColorVehiculo_Click;
			// 
			// tbNameColor
			// 
			tbNameColor.Anchor = AnchorStyles.None;
			tbNameColor.Location = new Point(206, 387);
			tbNameColor.Margin = new Padding(0);
			tbNameColor.MaxLength = 14;
			tbNameColor.Name = "tbNameColor";
			tbNameColor.Size = new Size(77, 31);
			tbNameColor.TabIndex = 27;
			tbNameColor.Tag = "Color";
			tbNameColor.Text = "White";
			AyudaToolTip.SetToolTip(tbNameColor, "Color del vehículo");
			tbNameColor.TextChanged += tbNameColor_TextChanged;
			// 
			// lblAlert
			// 
			lblAlert.Anchor = AnchorStyles.None;
			lblAlert.AutoSize = true;
			lblAlert.Location = new Point(714, 755);
			lblAlert.Margin = new Padding(0);
			lblAlert.Name = "lblAlert";
			lblAlert.Size = new Size(0, 24);
			lblAlert.TabIndex = 28;
			// 
			// AyudaToolTip
			// 
			AyudaToolTip.AutomaticDelay = 200;
			AyudaToolTip.AutoPopDelay = 2000;
			AyudaToolTip.InitialDelay = 100;
			AyudaToolTip.ReshowDelay = 40;
			AyudaToolTip.ToolTipTitle = "Descripción";
			// 
			// frmRegisterVehicle
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(775, 759);
			Controls.Add(lblAlert);
			Controls.Add(tbNameColor);
			Controls.Add(panelColorVehiculo);
			Controls.Add(btnRegistrar);
			Controls.Add(label10);
			Controls.Add(pictImagenVehiculo);
			Controls.Add(cbLicenciaRequerida);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(rtDescripcion);
			Controls.Add(label7);
			Controls.Add(numPrecioRenta);
			Controls.Add(cbEstado);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(numYear);
			Controls.Add(cbTipoVehiculo);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(tbModelo);
			Controls.Add(label1);
			Controls.Add(tbMarca);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmRegisterVehicle";
			StartPosition = FormStartPosition.WindowsDefaultBounds;
			Text = "frmRegisterVehicle";
			Load += frmRegisterVehicle_Load;
			((System.ComponentModel.ISupportInitialize)numYear).EndInit();
			((System.ComponentModel.ISupportInitialize)numPrecioRenta).EndInit();
			((System.ComponentModel.ISupportInitialize)pictImagenVehiculo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbMarca;
		private Label label1;
		private Label label2;
		private TextBox tbModelo;
		private Label label3;
		private ComboBox cbTipoVehiculo;
		private NumericUpDown numYear;
		private Label label4;
		private Label label5;
		private ComboBox cbEstado;
		private Label label6;
		private Label label7;
		private NumericUpDown numPrecioRenta;
		private RichTextBox rtDescripcion;
		private Label label8;
		private Label label9;
		private ComboBox cbLicenciaRequerida;
		private PictureBox pictImagenVehiculo;
		private Label label10;
		private Button btnRegistrar;
		private Panel panelColorVehiculo;
		private TextBox tbNameColor;
		private Label lblAlert;
		private ToolTip AyudaToolTip;
	}
}