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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaleWinApp
{
	public partial class frmMember : Form
	{
		IMemberRepository memberRepository = new MemberRepository();
		BindingSource source;
		public frmMember()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			LoadMemberList();
		}

		private void frmMember_Load(object sender, EventArgs e)
		{
			btnDelete.Enabled = false;

			dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;

		}

		private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void ClearText()
		{
			txtMemberID.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtCompanyName.Text = string.Empty;
			txtCity.Text = string.Empty;
			txtCountry.Text = string.Empty;
			txtPassword.Text = string.Empty;
		}
		private MemberObject GetCarObject()
		{
			MemberObject member = null;
			try
			{
				member = new MemberObject
				{
					MemberId = int.Parse(txtMemberID.Text),
					Email = txtEmail.Text,
					CompanyName = txtCompanyName.Text,
					City = txtCity.Text,
					Country = txtCountry.Text,
					Password = txtPassword.Text,
				};
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "Get member"); }
			return member;
		}
		public void LoadMemberList()
		{
			var cars = memberRepository.GetMembers();
			try
			{
				source = new BindingSource();
				source.DataSource = cars;
				txtMemberID.DataBindings.Clear();
				txtEmail.DataBindings.Clear();
				txtCompanyName.DataBindings.Clear();
				txtCity.DataBindings.Clear();
				txtCountry.DataBindings.Clear();
				txtPassword.DataBindings.Clear();

				txtMemberID.DataBindings.Add("Text", source, "MemberId");
				txtEmail.DataBindings.Add("Text", source, "Email");
				txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
				txtCity.DataBindings.Add("Text", source, "City");
				txtCountry.DataBindings.Add("Text", source, "Country");
				txtPassword.DataBindings.Add("Text", source, "Password");

				dgvMemberList.DataSource = null;
				dgvMemberList.DataSource = source;
				if (cars.Count() == 0)
				{
					ClearText();
					btnDelete.Enabled = false;
				}
				else { btnDelete.Enabled = true; }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load car list");
			}
		}


		private void btnSearch_Click(object sender, EventArgs e)
		{
			//LoadSearch();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{


		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			frmMemberDetail frm = new frmMemberDetail();
			frm.ShowDialog();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			var cars = memberRepository.GetMembers();
			try
			{
				source = new BindingSource();
				source.DataSource = cars.OrderBy(member => member.MemberId);
				txtMemberID.DataBindings.Clear();
				txtEmail.DataBindings.Clear();
				txtCompanyName.DataBindings.Clear();
				txtCity.DataBindings.Clear();
				txtCountry.DataBindings.Clear();
				txtPassword.DataBindings.Clear();

				txtMemberID.DataBindings.Add("Text", source, "MemberId");
				txtEmail.DataBindings.Add("Text", source, "Email");
				txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
				txtCity.DataBindings.Add("Text", source, "City");
				txtCountry.DataBindings.Add("Text", source, "Country");
				txtPassword.DataBindings.Add("Text", source, "Password");

				dgvMemberList.DataSource = null;
				dgvMemberList.DataSource = source;
				if (cars.Count() == 0)
				{
					ClearText();
					btnDelete.Enabled = false;
				}
				else { btnDelete.Enabled = true; }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load member list");
			}
		}

		private void rbDescending_CheckedChanged(object sender, EventArgs e)
		{
			var cars = memberRepository.GetMembers();
			try
			{
				source = new BindingSource();
				source.DataSource = cars.OrderByDescending(member => member.MemberId);
				txtMemberID.DataBindings.Clear();
				txtEmail.DataBindings.Clear();
				txtCompanyName.DataBindings.Clear();
				txtCity.DataBindings.Clear();
				txtCountry.DataBindings.Clear();
				txtPassword.DataBindings.Clear();

				txtMemberID.DataBindings.Add("Text", source, "MemberId");
				txtEmail.DataBindings.Add("Text", source, "Email");
				txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
				txtCity.DataBindings.Add("Text", source, "City");
				txtCountry.DataBindings.Add("Text", source, "Country");
				txtPassword.DataBindings.Add("Text", source, "Password");

				dgvMemberList.DataSource = null;
				dgvMemberList.DataSource = source;
				if (cars.Count() == 0)
				{
					ClearText();
					btnDelete.Enabled = false;
				}
				else { btnDelete.Enabled = true; }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load member list");
			}
		}
		public MemberObject GetMemberObject()
		{
			MemberObject memberObject = null;
			try
			{
				memberObject = new MemberObject
				{
					MemberId = int.Parse(txtMemberID.Text),
					Email = txtEmail.Text,
					CompanyName = txtCompanyName.Text,
					City = txtCity.Text,
					Country = txtCountry.Text,
					Password = txtPassword.Text,
				};
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return memberObject;
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				var member = GetMemberObject();
				DialogResult result = MessageBox.Show("Do you want really to delete", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					memberRepository.DeleteMember(member.MemberId);
					LoadMemberList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private void displayData(IEnumerable<MemberObject> members)
		{
			if (!members.Any()) members = memberRepository.GetMembers();
			try
			{
				txtMemberID.DataBindings.Clear();
				txtEmail.DataBindings.Clear();
				txtCompanyName.DataBindings.Clear();
				txtCity.DataBindings.Clear();
				txtCountry.DataBindings.Clear();
				txtPassword.DataBindings.Clear();

				txtMemberID.DataBindings.Add("Text", source, "MemberId");
				txtEmail.DataBindings.Add("Text", source, "Email");
				txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
				txtCity.DataBindings.Add("Text", source, "City");
				txtCountry.DataBindings.Add("Text", source, "Country");
				txtPassword.DataBindings.Add("Text", source, "Password");

				dgvMemberList.DataSource = null;
				dgvMemberList.DataSource = source;
				if (members.Count() == 0)
				{
					ClearText();
					btnDelete.Enabled = false;
				}
				else
				{
					btnDelete.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load member list");
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
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

				memberRepository.UpdateMember(member);

				MessageBox.Show("Success");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void searchComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (txtSearch.Text == null)
			{
				displayData(memberRepository.GetMembers());
				return;
			}
			if (searchComboBox.SelectedIndex == 0)
			{
				displayData(memberRepository.GetMembers());
			}
			else if (searchComboBox.SelectedIndex == 1)
			{
				_ = int.TryParse(txtSearch.Text, out int id);
				displayData(memberRepository.GetMembers().Where(mem => mem.MemberId == id));
			}
			else if (searchComboBox.SelectedIndex == 2)
			{
				displayData(memberRepository.GetMembers().Where(mem => mem.CompanyName.ToLower().Contains(txtSearch.Text)));
			}
		}
	}
}
