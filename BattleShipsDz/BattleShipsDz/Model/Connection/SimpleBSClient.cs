using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using BattleShipsDz.Model.BackgroudMatrix;
using SimpleTCP;

namespace BattleShipsDz.Model.Connection
{
    class SimpleBSClient : SimpleTcpClient
    {
        //personalization and game fields
        public string Name { get; set; }
        public ClientSTATE state { get; set; }
        public ElementState[,] personalTable;
        public ElementState[,] opponentTable;
        public int numberOfBoatTiles;


        public SimpleBSClient(string _name)
        {
            this.Name = _name;
            this.state = ClientSTATE.CLEAN;
        }

    }
}
