using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSServerPrj.Model.States
{
    public enum ClientState
    {
        CLEAN,
        CONNECTED,
        FAILED_CONNECTION,
        SEND_NAME,
        SEND_BOARD,
        WAIT_OPPONNENT_CONNECTION,
        GET_SET,
        YOUR_TURN,
        WAIT_OPPONENT_TURN,
        LOSER,
        WINNER
    }
}
