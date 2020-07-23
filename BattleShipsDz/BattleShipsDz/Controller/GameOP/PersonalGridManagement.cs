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
        public bool clicked { get; set; }

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
                    LogicTile.state = TileState.OCCUPIED;
                    this.From = LogicTile;
                }
                else
                {
                    this.clicked = false;
                }
            }
            else
            {
                if (!PlaceBoat(LogicTile))
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
            bool ret = false;

            if(To.x > From.x)
            {
                if (Math.Abs(To.x - From.x) >= Math.Abs(To.y - From.y))
                {
                    ret = AddTilesOnXAxis();
                }
                else
                {
                    if (To.y > From.y)
                    {
                        ret = AddTilesOnYAxis();
                    }
                    else
                    {
                        ret = AddTilesOnNegativeYAxis();
                    }
                    
                }
            }
            else if(To.y > From.y)
            {
                if((From.x - To.x) >= (To.y - From.y))
                {
                    ret = AddTilesOnNegativeXAxis();
                }
                else
                {
                    ret = AddTilesOnYAxis();
                }
            }
            else if(To.x < From.x)
            {
                if ((From.x - To.x) >= (From.y - To.y))
                {
                    ret = AddTilesOnNegativeXAxis();
                }
                else
                {
                    ret = AddTilesOnNegativeYAxis();
                }
            }
            else if(To.y < From.y)
            {
                ret = AddTilesOnNegativeYAxis();
            }
            return ret;
        }

        private bool AddTilesOnXAxis()
        {
            if((this.From.x + this.SelectedTile.SQsize) < this.TileGrid.tiles.GetLength(0)+1)
            {
               for(int i=this.From.x+1; i<this.SelectedTile.SQsize + this.From.x; i++)
               {
                    if (this.TileGrid.tiles[i, this.From.y].state == TileState.OCCUPIED)
                        return false;
               }
               for(int i=this.From.x+1; i<this.SelectedTile.SQsize + this.From.x; i++)
               {
                    this.TileGrid.tiles[i, this.From.y].inheritTileInfo(SelectedTile);
                    this.TileGrid.tiles[i, this.From.y].state = TileState.OCCUPIED;
               }
                return true;
            }
           
            return false;
        }

        private bool AddTilesOnNegativeXAxis()
        {
            if ((this.From.x - (this.SelectedTile.SQsize - 1)) >= 0)
            {
                for (int i = this.From.x - 1; i > this.From.x - this.SelectedTile.SQsize; i--)
                {
                    if (this.TileGrid.tiles[i, this.From.y].state == TileState.OCCUPIED)
                        return false;
                }
                for (int i = this.From.x-1; i >this.From.x - this.SelectedTile.SQsize; i--)
                {
                    this.TileGrid.tiles[i, this.From.y].inheritTileInfo(SelectedTile);
                    this.TileGrid.tiles[i, this.From.y].state = TileState.OCCUPIED;
                }
                return true;
            }

            return false;
        }

        private bool AddTilesOnYAxis()
        {
            if ((this.From.y + this.SelectedTile.SQsize) < this.TileGrid.tiles.GetLength(0) + 1)
            {
                for (int i = this.From.y + 1; i < this.SelectedTile.SQsize + this.From.y; i++)
                {
                    if (this.TileGrid.tiles[this.From.x, i].state == TileState.OCCUPIED)
                        return false;
                }
                for (int i = this.From.y+1; i < this.SelectedTile.SQsize + this.From.y; i++)
                {
                    this.TileGrid.tiles[this.From.x, i].inheritTileInfo(SelectedTile);
                    this.TileGrid.tiles[this.From.x, i].state = TileState.OCCUPIED;
                }
                return true;
            }

            return false;
        }

        private bool AddTilesOnNegativeYAxis()
        {
            if ((this.From.y - (this.SelectedTile.SQsize - 1)) >= 0)
            {
                for (int i = this.From.y - 1; i > this.From.y - this.SelectedTile.SQsize; i--)
                {
                    if (this.TileGrid.tiles[this.From.x, i].state == TileState.OCCUPIED)
                        return false;
                }
                for (int i = this.From.y - 1; i > this.From.y - this.SelectedTile.SQsize; i--)
                {
                    this.TileGrid.tiles[this.From.x, i].inheritTileInfo(SelectedTile);
                    this.TileGrid.tiles[this.From.x, i].state = TileState.OCCUPIED;
                }
                return true;
            }

            return false;
        }
    }
}
