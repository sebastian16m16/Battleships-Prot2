using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShipsDz.Model.ViewModels;

namespace BattleShipsDz.Model.Events
{
    class EventState
    {
        public bool BoatPlaced = false;
        private TileGrid personalGrid = new TileGrid();
        private TileGrid battleShipsGrid = new TileGrid();
        private Tile SelectedBoat = new Tile();
        public bool Clicked = false;

        public EventState(TileGrid pGrid, TileGrid bGrid, bool PlacedBoat, Tile lastTile, bool clicked)
        {
            this.personalGrid.LoadGrid(pGrid.gridSize, pGrid.tilesImage);
            this.battleShipsGrid.LoadGrid(bGrid.gridSize, bGrid.tilesImage);

            this.personalGrid.inheritGrid(pGrid);
            this.battleShipsGrid.inheritGrid(bGrid);
            this.BoatPlaced = PlacedBoat;
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
