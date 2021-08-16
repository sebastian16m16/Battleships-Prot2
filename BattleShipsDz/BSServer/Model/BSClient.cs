using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSServerPrj.Model.States;
using SimpleTCP;

namespace BSServerPrj.Model
{
    class BSClient : SimpleTcpClient
    {
        public string Name { get; set; }
        public ElementState[,] PersonalStates;
        public ElementState[,] OpponentStates;

        public BSClient(string name)
        {
            Name = name;
        }
    }
}
