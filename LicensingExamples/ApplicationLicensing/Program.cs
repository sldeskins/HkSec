using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ApplicationLicensing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            frmMain app = null;
            try
            { // This will throw a LicenseException if the 
                // license is invalid... if we get an exception,
                // "app" will remain null and the Run() method
                // (below) will not be executed...
                app = new frmMain();
            }
            catch (Exception ex)
            { // Catch any error, but especially licensing errors...
                string strErr =
                    String.Format("Error executing application: '{0}'",
                                  ex.Message);
                MessageBox.Show(strErr,
                                 "RegistryLicensedApplication Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (app != null)
                Application.Run(app);

        }
    }
}
