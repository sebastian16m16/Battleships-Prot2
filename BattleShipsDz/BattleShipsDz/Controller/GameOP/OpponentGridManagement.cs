using BattleShipsDz.Model.ViewModels;
using BattleShipsDz.Model.ViewModels.TileStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsDz.Controller.GameOP
{
    class OpponentGridManagement
    {
        private TileGrid OponentGrid { get; set; }
        public bool shotAttepmpted { get; set; }
        private Attempt AttemptTile { get; set; }

        public OpponentGridManagement(TileGrid oponentGrid)
        {
            OponentGrid = oponentGrid;
            this.AttemptTile = new Attempt(0,0);
            this.shotAttepmpted = false;
        }

        public bool Manage(Tile senderTile)
        {
            bool ret = false;

            if (!this.shotAttepmpted)
            {
                this.AttemptTile.x = senderTile.x;
                this.AttemptTile.y = senderTile.y;
                senderTile.inheritTileInfo(AttemptTile);
                senderTile.state = TileState.ATTEMPT;
                this.shotAttepmpted = true;
                ret = true;
            }
            return ret;
        }
    }
}
