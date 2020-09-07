using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Temp
{
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double celsius_to_farhenheit(double celsius)
        {
            return ((celsius * 9 / 5) + 32);
        }
        [WebMethod]
        public double farhenheit_to_celsius(double farhenheit)
        {
            return ((farhenheit - 32) * 5 / 9);

        }
    }
}
