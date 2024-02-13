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
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			label4 = new Label();
			label7 = new Label();
			label3 = new Label();
			cbUser = new ComboBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(10, 25, 50);
			panel1.Controls.Add(cbUser);
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
			// cbUser
			// 
			cbUser.Anchor = AnchorStyles.None;
			cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
			cbUser.FlatStyle = FlatStyle.Flat;
			cbUser.FormattingEnabled = true;
			cbUser.Location = new Point(28, 459);
			cbUser.Margin = new Padding(0);
			cbUser.Name = "cbUser";
			cbUser.Size = new Size(151, 32);
			cbUser.TabIndex = 21;
			// 
			// frmlogin
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.Frost;
			ClientSize = new Size(782, 753);
			Controls.Add(panel1);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmlogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Logg In";
			TopMost = true;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label4;
		private Label label7;
		private Label label3;
		private ComboBox cbUser;
	}
}