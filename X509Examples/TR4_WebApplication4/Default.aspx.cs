using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TR4_WebApplication4
{
    public partial class _Default : Page
    {
        protected void Page_Load ( object sender, EventArgs e )
        {
            if (!Page.IsPostBack)
            {
                ProductDropDown.DataSource = new[] { "Milk", "Cookies", "Vegemite" };
                ProductDropDown.DataBind();
            }

            MyButton.Text = "<script>alert('Hello World - My Button Text');</script>"; //output encoding for html attributes
            MyLabel.Text = "<script>alert('Hello World- lab text');</script>"; //not encoded
            MyLabel.CssClass = "<script>alert('Hello World lbb css');</script>"; // encoded
        }
    }
}