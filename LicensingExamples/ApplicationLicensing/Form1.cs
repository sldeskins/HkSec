using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ApplicationLicensing
{
    [GuidAttribute("2de915e1-df71-3443-9f4d-32259c92ced2")]
    [LicenseProvider(typeof(RegistryLicenseProvider))]
    public partial class frmMain : Form
    {
        private License license = null;
        public frmMain ()
        {
            InitializeComponent();

            //Obtain the license
            license = LicenseManager.Validate(typeof(frmMain), this);
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose ( bool disposing )
        {
            if (disposing)
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
            base.Dispose(disposing);
        }
    }
}
