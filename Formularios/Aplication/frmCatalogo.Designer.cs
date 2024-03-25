namespace ProjectFinalLp2.Formularios.Aplication
{
	partial class frmCatalogo
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
			panel1 = new Panel();
			lblCantidad = new Label();
			label1 = new Label();
			panelLayout = new TableLayoutPanel();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(10, 20, 42);
			panel1.Controls.Add(lblCantidad);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(982, 114);
			panel1.TabIndex = 8;
			// 
			// lblCantidad
			// 
			lblCantidad.Anchor = AnchorStyles.Top;
			lblCantidad.AutoSize = true;
			lblCantidad.BackColor = Color.Transparent;
			lblCantidad.Font = new Font("Agency FB", 18F, FontStyle.Bold);
			lblCantidad.Location = new Point(478, 31);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(27, 36);
			lblCantidad.TabIndex = 8;
			lblCantidad.Text = "0";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Agency FB", 18F, FontStyle.Bold);
			label1.Location = new Point(367, 31);
			label1.Name = "label1";
			label1.Size = new Size(249, 36);
			label1.TabIndex = 7;
			label1.Text = "VEHICULOS REGISTRADOS";
			// 
			// panelLayout
			// 
			panelLayout.AutoScroll = true;
			panelLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panelLayout.BackColor = SystemColors.ActiveCaptionText;
			panelLayout.BackgroundImageLayout = ImageLayout.Center;
			panelLayout.ColumnCount = 2;
			panelLayout.ColumnStyles.Add(new ColumnStyle());
			panelLayout.ColumnStyles.Add(new ColumnStyle());
			panelLayout.Dock = DockStyle.Fill;
			panelLayout.ForeColor = SystemColors.InactiveBorder;
			panelLayout.Location = new Point(0, 114);
			panelLayout.Margin = new Padding(0);
			panelLayout.Name = "panelLayout";
			panelLayout.RowCount = 2;
			panelLayout.RowStyles.Add(new RowStyle());
			panelLayout.RowStyles.Add(new RowStyle());
			panelLayout.Size = new Size(982, 839);
			panelLayout.TabIndex = 9;
			// 
			// frmCatalogo
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(982, 953);
			Controls.Add(panelLayout);
			Controls.Add(panel1);
			Font = new Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ForeColor = SystemColors.ActiveBorder;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmCatalogo";
			Tag = "Catalógo";
			Text = "Catalógo";
			Load += frmCatalogo_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel1;
		private Label lblCantidad;
		private Label label1;
		private TableLayoutPanel panelLayout;
	}
}