﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TR5_WebApplication5.Models
{
    public class XfoHeaderModule:IHttpModule
    {
        public void Init ( HttpApplication context )
        {
           context.PreSendRequestHeaders+=context_PreSendRequestHeaders;
        }

        private void context_PreSendRequestHeaders ( object sender, EventArgs e )
        {
             HttpContext.Current.Response.Headers.Add("X-Frame-Options","Deny");
        }
        public void Dispose ()
        { 
        }

      
    }
}