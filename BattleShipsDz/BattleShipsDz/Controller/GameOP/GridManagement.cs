using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShipsDz.Model.ViewModels;

namespace BattleShipsDz.Controller.GameOP
{
    class GridManagement
    {
        private Tile SelectedTile { get; set; }
        private TileGrid CurrentTileGrid { get; set; }

        public GridManagement(TileGrid currentTileGrid)
        {
           this.CurrentTileGrid = currentTileGrid;
        }

        public void PlaceBoat(Tile SelectedBoat, Tile FromWhere)
        {
            this.SelectedTile = SelectedBoat;

            


        }
    }
}
