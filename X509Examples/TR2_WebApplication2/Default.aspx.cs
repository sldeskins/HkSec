using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TR2_WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load ( object sender, EventArgs e )
        {
            string[] roles = Roles.GetAllRoles();
            if (!roles.Contains("Admin"))
            {
                Roles.CreateRole("Admin");
            }

            string[] users = Roles.GetUsersInRole("Admin");
            if (!users.Contains("sldeskins"))
            {
                Roles.AddUserToRole("sldeskins", "Admin");
            }

            //note:  in webconfig need to enable roleManager <roleManager defaultProvider="DefaultRoleProvider" enabled="true">
        }
    }
}