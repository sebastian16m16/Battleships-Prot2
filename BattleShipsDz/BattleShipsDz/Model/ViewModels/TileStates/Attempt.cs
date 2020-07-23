using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipsDz.Model.ViewModels.TileStates
{
    class Attempt : Tile
    {
        public Attempt(int x, int y)
        {
            this.Name = $"Attempt_{x}_{y}";
            this.Location = new Point(x * length, y * length);
            this.GPosition = new Point(x, y);
            this.Size = new Size(length, length);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.SQsize = 0;
            this.ships = 0;
            this.Image = Properties.Resources.Attempt;
            this.type = typeof(Attempt);
            this.tileName = "Attempt";
        }
    }
}
