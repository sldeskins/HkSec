using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ApplicationLicensing
{
    public class RuntimeRegistryLicense : License
    {
        private Type type;

        public RuntimeRegistryLicense ( Type type )
        {
            if (type == null)
                throw new NullReferenceException(
       "The licensed type reference may not be null.");
            this.type = type;
        }

        public override string LicenseKey
        {
            get
            {
                // Simply return the application's GUID
                return type.GUID.ToString();
            }
        }
        public override void Dispose ()
        {
        }
    }
}
