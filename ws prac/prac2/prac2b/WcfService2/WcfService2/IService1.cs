using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace WcfService2
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract(IsOneWay = false)]
        //declare the method which return type is string  
        string RequestReplyPattern();

    }
}
