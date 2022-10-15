using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TcpBiding.Contracts;

namespace TcpBiding.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ProductService : IProductService
    {
        string[] IProductService.GetStrings()
        {
            return new[] { "server1","server2","server3" };
        }
    }
}
