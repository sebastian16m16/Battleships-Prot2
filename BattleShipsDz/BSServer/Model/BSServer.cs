
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;
using System.Net;
using System.Net.Sockets;

namespace BSServer.Model
{
    class BSServer : SimpleTcpServer
    {

        private int maxClients;
        public int MaxClients { get { return this.maxClients; } set { this.maxClients = value; } }
        public int[] clientsConnected;
        private string HOST_ip;
        private string HOST_port;

        //
        //Constructor (Initialize)
        //
        public BSServer()
        {
            this.StringEncoder = Encoding.UTF8;
            maxClients = 2;
            this.Delimiter = 0x0;
            this.HOST_ip = "10.129.62.128";
            this.HOST_port = "7000";

        }

        public BSServer(int maxClients, string hOST_ip, string hOST_port)
        {
            this.maxClients = maxClients;
            HOST_ip = hOST_ip;
            HOST_port = hOST_port;
        }




        //
        //Start the server with the embedded info
        //
        public void startBSServer()
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(HOST_ip);
            this.Start(ip, Convert.ToInt32(HOST_port));
        }


        //
        //stop the server
        //
        public void stopBSServer()
        {
            if (this.IsStarted)
            {
                this.Stop();
            }
        }

        //
        //Send message to specific Client
        //

        //
        //Send message to client
        //
        private void SendDATA(byte[] data, TcpClient client)
        {
            client.GetStream().Write(data, 0, data.Length);
        }

        //
        //Transform string to server message  --------- This is the method to call
        //                                                                  |
        public void SendDataToClient(string data, TcpClient client)             //  
        {                                                                       //
            if (data == null) { return; }                                       //
            SendDATA(StringEncoder.GetBytes(data), client);                //
        }                                                                       //
                                                                                //
        public void SendLineToClient(string data, TcpClient client)         //
        {                                                                       //
            if (string.IsNullOrEmpty(data)) { return; }                         //
            if (data.LastOrDefault() != Delimiter)
            {
                SendDataToClient(data + StringEncoder.GetString(new byte[] { Delimiter }), client);
            }
            else
            {
                SendDataToClient(data, client);
            }
        }




    }
}
