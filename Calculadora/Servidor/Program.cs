using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Contracts;

namespace Servidor
{
    class Program
    {
        // Main Method
        static void Main(string[] args)
        {
            ExecuteServer();
        }

        public static void ExecuteServer()
        {
            // Establish the local endpoint
            // for the socket. Dns.GetHostName
            // returns the name of the host
            // running the application.
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

            // Creation TCP/IP Socket using
            // Socket Class Constructor
            Socket listener = new Socket(ipAddr.AddressFamily,
                        SocketType.Stream, ProtocolType.Tcp);

            try
            {

                // Using Bind() method we associate a
                // network address to the Server Socket
                // All client that will connect to this
                // Server Socket must know this network
                // Address
                listener.Bind(localEndPoint);

                // Using Listen() method we create
                // the Client list that will want
                // to connect to Server
                listener.Listen(10);

                while (true)
                {

                    Console.WriteLine("Waiting connection ... ");

                    // Suspend while waiting for
                    // incoming connection Using
                    // Accept() method the server
                    // will accept connection of client
                    Socket clientSocket = listener.Accept();

                    // Data buffer
                    byte[] bytes = new Byte[1024];
                    string data = null;
                    string respuesta = "";

                    while (true)
                    {

                        int numByte = clientSocket.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes,
                                                0, numByte);
                        if (data.IndexOf("end") > -1)
                            break;
                    }

                    List<string> list = new List<string>();
                    list = data.Split(' ').ToList();
                    list.Remove("end");
                    ProductService calculadora = new ProductService();
                    if (list.Contains("+"))
                    {
                        respuesta = $"El resultado es: {calculadora.Suma(Convert.ToDouble(list.First()),Convert.ToDouble(list.Last()))}";
                    }
                    else if (list.Contains("-"))
                    {
                        respuesta = $"El resultado es: {calculadora.Resta(Convert.ToDouble(list.First()), Convert.ToDouble(list.Last()))}";
                    }
                    else if (list.Contains("*"))
                    {
                        respuesta = $"El resultado es: {calculadora.Multiplicacion(Convert.ToDouble(list.First()), Convert.ToDouble(list.Last()))}";
                    }
                    else if (list.Contains("/"))
                    {
                        if(calculadora.Division(Convert.ToDouble(list.First()), Convert.ToDouble(list.Last()))== -255)
                        {
                            respuesta = "No puedes dividir entre cero";
                        }
                        else
                        {
                            respuesta = $"El resultado es: {calculadora.Division(Convert.ToDouble(list.First()), Convert.ToDouble(list.Last()))}";
                        }
                    }
                    else
                    {
                        respuesta = "No hay operacion";
                    }


                    Console.WriteLine("Text received -> {0} ", data);
                    Console.WriteLine("Text send -> {0} ", respuesta);
                    byte[] message = Encoding.ASCII.GetBytes(respuesta);

                    // Send a message to Client
                    // using Send() method
                    clientSocket.Send(message);

                    // Close client Socket using the
                    // Close() method. After closing,
                    // we can use the closed Socket
                    // for a new Client Connection
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void Prueba()
        {

        }
    }
}
