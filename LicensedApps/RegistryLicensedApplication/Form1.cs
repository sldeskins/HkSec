using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace RegistryLicensedApplication
{
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	[GuidAttribute("2de915e1-df71-3443-9f4d-32259c92ced2")]
	[LicenseProvider(typeof(RegistryLicenseProvider))]
	public class frmMain : System.Windows.Forms.Form
	{
		private License license = null;

		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Obtain the license
			license = LicenseManager.Validate(typeof(frmMain), this);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}

				if (license != null) 
				{
					license.Dispose();
					license = null;
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmdExit
			// 
			this.cmdExit.Location = new System.Drawing.Point(269, 12);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(90, 27);
			this.cmdExit.TabIndex = 3;
			this.cmdExit.Text = "E&xit";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "This is a licensed application.";
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(374, 51);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.label1);
			this.Name = "frmMain";
			this.Text = "Registry Licensed Application";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			// Create an instance of the licensed application
			frmMain app = null;
			try
			{
				// This will throw a LicenseException if the 
				// license is invalid... If we get an exception,
				// "app" will remain null and the Run() method
				// (below) will not be executed...
				app = new frmMain();
			} // try
			catch (Exception ex)
			{
				// Catch any error, but especially licensing errors...
				string strErr = String.Format("Error executing application: '{0}'",ex.Message);
				MessageBox.Show(strErr,"RegistryLicensedApplication Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			} // catch

			if ( app != null ) Application.Run(app);
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			// Just quit...
			Application.Exit();
		}
	}
}
