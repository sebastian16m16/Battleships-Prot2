
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;
using System.Net;
using System.Net.Sockets;

namespace BSServerPrj.Model
{
    class SimpleBSServer : SimpleTcpServer
    {

        private int maxClients;
        public int MaxClients { get { return this.maxClients; } set { this.maxClients = value; } }
        public BSClient[] clientsConnected;
        private string HOST_ip;
        private string HOST_port;

        //
        //Constructor (Initialize)
        //
        public SimpleBSServer()
        {
            this.StringEncoder = Encoding.UTF8;
            maxClients = 2;
            this.Delimiter = 0x0;
            this.HOST_ip = "10.129.62.128";
            this.HOST_port = "7000";

        }

        public SimpleBSServer(int maxClients, string hOST_ip, string hOST_port)
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
    }
}
