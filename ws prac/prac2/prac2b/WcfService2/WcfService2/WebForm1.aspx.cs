using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WcfService2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            lblPagedate.Text = "Page date is " + DateTime.Now.ToString();
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            lblServicedate.Text = sc.RequestReplyPattern();
        }
    }
}