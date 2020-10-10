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
    public class Service1 : IService1
    {
        public string RequestReplyPattern()
        {
            Thread.Sleep(2000);
            return "current time of Service is" + DateTime.Now.ToString();
        }
    }
}
