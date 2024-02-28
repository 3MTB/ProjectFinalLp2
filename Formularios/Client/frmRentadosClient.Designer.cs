namespace ProjectFinalLp2.Formularios.Client
{
	partial class frmRentadosClient
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
			dgRentados = new DataGridView();
			label1 = new Label();
			tbCantidad = new TextBox();
			lblAlert = new Label();
			((System.ComponentModel.ISupportInitialize)dgRentados).BeginInit();
			SuspendLayout();
			// 
			// dgRentados
			// 
			dgRentados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgRentados.Dock = DockStyle.Bottom;
			dgRentados.Location = new Point(0, 214);
			dgRentados.Margin = new Padding(3, 4, 3, 4);
			dgRentados.Name = "dgRentados";
			dgRentados.RowHeadersWidth = 51;
			dgRentados.Size = new Size(800, 416);
			dgRentados.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Agency FB", 16F);
			label1.ForeColor = Color.White;
			label1.Location = new Point(240, 48);
			label1.Name = "label1";
			label1.Size = new Size(84, 32);
			label1.TabIndex = 1;
			label1.Text = "Cantidad";
			// 
			// tbCantidad
			// 
			tbCantidad.Anchor = AnchorStyles.None;
			tbCantidad.Enabled = false;
			tbCantidad.Location = new Point(364, 48);
			tbCantidad.Margin = new Padding(0);
			tbCantidad.Name = "tbCantidad";
			tbCantidad.Size = new Size(125, 35);
			tbCantidad.TabIndex = 2;
			// 
			// lblAlert
			// 
			lblAlert.Anchor = AnchorStyles.None;
			lblAlert.AutoSize = true;
			lblAlert.Font = new Font("Agency FB", 28F);
			lblAlert.ForeColor = Color.White;
			lblAlert.Location = new Point(281, 155);
			lblAlert.Name = "lblAlert";
			lblAlert.Size = new Size(208, 55);
			lblAlert.TabIndex = 3;
			lblAlert.Text = "Sin registros";
			lblAlert.UseMnemonic = false;
			lblAlert.Visible = false;
			// 
			// frmRentadosClient
			// 
			AutoScaleDimensions = new SizeF(8F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(800, 630);
			Controls.Add(lblAlert);
			Controls.Add(tbCantidad);
			Controls.Add(label1);
			Controls.Add(dgRentados);
			Font = new Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmRentadosClient";
			Load += frmRentadosClient_Load;
			((System.ComponentModel.ISupportInitialize)dgRentados).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgRentados;
		private Label label1;
		private TextBox tbCantidad;
		private Label lblAlert;
	}
}