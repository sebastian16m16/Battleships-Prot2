using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShipsDz.Model.ViewModels;

namespace BattleShipsDz.Model.Events
{
    class PGEventState
    {
        private TileGrid personalGrid { get; set; }
        private TileGrid battleShipsGrid { get; set; }
        private Tile SelectedBoat { get; set; }
        public bool Clicked { get; set; }


        public PGEventState(TileGrid pGrid, TileGrid bGrid, Tile lastTile, bool clicked)
        {
            this.personalGrid = new TileGrid();
            this.battleShipsGrid = new TileGrid();

            this.personalGrid.LoadGrid(pGrid.gridSize, pGrid.tilesImage);
            this.battleShipsGrid.LoadGrid(bGrid.gridSize, bGrid.tilesImage);

            this.personalGrid.inheritGrid(pGrid);
            this.battleShipsGrid.inheritGrid(bGrid);
            this.SelectedBoat = lastTile;
            this.Clicked = clicked;


        }

        public TileGrid getLastPersonalGrid()
        {
            return this.personalGrid;
        }

        public TileGrid getLastBattleshipGrid()
        {
            return this.battleShipsGrid;
        }

        public void UpdateEventState(TileGrid pGrid, TileGrid bGrid)
        {
            this.personalGrid = pGrid;
            this.battleShipsGrid = bGrid;
        }

        public Tile GetSelectedBoat()
        {
            return this.SelectedBoat;
        }
    }
}
