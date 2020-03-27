using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BattleShipsDz.Controller.ClientOP;
using BattleShipsDz.Model.ViewModels;

namespace BattleShipsDz.View
{
    public partial class GameUI : Form
    {
        //
        // Local Variables
        //
        private string PlayerName { get; set; }
        private string Host { get; set; }
        private int PORT { get; set; }
        private Point lastPoint { get; set; }



        public GameUI(string PlayerName, string Host, int Port)
        {
            InitializeComponent();
            this.PlayerName = PlayerName;
            this.Host = Host;
            this.PORT = Port;
        }

        private void GameUI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //ClientOP clientOP = new ClientOP(this.PlayerName, this.Host, this.PORT);
            this.lblPlayerName.Text = PlayerName;

            // PERSONAL GRID
            this.PersonalGrid.LoadGrid(new Size(10, 10), BattleShipsDz.Properties.Resources.blankTile);

            //OPPONENT GRID
            this.OpponentGrid.LoadGrid(new Size(10, 10), BattleShipsDz.Properties.Resources.opponentTile);

            //Battleships GRID
            this.BattleShipGrid.LoadGrid(new Size(1, 5), BattleShipsDz.Properties.Resources.blankTile);

        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GameUI_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void GameUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
