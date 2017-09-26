using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapProviderCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCalculator" in both code and config file together.
    [ServiceContract]
    public interface IServiceCalculator
    {
        [OperationContract]
        int Add(int noOne, int noTwo);

        [OperationContract]
        int Subtract(int noOne, int noTwo);

        [OperationContract]
        int Multiply(int noOne, int noTwo);

        [OperationContract]
        int Divide(int noOne, int noTwo);

        [OperationContract]
        string HelloWorld();
    }
}
