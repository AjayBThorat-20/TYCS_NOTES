﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac2a
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Time show before the service is calling  
            lblPagedate.Text = "on the load time the time is " + DateTime.Now.ToString();
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            sc.OneWayMessage();
            //after service is calling that time show  
            lblServicedate.Text = "After Calling the service the time is " + DateTime.Now.ToString();
        }
    }
}