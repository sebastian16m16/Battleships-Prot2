using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace BattleShipsDz.Model.ViewModels
{
    class TileGrid : Panel
    {
        public Size gridSize { get; set; }
        public Tile[,] tiles { get; set; }
        public Image tilesImage { get; set; }
        private bool InfoGrid { get; set; }


        public void LoadGrid(Size gridSize, Image tileImage)
        {
            this.Controls.Clear();

            this.gridSize = gridSize;
            this.Size = new Size(gridSize.Width * Tile.length, gridSize.Height * Tile.length);
            this.tiles = new Tile[gridSize.Width, gridSize.Height];
            this.tilesImage = tileImage;

            for (int x = 0; x < gridSize.Width; x++)
            {
                for (int y = 0; y < gridSize.Height; y++)
                {
                    tiles[x, y] = new Tile(x, y, tileImage, this.Location);

                    this.Controls.Add(tiles[x, y]);
                }
            }
        }

        public void LoadGrid(Size gridSize, Image tileImage, bool InfoGrid)
        {
            this.Controls.Clear();
            this.InfoGrid = InfoGrid;
            this.gridSize = gridSize;
            this.Size = new Size(gridSize.Width * Tile.length, gridSize.Height * Tile.length);
            this.tiles = new Tile[gridSize.Width, gridSize.Height];
            this.tilesImage = tileImage;

            tiles[0, 0] = new BattleShipsDz.Model.ViewModels.Boats.CruiserBoat(0, 0);
            tiles[0, 1] = new BattleShipsDz.Model.ViewModels.Boats.PatrolBoat(0, 1);
            tiles[0, 2] = new BattleShipsDz.Model.ViewModels.Boats.RedCrowBoat(0, 2);
            tiles[0, 3] = new BattleShipsDz.Model.ViewModels.Boats.ValvetShellBoat(0, 3);
            tiles[0, 4] = new BattleShipsDz.Model.ViewModels.Boats.VDragonBoat(0, 4);


            for (int i=0; i<gridSize.Height; i++)
            {
                this.Controls.Add(tiles[0, i]);
            }

        }

        public void inheritGrid(TileGrid other)
        {
            if(other != null)
            {
                for (int i = 0; i < gridSize.Width; i++)
                {
                    for (int j = 0; j < gridSize.Height; j++)
                    {
                        // Console.WriteLine(" BEFORE: This.name[" + i + "," + j + "] = " + this.tiles[i, j].tileName + ",   Other.name[" + i + "," + j + "] = " + other.tiles[i, j].tileName);
                        this.tiles[i, j].inheritTileInfo(other.tiles[i, j]);
                        //Console.WriteLine(" AFTER: This.name[" + i + "," + j + "] = " + this.tiles[i, j].tileName + ",   Other.name[" + i + "," + j + "] = " + other.tiles[i, j].tileName);
                    }
                }
            }
                
        }

    }
}
