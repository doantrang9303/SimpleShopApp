namespace SaleWinApp
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			menuStrip1 = new MenuStrip();
			mainToolStripMenuItem = new ToolStripMenuItem();
			loginToolStripMenuItem = new ToolStripMenuItem();
			productToolStripMenuItem = new ToolStripMenuItem();
			orderToolStripMenuItem = new ToolStripMenuItem();
			logoutToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { mainToolStripMenuItem, loginToolStripMenuItem, productToolStripMenuItem, orderToolStripMenuItem, logoutToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 33);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// mainToolStripMenuItem
			// 
			mainToolStripMenuItem.Name = "mainToolStripMenuItem";
			mainToolStripMenuItem.Size = new Size(71, 29);
			mainToolStripMenuItem.Text = "Main";
			mainToolStripMenuItem.Click += mainToolStripMenuItem_Click;
			// 
			// loginToolStripMenuItem
			// 
			loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			loginToolStripMenuItem.Size = new Size(99, 29);
			loginToolStripMenuItem.Text = "Member";
			loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
			// 
			// productToolStripMenuItem
			// 
			productToolStripMenuItem.Name = "productToolStripMenuItem";
			productToolStripMenuItem.Size = new Size(95, 29);
			productToolStripMenuItem.Text = "Product";
			productToolStripMenuItem.Click += productToolStripMenuItem_Click;
			// 
			// orderToolStripMenuItem
			// 
			orderToolStripMenuItem.Name = "orderToolStripMenuItem";
			orderToolStripMenuItem.Size = new Size(77, 29);
			orderToolStripMenuItem.Text = "Order";
			orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
			// 
			// logoutToolStripMenuItem
			// 
			logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			logoutToolStripMenuItem.Size = new Size(88, 29);
			logoutToolStripMenuItem.Text = "Logout";
			logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 450);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "frmMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmMain";
			WindowState = FormWindowState.Maximized;
			Load += frmMain_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem mainToolStripMenuItem;
		private ToolStripMenuItem loginToolStripMenuItem;
		private ToolStripMenuItem productToolStripMenuItem;
		private ToolStripMenuItem orderToolStripMenuItem;
		private ToolStripMenuItem logoutToolStripMenuItem;
	}
}