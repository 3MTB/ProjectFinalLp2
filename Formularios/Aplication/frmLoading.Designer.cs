namespace ProjectFinalLp2.Formularios.Aplication
{
	partial class frmLoading
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
			label3 = new Label();
			label4 = new Label();
			label7 = new Label();
			progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
			timerAnimation = new System.Windows.Forms.Timer(components);
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Ink Free", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(164, 303);
			label3.Name = "label3";
			label3.Size = new Size(270, 75);
			label3.TabIndex = 17;
			label3.Text = "Rent Car";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.FlatStyle = FlatStyle.Flat;
			label4.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Yellow;
			label4.Location = new Point(134, 407);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(129, 58);
			label4.TabIndex = 16;
			label4.Text = "Goku";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.None;
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.FlatStyle = FlatStyle.Flat;
			label7.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.Red;
			label7.Location = new Point(263, 395);
			label7.Margin = new Padding(0);
			label7.Name = "label7";
			label7.Size = new Size(203, 75);
			label7.TabIndex = 15;
			label7.Text = "Demon";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// progressBar
			// 
			progressBar.BackColor = Color.Transparent;
			progressBar.BorderColor = Color.Transparent;
			progressBar.BorderRadius = 10;
			progressBar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			progressBar.CustomizableEdges = customizableEdges1;
			progressBar.Dock = DockStyle.Bottom;
			progressBar.FillColor = Color.Transparent;
			progressBar.Font = new Font("Agency FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			progressBar.ForeColor = Color.Black;
			progressBar.Location = new Point(0, 562);
			progressBar.Margin = new Padding(0);
			progressBar.Name = "progressBar";
			progressBar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
			progressBar.ProgressColor = Color.Crimson;
			progressBar.ProgressColor2 = Color.SteelBlue;
			progressBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
			progressBar.ShowText = true;
			progressBar.Size = new Size(600, 38);
			progressBar.TabIndex = 18;
			progressBar.TextAlign = HorizontalAlignment.Right;
			progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
			progressBar.UseTransparentBackground = true;
			progressBar.Value = 60;
			// 
			// timerAnimation
			// 
			timerAnimation.Enabled = true;
			timerAnimation.Tick += timerAnimation_Tick;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = Properties.Resources.logo;
			pictureBox1.Location = new Point(133, 130);
			pictureBox1.Margin = new Padding(0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(335, 173);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 19;
			pictureBox1.TabStop = false;
			// 
			// frmLoading
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = SystemColors.ActiveCaptionText;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(600, 600);
			Controls.Add(pictureBox1);
			Controls.Add(progressBar);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(label7);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmLoading";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cargando";
			TopMost = true;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private Label label4;
		private Label label7;
		private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
		private System.Windows.Forms.Timer timerAnimation;
		private PictureBox pictureBox1;
	}
}