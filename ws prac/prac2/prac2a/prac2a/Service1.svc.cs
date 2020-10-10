using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace prac2a
{
    public class Service1 : IService1
    {
        public void OneWayMessage()
        {
            Thread.Sleep(2000);
        }
    }
}
