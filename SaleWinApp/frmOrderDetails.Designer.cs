namespace SaleWinApps
{
	partial class frmOrderDetails
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			orderIdTextbox = new TextBox();
			productIDTextbox = new TextBox();
			quantityTextbox = new MaskedTextBox();
			unitPriceTextbox = new MaskedTextBox();
			discountTextbox = new MaskedTextBox();
			updateButton = new Button();
			cancelButton = new Button();
			label6 = new Label();
			priceTextbox = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(70, 38);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(105, 32);
			label1.TabIndex = 0;
			label1.Text = "Order ID";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(70, 94);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(126, 32);
			label2.TabIndex = 1;
			label2.Text = "Product ID";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(70, 258);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(65, 32);
			label3.TabIndex = 2;
			label3.Text = "Price";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(70, 196);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(106, 32);
			label4.TabIndex = 3;
			label4.Text = "Quantity";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(70, 321);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(108, 32);
			label5.TabIndex = 4;
			label5.Text = "Discount";
			// 
			// orderIdTextbox
			// 
			orderIdTextbox.Location = new Point(215, 41);
			orderIdTextbox.Margin = new Padding(4);
			orderIdTextbox.Name = "orderIdTextbox";
			orderIdTextbox.Size = new Size(155, 31);
			orderIdTextbox.TabIndex = 5;
			// 
			// productIDTextbox
			// 
			productIDTextbox.Location = new Point(215, 94);
			productIDTextbox.Margin = new Padding(4);
			productIDTextbox.Name = "productIDTextbox";
			productIDTextbox.Size = new Size(155, 31);
			productIDTextbox.TabIndex = 6;
			productIDTextbox.TextChanged += productIDTextbox_TextChanged;
			// 
			// quantityTextbox
			// 
			quantityTextbox.Location = new Point(215, 201);
			quantityTextbox.Margin = new Padding(4);
			quantityTextbox.Name = "quantityTextbox";
			quantityTextbox.Size = new Size(155, 31);
			quantityTextbox.TabIndex = 7;
			quantityTextbox.ValidatingType = typeof(int);
			quantityTextbox.TextChanged += quantityTextbox_TextChanged;
			// 
			// unitPriceTextbox
			// 
			unitPriceTextbox.Location = new Point(215, 154);
			unitPriceTextbox.Margin = new Padding(4);
			unitPriceTextbox.Name = "unitPriceTextbox";
			unitPriceTextbox.Size = new Size(155, 31);
			unitPriceTextbox.TabIndex = 8;
			// 
			// discountTextbox
			// 
			discountTextbox.Location = new Point(215, 321);
			discountTextbox.Margin = new Padding(4);
			discountTextbox.Name = "discountTextbox";
			discountTextbox.Size = new Size(155, 31);
			discountTextbox.TabIndex = 9;
			discountTextbox.ValidatingType = typeof(int);
			// 
			// updateButton
			// 
			updateButton.BackColor = Color.White;
			updateButton.Location = new Point(70, 391);
			updateButton.Margin = new Padding(4);
			updateButton.Name = "updateButton";
			updateButton.Size = new Size(118, 36);
			updateButton.TabIndex = 10;
			updateButton.Text = "Add";
			updateButton.UseVisualStyleBackColor = false;
			updateButton.Click += updateButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.BackColor = Color.White;
			cancelButton.Location = new Point(293, 391);
			cancelButton.Margin = new Padding(4);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(118, 36);
			cancelButton.TabIndex = 12;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = false;
			cancelButton.Click += cancelButton_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(70, 149);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(116, 32);
			label6.TabIndex = 13;
			label6.Text = "Unit Price";
			// 
			// priceTextbox
			// 
			priceTextbox.Location = new Point(215, 258);
			priceTextbox.Margin = new Padding(4);
			priceTextbox.Name = "priceTextbox";
			priceTextbox.Size = new Size(155, 31);
			priceTextbox.TabIndex = 14;
			// 
			// frmOrderDetails
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(472, 472);
			ControlBox = false;
			Controls.Add(priceTextbox);
			Controls.Add(label6);
			Controls.Add(cancelButton);
			Controls.Add(updateButton);
			Controls.Add(discountTextbox);
			Controls.Add(unitPriceTextbox);
			Controls.Add(quantityTextbox);
			Controls.Add(productIDTextbox);
			Controls.Add(orderIdTextbox);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(4);
			MaximumSize = new Size(494, 494);
			MinimumSize = new Size(494, 494);
			Name = "frmOrderDetails";
			StartPosition = FormStartPosition.CenterScreen;
			Load += frmOrderDetails_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox orderIdTextbox;
		private TextBox productIDTextbox;
		private MaskedTextBox quantityTextbox;
		private MaskedTextBox unitPriceTextbox;
		private MaskedTextBox discountTextbox;
		private Button updateButton;
		private Button cancelButton;
		private Label label6;
		private TextBox priceTextbox;
	}
}