namespace BattleShipsDz.Model.Connection
{
    public enum ClientSTATE
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