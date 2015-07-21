using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Permissions;

namespace GenericPrincipal
{
    class Program
    {
        static void Main ( string[] args )
        {
            SetupPrincipal();
            UsePrincipal();
        }


        private static void SetupPrincipal ()
        {
            //authenticate your client
            var id = new GenericIdentity("bob");

            //fetch roles
            var roles = new string[] { "Development", "Marketing" };
            var p = new System.Security.Principal.GenericPrincipal(id, roles);

            Thread.CurrentPrincipal = p;
        }

        private static void UsePrincipal ()
        {
            var p = Thread.CurrentPrincipal;
            Console.WriteLine(p.IsInRole("Development"));

            if (p.IsInRole("Marketing")) { //do some marketing
            }
            else { 
            //access denied
            }

            //throws exception
            new PrincipalPermission(null, "DevelopmentA").Demand();
            DoDeveloperWork();
        }

        [PrincipalPermission(SecurityAction.Demand, Role="DevelopmentA")]
        private static void DoDeveloperWork ()
        {
          Console.WriteLine("You are a developer");
        }
    }
}
