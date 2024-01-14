
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var admin = new BusinessObject.MemberObject
            {
                Email = "admin@fstore.com",
                Password = "admin@@",
            };
            var members = MemberDAO.Instance.GetMemberList();
            bool isMem = false;
            bool isAdmin;
            foreach (var item in members)
            {
                if (item.Email.Equals(txtUsername.Text) && item.Password.Equals(txtPassword.Text))
                {
                    isMem = true;
                    frmProduct frm = new frmProduct();
                    frm.ShowDialog();
                    isAdmin = false;
                    this.Close();
                    break;
                }
                else if (admin.Email.Equals(txtUsername.Text) && admin.Password.Equals(txtPassword.Text))
                {

                    frmMain frm = new frmMain();
                    isMem = true;
                    frm.ShowDialog();
                    this.Close();
                    break;
                }
            }
            if (isMem == true)
            {
                MessageBox.Show("Login successfully");
            }
            else
            {
                MessageBox.Show("Login failed, enter email and password again!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMemberDetail frm = new frmMemberDetail();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
