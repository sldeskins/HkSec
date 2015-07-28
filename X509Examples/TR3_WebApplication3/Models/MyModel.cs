using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace TR3_WebApplication3.Models
{
    public class MyModel
    {
        [AllowHtml]
        public string MyAttribute { get; set; }


        public string MyAttributeB { get { return "<script>alert('hello world');</script>"; } }
    }
}