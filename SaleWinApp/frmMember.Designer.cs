namespace SaleWinApp
{
	partial class frmMember
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
			IbMemberID = new Label();
			IbEmail = new Label();
			IbCompanyName = new Label();
			IbCity = new Label();
			IbCountry = new Label();
			IbPassword = new Label();
			dgvMemberList = new DataGridView();
			btnLoad = new Button();
			btnNew = new Button();
			btnDelete = new Button();
			txtMemberID = new TextBox();
			txtEmail = new TextBox();
			txtCompanyName = new TextBox();
			txtCity = new TextBox();
			txtCountry = new TextBox();
			txtPassword = new TextBox();
			txtSearch = new TextBox();
			btnSearch = new Button();
			rbAscending = new RadioButton();
			rbDescending = new RadioButton();
			btnUpdate = new Button();
			searchComboBox = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
			SuspendLayout();
			// 
			// IbMemberID
			// 
			IbMemberID.AutoSize = true;
			IbMemberID.Location = new Point(47, 301);
			IbMemberID.Name = "IbMemberID";
			IbMemberID.Size = new Size(102, 25);
			IbMemberID.TabIndex = 0;
			IbMemberID.Text = "Member ID";
			// 
			// IbEmail
			// 
			IbEmail.AutoSize = true;
			IbEmail.Location = new Point(47, 354);
			IbEmail.Name = "IbEmail";
			IbEmail.Size = new Size(54, 25);
			IbEmail.TabIndex = 1;
			IbEmail.Text = "Email";
			// 
			// IbCompanyName
			// 
			IbCompanyName.AutoSize = true;
			IbCompanyName.Location = new Point(47, 411);
			IbCompanyName.Name = "IbCompanyName";
			IbCompanyName.Size = new Size(141, 25);
			IbCompanyName.TabIndex = 2;
			IbCompanyName.Text = "Company Name";
			// 
			// IbCity
			// 
			IbCity.AutoSize = true;
			IbCity.Location = new Point(605, 298);
			IbCity.Name = "IbCity";
			IbCity.Size = new Size(42, 25);
			IbCity.TabIndex = 3;
			IbCity.Text = "City";
			// 
			// IbCountry
			// 
			IbCountry.AutoSize = true;
			IbCountry.Location = new Point(605, 354);
			IbCountry.Name = "IbCountry";
			IbCountry.Size = new Size(75, 25);
			IbCountry.TabIndex = 4;
			IbCountry.Text = "Country";
			// 
			// IbPassword
			// 
			IbPassword.AutoSize = true;
			IbPassword.Location = new Point(605, 408);
			IbPassword.Name = "IbPassword";
			IbPassword.Size = new Size(87, 25);
			IbPassword.TabIndex = 5;
			IbPassword.Text = "Password";
			// 
			// dgvMemberList
			// 
			dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMemberList.Location = new Point(12, 61);
			dgvMemberList.Name = "dgvMemberList";
			dgvMemberList.ReadOnly = true;
			dgvMemberList.RowHeadersWidth = 62;
			dgvMemberList.RowTemplate.Height = 33;
			dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvMemberList.Size = new Size(910, 225);
			dgvMemberList.TabIndex = 6;
			dgvMemberList.CellContentClick += dgvMemberList_CellDoubleClick;
			// 
			// btnLoad
			// 
			btnLoad.Location = new Point(758, 12);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(112, 34);
			btnLoad.TabIndex = 7;
			btnLoad.Text = "Load";
			btnLoad.UseVisualStyleBackColor = true;
			btnLoad.Click += btnLoad_Click;
			// 
			// btnNew
			// 
			btnNew.Location = new Point(313, 465);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(112, 34);
			btnNew.TabIndex = 8;
			btnNew.Text = "New";
			btnNew.UseVisualStyleBackColor = true;
			btnNew.Click += btnNew_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(535, 465);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(112, 34);
			btnDelete.TabIndex = 9;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// txtMemberID
			// 
			txtMemberID.Location = new Point(201, 298);
			txtMemberID.Name = "txtMemberID";
			txtMemberID.Size = new Size(150, 31);
			txtMemberID.TabIndex = 10;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(201, 354);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(150, 31);
			txtEmail.TabIndex = 11;
			// 
			// txtCompanyName
			// 
			txtCompanyName.Location = new Point(201, 408);
			txtCompanyName.Name = "txtCompanyName";
			txtCompanyName.Size = new Size(150, 31);
			txtCompanyName.TabIndex = 12;
			// 
			// txtCity
			// 
			txtCity.Location = new Point(711, 298);
			txtCity.Name = "txtCity";
			txtCity.Size = new Size(150, 31);
			txtCity.TabIndex = 13;
			// 
			// txtCountry
			// 
			txtCountry.Location = new Point(711, 354);
			txtCountry.Name = "txtCountry";
			txtCountry.Size = new Size(150, 31);
			txtCountry.TabIndex = 14;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(711, 405);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(150, 31);
			txtPassword.TabIndex = 15;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(59, 15);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(292, 31);
			txtSearch.TabIndex = 16;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(622, 12);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(112, 34);
			btnSearch.TabIndex = 17;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// rbAscending
			// 
			rbAscending.AutoSize = true;
			rbAscending.Location = new Point(47, 451);
			rbAscending.Name = "rbAscending";
			rbAscending.Size = new Size(120, 29);
			rbAscending.TabIndex = 19;
			rbAscending.TabStop = true;
			rbAscending.Text = "Ascending";
			rbAscending.UseVisualStyleBackColor = true;
			rbAscending.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// rbDescending
			// 
			rbDescending.AutoSize = true;
			rbDescending.Location = new Point(48, 488);
			rbDescending.Name = "rbDescending";
			rbDescending.Size = new Size(130, 29);
			rbDescending.TabIndex = 20;
			rbDescending.TabStop = true;
			rbDescending.Text = "Descending";
			rbDescending.UseVisualStyleBackColor = true;
			rbDescending.CheckedChanged += rbDescending_CheckedChanged;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(758, 465);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(112, 34);
			btnUpdate.TabIndex = 21;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// searchComboBox
			// 
			searchComboBox.FormattingEnabled = true;
			searchComboBox.Items.AddRange(new object[] { "Search", "Search By ID", "Search By Name" });
			searchComboBox.Location = new Point(400, 14);
			searchComboBox.Name = "searchComboBox";
			searchComboBox.Size = new Size(182, 33);
			searchComboBox.TabIndex = 22;
			searchComboBox.SelectedIndexChanged += searchComboBox_SelectedIndexChanged_1;
			// 
			// frmMember
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(934, 540);
			Controls.Add(searchComboBox);
			Controls.Add(btnUpdate);
			Controls.Add(rbDescending);
			Controls.Add(rbAscending);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(txtPassword);
			Controls.Add(txtCountry);
			Controls.Add(txtCity);
			Controls.Add(txtCompanyName);
			Controls.Add(txtEmail);
			Controls.Add(txtMemberID);
			Controls.Add(btnDelete);
			Controls.Add(btnNew);
			Controls.Add(btnLoad);
			Controls.Add(dgvMemberList);
			Controls.Add(IbPassword);
			Controls.Add(IbCountry);
			Controls.Add(IbCity);
			Controls.Add(IbCompanyName);
			Controls.Add(IbEmail);
			Controls.Add(IbMemberID);
			Name = "frmMember";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmMember";
			Load += frmMember_Load;
			((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label IbMemberID;
		private Label IbEmail;
		private Label IbCompanyName;
		private Label IbCity;
		private Label IbCountry;
		private Label IbPassword;
		private DataGridView dgvMemberList;
		private Button btnLoad;
		private Button btnNew;
		private Button btnDelete;
		private TextBox txtMemberID;
		private TextBox txtEmail;
		private TextBox txtCompanyName;
		private TextBox txtCity;
		private TextBox txtCountry;
		private TextBox txtPassword;
		private TextBox txtSearch;
		private Button btnSearch;
		private RadioButton rbAscending;
		private RadioButton rbDescending;
		private Button btnUpdate;
		private ComboBox searchComboBox;
	}
}