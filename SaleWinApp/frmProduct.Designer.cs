namespace SaleWinApp
{
	partial class frmProduct
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
			IbCategoryId = new Label();
			IbProductName = new Label();
			IbWeight = new Label();
			IbUnitPrice = new Label();
			IbUnitslnStock = new Label();
			txtProductId = new TextBox();
			txtCategoryId = new TextBox();
			txtProductName = new TextBox();
			txtWeight = new TextBox();
			txtUnitPrice = new TextBox();
			txtUnitslnStock = new TextBox();
			btnLoad = new Button();
			dgvProductList = new DataGridView();
			txtSearch = new TextBox();
			label1 = new Label();
			txtCreate = new Button();
			button1 = new Button();
			searchComboBox = new ComboBox();
			btnDelete = new Button();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
			SuspendLayout();
			// 
			// IbProductId
			// 
			IbProductId.AutoSize = true;
			IbProductId.Location = new Point(48, 392);
			IbProductId.Name = "IbProductId";
			IbProductId.Size = new Size(97, 25);
			IbProductId.TabIndex = 0;
			IbProductId.Text = "Product ID";
			// 
			// IbCategoryId
			// 
			IbCategoryId.AutoSize = true;
			IbCategoryId.Location = new Point(48, 450);
			IbCategoryId.Name = "IbCategoryId";
			IbCategoryId.Size = new Size(107, 25);
			IbCategoryId.TabIndex = 1;
			IbCategoryId.Text = "Category ID";
			// 
			// IbProductName
			// 
			IbProductName.AutoSize = true;
			IbProductName.Location = new Point(48, 511);
			IbProductName.Name = "IbProductName";
			IbProductName.Size = new Size(126, 25);
			IbProductName.TabIndex = 2;
			IbProductName.Text = "Product Name";
			// 
			// IbWeight
			// 
			IbWeight.AutoSize = true;
			IbWeight.Location = new Point(558, 392);
			IbWeight.Name = "IbWeight";
			IbWeight.Size = new Size(68, 25);
			IbWeight.TabIndex = 3;
			IbWeight.Text = "Weight";
			// 
			// IbUnitPrice
			// 
			IbUnitPrice.AutoSize = true;
			IbUnitPrice.Location = new Point(558, 450);
			IbUnitPrice.Name = "IbUnitPrice";
			IbUnitPrice.Size = new Size(86, 25);
			IbUnitPrice.TabIndex = 4;
			IbUnitPrice.Text = "Unit Price";
			// 
			// IbUnitslnStock
			// 
			IbUnitslnStock.AutoSize = true;
			IbUnitslnStock.Location = new Point(549, 511);
			IbUnitslnStock.Name = "IbUnitslnStock";
			IbUnitslnStock.Size = new Size(109, 25);
			IbUnitslnStock.TabIndex = 5;
			IbUnitslnStock.Text = "UnitslnStock";
			// 
			// txtProductId
			// 
			txtProductId.Location = new Point(202, 392);
			txtProductId.Name = "txtProductId";
			txtProductId.Size = new Size(228, 31);
			txtProductId.TabIndex = 6;
			// 
			// txtCategoryId
			// 
			txtCategoryId.Location = new Point(202, 450);
			txtCategoryId.Name = "txtCategoryId";
			txtCategoryId.Size = new Size(228, 31);
			txtCategoryId.TabIndex = 7;
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(202, 511);
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(228, 31);
			txtProductName.TabIndex = 8;
			// 
			// txtWeight
			// 
			txtWeight.Location = new Point(661, 389);
			txtWeight.Name = "txtWeight";
			txtWeight.Size = new Size(222, 31);
			txtWeight.TabIndex = 9;
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(661, 450);
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.Size = new Size(222, 31);
			txtUnitPrice.TabIndex = 10;
			// 
			// txtUnitslnStock
			// 
			txtUnitslnStock.Location = new Point(664, 511);
			txtUnitslnStock.Name = "txtUnitslnStock";
			txtUnitslnStock.Size = new Size(219, 31);
			txtUnitslnStock.TabIndex = 11;
			// 
			// btnLoad
			// 
			btnLoad.Location = new Point(675, 20);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(112, 34);
			btnLoad.TabIndex = 12;
			btnLoad.Text = "Load";
			btnLoad.UseVisualStyleBackColor = true;
			btnLoad.Click += btnLoad_Click;
			// 
			// dgvProductList
			// 
			dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProductList.Location = new Point(12, 74);
			dgvProductList.Name = "dgvProductList";
			dgvProductList.ReadOnly = true;
			dgvProductList.RowHeadersWidth = 62;
			dgvProductList.RowTemplate.Height = 33;
			dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProductList.Size = new Size(945, 280);
			dgvProductList.TabIndex = 13;
			dgvProductList.CellContentClick += dgvProductList_CellContentClick;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(120, 19);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(267, 31);
			txtSearch.TabIndex = 17;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(35, 19);
			label1.Name = "label1";
			label1.Size = new Size(64, 25);
			label1.TabIndex = 18;
			label1.Text = "Search";
			label1.Click += label1_Click;
			// 
			// txtCreate
			// 
			txtCreate.Location = new Point(178, 573);
			txtCreate.Name = "txtCreate";
			txtCreate.Size = new Size(112, 34);
			txtCreate.TabIndex = 19;
			txtCreate.Text = "Create";
			txtCreate.UseVisualStyleBackColor = true;
			txtCreate.Click += txtCreate_Click;
			// 
			// button1
			// 
			button1.Location = new Point(377, 573);
			button1.Name = "button1";
			button1.Size = new Size(112, 34);
			button1.TabIndex = 20;
			button1.Text = "Update";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// searchComboBox
			// 
			searchComboBox.FormattingEnabled = true;
			searchComboBox.Items.AddRange(new object[] { "Search ", "Search By ID", "Search By Category ID", "Search By Name" });
			searchComboBox.Location = new Point(423, 20);
			searchComboBox.Name = "searchComboBox";
			searchComboBox.Size = new Size(182, 33);
			searchComboBox.TabIndex = 21;
			searchComboBox.SelectedIndexChanged += searchComboBox_SelectedIndexChanged_1;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(596, 573);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(112, 34);
			btnDelete.TabIndex = 22;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// button2
			// 
			button2.Location = new Point(793, 571);
			button2.Name = "button2";
			button2.Size = new Size(112, 34);
			button2.TabIndex = 23;
			button2.Text = "Order";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// frmProduct
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(969, 637);
			Controls.Add(button2);
			Controls.Add(btnDelete);
			Controls.Add(searchComboBox);
			Controls.Add(button1);
			Controls.Add(txtCreate);
			Controls.Add(label1);
			Controls.Add(txtSearch);
			Controls.Add(dgvProductList);
			Controls.Add(btnLoad);
			Controls.Add(txtUnitslnStock);
			Controls.Add(txtUnitPrice);
			Controls.Add(txtWeight);
			Controls.Add(txtProductName);
			Controls.Add(txtCategoryId);
			Controls.Add(txtProductId);
			Controls.Add(IbUnitslnStock);
			Controls.Add(IbUnitPrice);
			Controls.Add(IbWeight);
			Controls.Add(IbProductName);
			Controls.Add(IbCategoryId);
			Controls.Add(IbProductId);
			Name = "frmProduct";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmProduct";
			Load += frmProduct_Load;
			((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label IbProductId;
		private Label IbCategoryId;
		private Label IbProductName;
		private Label IbWeight;
		private Label IbUnitPrice;
		private Label IbUnitslnStock;
		private TextBox txtProductId;
		private TextBox txtCategoryId;
		private TextBox txtProductName;
		private TextBox txtWeight;
		private TextBox txtUnitPrice;
		private TextBox txtUnitslnStock;
		private Button btnLoad;
		private DataGridView dgvProductList;
		private TextBox txtSearch;
		private Label label1;
		private Button txtCreate;
		private Button button1;
		private ComboBox searchComboBox;
		private Button btnDelete;
		private Button button2;
	}
}