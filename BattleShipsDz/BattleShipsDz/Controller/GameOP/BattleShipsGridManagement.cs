using BattleShipsDz.Model.ViewModels;
using BattleShipsDz.Model.ViewModels.Boats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsDz.Controller.GameOP
{
    class BattleShipsGridManagement
    {
        TileGrid bsGrid { get; set; }

        public BattleShipsGridManagement(TileGrid bsGrid)
        {
            this.bsGrid = bsGrid;
        }

        public bool ConsumeBoat(Tile boat)
        {
            bool ret = false;

            if(boat.ships > 0)
            {
                int oldNoOfShips = boat.ships;
                boat.ships--;
                boat.NoOfBoatsLeft.Text = boat.ships.ToString();

                if (oldNoOfShips > boat.ships)
                    ret = true;
            }
            

            return ret;
        }
    }
}
