namespace ProjectFinalLp2
{
	partial class UCVehiculos
	{
		/// <summary> 
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVehiculos));
			lblBrand = new Label();
			pictImage = new PictureBox();
			lblModel = new Label();
			btnAction = new Button();
			lblPrice = new Label();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			panelContenedor = new Panel();
			lblALert = new Label();
			btnMoreInformation = new Button();
			toolTip = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)pictImage).BeginInit();
			panelContenedor.SuspendLayout();
			SuspendLayout();
			// 
			// lblBrand
			// 
			lblBrand.Anchor = AnchorStyles.None;
			lblBrand.AutoSize = true;
			lblBrand.BackColor = Color.Transparent;
			lblBrand.ForeColor = Color.Black;
			lblBrand.Location = new Point(63, 156);
			lblBrand.Margin = new Padding(2, 0, 2, 0);
			lblBrand.Name = "lblBrand";
			lblBrand.Size = new Size(42, 23);
			lblBrand.TabIndex = 5;
			lblBrand.Text = "Marca";
			// 
			// pictImage
			// 
			pictImage.Anchor = AnchorStyles.None;
			pictImage.Image = (Image)resources.GetObject("pictImage.Image");
			pictImage.InitialImage = (Image)resources.GetObject("pictImage.InitialImage");
			pictImage.Location = new Point(20, 20);
			pictImage.Margin = new Padding(0);
			pictImage.Name = "pictImage";
			pictImage.Size = new Size(275, 136);
			pictImage.SizeMode = PictureBoxSizeMode.CenterImage;
			pictImage.TabIndex = 4;
			pictImage.TabStop = false;
			// 
			// lblModel
			// 
			lblModel.Anchor = AnchorStyles.None;
			lblModel.AutoSize = true;
			lblModel.BackColor = Color.Transparent;
			lblModel.Font = new Font("Agency FB", 14F);
			lblModel.ForeColor = Color.Black;
			lblModel.Location = new Point(58, 175);
			lblModel.Margin = new Padding(0);
			lblModel.Name = "lblModel";
			lblModel.Size = new Size(56, 28);
			lblModel.TabIndex = 9;
			lblModel.Text = "Model";
			// 
			// btnAction
			// 
			btnAction.Anchor = AnchorStyles.None;
			btnAction.BackColor = SystemColors.ControlDark;
			btnAction.FlatStyle = FlatStyle.Flat;
			btnAction.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnAction.ForeColor = Color.SpringGreen;
			btnAction.Location = new Point(190, 197);
			btnAction.Margin = new Padding(0);
			btnAction.Name = "btnAction";
			btnAction.Size = new Size(94, 32);
			btnAction.TabIndex = 10;
			btnAction.Text = "Rentar";
			toolTip.SetToolTip(btnAction, "Rentar");
			btnAction.UseVisualStyleBackColor = false;
			btnAction.Click += btnRentar_Click;
			// 
			// lblPrice
			// 
			lblPrice.Anchor = AnchorStyles.None;
			lblPrice.AutoSize = true;
			lblPrice.Font = new Font("Agency FB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPrice.ForeColor = Color.MediumBlue;
			lblPrice.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
			lblPrice.Location = new Point(218, 156);
			lblPrice.Margin = new Padding(0);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(48, 22);
			lblPrice.TabIndex = 11;
			lblPrice.Text = "Precio";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Agency FB", 11F);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(200, 156);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(18, 24);
			label1.TabIndex = 12;
			label1.Text = "$";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(20, 156);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(42, 23);
			label2.TabIndex = 13;
			label2.Text = "Marca";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Agency FB", 10F);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(20, 179);
			label3.Margin = new Padding(0);
			label3.Name = "label3";
			label3.Size = new Size(38, 22);
			label3.TabIndex = 14;
			label3.Text = "Model";
			// 
			// panelContenedor
			// 
			panelContenedor.BackColor = Color.DarkGray;
			panelContenedor.BorderStyle = BorderStyle.FixedSingle;
			panelContenedor.Controls.Add(lblALert);
			panelContenedor.Controls.Add(btnMoreInformation);
			panelContenedor.Controls.Add(pictImage);
			panelContenedor.Controls.Add(label3);
			panelContenedor.Controls.Add(lblBrand);
			panelContenedor.Controls.Add(label2);
			panelContenedor.Controls.Add(lblModel);
			panelContenedor.Controls.Add(label1);
			panelContenedor.Controls.Add(btnAction);
			panelContenedor.Controls.Add(lblPrice);
			panelContenedor.Dock = DockStyle.Fill;
			panelContenedor.Location = new Point(0, 0);
			panelContenedor.Margin = new Padding(0);
			panelContenedor.MaximumSize = new Size(316, 240);
			panelContenedor.Name = "panelContenedor";
			panelContenedor.Size = new Size(316, 240);
			panelContenedor.TabIndex = 15;
			panelContenedor.Paint += panelContenedor_Paint;
			// 
			// lblALert
			// 
			lblALert.AutoSize = true;
			lblALert.BackColor = Color.Black;
			lblALert.Dock = DockStyle.Top;
			lblALert.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblALert.ForeColor = Color.Red;
			lblALert.Location = new Point(0, 0);
			lblALert.Margin = new Padding(0);
			lblALert.Name = "lblALert";
			lblALert.Size = new Size(38, 16);
			lblALert.TabIndex = 16;
			lblALert.Text = "alert";
			lblALert.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnMoreInformation
			// 
			btnMoreInformation.Anchor = AnchorStyles.None;
			btnMoreInformation.BackColor = Color.Transparent;
			btnMoreInformation.BackgroundImage = (Image)resources.GetObject("btnMoreInformation.BackgroundImage");
			btnMoreInformation.BackgroundImageLayout = ImageLayout.Zoom;
			btnMoreInformation.Location = new Point(13, 210);
			btnMoreInformation.Name = "btnMoreInformation";
			btnMoreInformation.Size = new Size(49, 25);
			btnMoreInformation.TabIndex = 15;
			toolTip.SetToolTip(btnMoreInformation, "Mas Información");
			btnMoreInformation.UseVisualStyleBackColor = false;
			btnMoreInformation.Click += btnMoreInformation_Click;
			// 
			// toolTip
			// 
			toolTip.AutomaticDelay = 50;
			toolTip.IsBalloon = true;
			// 
			// UCVehiculos
			// 
			AutoScaleMode = AutoScaleMode.None;
			AutoValidate = AutoValidate.EnableAllowFocusChange;
			Controls.Add(panelContenedor);
			Font = new Font("Agency FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(0);
			Name = "UCVehiculos";
			Size = new Size(316, 240);
			Load += UCVehiculos_Load;
			((System.ComponentModel.ISupportInitialize)pictImage).EndInit();
			panelContenedor.ResumeLayout(false);
			panelContenedor.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Label lblBrand;
		protected internal PictureBox pictImage;
		private Label lblModel;
		private Button btnAction;
		private Label lblPrice;
		private Label label1;
		private Label label2;
		private Label label3;
		private Panel panelContenedor;
		private Button btnMoreInformation;
		private Label lblALert;
		private ToolTip toolTip;
	}
}
