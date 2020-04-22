﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BattleShipsDz.Model.ViewModels.Boats
{
    class RedCrowBoat : Tile
    {
        public RedCrowBoat(int x, int y)
        {
            this.Name = $"RedCrow_Boat_{x}_{y}";
            this.Location = new Point(x * length, y * length);
            this.GPosition = new Point(x, y);
            this.Size = new Size(length, length);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.SQsize = 5;
            this.ships = 2;
            this.Image = Properties.Resources.RedCrowBoat;
            this.type = typeof(RedCrowBoat);
            this.tileName = "RedCrow";


            //
            //Number of Boats Left
            //
            this.NoOfBoatsLeft = new Label();
            this.NoOfBoatsLeft.Size = new Size(11, 11);
            this.NoOfBoatsLeft.Text = this.ships.ToString();
            this.NoOfBoatsLeft.ForeColor = Color.White;
            this.NoOfBoatsLeft.BackColor = this.getTileColor();
            this.NoOfBoatsLeft.Location = this.getNumberLabelLocation();
            this.Controls.Add(NoOfBoatsLeft);
            //
            //Size of the boat
            //
            this.SizeOfBoat = new Label();
            this.SizeOfBoat.Size = new Size(11, 11);
            this.SizeOfBoat.Text = this.SQsize.ToString();
            this.SizeOfBoat.ForeColor = Color.White;
            this.SizeOfBoat.BackColor = this.getTileColor();
            this.SizeOfBoat.Location = this.getSizeLabelLocation();
            this.Controls.Add(SizeOfBoat);
        }
    }
}
