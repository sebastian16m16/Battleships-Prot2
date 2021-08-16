using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using BSServerPrj.Model;

namespace BSServerPrj.Control
{
    class BSServerOP
    {
        private BSServer Server;
        private int rows { get; }
        private int columns { get; }
        private string clientMessage;
        private int currentClient = 0;
        private TcpClient ServerClient;

        //coordonates from client
        private string[] coordonates;


        public BSServerOP(BSServer _newServer)
        {
            this.Server = _newServer;
            rows = columns = 10;
            //assign methods for behaviour
            Server.ClientConnected += client_connected;
            Server.ClientDisconnected += client_disconnected;
            Server.DataReceived += data_received;
        }


        //                                                      //
        //                  BEHAVIORAL METHODS                  //
        //                                                      //

        //
        //What happens when the client disconnects
        //
        private void client_disconnected(object sender, TcpClient e)
        {
            Server.BroadcastLine("OPPONENT_DISCONNECTED");

            currentClient--;
        }

        //
        //What Happens when a client connects
        //
        private void client_connected(object sender, TcpClient e)
        {
            if (Server.ConnectedClientsCount < 2)
            {
                //add client
                Server.clientsConnected[currentClient] = (BSClient)e;

                //set client to CONNECTED state
                Server.clientsConnected[currentClient].state = ClientSTATE.CONNECTED;

                //increment client clientsConnected index
                currentClient++;

                //Send accepted response
                Server.SendLineToClient("SUCCESS", (BSClient)e);
                Console.WriteLine("Client with IP: " + ((IPEndPoint)e.Client.RemoteEndPoint).Address.ToString() + " ----> Connected!");

            }
            else
            {
                Server.SendLineToClient("FAILED", (BSClient)e);
                ((BSClient)e).state = ClientSTATE.FAILED_CONNECTION;
                ((BSClient)e).Close();
                Console.WriteLine("FAILED");
            }

        }

        //
        //React to client ouptut
        //
        private void data_received(object sender, Message e)
        {
            clientMessage = e.MessageString;
            Console.WriteLine(clientMessage);
            ServerClient = (BSClient)sender;

            switch (ServerClient.state)
            {
                case ClientSTATE.CONNECTED:

                    ServerClient.state = ClientSTATE.SEND_NAME;
                    Server.SendLineToClient("SEND_NAME", ServerClient);
                    break;


                case ClientSTATE.SEND_NAME:

                    ServerClient.state = ClientSTATE.GET_SET;
                    ServerClient.Name = clientMessage;
                    Server.SendLineToClient("GET_SET", ServerClient);
                    break;

                case ClientSTATE.GET_SET:

                    if (clientMessage == "SET")
                    {
                        ServerClient.state = ClientSTATE.SEND_BOARD;
                        Server.SendLineToClient("SEND_BOARD", ServerClient);
                    }
                    break;

                case ClientSTATE.SEND_BOARD:

                    ServerClient.personalTable = getBoard(clientMessage);
                    ServerClient.state = ClientSTATE.WAIT_OPPONNENT_CONNECTION;
                    break;

                case ClientSTATE.WAIT_OPPONNENT_CONNECTION:

                    //check to see if every client is in WAIT_OPPONENT_CONNECTION state
                    if (shouldWeStart())
                    {
                        Server.BroadcastLine("START");
                        Server.SendLineToClient("YOUR_TURN", Server.clientsConnected[0]);
                        Server.clientsConnected[0].state = ClientSTATE.YOUR_TURN;
                        Server.clientsConnected[1].state = ClientSTATE.WAIT_OPPONENT_TURN;

                    }
                    else
                    {
                        Server.SendLineToClient("WAIT_OPPONENT_CONNECTION", ServerClient);
                    }
                    break;

                case ClientSTATE.YOUR_TURN:
                    coordonates = Regex.Split(clientMessage, @"\D+");
                    if (coordonates.Length == 2)
                    {
                        shoot(int.Parse(coordonates[0]), int.Parse(coordonates[1]));

                        Server.SendLineToClient("YOUR_TURN", opponent());

                        if (!GameStatus())
                        {
                            Server.BroadcastLine("END");
                            break;
                        }

                        //change turns
                        ServerClient.state = ClientSTATE.WAIT_OPPONENT_TURN;
                        opponent().state = ClientSTATE.YOUR_TURN;
                    }

                    break;
            }

        }


        //                                                      //
        //                     OTHER METHODS                    //
        //                                                      //

        //
        //transform string into matrix
        //
        public ElementState[,] getBoard(string data)
        {
            ElementState[,] matrix = new ElementState[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = (ElementState)data[i * rows + j];
                }
            }

            return matrix;
        }


        //See if both players reached the end of the connection process
        public bool shouldWeStart()
        {

            foreach (var client in Server.clientsConnected)
            {
                if (client.state != ClientSTATE.WAIT_OPPONNENT_CONNECTION)
                {
                    return false;
                }
            }

            return true;
        }

        //get opponent of player who's turn is
        public BSClient opponent()
        {
            foreach (var client in Server.clientsConnected)
            {
                if (client.state == ClientSTATE.WAIT_OPPONENT_TURN)
                    return client;
            }
            return null;
        }

        //
        //get the player who's turn is
        //
        public BSClient thisPlayer()
        {
            foreach (var client in Server.clientsConnected)
            {
                if (client.state == ClientSTATE.YOUR_TURN)
                    return client;
            }
            return null;
        }



        //
        //Change elemenet state if it is hit or missed
        //
        public void shoot(int x, int y)
        {
            switch (opponent().personalTable[x, y])
            {
                case ElementState.BOAT:

                    opponent().personalTable[x, y] = ElementState.HIT;
                    thisPlayer().opponentTable[x, y] = ElementState.HIT;
                    break;

                case ElementState.CLEAR:

                    opponent().personalTable[x, y] = ElementState.MISS;
                    thisPlayer().opponentTable[x, y] = ElementState.MISS;
                    break;
            }
        }


        //
        //CHECK GAME STATUS
        //
        public bool GameStatus()
        {
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (thisPlayer().personalTable[i, j] == ElementState.HIT)
                        count++;
                }
            }

            if (count == opponent().numberOfBoatTiles)
            {
                opponent().state = ClientSTATE.LOSER;
                thisPlayer().state = ClientSTATE.WINNER;
                return false;
            }
            return true;
        }
    }
}
