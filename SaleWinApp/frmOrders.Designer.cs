namespace SaleWinApp
{
	partial class frmOrders
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
			dgvOrder = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtOrderId = new TextBox();
			txtMemberId = new TextBox();
			txtFreight = new TextBox();
			txtOrderDate = new DateTimePicker();
			txtRequiredDate = new DateTimePicker();
			txtShippedDate = new DateTimePicker();
			btnSave = new Button();
			newbutton = new Button();
			btnAdd = new Button();
			((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
			SuspendLayout();
			// 
			// dgvOrder
			// 
			dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvOrder.Location = new Point(29, 39);
			dgvOrder.Name = "dgvOrder";
			dgvOrder.RowHeadersWidth = 62;
			dgvOrder.RowTemplate.Height = 33;
			dgvOrder.Size = new Size(919, 262);
			dgvOrder.TabIndex = 0;
			dgvOrder.CellContentClick += txtOrder_CellContentClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 366);
			label1.Name = "label1";
			label1.Size = new Size(74, 25);
			label1.TabIndex = 1;
			label1.Text = "OrderId";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(29, 422);
			label2.Name = "label2";
			label2.Size = new Size(95, 25);
			label2.TabIndex = 2;
			label2.Text = "MemberId";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(29, 471);
			label3.Name = "label3";
			label3.Size = new Size(95, 25);
			label3.TabIndex = 3;
			label3.Text = "OrderDate";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(476, 360);
			label4.Name = "label4";
			label4.Size = new Size(119, 25);
			label4.TabIndex = 4;
			label4.Text = "RequiredDate";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(480, 412);
			label5.Name = "label5";
			label5.Size = new Size(115, 25);
			label5.TabIndex = 5;
			label5.Text = "ShippedDate";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(480, 471);
			label6.Name = "label6";
			label6.Size = new Size(67, 25);
			label6.TabIndex = 6;
			label6.Text = "Freight";
			// 
			// txtOrderId
			// 
			txtOrderId.Location = new Point(130, 360);
			txtOrderId.Name = "txtOrderId";
			txtOrderId.Size = new Size(150, 31);
			txtOrderId.TabIndex = 7;
			// 
			// txtMemberId
			// 
			txtMemberId.Location = new Point(130, 416);
			txtMemberId.Name = "txtMemberId";
			txtMemberId.Size = new Size(150, 31);
			txtMemberId.TabIndex = 8;
			// 
			// txtFreight
			// 
			txtFreight.Location = new Point(620, 465);
			txtFreight.Name = "txtFreight";
			txtFreight.Size = new Size(150, 31);
			txtFreight.TabIndex = 9;
			// 
			// txtOrderDate
			// 
			txtOrderDate.Location = new Point(130, 465);
			txtOrderDate.Name = "txtOrderDate";
			txtOrderDate.Size = new Size(300, 31);
			txtOrderDate.TabIndex = 10;
			// 
			// txtRequiredDate
			// 
			txtRequiredDate.Location = new Point(620, 358);
			txtRequiredDate.Name = "txtRequiredDate";
			txtRequiredDate.Size = new Size(300, 31);
			txtRequiredDate.TabIndex = 11;
			// 
			// txtShippedDate
			// 
			txtShippedDate.Location = new Point(620, 407);
			txtShippedDate.Name = "txtShippedDate";
			txtShippedDate.Size = new Size(300, 31);
			txtShippedDate.TabIndex = 12;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(209, 529);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(112, 34);
			btnSave.TabIndex = 13;
			btnSave.Text = "save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// newbutton
			// 
			newbutton.Location = new Point(412, 529);
			newbutton.Name = "newbutton";
			newbutton.Size = new Size(112, 34);
			newbutton.TabIndex = 15;
			newbutton.Text = "Cancel";
			newbutton.UseVisualStyleBackColor = true;
			newbutton.Click += newbutton_Click_1;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(608, 529);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(112, 34);
			btnAdd.TabIndex = 16;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// frmOrders
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(960, 592);
			Controls.Add(btnAdd);
			Controls.Add(newbutton);
			Controls.Add(btnSave);
			Controls.Add(txtShippedDate);
			Controls.Add(txtRequiredDate);
			Controls.Add(txtOrderDate);
			Controls.Add(txtFreight);
			Controls.Add(txtMemberId);
			Controls.Add(txtOrderId);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgvOrder);
			Name = "frmOrders";
			Text = "Order";
			Load += frmOrder_Load;
			((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvOrder;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox txtOrderId;
		private TextBox txtMemberId;
		private TextBox txtFreight;
		private DateTimePicker txtOrderDate;
		private DateTimePicker txtRequiredDate;
		private DateTimePicker txtShippedDate;
		private Button btnSave;
		private Button newbutton;
		private Button btnAdd;
	}
}