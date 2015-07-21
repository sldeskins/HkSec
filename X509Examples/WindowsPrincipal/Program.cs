using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace IdentityAndAccess
{
    class Program
    {
        static void Main ( string[] args )
        {
            var id = WindowsIdentity.GetCurrent();
            Console.WriteLine(id.Name);

            var account = new NTAccount(id.Name);
            var sid = account.Translate(typeof(SecurityIdentifier));
            Console.WriteLine(sid.Value);

            foreach (var group in id.Groups)
            {
                Console.WriteLine(group.Value);
                //whoami
                Console.WriteLine(group.Translate(typeof(NTAccount)));
            }
            //alternate just to get the string names
            //Note: String names are local and culture specific -- use ids
            foreach (var group in id.Groups.Translate(typeof(NTAccount)))
            { 
                Console.WriteLine(group);
            }


           //Note: String names are local and culture svapecific -- use ids
            //var principal = new WindowsPrincipal(id);
            //Console.WriteLine(principal.IsInRole(("Builtin\\Users")));
            var principal = new WindowsPrincipal(id);

            var localAdmins = new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid,null);
            var domainAdmin = new SecurityIdentifier(WellKnownSidType.AccountDomainAdminsSid, id.User.AccountDomainSid);
            var user = new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null);
            
            Console.WriteLine(principal.IsInRole(localAdmins));
            Console.WriteLine(principal.IsInRole(domainAdmin));
            Console.WriteLine(principal.IsInRole(user));

            //  Console.ReadLine();
        }
    }
}
