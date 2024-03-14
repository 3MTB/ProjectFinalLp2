namespace ProjectFinalLp2.Formularios.Aplication
{
	partial class FrmRegRentarVehiculo
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
			Label label5;
			Label label6;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegRentarVehiculo));
			pictImage = new PictureBox();
			label3 = new Label();
			lblBrand = new Label();
			label2 = new Label();
			lblModel = new Label();
			label1 = new Label();
			lblPrice = new Label();
			cbTrabajador = new ComboBox();
			label4 = new Label();
			dtFechaInicio = new DateTimePicker();
			dtFechaFinal = new DateTimePicker();
			label7 = new Label();
			lblTotalPagar = new Label();
			label8 = new Label();
			lblDescuentoPagar = new Label();
			lblAviso = new Label();
			tbRentar = new Button();
			label5 = new Label();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)pictImage).BeginInit();
			SuspendLayout();
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.None;
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Agency FB", 16F);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(283, 370);
			label5.Margin = new Padding(0);
			label5.Name = "label5";
			label5.Size = new Size(109, 32);
			label5.TabIndex = 26;
			label5.Text = "Fecha Inicio";
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.None;
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Agency FB", 16F);
			label6.ForeColor = SystemColors.ActiveCaptionText;
			label6.Location = new Point(283, 442);
			label6.Margin = new Padding(0);
			label6.Name = "label6";
			label6.Size = new Size(103, 32);
			label6.TabIndex = 28;
			label6.Text = "Fecha Final";
			// 
			// pictImage
			// 
			pictImage.Anchor = AnchorStyles.None;
			pictImage.Image = (Image)resources.GetObject("pictImage.Image");
			pictImage.InitialImage = (Image)resources.GetObject("pictImage.InitialImage");
			pictImage.Location = new Point(55, 31);
			pictImage.Margin = new Padding(0);
			pictImage.Name = "pictImage";
			pictImage.Size = new Size(270, 293);
			pictImage.SizeMode = PictureBoxSizeMode.CenterImage;
			pictImage.TabIndex = 15;
			pictImage.TabStop = false;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Agency FB", 20F);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(384, 127);
			label3.Margin = new Padding(0);
			label3.Name = "label3";
			label3.Size = new Size(76, 42);
			label3.TabIndex = 22;
			label3.Text = "Model";
			// 
			// lblBrand
			// 
			lblBrand.Anchor = AnchorStyles.None;
			lblBrand.AutoSize = true;
			lblBrand.BackColor = Color.Transparent;
			lblBrand.Font = new Font("Segoe UI", 19F);
			lblBrand.ForeColor = Color.Black;
			lblBrand.Location = new Point(463, 47);
			lblBrand.Margin = new Padding(2, 0, 2, 0);
			lblBrand.Name = "lblBrand";
			lblBrand.Size = new Size(107, 45);
			lblBrand.TabIndex = 16;
			lblBrand.Text = "Marca";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 19F);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(366, 47);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(107, 45);
			label2.TabIndex = 21;
			label2.Text = "Marca";
			// 
			// lblModel
			// 
			lblModel.Anchor = AnchorStyles.None;
			lblModel.AutoSize = true;
			lblModel.BackColor = Color.Transparent;
			lblModel.Font = new Font("Agency FB", 24F);
			lblModel.ForeColor = Color.Black;
			lblModel.Location = new Point(463, 127);
			lblModel.Margin = new Padding(0);
			lblModel.Name = "lblModel";
			lblModel.Size = new Size(97, 49);
			lblModel.TabIndex = 17;
			lblModel.Text = "Model";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Microsoft Sans Serif", 13.8F);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(543, 236);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(60, 29);
			label1.TabIndex = 20;
			label1.Text = "$p/h";
			// 
			// lblPrice
			// 
			lblPrice.Anchor = AnchorStyles.None;
			lblPrice.AutoSize = true;
			lblPrice.Font = new Font("Microsoft Sans Serif", 16F);
			lblPrice.ForeColor = Color.MediumBlue;
			lblPrice.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
			lblPrice.Location = new Point(463, 233);
			lblPrice.Margin = new Padding(0);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(91, 31);
			lblPrice.TabIndex = 19;
			lblPrice.Text = "Precio";
			// 
			// cbTrabajador
			// 
			cbTrabajador.Anchor = AnchorStyles.None;
			cbTrabajador.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTrabajador.FormattingEnabled = true;
			cbTrabajador.Location = new Point(244, 683);
			cbTrabajador.Margin = new Padding(0);
			cbTrabajador.Name = "cbTrabajador";
			cbTrabajador.Size = new Size(133, 32);
			cbTrabajador.TabIndex = 23;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Agency FB", 15F);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(146, 677);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(112, 29);
			label4.TabIndex = 24;
			label4.Text = "Atendido por:";
			// 
			// dtFechaInicio
			// 
			dtFechaInicio.Anchor = AnchorStyles.None;
			dtFechaInicio.Font = new Font("Segoe UI", 12F);
			dtFechaInicio.Format = DateTimePickerFormat.Short;
			dtFechaInicio.Location = new Point(384, 370);
			dtFechaInicio.Margin = new Padding(3, 4, 3, 4);
			dtFechaInicio.Name = "dtFechaInicio";
			dtFechaInicio.Size = new Size(291, 34);
			dtFechaInicio.TabIndex = 25;
			dtFechaInicio.ValueChanged += dtFechaInicio_ValueChanged;
			// 
			// dtFechaFinal
			// 
			dtFechaFinal.Anchor = AnchorStyles.None;
			dtFechaFinal.Font = new Font("Segoe UI", 12F);
			dtFechaFinal.Format = DateTimePickerFormat.Short;
			dtFechaFinal.Location = new Point(384, 442);
			dtFechaFinal.Margin = new Padding(3, 4, 3, 4);
			dtFechaFinal.Name = "dtFechaFinal";
			dtFechaFinal.Size = new Size(291, 34);
			dtFechaFinal.TabIndex = 27;
			dtFechaFinal.ValueChanged += dtFechaFinal_ValueChanged;
			dtFechaFinal.Validating += dtFechaFinal_Validating;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.None;
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 14F);
			label7.Location = new Point(259, 536);
			label7.Name = "label7";
			label7.Size = new Size(130, 32);
			label7.TabIndex = 29;
			label7.Text = "Total Pagar";
			// 
			// lblTotalPagar
			// 
			lblTotalPagar.Anchor = AnchorStyles.None;
			lblTotalPagar.AutoSize = true;
			lblTotalPagar.Font = new Font("Segoe UI", 14F);
			lblTotalPagar.Location = new Point(384, 536);
			lblTotalPagar.Name = "lblTotalPagar";
			lblTotalPagar.Size = new Size(27, 32);
			lblTotalPagar.TabIndex = 30;
			lblTotalPagar.Text = "0";
			// 
			// label8
			// 
			label8.Anchor = AnchorStyles.None;
			label8.AutoSize = true;
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Agency FB", 20F);
			label8.ForeColor = SystemColors.ActiveCaptionText;
			label8.Location = new Point(384, 217);
			label8.Margin = new Padding(0);
			label8.Name = "label8";
			label8.Size = new Size(83, 42);
			label8.TabIndex = 31;
			label8.Text = "Precio";
			// 
			// lblDescuentoPagar
			// 
			lblDescuentoPagar.Anchor = AnchorStyles.None;
			lblDescuentoPagar.AutoSize = true;
			lblDescuentoPagar.Font = new Font("Segoe UI", 9F);
			lblDescuentoPagar.ForeColor = SystemColors.AppWorkspace;
			lblDescuentoPagar.Location = new Point(293, 575);
			lblDescuentoPagar.Name = "lblDescuentoPagar";
			lblDescuentoPagar.Size = new Size(77, 20);
			lblDescuentoPagar.TabIndex = 32;
			lblDescuentoPagar.Text = "descuento";
			// 
			// lblAviso
			// 
			lblAviso.Anchor = AnchorStyles.None;
			lblAviso.AutoSize = true;
			lblAviso.BackColor = Color.Transparent;
			lblAviso.Font = new Font("Agency FB", 15F);
			lblAviso.ForeColor = SystemColors.ActiveCaptionText;
			lblAviso.Location = new Point(415, 787);
			lblAviso.Margin = new Padding(0);
			lblAviso.Name = "lblAviso";
			lblAviso.Size = new Size(116, 29);
			lblAviso.TabIndex = 33;
			lblAviso.Text = "Aviso General";
			// 
			// tbRentar
			// 
			tbRentar.Anchor = AnchorStyles.None;
			tbRentar.BackColor = Color.LawnGreen;
			tbRentar.Location = new Point(503, 630);
			tbRentar.Margin = new Padding(3, 4, 3, 4);
			tbRentar.Name = "tbRentar";
			tbRentar.Size = new Size(82, 35);
			tbRentar.TabIndex = 34;
			tbRentar.Text = "RENTAR";
			tbRentar.UseVisualStyleBackColor = false;
			tbRentar.Click += tbRentar_Click;
			// 
			// FrmRegRentarVehiculo
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(947, 869);
			Controls.Add(tbRentar);
			Controls.Add(lblAviso);
			Controls.Add(lblDescuentoPagar);
			Controls.Add(label8);
			Controls.Add(lblTotalPagar);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(dtFechaFinal);
			Controls.Add(label5);
			Controls.Add(dtFechaInicio);
			Controls.Add(label4);
			Controls.Add(cbTrabajador);
			Controls.Add(pictImage);
			Controls.Add(label3);
			Controls.Add(lblBrand);
			Controls.Add(label2);
			Controls.Add(lblModel);
			Controls.Add(label1);
			Controls.Add(lblPrice);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FrmRegRentarVehiculo";
			Text = "FrmRegRentarVehiculo";
			Load += FrmRegRentarVehiculo_Load;
			((System.ComponentModel.ISupportInitialize)pictImage).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		protected internal PictureBox pictImage;
		private Label label3;
		private Label lblBrand;
		private Label label2;
		private Label lblModel;
		private Label label1;
		private Label lblPrice;
		private ComboBox cbTrabajador;
		private Label label4;
		private DateTimePicker dtFechaInicio;
		private DateTimePicker dtFechaFinal;
		private Label label7;
		private Label lblTotalPagar;
		private Label label8;
		private Label lblDescuentoPagar;
		private Label lblAviso;
		private Button tbRentar;
	}
}