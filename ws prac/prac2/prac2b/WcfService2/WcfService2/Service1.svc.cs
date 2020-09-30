using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string RequestReplyPattern()
        {
            //using the namespace using System.Threading for sleep the thread in 2 minute  
            Thread.Sleep(2000);
            //return the date and time  
            return "current time of Service is" + DateTime.Now.ToString();
        }
    }
}
