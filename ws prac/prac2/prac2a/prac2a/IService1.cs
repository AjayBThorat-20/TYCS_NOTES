using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace prac2a
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract(IsOneWay = true)]
        void OneWayMessage();
    }
}

