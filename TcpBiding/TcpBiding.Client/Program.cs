using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using TcpBiding.Contracts;

namespace TcpBiding.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to enter");
            Console.ReadLine();
            var uri = "net.tcp://localhost:4345/ProductService";
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
            var channel = new ChannelFactory<IProductService>(binding);
            var endpoint = new EndpointAddress(uri);
            var proxy = channel.CreateChannel(endpoint);
            proxy?.GetStrings().ToList().ForEach(p => Console.WriteLine(p));
            Console.ReadLine();
        }
    }
}
