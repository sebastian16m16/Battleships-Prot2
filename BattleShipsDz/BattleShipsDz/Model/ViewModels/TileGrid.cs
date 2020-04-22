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
        public Label[] NoOfBoatsLeft { get; set; }
        public Label[] SizeOfBoat { get; set; }


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

            this.NoOfBoatsLeft = new Label[gridSize.Height]; 
            this.SizeOfBoat = new Label[gridSize.Height]; ;

            tiles[0, 0] = new BattleShipsDz.Model.ViewModels.Boats.CruiserBoat(0, 0);
            tiles[0, 1] = new BattleShipsDz.Model.ViewModels.Boats.PatrolBoat(0, 1);
            tiles[0, 2] = new BattleShipsDz.Model.ViewModels.Boats.RedCrowBoat(0, 2);
            tiles[0, 3] = new BattleShipsDz.Model.ViewModels.Boats.ValvetShellBoat(0, 3);
            tiles[0, 4] = new BattleShipsDz.Model.ViewModels.Boats.VDragonBoat(0, 4);


            for (int i=0; i<gridSize.Height; i++)
            {
                this.Controls.Add(tiles[0, i]);

                //
                //Labels Locations
                //

                //
                //Number of Boats Left
                //
                NoOfBoatsLeft[i] = new Label();
                NoOfBoatsLeft[i].Size = new Size(11, 11);
                NoOfBoatsLeft[i].Text = tiles[0, i].ships.ToString();
                NoOfBoatsLeft[i].ForeColor = Color.White;
                NoOfBoatsLeft[i].BackColor = tiles[0, i].getTileColor();
                NoOfBoatsLeft[i].Location = tiles[0, i].getNumberLabelLocation();
                tiles[0, i].Controls.Add(NoOfBoatsLeft[i]);

                //
                //Size of the boat
                //
                SizeOfBoat[i] = new Label();
                SizeOfBoat[i].Size = new Size(11, 11);
                SizeOfBoat[i].Text = tiles[0, i].SQsize.ToString();
                SizeOfBoat[i].ForeColor = Color.White;
                SizeOfBoat[i].BackColor = tiles[0, i].getTileColor();
                SizeOfBoat[i].Location = tiles[0, i].getSizeLabelLocation();
                tiles[0, i].Controls.Add(SizeOfBoat[i]);

            }

        }

        public void inheritGrid(TileGrid other)
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
