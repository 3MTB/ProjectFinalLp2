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
			tbName = new TextBox();
			label1 = new Label();
			label2 = new Label();
			textBox1 = new TextBox();
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
			tbCategoria = new TextBox();
			label10 = new Label();
			getEmisionLicencia = new DateTimePicker();
			getVencimientoLicencia = new DateTimePicker();
			label11 = new Label();
			btnRegistrar = new Button();
			((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
			SuspendLayout();
			// 
			// tbName
			// 
			resources.ApplyResources(tbName, "tbName");
			tbName.BorderStyle = BorderStyle.FixedSingle;
			tbName.Name = "tbName";
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
			// textBox1
			// 
			resources.ApplyResources(textBox1, "textBox1");
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Name = "textBox1";
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
			// 
			// label9
			// 
			resources.ApplyResources(label9, "label9");
			label9.Name = "label9";
			// 
			// tbCategoria
			// 
			resources.ApplyResources(tbCategoria, "tbCategoria");
			tbCategoria.BorderStyle = BorderStyle.FixedSingle;
			tbCategoria.Name = "tbCategoria";
			// 
			// label10
			// 
			resources.ApplyResources(label10, "label10");
			label10.Name = "label10";
			// 
			// getEmisionLicencia
			// 
			resources.ApplyResources(getEmisionLicencia, "getEmisionLicencia");
			getEmisionLicencia.Name = "getEmisionLicencia";
			// 
			// getVencimientoLicencia
			// 
			resources.ApplyResources(getVencimientoLicencia, "getVencimientoLicencia");
			getVencimientoLicencia.Name = "getVencimientoLicencia";
			getVencimientoLicencia.ValueChanged += dateTimePicker1_ValueChanged;
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
			// 
			// frmRegisterClient
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(10, 25, 94);
			BackgroundImage = Properties.Resources.Frost;
			Controls.Add(btnRegistrar);
			Controls.Add(getVencimientoLicencia);
			Controls.Add(label11);
			Controls.Add(getEmisionLicencia);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(tbCategoria);
			Controls.Add(label8);
			Controls.Add(tbTelefono);
			Controls.Add(label6);
			Controls.Add(tbEmail);
			Controls.Add(label7);
			Controls.Add(tbDireccion);
			Controls.Add(label4);
			Controls.Add(tbCiudad);
			Controls.Add(label5);
			Controls.Add(tbPais);
			Controls.Add(numEdad);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(tbName);
			Name = "frmRegisterClient";
			((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbName;
		private Label label1;
		private Label label2;
		private TextBox textBox1;
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
		private TextBox tbCategoria;
		private Label label10;
		private DateTimePicker getEmisionLicencia;
		private DateTimePicker getVencimientoLicencia;
		private Label label11;
		private Button btnRegistrar;
	}
}