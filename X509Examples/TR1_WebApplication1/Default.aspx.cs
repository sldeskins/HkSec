using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TR1_WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load ( object sender, EventArgs e )
        {
            sessionStart.Text = Session["SessionStart"].ToString();

            Trace.Write("My trace message");
            Trace.Warn("My Trace warn");

            var cookie = new HttpCookie("MyCookie","Sheila's cookie");
            cookie.Secure= false;
            cookie.HttpOnly = false;

            Response.Cookies.Add(cookie);
        }
    }
}