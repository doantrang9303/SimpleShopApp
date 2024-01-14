namespace SaleWinApp
{
	partial class frmMemberDetail
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
			IbMemberId = new Label();
			IbEmail = new Label();
			IbCompanyName = new Label();
			IbCity = new Label();
			IbCountry = new Label();
			IbPassword = new Label();
			btnSave = new Button();
			txtMemberID = new TextBox();
			txtEmail = new TextBox();
			txtCompanyName = new TextBox();
			txtCity = new TextBox();
			txtCountry = new TextBox();
			txtPassword = new TextBox();
			SuspendLayout();
			// 
			// IbMemberId
			// 
			IbMemberId.AutoSize = true;
			IbMemberId.Location = new Point(185, 25);
			IbMemberId.Name = "IbMemberId";
			IbMemberId.Size = new Size(102, 25);
			IbMemberId.TabIndex = 0;
			IbMemberId.Text = "Member ID";
			// 
			// IbEmail
			// 
			IbEmail.AutoSize = true;
			IbEmail.Location = new Point(185, 80);
			IbEmail.Name = "IbEmail";
			IbEmail.Size = new Size(54, 25);
			IbEmail.TabIndex = 1;
			IbEmail.Text = "Email";
			// 
			// IbCompanyName
			// 
			IbCompanyName.AutoSize = true;
			IbCompanyName.Location = new Point(185, 143);
			IbCompanyName.Name = "IbCompanyName";
			IbCompanyName.Size = new Size(141, 25);
			IbCompanyName.TabIndex = 2;
			IbCompanyName.Text = "Company Name";
			// 
			// IbCity
			// 
			IbCity.AutoSize = true;
			IbCity.Location = new Point(185, 205);
			IbCity.Name = "IbCity";
			IbCity.Size = new Size(42, 25);
			IbCity.TabIndex = 3;
			IbCity.Text = "City";
			// 
			// IbCountry
			// 
			IbCountry.AutoSize = true;
			IbCountry.Location = new Point(185, 275);
			IbCountry.Name = "IbCountry";
			IbCountry.Size = new Size(75, 25);
			IbCountry.TabIndex = 4;
			IbCountry.Text = "Country";
			// 
			// IbPassword
			// 
			IbPassword.AutoSize = true;
			IbPassword.Location = new Point(185, 341);
			IbPassword.Name = "IbPassword";
			IbPassword.Size = new Size(87, 25);
			IbPassword.TabIndex = 5;
			IbPassword.Text = "Password";
			// 
			// btnSave
			// 
			btnSave.Location = new Point(273, 408);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(112, 34);
			btnSave.TabIndex = 6;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// txtMemberID
			// 
			txtMemberID.Location = new Point(352, 25);
			txtMemberID.Name = "txtMemberID";
			txtMemberID.Size = new Size(150, 31);
			txtMemberID.TabIndex = 8;
			txtMemberID.TextChanged += textBox1_TextChanged;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(353, 83);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(150, 31);
			txtEmail.TabIndex = 9;
			// 
			// txtCompanyName
			// 
			txtCompanyName.Location = new Point(354, 148);
			txtCompanyName.Name = "txtCompanyName";
			txtCompanyName.Size = new Size(150, 31);
			txtCompanyName.TabIndex = 10;
			// 
			// txtCity
			// 
			txtCity.Location = new Point(355, 218);
			txtCity.Name = "txtCity";
			txtCity.Size = new Size(150, 31);
			txtCity.TabIndex = 11;
			// 
			// txtCountry
			// 
			txtCountry.Location = new Point(357, 279);
			txtCountry.Name = "txtCountry";
			txtCountry.Size = new Size(150, 31);
			txtCountry.TabIndex = 12;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(354, 341);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(150, 31);
			txtPassword.TabIndex = 13;
			// 
			// frmMemberDetail
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(671, 471);
			Controls.Add(txtPassword);
			Controls.Add(txtCountry);
			Controls.Add(txtCity);
			Controls.Add(txtCompanyName);
			Controls.Add(txtEmail);
			Controls.Add(txtMemberID);
			Controls.Add(btnSave);
			Controls.Add(IbPassword);
			Controls.Add(IbCountry);
			Controls.Add(IbCity);
			Controls.Add(IbCompanyName);
			Controls.Add(IbEmail);
			Controls.Add(IbMemberId);
			Name = "frmMemberDetail";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmMemberDetail";
			Load += frmMemberDetail_Load_1;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label IbMemberId;
		private Label IbEmail;
		private Label IbCompanyName;
		private Label IbCity;
		private Label IbCountry;
		private Label IbPassword;
		private Button btnSave;
		private TextBox txtMemberID;
		private TextBox txtEmail;
		private TextBox txtCompanyName;
		private TextBox txtCity;
		private TextBox txtCountry;
		private TextBox txtPassword;
	}
}