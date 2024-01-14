using BusinessObject;
using SaleWinApps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
	public partial class frmMain : Form
	{

		public frmMain()
		{
			InitializeComponent();
		}
		private void frmMain_Load(object sender, EventArgs e)
		{
			//this.Invalidate();
			MdiClient MDI;
			foreach (Control ct1 in this.Controls)
			{
				try
				{
					MDI = (MdiClient)ct1;
					MDI.BackColor = System.Drawing.Color.LightSkyBlue;
					//MDI.BackgroundImage = Properties.Resources.Images;
					menuStrip1.Enabled = true;
				}
				catch (InvalidCastException exc)
				{

				}
			}
			////}
		}

		private void mainToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void loginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMember frmMember = new frmMember();
			frmMember.MdiParent = this;
			frmMember.Show();
		}

		private void productToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmProduct frm = new frmProduct();
			frm.MdiParent = this;
			frm.Show();
		}

		private void cartToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void orderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmOrder frm = new frmOrder();
			frm.MdiParent = this;
			frm.Show();

		}


		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLogin loginForm = new frmLogin();
			loginForm.FormClosed += (s, args) => this.Close();
			this.Hide();
			loginForm.Show();
		}
	}
}
