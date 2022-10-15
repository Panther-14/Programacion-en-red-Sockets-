using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        double Suma(double numero1, double numero2);
        [OperationContract]
        double Resta(double numero1, double numero2);
        [OperationContract]
        double Multiplicacion(double numero1, double numero2);
        [OperationContract]
        double Division(double numero1, double numero2);
    }
}
