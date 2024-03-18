namespace ProjectFinalLp2.Formularios.Aplication
{
	partial class frmRentados
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			label1 = new Label();
			dgRentados = new DataGridView();
			label2 = new Label();
			lblCantidad = new Label();
			((System.ComponentModel.ISupportInitialize)dgRentados).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Agency FB", 26F);
			label1.Location = new Point(232, 24);
			label1.Name = "label1";
			label1.Size = new Size(147, 53);
			label1.TabIndex = 0;
			label1.Text = "Rentados";
			// 
			// dgRentados
			// 
			dgRentados.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
			dataGridViewCellStyle1.SelectionForeColor = Color.Red;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgRentados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgRentados.BackgroundColor = Color.Black;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle2.BackColor = Color.DimGray;
			dataGridViewCellStyle2.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgRentados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgRentados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = Color.Black;
			dataGridViewCellStyle3.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dgRentados.DefaultCellStyle = dataGridViewCellStyle3;
			dgRentados.Dock = DockStyle.Bottom;
			dgRentados.GridColor = Color.Red;
			dgRentados.Location = new Point(0, 481);
			dgRentados.Margin = new Padding(0);
			dgRentados.Name = "dgRentados";
			dgRentados.RowHeadersWidth = 51;
			dgRentados.Size = new Size(971, 352);
			dgRentados.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Agency FB", 18F);
			label2.Location = new Point(12, 116);
			label2.Name = "label2";
			label2.Size = new Size(97, 36);
			label2.TabIndex = 2;
			label2.Text = "Cantidad:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblCantidad
			// 
			lblCantidad.AutoSize = true;
			lblCantidad.Font = new Font("Agency FB", 18F);
			lblCantidad.Location = new Point(116, 116);
			lblCantidad.Margin = new Padding(0);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(26, 36);
			lblCantidad.TabIndex = 3;
			lblCantidad.Text = "0";
			lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// frmRentados
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(10, 25, 40);
			ClientSize = new Size(971, 833);
			Controls.Add(lblCantidad);
			Controls.Add(label2);
			Controls.Add(dgRentados);
			Controls.Add(label1);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmRentados";
			Text = "Rentados";
			Load += frmRentados_Load;
			((System.ComponentModel.ISupportInitialize)dgRentados).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private DataGridView dgRentados;
		private Label label2;
		private Label lblCantidad;
	}
}