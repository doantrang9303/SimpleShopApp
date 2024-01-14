using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SaleWinApp
{
	public partial class frmMemberDetail : Form
	{
		IMemberRepository memberRepository = new MemberRepository();
		BindingSource source;
		public bool InsertOrUpdate { get; set; }
		public MemberObject MemberObject { get; set; }
		public frmMemberDetail()
		{
			InitializeComponent();
		}

		private void frmMemberDetail_Load(object sender, EventArgs e)
		{
			txtMemberID.Enabled = !InsertOrUpdate;
			if (InsertOrUpdate == true)
			{
				txtMemberID.Text = MemberObject.MemberId.ToString();
				txtEmail.Text = MemberObject.Email;
				txtCompanyName.Text = MemberObject.City;
				txtCity.Text = MemberObject.City;
				txtCountry.Text = MemberObject.Country;
				txtPassword.Text = MemberObject.Password;
			}
		}





		private void txtEmail_TextChanged(object sender, EventArgs e)
		{

		}

		private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				var member = new MemberObject
				{
					MemberId = int.Parse(txtMemberID.Text),
					Email = txtEmail.Text,
					CompanyName = txtCompanyName.Text,
					City = txtCity.Text,
					Country = txtCountry.Text,
					Password = txtPassword.Text,
				};

				memberRepository.AddNewMember(member);

				MessageBox.Show("Success");
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}



		private void frmMemberDetail_Load_1(object sender, EventArgs e)
		{

		}
	}
}
