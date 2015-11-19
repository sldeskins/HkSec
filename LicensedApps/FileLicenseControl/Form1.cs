using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FileLicenseControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private FileLicenseControl.LicensedColorComboBox cmbLicColor;
		private System.Windows.Forms.Button cmdExit;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Note that for an instance of the licensed control to show
			// up in the editor, the license file *must* be copied to
			// the appropriate obj subdirectory:
			//
			// myApp\obj\Release\{lic file}.lic
			//
			// or
			//
			// myApp\obj\Debug\{lic file}.lic
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
			this.label1 = new System.Windows.Forms.Label();
			this.cmdExit = new System.Windows.Forms.Button();
			this.cmbLicColor = new FileLicenseControl.LicensedColorComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "The licensed ComboBox:";
			// 
			// cmdExit
			// 
			this.cmdExit.Location = new System.Drawing.Point(296, 32);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.TabIndex = 1;
			this.cmdExit.Text = "E&xit";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// cmbLicColor
			// 
			this.cmbLicColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbLicColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLicColor.Location = new System.Drawing.Point(16, 32);
			this.cmbLicColor.Name = "cmbLicColor";
			this.cmbLicColor.Size = new System.Drawing.Size(264, 21);
			this.cmbLicColor.TabIndex = 2;
			// 
			// Form1
			// 
			this.AcceptButton = this.cmdExit;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 69);
			this.Controls.Add(this.cmbLicColor);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Licensed Control Demo";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			// Just quit
			Application.Exit();
		}
	}
}
