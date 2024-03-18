namespace ProjectFinalLp2.Formularios.Aplication
{
	partial class frmDefaultHour
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
			label4.BackColor = Color.Transparent;
			label4.FlatStyle = FlatStyle.Flat;
			label4.Font = new Font("Ink Free", 350F, FontStyle.Underline, GraphicsUnit.Document, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(129, 106);
			label4.Name = "label4";
			label4.Size = new Size(607, 173);
			label4.TabIndex = 41;
			label4.Text = "Rent Car";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTimeMain
			// 
			lblTimeMain.Anchor = AnchorStyles.None;
			lblTimeMain.AutoSize = true;
			lblTimeMain.Font = new Font("Agency FB", 150F, FontStyle.Regular, GraphicsUnit.Document);
			lblTimeMain.ForeColor = Color.White;
			lblTimeMain.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			lblTimeMain.Location = new Point(274, 491);
			lblTimeMain.Margin = new Padding(0);
			lblTimeMain.Name = "lblTimeMain";
			lblTimeMain.RightToLeft = RightToLeft.No;
			lblTimeMain.Size = new Size(119, 73);
			lblTimeMain.TabIndex = 37;
			lblTimeMain.Text = "Time";
			// 
			// lblDateMain
			// 
			lblDateMain.Anchor = AnchorStyles.None;
			lblDateMain.AutoSize = true;
			lblDateMain.Font = new Font("Agency FB", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblDateMain.ForeColor = Color.White;
			lblDateMain.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
			lblDateMain.Location = new Point(100, 431);
			lblDateMain.Margin = new Padding(0);
			lblDateMain.Name = "lblDateMain";
			lblDateMain.Size = new Size(116, 73);
			lblDateMain.TabIndex = 38;
			lblDateMain.Text = "Date";
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.None;
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.FlatStyle = FlatStyle.Flat;
			label6.Font = new Font("Ink Free", 225F, FontStyle.Regular, GraphicsUnit.Document);
			label6.ForeColor = Color.Yellow;
			label6.Location = new Point(39, 279);
			label6.Margin = new Padding(0);
			label6.Name = "label6";
			label6.Size = new Size(240, 112);
			label6.TabIndex = 40;
			label6.Text = "Goku";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.None;
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.FlatStyle = FlatStyle.Flat;
			label7.Font = new Font("Ink Free", 250F, FontStyle.Regular, GraphicsUnit.Document);
			label7.ForeColor = Color.Red;
			label7.Location = new Point(355, 270);
			label7.Margin = new Padding(0);
			label7.Name = "label7";
			label7.Size = new Size(327, 124);
			label7.TabIndex = 39;
			label7.Text = "Demon";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// timerDateTime
			// 
			timerDateTime.Enabled = true;
			timerDateTime.Tick += timerDateTime_Tick_1;
			// 
			// frmDefaultHour
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.FromArgb(10, 25, 29);
			ClientSize = new Size(865, 660);
			Controls.Add(label4);
			Controls.Add(lblTimeMain);
			Controls.Add(lblDateMain);
			Controls.Add(label6);
			Controls.Add(label7);
			Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ForeColor = SystemColors.ControlText;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 3, 4, 3);
			MaximumSize = new Size(920, 833);
			Name = "frmDefaultHour";
			StartPosition = FormStartPosition.WindowsDefaultBounds;
			Tag = "Inicio";
			Text = "Inico";
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