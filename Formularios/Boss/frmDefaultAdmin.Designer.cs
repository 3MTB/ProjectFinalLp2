namespace ProjectFinalLp2.Formularios.Boss
{
	partial class frmDefaultAdmin
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
			label4 = new Label();
			lblTimeMain = new Label();
			lblDateMain = new Label();
			label6 = new Label();
			label7 = new Label();
			timerDateTime = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.BackColor = Color.Black;
			label4.FlatStyle = FlatStyle.Flat;
			label4.Font = new Font("Ink Free", 55.7999954F, FontStyle.Underline, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(58, 139);
			label4.Name = "label4";
			label4.Size = new Size(405, 116);
			label4.TabIndex = 36;
			label4.Text = "Rent Car";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTimeMain
			// 
			lblTimeMain.AutoSize = true;
			lblTimeMain.Font = new Font("Agency FB", 28F);
			lblTimeMain.ForeColor = Color.White;
			lblTimeMain.Location = new Point(416, 543);
			lblTimeMain.Name = "lblTimeMain";
			lblTimeMain.RightToLeft = RightToLeft.No;
			lblTimeMain.Size = new Size(90, 55);
			lblTimeMain.TabIndex = 32;
			lblTimeMain.Text = "Time";
			// 
			// lblDateMain
			// 
			lblDateMain.AutoSize = true;
			lblDateMain.Font = new Font("Agency FB", 28F, FontStyle.Bold);
			lblDateMain.ForeColor = Color.White;
			lblDateMain.Location = new Point(108, 524);
			lblDateMain.Name = "lblDateMain";
			lblDateMain.Size = new Size(96, 57);
			lblDateMain.TabIndex = 33;
			lblDateMain.Text = "Date";
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.None;
			label6.AutoSize = true;
			label6.BackColor = Color.Black;
			label6.FlatStyle = FlatStyle.Flat;
			label6.Font = new Font("Ink Free", 52F);
			label6.ForeColor = Color.Yellow;
			label6.Location = new Point(99, 265);
			label6.Margin = new Padding(0);
			label6.Name = "label6";
			label6.Size = new Size(230, 108);
			label6.TabIndex = 35;
			label6.Text = "Goku";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.None;
			label7.AutoSize = true;
			label7.BackColor = Color.Black;
			label7.FlatStyle = FlatStyle.Flat;
			label7.Font = new Font("Ink Free", 52F);
			label7.ForeColor = Color.Red;
			label7.Location = new Point(427, 330);
			label7.Margin = new Padding(0);
			label7.Name = "label7";
			label7.Size = new Size(284, 108);
			label7.TabIndex = 34;
			label7.Text = "Demon";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// timerDateTime
			// 
			timerDateTime.Enabled = true;
			timerDateTime.Tick += timerDateTime_Tick;
			// 
			// frmDefaultAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(932, 753);
			Controls.Add(label4);
			Controls.Add(lblTimeMain);
			Controls.Add(lblDateMain);
			Controls.Add(label6);
			Controls.Add(label7);
			Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmDefaultAdmin";
			Text = "frmDefaultAdmin";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label4;
		private Label lblTimeMain;
		private Label lblDateMain;
		private Label label6;
		private Label label7;
		private System.Windows.Forms.Timer timerDateTime;
	}
}