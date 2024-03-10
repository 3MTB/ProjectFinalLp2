namespace ProjectFinalLp2
{
	partial class test2
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
			table = new TableLayoutPanel();
			SuspendLayout();
			// 
			// table
			// 
			table.AutoScroll = true;
			table.AutoSize = true;
			table.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			table.ColumnCount = 2;
			table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			table.Dock = DockStyle.Fill;
			table.Location = new Point(0, 0);
			table.Margin = new Padding(0);
			table.Name = "table";
			table.RowCount = 2;
			table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			table.Size = new Size(1065, 752);
			table.TabIndex = 0;
			// 
			// test2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(1065, 752);
			Controls.Add(table);
			Name = "test2";
			Text = "test2";
			Load += test2_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel table;
	}
}