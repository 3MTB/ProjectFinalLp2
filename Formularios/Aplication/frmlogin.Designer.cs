namespace ProjectFinalLp2.Formularios.Aplication
{
	partial class frmlogin
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
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			panel1 = new Panel();
			btnOut = new Button();
			cbRoll = new ComboBox();
			label4 = new Label();
			label7 = new Label();
			label3 = new Label();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			cbUser = new ComboBox();
			btnEntrar = new Button();
			pgbHorizontal = new Guna.UI2.WinForms.Guna2ProgressBar();
			pgbVertical = new Guna.UI2.WinForms.Guna2VProgressBar();
			timerAnimation = new System.Windows.Forms.Timer(components);
			tbPassword = new TextBox();
			label2 = new Label();
			btnRegistrar = new Button();
			lblUser = new Label();
			lblAlert = new Label();
			toolTip = new ToolTip(components);
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(10, 25, 50);
			panel1.Controls.Add(btnOut);
			panel1.Controls.Add(cbRoll);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(218, 753);
			panel1.TabIndex = 0;
			// 
			// btnOut
			// 
			btnOut.BackColor = Color.Transparent;
			btnOut.FlatStyle = FlatStyle.Flat;
			btnOut.Font = new Font("Agency FB", 15F);
			btnOut.ForeColor = Color.White;
			btnOut.Location = new Point(23, 682);
			btnOut.Margin = new Padding(0);
			btnOut.Name = "btnOut";
			btnOut.Size = new Size(118, 44);
			btnOut.TabIndex = 22;
			btnOut.Text = "Out";
			toolTip.SetToolTip(btnOut, "Salir");
			btnOut.UseVisualStyleBackColor = false;
			btnOut.Click += btnOut_Click;
			// 
			// cbRoll
			// 
			cbRoll.Anchor = AnchorStyles.None;
			cbRoll.DropDownStyle = ComboBoxStyle.DropDownList;
			cbRoll.FlatStyle = FlatStyle.Flat;
			cbRoll.FormattingEnabled = true;
			cbRoll.Location = new Point(28, 459);
			cbRoll.Margin = new Padding(0);
			cbRoll.Name = "cbRoll";
			cbRoll.Size = new Size(151, 32);
			cbRoll.TabIndex = 21;
			toolTip.SetToolTip(cbRoll, "Cambiar Tipo Usuario");
			cbRoll.SelectedIndexChanged += cbRoll_SelectedIndexChanged;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.FlatStyle = FlatStyle.Flat;
			label4.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Yellow;
			label4.Location = new Point(21, 321);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(79, 34);
			label4.TabIndex = 19;
			label4.Text = "Goku";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.None;
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.FlatStyle = FlatStyle.Flat;
			label7.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.Red;
			label7.Location = new Point(100, 321);
			label7.Margin = new Padding(0);
			label7.Name = "label7";
			label7.Size = new Size(97, 34);
			label7.TabIndex = 18;
			label7.Text = "Demon";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Ink Free", 19.7999973F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(28, 261);
			label3.Name = "label3";
			label3.Size = new Size(151, 41);
			label3.TabIndex = 20;
			label3.Text = "Rent Car";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.logo;
			pictureBox1.Location = new Point(3, 34);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(168, 98);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Agency FB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(371, 117);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(148, 72);
			label1.TabIndex = 1;
			label1.Text = "Log In";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cbUser
			// 
			cbUser.Anchor = AnchorStyles.None;
			cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
			cbUser.FlatStyle = FlatStyle.Flat;
			cbUser.Font = new Font("Agency FB", 15F);
			cbUser.FormattingEnabled = true;
			cbUser.Location = new Point(466, 324);
			cbUser.Margin = new Padding(0);
			cbUser.Name = "cbUser";
			cbUser.Size = new Size(151, 37);
			cbUser.TabIndex = 2;
			toolTip.SetToolTip(cbUser, "Selecciona el Usuario");
			// 
			// btnEntrar
			// 
			btnEntrar.Anchor = AnchorStyles.None;
			btnEntrar.BackColor = Color.Transparent;
			btnEntrar.FlatStyle = FlatStyle.Flat;
			btnEntrar.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnEntrar.ForeColor = Color.White;
			btnEntrar.Location = new Point(421, 515);
			btnEntrar.Margin = new Padding(0);
			btnEntrar.Name = "btnEntrar";
			btnEntrar.Size = new Size(147, 56);
			btnEntrar.TabIndex = 4;
			btnEntrar.Text = "Entrar";
			toolTip.SetToolTip(btnEntrar, "Ingresar");
			btnEntrar.UseVisualStyleBackColor = false;
			btnEntrar.Click += btnEntrar_Click;
			// 
			// pgbHorizontal
			// 
			pgbHorizontal.Anchor = AnchorStyles.None;
			pgbHorizontal.BackColor = Color.Transparent;
			pgbHorizontal.BorderColor = Color.Transparent;
			pgbHorizontal.CustomizableEdges = customizableEdges1;
			pgbHorizontal.FillColor = Color.Transparent;
			pgbHorizontal.ForeColor = Color.LightGreen;
			pgbHorizontal.Location = new Point(244, 34);
			pgbHorizontal.Name = "pgbHorizontal";
			pgbHorizontal.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
			pgbHorizontal.ProgressColor = Color.Transparent;
			pgbHorizontal.ProgressColor2 = Color.FromArgb(25, 10, 92);
			pgbHorizontal.ShadowDecoration.CustomizableEdges = customizableEdges2;
			pgbHorizontal.Size = new Size(375, 10);
			pgbHorizontal.Style = ProgressBarStyle.Continuous;
			pgbHorizontal.TabIndex = 5;
			pgbHorizontal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// pgbVertical
			// 
			pgbVertical.Anchor = AnchorStyles.None;
			pgbVertical.BackColor = Color.Transparent;
			pgbVertical.CustomizableEdges = customizableEdges3;
			pgbVertical.FillColor = Color.Transparent;
			pgbVertical.Location = new Point(258, 12);
			pgbVertical.Margin = new Padding(0);
			pgbVertical.Name = "pgbVertical";
			pgbVertical.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
			pgbVertical.ProgressColor = Color.FromArgb(25, 10, 92);
			pgbVertical.ProgressColor2 = Color.Transparent;
			pgbVertical.ShadowDecoration.CustomizableEdges = customizableEdges4;
			pgbVertical.Size = new Size(10, 614);
			pgbVertical.Style = ProgressBarStyle.Continuous;
			pgbVertical.TabIndex = 6;
			pgbVertical.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// timerAnimation
			// 
			timerAnimation.Enabled = true;
			timerAnimation.Tick += timerAnimation_Tick;
			// 
			// tbPassword
			// 
			tbPassword.Anchor = AnchorStyles.None;
			tbPassword.Location = new Point(478, 403);
			tbPassword.MaxLength = 15;
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(125, 31);
			tbPassword.TabIndex = 7;
			toolTip.SetToolTip(tbPassword, "Ingresa la contraseña");
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Location = new Point(371, 403);
			label2.Name = "label2";
			label2.Size = new Size(68, 24);
			label2.TabIndex = 8;
			label2.Text = "Password";
			// 
			// btnRegistrar
			// 
			btnRegistrar.Anchor = AnchorStyles.None;
			btnRegistrar.BackColor = Color.Transparent;
			btnRegistrar.FlatStyle = FlatStyle.Flat;
			btnRegistrar.Font = new Font("Agency FB", 12F);
			btnRegistrar.ForeColor = Color.White;
			btnRegistrar.Location = new Point(533, 682);
			btnRegistrar.Margin = new Padding(0);
			btnRegistrar.Name = "btnRegistrar";
			btnRegistrar.Size = new Size(197, 44);
			btnRegistrar.TabIndex = 9;
			btnRegistrar.Text = "Registrar";
			toolTip.SetToolTip(btnRegistrar, "Registrar");
			btnRegistrar.UseVisualStyleBackColor = false;
			btnRegistrar.Click += btnRegistrar_Click;
			// 
			// lblUser
			// 
			lblUser.Anchor = AnchorStyles.None;
			lblUser.AutoSize = true;
			lblUser.BackColor = Color.Transparent;
			lblUser.FlatStyle = FlatStyle.Flat;
			lblUser.ForeColor = SystemColors.ActiveBorder;
			lblUser.Location = new Point(421, 210);
			lblUser.Name = "lblUser";
			lblUser.Size = new Size(41, 24);
			lblUser.TabIndex = 10;
			lblUser.Text = "USER";
			lblUser.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblAlert
			// 
			lblAlert.Anchor = AnchorStyles.None;
			lblAlert.AutoSize = true;
			lblAlert.BackColor = Color.Transparent;
			lblAlert.FlatStyle = FlatStyle.Flat;
			lblAlert.Font = new Font("Agency FB", 15F);
			lblAlert.ForeColor = Color.AliceBlue;
			lblAlert.Location = new Point(222, 57);
			lblAlert.Margin = new Padding(0);
			lblAlert.Name = "lblAlert";
			lblAlert.Size = new Size(56, 29);
			lblAlert.TabIndex = 11;
			lblAlert.Text = "ALERT";
			lblAlert.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// toolTip
			// 
			toolTip.AutomaticDelay = 200;
			toolTip.IsBalloon = true;
			// 
			// frmlogin
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.Frost;
			ClientSize = new Size(782, 753);
			Controls.Add(lblAlert);
			Controls.Add(lblUser);
			Controls.Add(btnRegistrar);
			Controls.Add(label2);
			Controls.Add(tbPassword);
			Controls.Add(pgbVertical);
			Controls.Add(pgbHorizontal);
			Controls.Add(btnEntrar);
			Controls.Add(cbUser);
			Controls.Add(label1);
			Controls.Add(panel1);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			HelpButton = true;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmlogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Log In";
			TopMost = true;
			Load += frmlogin_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label4;
		private Label label7;
		private Label label3;
		private ComboBox cbRoll;
		private Label label1;
		private ComboBox cbUser;
		private Button btnEntrar;
		private Guna.UI2.WinForms.Guna2ProgressBar pgbHorizontal;
		private Guna.UI2.WinForms.Guna2VProgressBar pgbVertical;
		private System.Windows.Forms.Timer timerAnimation;
		private Button btnOut;
		private TextBox tbPassword;
		private Label label2;
		private Button btnRegistrar;
		private Label lblUser;
		private Label lblAlert;
		private ToolTip toolTip;
	}
}