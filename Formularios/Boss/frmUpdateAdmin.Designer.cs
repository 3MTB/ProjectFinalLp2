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
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			label1 = new Label();
			label2 = new Label();
			btnUpdate = new Guna.UI2.WinForms.Guna2Button();
			label3 = new Label();
			tbName = new Guna.UI2.WinForms.Guna2TextBox();
			tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			lblName = new Label();
			lblPassword = new Label();
			label4 = new Label();
			label5 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Agency FB", 16F);
			label1.ForeColor = Color.White;
			label1.Location = new Point(80, 229);
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
			label2.Location = new Point(65, 312);
			label2.Name = "label2";
			label2.Size = new Size(98, 32);
			label2.TabIndex = 3;
			label2.Text = "Password";
			// 
			// btnUpdate
			// 
			btnUpdate.Anchor = AnchorStyles.None;
			btnUpdate.CustomizableEdges = customizableEdges1;
			btnUpdate.DisabledState.BorderColor = Color.DarkGray;
			btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
			btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			btnUpdate.Font = new Font("Agency FB", 16F);
			btnUpdate.ForeColor = Color.White;
			btnUpdate.Location = new Point(121, 414);
			btnUpdate.Margin = new Padding(0);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges2;
			btnUpdate.Size = new Size(225, 56);
			btnUpdate.TabIndex = 4;
			btnUpdate.Text = "Actualizar";
			btnUpdate.Click += btnUpdate_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new Font("Agency FB", 42F);
			label3.ForeColor = Color.White;
			label3.Location = new Point(99, 31);
			label3.Name = "label3";
			label3.Size = new Size(268, 83);
			label3.TabIndex = 5;
			label3.Text = "Actualizar";
			// 
			// tbName
			// 
			tbName.Anchor = AnchorStyles.None;
			tbName.CustomizableEdges = customizableEdges3;
			tbName.DefaultText = "";
			tbName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			tbName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			tbName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			tbName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			tbName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			tbName.Font = new Font("Agency FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			tbName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			tbName.Location = new Point(179, 229);
			tbName.Margin = new Padding(0);
			tbName.MaxLength = 30;
			tbName.Name = "tbName";
			tbName.PasswordChar = '\0';
			tbName.PlaceholderText = "";
			tbName.SelectedText = "";
			tbName.ShadowDecoration.CustomizableEdges = customizableEdges4;
			tbName.Size = new Size(169, 32);
			tbName.TabIndex = 6;
			// 
			// tbPassword
			// 
			tbPassword.Anchor = AnchorStyles.None;
			tbPassword.CustomizableEdges = customizableEdges5;
			tbPassword.DefaultText = "";
			tbPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			tbPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			tbPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			tbPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			tbPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			tbPassword.Font = new Font("Agency FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			tbPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			tbPassword.Location = new Point(179, 312);
			tbPassword.Margin = new Padding(0);
			tbPassword.MaxLength = 15;
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '\0';
			tbPassword.PlaceholderText = "";
			tbPassword.SelectedText = "";
			tbPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
			tbPassword.Size = new Size(169, 37);
			tbPassword.TabIndex = 7;
			// 
			// lblName
			// 
			lblName.Anchor = AnchorStyles.None;
			lblName.AutoSize = true;
			lblName.Font = new Font("Agency FB", 16F);
			lblName.ForeColor = Color.Gray;
			lblName.Location = new Point(108, 133);
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
			lblPassword.Location = new Point(348, 133);
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
			label4.Location = new Point(37, 133);
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
			label5.Location = new Point(228, 133);
			label5.Margin = new Padding(0);
			label5.Name = "label5";
			label5.Size = new Size(102, 32);
			label5.TabIndex = 12;
			label5.Text = "Password:";
			// 
			// frmUpdateAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(10, 25, 49);
			ClientSize = new Size(466, 544);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(lblPassword);
			Controls.Add(lblName);
			Controls.Add(tbPassword);
			Controls.Add(tbName);
			Controls.Add(label3);
			Controls.Add(btnUpdate);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			ImeMode = ImeMode.Alpha;
			Margin = new Padding(3, 4, 3, 4);
			MaximumSize = new Size(466, 544);
			Name = "frmUpdateAdmin";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Actualizar Administrador";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private Label label2;
		private Guna.UI2.WinForms.Guna2Button btnUpdate;
		private Label label3;
		private Guna.UI2.WinForms.Guna2TextBox tbName;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
		private Label lblName;
		private Label lblPassword;
		private Label label4;
		private Label label5;
	}
}