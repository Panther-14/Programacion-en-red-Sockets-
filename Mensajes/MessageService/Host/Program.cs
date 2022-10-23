using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

//WCF utiliza RPC, se va utilizar el host atraves de un proceso, HOST toma el contrato y lo pone a lared
// Para que otros servicios lo pueda tener, se necesita una interfaz para que sea el contrato 
//(tipo de retono, parametros de entrada, clases)
// Y una clase para implementar los metodos,
// Los contratos que se exponen son las intergaces

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MessageService.MessageService)))
            {
                    host.Open(); //Levantar el servicio y escuchar en la red, y el SO le dice Nel prro
                    Console.WriteLine("Server is running");
                    Console.ReadLine();
            }
        }
    }
}
