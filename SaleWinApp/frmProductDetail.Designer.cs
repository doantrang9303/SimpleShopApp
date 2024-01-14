namespace SaleWinApps
{
    partial class frmProductDetail
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
            idLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            idTextbox = new TextBox();
            nameTextbox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            weightTextbox = new MaskedTextBox();
            priceTextbox = new MaskedTextBox();
            unitTextbox = new MaskedTextBox();
            categoryTextbox = new MaskedTextBox();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.Location = new Point(42, 66);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(119, 32);
            idLabel.TabIndex = 0;
            idLabel.Text = "ProductID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 1;
            label2.Text = "Category ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 189);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 2;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 246);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 3;
            label4.Text = "Weight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 305);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 4;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 368);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 32);
            label6.TabIndex = 5;
            label6.Text = "Units Is Stock";
            // 
            // idTextbox
            // 
            idTextbox.Location = new Point(219, 66);
            idTextbox.Margin = new Padding(4);
            idTextbox.Name = "idTextbox";
            idTextbox.Size = new Size(291, 31);
            idTextbox.TabIndex = 6;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(219, 190);
            nameTextbox.Margin = new Padding(4);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(290, 31);
            nameTextbox.TabIndex = 8;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.WhiteSmoke;
            saveButton.Location = new Point(132, 462);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(118, 36);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += actionButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Snow;
            cancelButton.Location = new Point(324, 462);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(118, 36);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // weightTextbox
            // 
            weightTextbox.Location = new Point(219, 251);
            weightTextbox.Margin = new Padding(4);
            weightTextbox.Name = "weightTextbox";
            weightTextbox.Size = new Size(290, 31);
            weightTextbox.TabIndex = 14;
            // 
            // priceTextbox
            // 
            priceTextbox.Location = new Point(219, 310);
            priceTextbox.Margin = new Padding(4);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.Size = new Size(291, 31);
            priceTextbox.TabIndex = 15;
            priceTextbox.ValidatingType = typeof(int);
            // 
            // unitTextbox
            // 
            unitTextbox.Location = new Point(220, 374);
            unitTextbox.Margin = new Padding(4);
            unitTextbox.Name = "unitTextbox";
            unitTextbox.Size = new Size(290, 31);
            unitTextbox.TabIndex = 16;
            unitTextbox.ValidatingType = typeof(int);
            // 
            // categoryTextbox
            // 
            categoryTextbox.Location = new Point(221, 130);
            categoryTextbox.Margin = new Padding(4);
            categoryTextbox.Name = "categoryTextbox";
            categoryTextbox.Size = new Size(289, 31);
            categoryTextbox.TabIndex = 17;
            categoryTextbox.ValidatingType = typeof(int);
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 501);
            ControlBox = false;
            Controls.Add(categoryTextbox);
            Controls.Add(unitTextbox);
            Controls.Add(priceTextbox);
            Controls.Add(weightTextbox);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(nameTextbox);
            Controls.Add(idTextbox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(idLabel);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(620, 557);
            MinimumSize = new Size(620, 557);
            Name = "frmProductDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mi";
            Load += formProductDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox idTextbox;
        private TextBox nameTextbox;
        private Button saveButton;
        private Button cancelButton;
        private MaskedTextBox weightTextbox;
        private MaskedTextBox priceTextbox;
        private MaskedTextBox unitTextbox;
        private MaskedTextBox categoryTextbox;
    }
}