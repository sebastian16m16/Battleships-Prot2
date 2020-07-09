using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShipsDz.Model.ViewModels;


namespace BattleShipsDz.Controller.GameOP
{
    class PersonalGridManagement
    {
        private Tile SelectedTile { get; set; }
        private TileGrid TileGrid { get; set; }
        private Tile From { get; set; }
        private Tile To { get; set; }
        private bool clicked { get; set; }

        private Tile Blank = new Tile();

        public PersonalGridManagement(TileGrid currentTileGrid)
        {
           this.TileGrid = currentTileGrid;
            this.clicked = false;
        }

        public bool Manage(Tile SelectedBoat, Tile LogicTile)
        {
            this.clicked = !clicked;

            if (clicked)
            {
                if (SelectedBoat != null)
                {
                    this.SelectedTile = SelectedBoat;
                    LogicTile.inheritTileInfo(SelectedTile);
                    this.From = LogicTile;
                }
                else
                {
                    this.clicked = false;
                }
            }
            else
            {
                if (PlaceBoat(LogicTile))
                    this.SelectedTile = null;
                else
                    this.clicked = true;
            }

            return clicked;
        }

        //
        // Private Methods
        //

        private bool PlaceBoat(Tile ToWhere)
        {
            this.To = ToWhere;

            if(To.x > From.x)
            {
                if (Math.Abs(To.x - From.x) >= Math.Abs(To.y - From.y))
                {
                    AddTilesOnXAxis();
                }
                else
                {
                    if (To.y > From.y)
                    {
                        AddTilesOnYAxis();
                    }
                    else
                    {
                        AddTilesOnNegativeYAxis();
                    }
                    
                }
            }
            else if(To.y > From.y)
            {
                if((From.x - To.x) >= (To.y - From.y))
                {
                    AddTilesOnNegativeXAxis();
                }
                else
                {
                    AddTilesOnYAxis();
                }
            }
            else if(To.x < From.x)
            {
                if ((From.x - To.x) >= (From.y - To.y))
                {
                    AddTilesOnNegativeXAxis();
                }
                else
                {
                    AddTilesOnNegativeYAxis();
                }
            }
            else if(To.y < From.y)
            {
                AddTilesOnNegativeYAxis();
            }
            else
            {
                return false;
            }
            return true;
        }

        private bool AddTilesOnXAxis()
        {
            if((this.From.x + this.SelectedTile.SQsize) < this.TileGrid.tiles.GetLength(0)+1)
            {
               for(int i=this.From.x; i<this.SelectedTile.SQsize + this.From.x; i++)
                {
                    this.TileGrid.tiles[i, this.From.y].inheritTileInfo(SelectedTile);
                }
                return true;
            }
           
            return false;
        }

        private bool AddTilesOnNegativeXAxis()
        {
            if ((this.From.x - (this.SelectedTile.SQsize - 1)) >= 0)
            {
                for (int i = this.From.x; i >this.From.x - this.SelectedTile.SQsize; i--)
                {
                    this.TileGrid.tiles[i, this.From.y].inheritTileInfo(SelectedTile);
                }
                return true;
            }

            return false;
        }

        private bool AddTilesOnYAxis()
        {
            if ((this.From.y + this.SelectedTile.SQsize) < this.TileGrid.tiles.GetLength(0) + 1)
            {
                for (int i = this.From.y; i < this.SelectedTile.SQsize + this.From.y; i++)
                {
                    this.TileGrid.tiles[this.From.x, i].inheritTileInfo(SelectedTile);
                }
                return true;
            }

            return false;
        }

        private bool AddTilesOnNegativeYAxis()
        {
            if ((this.From.y - (this.SelectedTile.SQsize - 1)) >= 0)
            {
                for (int i = this.From.y; i > this.From.y - this.SelectedTile.SQsize; i--)
                {
                    this.TileGrid.tiles[this.From.x, i].inheritTileInfo(SelectedTile);
                }
                return true;
            }

            return false;
        }
    }
}
