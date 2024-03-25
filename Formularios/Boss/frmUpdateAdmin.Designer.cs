namespace ProjectFinalLp2.Formularios.Boss
{
	partial class frmUpdateAdmin
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			lblName = new Label();
			lblPassword = new Label();
			label4 = new Label();
			label5 = new Label();
			tbName = new TextBox();
			tbPassword = new TextBox();
			panel1 = new Panel();
			panel2 = new Panel();
			btnUpdate = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Agency FB", 16F);
			label1.ForeColor = Color.White;
			label1.Location = new Point(368, 373);
			label1.Name = "label1";
			label1.Size = new Size(80, 32);
			label1.TabIndex = 2;
			label1.Text = "Nombre";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new Font("Agency FB", 16F);
			label2.ForeColor = Color.White;
			label2.Location = new Point(353, 456);
			label2.Name = "label2";
			label2.Size = new Size(98, 32);
			label2.TabIndex = 3;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new Font("Agency FB", 42F);
			label3.ForeColor = Color.White;
			label3.Location = new Point(382, 175);
			label3.Name = "label3";
			label3.Size = new Size(268, 83);
			label3.TabIndex = 5;
			label3.Text = "Actualizar";
			// 
			// lblName
			// 
			lblName.Anchor = AnchorStyles.None;
			lblName.AutoSize = true;
			lblName.Font = new Font("Agency FB", 16F);
			lblName.ForeColor = Color.Gray;
			lblName.Location = new Point(391, 277);
			lblName.Name = "lblName";
			lblName.Size = new Size(0, 32);
			lblName.TabIndex = 8;
			lblName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblPassword
			// 
			lblPassword.Anchor = AnchorStyles.None;
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Agency FB", 16F);
			lblPassword.ForeColor = Color.DimGray;
			lblPassword.Location = new Point(631, 277);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(0, 32);
			lblPassword.TabIndex = 10;
			lblPassword.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.Font = new Font("Agency FB", 16F);
			label4.ForeColor = SystemColors.ControlDarkDark;
			label4.Location = new Point(320, 277);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(65, 32);
			label4.TabIndex = 11;
			label4.Text = "Name:";
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.None;
			label5.AutoSize = true;
			label5.Font = new Font("Agency FB", 16F);
			label5.ForeColor = SystemColors.ControlDarkDark;
			label5.Location = new Point(511, 277);
			label5.Margin = new Padding(0);
			label5.Name = "label5";
			label5.Size = new Size(102, 32);
			label5.TabIndex = 12;
			label5.Text = "Password:";
			// 
			// tbName
			// 
			tbName.Anchor = AnchorStyles.None;
			tbName.Font = new Font("Agency FB", 14F);
			tbName.Location = new Point(463, 373);
			tbName.Margin = new Padding(0);
			tbName.MaxLength = 30;
			tbName.Name = "tbName";
			tbName.Size = new Size(155, 35);
			tbName.TabIndex = 13;
			// 
			// tbPassword
			// 
			tbPassword.Anchor = AnchorStyles.None;
			tbPassword.Font = new Font("Agency FB", 14F);
			tbPassword.Location = new Point(463, 457);
			tbPassword.Margin = new Padding(0);
			tbPassword.MaxLength = 14;
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(155, 35);
			tbPassword.TabIndex = 14;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(52, 55, 75);
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Dock = DockStyle.Left;
			panel1.ForeColor = Color.Red;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(0);
			panel1.Name = "panel1";
			panel1.Size = new Size(80, 833);
			panel1.TabIndex = 17;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(181, 192, 208);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(80, 0);
			panel2.Margin = new Padding(0);
			panel2.Name = "panel2";
			panel2.Size = new Size(80, 833);
			panel2.TabIndex = 18;
			// 
			// btnUpdate
			// 
			btnUpdate.Anchor = AnchorStyles.None;
			btnUpdate.BackColor = Color.FromArgb(94, 148, 255);
			btnUpdate.FlatAppearance.BorderSize = 0;
			btnUpdate.FlatStyle = FlatStyle.Flat;
			btnUpdate.Font = new Font("Agency FB", 18F);
			btnUpdate.ForeColor = Color.White;
			btnUpdate.Location = new Point(362, 569);
			btnUpdate.Margin = new Padding(0);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(247, 79);
			btnUpdate.TabIndex = 19;
			btnUpdate.Text = "Actualizar";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click_1;
			// 
			// frmUpdateAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(10, 25, 49);
			ClientSize = new Size(971, 833);
			Controls.Add(btnUpdate);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(tbPassword);
			Controls.Add(tbName);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(lblPassword);
			Controls.Add(lblName);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			ImeMode = ImeMode.Alpha;
			Margin = new Padding(3, 4, 3, 4);
			MaximumSize = new Size(971, 833);
			Name = "frmUpdateAdmin";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Actualizar Administrador";
			Load += frmUpdateAdmin_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private Label label2;
		private Label label3;
		private Label lblName;
		private Label lblPassword;
		private Label label4;
		private Label label5;
		private TextBox tbName;
		private TextBox tbPassword;
		private Panel panel1;
		private Panel panel2;
		private Button btnUpdate;
	}
}