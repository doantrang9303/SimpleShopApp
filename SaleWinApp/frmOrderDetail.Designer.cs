namespace SaleWinApp
{
	partial class frmOrderDetail
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
			IbOrderId = new Label();
			IbProductId = new Label();
			IbUnitPrice = new Label();
			dgvOrderDetail = new DataGridView();
			btnLoad = new Button();
			btnOrder = new Button();
			IbQuantity = new Label();
			Discount = new Label();
			btnDelete = new Button();
			btnUpdate = new Button();
			txtOrderId = new TextBox();
			txtProductId = new TextBox();
			txtUnitPrice = new TextBox();
			txtQuantity = new TextBox();
			txtDiscount = new TextBox();
			txtSearch = new TextBox();
			searchComboBox = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
			SuspendLayout();
			// 
			// IbOrderId
			// 
			IbOrderId.AutoSize = true;
			IbOrderId.Location = new Point(104, 330);
			IbOrderId.Name = "IbOrderId";
			IbOrderId.Size = new Size(81, 25);
			IbOrderId.TabIndex = 0;
			IbOrderId.Text = "Order ID";
			IbOrderId.Click += label1_Click;
			// 
			// IbProductId
			// 
			IbProductId.AutoSize = true;
			IbProductId.Location = new Point(107, 374);
			IbProductId.Name = "IbProductId";
			IbProductId.Size = new Size(97, 25);
			IbProductId.TabIndex = 1;
			IbProductId.Text = "Product ID";
			// 
			// IbUnitPrice
			// 
			IbUnitPrice.AutoSize = true;
			IbUnitPrice.Location = new Point(111, 419);
			IbUnitPrice.Name = "IbUnitPrice";
			IbUnitPrice.Size = new Size(86, 25);
			IbUnitPrice.TabIndex = 2;
			IbUnitPrice.Text = "Unit Price";
			// 
			// dgvOrderDetail
			// 
			dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvOrderDetail.Location = new Point(12, 79);
			dgvOrderDetail.Name = "dgvOrderDetail";
			dgvOrderDetail.ReadOnly = true;
			dgvOrderDetail.RowHeadersWidth = 62;
			dgvOrderDetail.RowTemplate.Height = 33;
			dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvOrderDetail.Size = new Size(1015, 224);
			dgvOrderDetail.TabIndex = 3;
			dgvOrderDetail.CellContentClick += dgvOrderDetail_CellContentClick;
			// 
			// btnLoad
			// 
			btnLoad.Location = new Point(738, 22);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(112, 34);
			btnLoad.TabIndex = 4;
			btnLoad.Text = "Load";
			btnLoad.UseVisualStyleBackColor = true;
			btnLoad.Click += btnLoad_Click;
			// 
			// btnOrder
			// 
			btnOrder.Location = new Point(702, 484);
			btnOrder.Name = "btnOrder";
			btnOrder.Size = new Size(112, 34);
			btnOrder.TabIndex = 5;
			btnOrder.Text = "Cancel";
			btnOrder.UseVisualStyleBackColor = true;
			btnOrder.Click += btnOrder_Click;
			// 
			// IbQuantity
			// 
			IbQuantity.AutoSize = true;
			IbQuantity.Location = new Point(626, 333);
			IbQuantity.Name = "IbQuantity";
			IbQuantity.Size = new Size(80, 25);
			IbQuantity.TabIndex = 6;
			IbQuantity.Text = "Quantity";
			// 
			// Discount
			// 
			Discount.AutoSize = true;
			Discount.Location = new Point(626, 380);
			Discount.Name = "Discount";
			Discount.Size = new Size(82, 25);
			Discount.TabIndex = 7;
			Discount.Text = "Discount";
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(212, 484);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(112, 34);
			btnDelete.TabIndex = 8;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(474, 484);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(112, 34);
			btnUpdate.TabIndex = 9;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnReturn_Click;
			// 
			// txtOrderId
			// 
			txtOrderId.Location = new Point(212, 327);
			txtOrderId.Name = "txtOrderId";
			txtOrderId.Size = new Size(228, 31);
			txtOrderId.TabIndex = 10;
			// 
			// txtProductId
			// 
			txtProductId.Location = new Point(212, 371);
			txtProductId.Name = "txtProductId";
			txtProductId.Size = new Size(228, 31);
			txtProductId.TabIndex = 11;
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(212, 419);
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.Size = new Size(228, 31);
			txtUnitPrice.TabIndex = 12;
			// 
			// txtQuantity
			// 
			txtQuantity.Location = new Point(738, 327);
			txtQuantity.Name = "txtQuantity";
			txtQuantity.Size = new Size(219, 31);
			txtQuantity.TabIndex = 13;
			// 
			// txtDiscount
			// 
			txtDiscount.Location = new Point(738, 374);
			txtDiscount.Name = "txtDiscount";
			txtDiscount.Size = new Size(219, 31);
			txtDiscount.TabIndex = 14;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(139, 25);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(301, 31);
			txtSearch.TabIndex = 15;
			// 
			// searchComboBox
			// 
			searchComboBox.FormattingEnabled = true;
			searchComboBox.Items.AddRange(new object[] { "Search", "Search By Order ID", "Search By Product ID" });
			searchComboBox.Location = new Point(468, 25);
			searchComboBox.Name = "searchComboBox";
			searchComboBox.Size = new Size(215, 33);
			searchComboBox.TabIndex = 17;
			searchComboBox.SelectedIndexChanged += searchComboBox_SelectedIndexChanged;
			// 
			// frmOrderDetail
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1039, 557);
			Controls.Add(searchComboBox);
			Controls.Add(txtSearch);
			Controls.Add(txtDiscount);
			Controls.Add(txtQuantity);
			Controls.Add(txtUnitPrice);
			Controls.Add(txtProductId);
			Controls.Add(txtOrderId);
			Controls.Add(btnUpdate);
			Controls.Add(btnDelete);
			Controls.Add(Discount);
			Controls.Add(IbQuantity);
			Controls.Add(btnOrder);
			Controls.Add(btnLoad);
			Controls.Add(dgvOrderDetail);
			Controls.Add(IbUnitPrice);
			Controls.Add(IbProductId);
			Controls.Add(IbOrderId);
			Name = "frmOrderDetail";
			Text = "frmOrderDetail";
			Load += frmOrderDetail_Load;
			((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label IbOrderId;
		private Label IbProductId;
		private Label IbUnitPrice;
		private DataGridView dgvOrderDetail;
		private Button btnLoad;
		private Button btnOrder;
		private Label IbQuantity;
		private Label Discount;
		private Button btnDelete;
		private Button btnUpdate;
		private TextBox txtOrderId;
		private TextBox txtProductId;
		private TextBox txtUnitPrice;
		private TextBox txtQuantity;
		private TextBox txtDiscount;
		private TextBox txtSearch;
		private ComboBox searchComboBox;
	}
}