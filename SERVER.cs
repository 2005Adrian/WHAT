using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace WHAT
{
    class SERVER

    {
        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endpoint;
        Socket s_Server;
        Socket s_cliente;

        public SERVER(string ip, int port)
        {
            host = Dns.GetHostByName(ip);
            ipAddr = host.AddressList[0];
            endpoint = new IPEndPoint(ipAddr, port);

            s_Server = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s_Server.Bind(endpoint);
            s_Server.Listen(10);

        }
        public void Start()
        {
            byte[] buffer = new byte[1024];
            string message;

            s_cliente = s_Server.Accept();
            s_cliente.Receive(buffer);
            message = Encoding.ASCII.GetString(buffer);
            Console.WriteLine("Se recibio el mensaje:" + message);
        }
    }
}
