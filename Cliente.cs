using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace WHAT
{
    class Cliente
    {
        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endpoint;

        Socket s_cliente;

        public Cliente(string ip, int port)
        {
            host = Dns.GetHostByName(ip);
            ipAddr = host.AddressList[0];
            endpoint = new IPEndPoint(ipAddr, port);

            s_cliente = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s_cliente.Connect(endpoint);

        }
        public void Start()
        {
            s_cliente.Connect(endpoint);
        }
        public void Send(String msg)
        {
            byte[] byteMsg = Encoding.ASCII.GetBytes(msg);
            s_cliente.Send(byteMsg);
            Console.WriteLine("Mensaje Enviado");
        }

    }
}
