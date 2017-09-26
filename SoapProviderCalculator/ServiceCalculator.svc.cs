using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapProviderCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCalculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCalculator.svc or ServiceCalculator.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCalculator : IServiceCalculator
    {
        public int Add(int noOne, int noTwo)
        {
            int result = noOne + noTwo;
            return result;
        }

        public int Subtract(int noOne, int noTwo)
        {
            int result = noOne - noTwo;
            return result;
        }

        public int Multiply(int noOne, int noTwo)
        {
            int result = noOne*noTwo;
            return result;
        }

        public int Divide(int noOne, int noTwo)
        {
            int result = noOne/noTwo;
            return result;
        }

        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
