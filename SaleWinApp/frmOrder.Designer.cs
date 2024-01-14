namespace SaleWinApp
{
	partial class frmOrder
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
			searchTextbox = new TextBox();
			memberIdTextbox = new TextBox();
			orderIDTextbox = new TextBox();
			orderDateTextbox = new TextBox();
			requiredDateTextbox = new TextBox();
			shippedDateTextbox = new TextBox();
			freightTextbox = new TextBox();
			searchComboBox = new ComboBox();
			loadButton = new Button();
			newButton = new Button();
			deleteButton = new Button();
			orderData = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			btnUpdate = new Button();
			((System.ComponentModel.ISupportInitialize)orderData).BeginInit();
			SuspendLayout();
			// 
			// searchTextbox
			// 
			searchTextbox.Location = new Point(188, 24);
			searchTextbox.Name = "searchTextbox";
			searchTextbox.PlaceholderText = "Search text";
			searchTextbox.Size = new Size(332, 31);
			searchTextbox.TabIndex = 0;
			searchTextbox.TextChanged += searchTextbox_TextChanged;
			// 
			// memberIdTextbox
			// 
			memberIdTextbox.Location = new Point(150, 406);
			memberIdTextbox.Name = "memberIdTextbox";
			memberIdTextbox.Size = new Size(150, 31);
			memberIdTextbox.TabIndex = 1;
			// 
			// orderIDTextbox
			// 
			orderIDTextbox.Location = new Point(149, 354);
			orderIDTextbox.Name = "orderIDTextbox";
			orderIDTextbox.Size = new Size(150, 31);
			orderIDTextbox.TabIndex = 2;
			// 
			// orderDateTextbox
			// 
			orderDateTextbox.Location = new Point(149, 467);
			orderDateTextbox.Name = "orderDateTextbox";
			orderDateTextbox.Size = new Size(150, 31);
			orderDateTextbox.TabIndex = 3;
			// 
			// requiredDateTextbox
			// 
			requiredDateTextbox.Location = new Point(690, 344);
			requiredDateTextbox.Name = "requiredDateTextbox";
			requiredDateTextbox.Size = new Size(150, 31);
			requiredDateTextbox.TabIndex = 4;
			// 
			// shippedDateTextbox
			// 
			shippedDateTextbox.Location = new Point(690, 395);
			shippedDateTextbox.Name = "shippedDateTextbox";
			shippedDateTextbox.Size = new Size(150, 31);
			shippedDateTextbox.TabIndex = 5;
			// 
			// freightTextbox
			// 
			freightTextbox.Location = new Point(690, 449);
			freightTextbox.Name = "freightTextbox";
			freightTextbox.Size = new Size(150, 31);
			freightTextbox.TabIndex = 6;
			// 
			// searchComboBox
			// 
			searchComboBox.FormattingEnabled = true;
			searchComboBox.Items.AddRange(new object[] { "Search", "Search By Order ID", "Search By Member ID" });
			searchComboBox.Location = new Point(627, 22);
			searchComboBox.Name = "searchComboBox";
			searchComboBox.Size = new Size(186, 33);
			searchComboBox.TabIndex = 7;
			searchComboBox.SelectedIndexChanged += searchComboBox_SelectedIndexChanged;
			// 
			// loadButton
			// 
			loadButton.Location = new Point(131, 524);
			loadButton.Name = "loadButton";
			loadButton.Size = new Size(112, 34);
			loadButton.TabIndex = 8;
			loadButton.Text = "Load";
			loadButton.UseVisualStyleBackColor = true;
			loadButton.Click += loadButton_Click;
			// 
			// newButton
			// 
			newButton.Location = new Point(348, 524);
			newButton.Name = "newButton";
			newButton.Size = new Size(112, 34);
			newButton.TabIndex = 9;
			newButton.Text = "New";
			newButton.UseVisualStyleBackColor = true;
			newButton.Click += newButton_Click;
			// 
			// deleteButton
			// 
			deleteButton.Location = new Point(778, 524);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(112, 34);
			deleteButton.TabIndex = 10;
			deleteButton.Text = "Delete";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += deleteButton_Click;
			// 
			// orderData
			// 
			orderData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			orderData.Location = new Point(12, 77);
			orderData.Name = "orderData";
			orderData.RowHeadersWidth = 62;
			orderData.RowTemplate.Height = 33;
			orderData.Size = new Size(936, 225);
			orderData.TabIndex = 11;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(34, 360);
			label1.Name = "label1";
			label1.Size = new Size(81, 25);
			label1.TabIndex = 12;
			label1.Text = "Order ID";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(42, 409);
			label2.Name = "label2";
			label2.Size = new Size(102, 25);
			label2.TabIndex = 13;
			label2.Text = "Member ID";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(40, 470);
			label3.Name = "label3";
			label3.Size = new Size(95, 25);
			label3.TabIndex = 14;
			label3.Text = "OrderDate";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(544, 344);
			label4.Name = "label4";
			label4.Size = new Size(119, 25);
			label4.TabIndex = 15;
			label4.Text = "RequiredDate";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(544, 398);
			label5.Name = "label5";
			label5.Size = new Size(115, 25);
			label5.TabIndex = 16;
			label5.Text = "ShippedDate";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(544, 449);
			label6.Name = "label6";
			label6.Size = new Size(67, 25);
			label6.TabIndex = 17;
			label6.Text = "Freight";
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(580, 526);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(112, 34);
			btnUpdate.TabIndex = 18;
			btnUpdate.Text = "Show full order";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// frmOrder
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(960, 570);
			Controls.Add(btnUpdate);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(orderData);
			Controls.Add(deleteButton);
			Controls.Add(newButton);
			Controls.Add(loadButton);
			Controls.Add(searchComboBox);
			Controls.Add(freightTextbox);
			Controls.Add(shippedDateTextbox);
			Controls.Add(requiredDateTextbox);
			Controls.Add(orderDateTextbox);
			Controls.Add(orderIDTextbox);
			Controls.Add(memberIdTextbox);
			Controls.Add(searchTextbox);
			Name = "frmOrder";
			Text = "frmOrder";
			Load += frmOrder_Load;
			((System.ComponentModel.ISupportInitialize)orderData).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox searchTextbox;
		private TextBox memberIdTextbox;
		private TextBox orderIDTextbox;
		private TextBox orderDateTextbox;
		private TextBox requiredDateTextbox;
		private TextBox shippedDateTextbox;
		private TextBox freightTextbox;
		private ComboBox searchComboBox;
		private Button loadButton;
		private Button newButton;
		private Button deleteButton;
		private DataGridView orderData;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Button btnUpdate;
	}
}