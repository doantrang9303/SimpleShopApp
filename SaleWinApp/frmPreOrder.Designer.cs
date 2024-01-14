namespace SaleWinApp
{
	partial class frmPreOrder
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
			IbProductId = new Label();
			label3 = new Label();
			IbCategoryID = new Label();
			IbUnitPrice = new Label();
			txtWeight = new TextBox();
			txtCategoryId = new TextBox();
			btnSave = new Button();
			IbProductName = new Label();
			txtProductName = new TextBox();
			txtUnitPrice = new TextBox();
			txtUnitslnStock = new TextBox();
			IbUnitslnStock = new Label();
			txtProductId = new TextBox();
			SuspendLayout();
			// 
			// IbProductId
			// 
			IbProductId.AutoSize = true;
			IbProductId.Location = new Point(29, 47);
			IbProductId.Name = "IbProductId";
			IbProductId.Size = new Size(97, 25);
			IbProductId.TabIndex = 1;
			IbProductId.Text = "Product ID";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(407, 47);
			label3.Name = "label3";
			label3.Size = new Size(68, 25);
			label3.TabIndex = 2;
			label3.Text = "Weight";
			// 
			// IbCategoryID
			// 
			IbCategoryID.AutoSize = true;
			IbCategoryID.Location = new Point(29, 115);
			IbCategoryID.Name = "IbCategoryID";
			IbCategoryID.Size = new Size(107, 25);
			IbCategoryID.TabIndex = 3;
			IbCategoryID.Text = "Category ID";
			// 
			// IbUnitPrice
			// 
			IbUnitPrice.AutoSize = true;
			IbUnitPrice.Location = new Point(407, 112);
			IbUnitPrice.Name = "IbUnitPrice";
			IbUnitPrice.Size = new Size(86, 25);
			IbUnitPrice.TabIndex = 4;
			IbUnitPrice.Text = "Unit Price";
			// 
			// txtWeight
			// 
			txtWeight.Location = new Point(522, 41);
			txtWeight.Name = "txtWeight";
			txtWeight.Size = new Size(150, 31);
			txtWeight.TabIndex = 7;
			// 
			// txtCategoryId
			// 
			txtCategoryId.Location = new Point(156, 109);
			txtCategoryId.Name = "txtCategoryId";
			txtCategoryId.Size = new Size(218, 31);
			txtCategoryId.TabIndex = 8;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(274, 254);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(112, 34);
			btnSave.TabIndex = 10;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnOrder_Click;
			// 
			// IbProductName
			// 
			IbProductName.AutoSize = true;
			IbProductName.Location = new Point(29, 180);
			IbProductName.Name = "IbProductName";
			IbProductName.Size = new Size(126, 25);
			IbProductName.TabIndex = 11;
			IbProductName.Text = "Product Name";
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(156, 174);
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(218, 31);
			txtProductName.TabIndex = 12;
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(522, 109);
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.Size = new Size(150, 31);
			txtUnitPrice.TabIndex = 13;
			// 
			// txtUnitslnStock
			// 
			txtUnitslnStock.Location = new Point(522, 174);
			txtUnitslnStock.Name = "txtUnitslnStock";
			txtUnitslnStock.Size = new Size(150, 31);
			txtUnitslnStock.TabIndex = 14;
			// 
			// IbUnitslnStock
			// 
			IbUnitslnStock.AutoSize = true;
			IbUnitslnStock.Location = new Point(407, 180);
			IbUnitslnStock.Name = "IbUnitslnStock";
			IbUnitslnStock.Size = new Size(109, 25);
			IbUnitslnStock.TabIndex = 15;
			IbUnitslnStock.Text = "UnitslnStock";
			// 
			// txtProductId
			// 
			txtProductId.Location = new Point(156, 41);
			txtProductId.Margin = new Padding(4);
			txtProductId.Name = "txtProductId";
			txtProductId.Size = new Size(155, 31);
			txtProductId.TabIndex = 6;
			// 
			// frmPreOrder
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(729, 314);
			Controls.Add(txtProductId);
			Controls.Add(IbUnitslnStock);
			Controls.Add(txtUnitslnStock);
			Controls.Add(txtUnitPrice);
			Controls.Add(txtProductName);
			Controls.Add(IbProductName);
			Controls.Add(btnSave);
			Controls.Add(txtCategoryId);
			Controls.Add(txtWeight);
			Controls.Add(IbUnitPrice);
			Controls.Add(IbCategoryID);
			Controls.Add(label3);
			Controls.Add(IbProductId);
			Name = "frmPreOrder";
			Text = "frmAddProduct";
			Load += frmPreOrder_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label IbProductId;
		private Label label3;
		private Label IbCategoryID;
		private Label IbUnitPrice;
		private TextBox txtWeight;
		private TextBox txtCategoryId;
		private Button btnSave;
		private Label IbProductName;
		private TextBox txtProductName;
		private TextBox txtUnitPrice;
		private TextBox txtUnitslnStock;
		private Label IbUnitslnStock;
		private TextBox txtProductId;
	}
}