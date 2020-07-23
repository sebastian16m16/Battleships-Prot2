using BattleShipsDz.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsDz.Model.Events
{
    class OGEventState
    {
        private TileGrid OpponentGrid { get; set; }

        public OGEventState(TileGrid opponentGrid)
        {
            this.OpponentGrid = new TileGrid();

            this.OpponentGrid.LoadGrid(opponentGrid.gridSize, opponentGrid.tilesImage);

            this.OpponentGrid.inheritGrid(opponentGrid);
        }

        public TileGrid getLastOpponentGrid()
        {
            return this.OpponentGrid;
        }
    }
}
