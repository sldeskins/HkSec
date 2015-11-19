using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Microsoft.Win32;

namespace ApplicationLicensing
{
    public class RegistryLicenseProvider : LicenseProvider
    {

        public override License GetLicense ( LicenseContext context,
        Type type,
        object instance,
         bool allowExceptions )
        {
            // We'll test for the usage mode...run time v. design time.
            // Note we only check if run time...
            if (context.UsageMode == LicenseUsageMode.Runtime)
            {
                // The Registry key we'll check
                RegistryKey licenseKey =
              Registry.CurrentUser.OpenSubKey("Software\\Acme\\HostKeys");

                if (licenseKey != null)
                {
                    // Passed the first test, which is the existence of the
                    // Registry key itself. Now obtain the stored value
                    // associated with our app's GUID.
                    string strLic =
           (string)licenseKey.GetValue(type.GUID.ToString()); // reflected!
                    if (strLic != null)
                    {
                        // Passed the second test, which is some value
                        // exists that's associated with our app's GUID.
                        if (String.Compare("Installed", strLic, false) == 0)
                        {
                            // Got it...valid license...
                            return new RuntimeRegistryLicense(type);
                        } // if
                    } // if
                } // if

                // if we got this far, we failed the license test. We then
                // check to see if exceptions are allowed, and if so, throw
                // a new license exception...
                if (allowExceptions == true)
                {
                    throw new LicenseException(type,
                                               instance,
                                               "Your license is invalid");
                } // if

                // Exceptions are not desired, so we'll simply return null.
                return null;
            } // if
            else
            {
                return new DesigntimeRegistryLicense(type);
            } // else

        }
    }
}
