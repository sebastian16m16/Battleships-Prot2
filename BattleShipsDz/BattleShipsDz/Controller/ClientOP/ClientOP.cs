using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using BattleShipsDz.Model.Connection;
using SimpleTCP;

namespace BattleShipsDz.Controller.ClientOP
{
    class ClientOP
    {
        private SimpleBSClient client;
        private string HostIP;
        private int HostPort;

        public ClientOP(String username, string HostIp, int HostPort)
        {

            this.client = new SimpleBSClient(username);
            this.HostIP = HostIp;
            this.HostPort = HostPort;
            //
            //setup client
            //
            client.StringEncoder = Encoding.UTF8;
            client.Delimiter = 0x0;

            //assign behavioral methods
            client.DataReceived += Client_DataReceived;
            client.Connect(HostIp, HostPort);
            
            

        }

      
        private void Client_DataReceived(object sender, Message e)
        {

        }

    }
}
