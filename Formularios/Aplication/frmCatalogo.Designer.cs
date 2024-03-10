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
			button1 = new Button();
			panelMain = new Panel();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(108, 13);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 1;
			button1.Text = "CARGAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panelMain
			// 
			panelMain.BackColor = SystemColors.MenuText;
			panelMain.Dock = DockStyle.Right;
			panelMain.Location = new Point(838, 0);
			panelMain.Margin = new Padding(0);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(635, 723);
			panelMain.TabIndex = 2;
			// 
			// frmCatalogo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(1473, 723);
			Controls.Add(panelMain);
			Controls.Add(button1);
			ForeColor = SystemColors.ActiveBorder;
			Name = "frmCatalogo";
			Text = "frmCatalogo";
			Load += frmCatalogo_Load;
			ResumeLayout(false);
		}

		#endregion
		private Button button1;
		private Panel panelMain;
	}
}