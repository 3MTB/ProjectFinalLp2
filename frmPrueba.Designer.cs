namespace ProjectFinalLp2
{
	partial class frmPrueba
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
			tbName = new TextBox();
			cbRegistroName = new ComboBox();
			btnEnviar = new Button();
			tbPassword = new TextBox();
			label1 = new Label();
			dgData = new DataGridView();
			btnDelete = new Button();
			btnUpdate = new Button();
			((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
			SuspendLayout();
			// 
			// tbName
			// 
			tbName.Location = new Point(273, 135);
			tbName.Name = "tbName";
			tbName.Size = new Size(125, 27);
			tbName.TabIndex = 0;
			// 
			// cbRegistroName
			// 
			cbRegistroName.DropDownStyle = ComboBoxStyle.DropDownList;
			cbRegistroName.FlatStyle = FlatStyle.Popup;
			cbRegistroName.FormattingEnabled = true;
			cbRegistroName.Location = new Point(591, 75);
			cbRegistroName.Name = "cbRegistroName";
			cbRegistroName.Size = new Size(151, 28);
			cbRegistroName.TabIndex = 1;
			// 
			// btnEnviar
			// 
			btnEnviar.FlatStyle = FlatStyle.Flat;
			btnEnviar.Font = new Font("Segoe UI", 14F);
			btnEnviar.Location = new Point(420, 224);
			btnEnviar.Name = "btnEnviar";
			btnEnviar.Size = new Size(106, 65);
			btnEnviar.TabIndex = 2;
			btnEnviar.Text = "Add";
			btnEnviar.UseVisualStyleBackColor = true;
			btnEnviar.Click += btnEnviar_Click;
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(273, 194);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(125, 27);
			tbPassword.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(176, 201);
			label1.Name = "label1";
			label1.Size = new Size(70, 20);
			label1.TabIndex = 4;
			label1.Text = "Password";
			// 
			// dgData
			// 
			dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgData.Dock = DockStyle.Bottom;
			dgData.Location = new Point(0, 295);
			dgData.Name = "dgData";
			dgData.RowHeadersWidth = 51;
			dgData.Size = new Size(800, 155);
			dgData.TabIndex = 5;
			// 
			// btnDelete
			// 
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.Font = new Font("Segoe UI Black", 14F);
			btnDelete.ForeColor = Color.OrangeRed;
			btnDelete.Location = new Point(650, 201);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(108, 40);
			btnDelete.TabIndex = 6;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.FlatStyle = FlatStyle.Flat;
			btnUpdate.Font = new Font("Segoe UI", 12F);
			btnUpdate.ForeColor = Color.SteelBlue;
			btnUpdate.Location = new Point(650, 142);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(113, 53);
			btnUpdate.TabIndex = 7;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// frmPrueba
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(800, 450);
			Controls.Add(btnUpdate);
			Controls.Add(btnDelete);
			Controls.Add(dgData);
			Controls.Add(label1);
			Controls.Add(tbPassword);
			Controls.Add(btnEnviar);
			Controls.Add(cbRegistroName);
			Controls.Add(tbName);
			ForeColor = Color.BurlyWood;
			Name = "frmPrueba";
			Text = "frmPrueba";
			((System.ComponentModel.ISupportInitialize)dgData).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbName;
		private ComboBox cbRegistroName;
		private Button btnEnviar;
		private TextBox tbPassword;
		private Label label1;
		private DataGridView dgData;
		private Button btnDelete;
		private Button btnUpdate;
	}
}