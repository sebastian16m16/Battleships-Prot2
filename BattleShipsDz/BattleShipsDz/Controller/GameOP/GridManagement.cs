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
        private TileGrid TileGrid { get; set; }
        private Tile From { get; set; }
        private Tile To { get; set; }
        private bool clicked { get; set; }
        private Tile Blank = new Tile();

        public GridManagement(TileGrid currentTileGrid)
        {
           this.TileGrid = currentTileGrid;
            this.clicked = false;
        }

        public bool Manage(Tile SelectedBoat, Tile LogicTile)
        {
            this.clicked = !clicked;

            if (clicked)
            {
                this.SelectedTile = SelectedBoat;
                LogicTile.inheritTileInfo(SelectedTile);
                this.From = LogicTile;
            }
            else
            {
                if (PlaceBoat(LogicTile))
                    this.SelectedTile = Blank;
                else
                    this.clicked = true;
            }

            return clicked;
        }

        private bool PlaceBoat(Tile ToWhere)
        {
            this.To = ToWhere;

            if(To.x > To.y)
            {
                if(To.x > this.From.x)
                {
                    AddTilesOnXAxis();
                }
                else if(To.x < this.From.x)
                {
                    AddTilesOnNegativeXAxis();
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                if (To.y > this.From.y)
                {
                    AddTilesOnYAxis();
                }
                else if (To.y < this.From.y)
                {
                    AddTilesOnNegativeYAxis();
                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }


        private bool AddTilesOnXAxis()
        {
            if((this.From.x + this.SelectedTile.SQsize) < this.TileGrid.tiles.GetLength(0))
            {
               
            }
           
            return false;
        }

        private bool AddTilesOnNegativeXAxis()
        {
            return false;
        }

        private bool AddTilesOnYAxis()
        {
            return false;
        }

        private bool AddTilesOnNegativeYAxis()
        {
            return false;
        }
    }
}
