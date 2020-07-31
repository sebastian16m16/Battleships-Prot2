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
using BattleShipsDz.Controller.GameOP;
using BattleShipsDz.Model.Events;
using System.Diagnostics;

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
        private Tile SelectedBoat { get; set; }
        private OpponentGridManagement OpponentGridManagement { get; set; }
        private PersonalGridManagement PersonalGridManagement { get; set; }
        private Stack<PGEventState> PGEventState { get; set; }
        private OGEventState OGEventState { get; set; }
        private PGEventState PGtempState { get; set; }
        private Tile Blank { get; set; }
        private bool CanIPush { get; set; }



        public GameUI(string PlayerName, string Host, int Port)
        {
            InitializeComponent();
            this.PlayerName = PlayerName;
            this.Host = Host;
            this.PORT = Port;
            this.PGEventState = new Stack<PGEventState>();
            this.Blank = new Tile();
        }

        private void GameUI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //ClientOP clientOP = new ClientOP(this.PlayerName, this.Host, this.PORT);
            this.lblPlayerName.Text = PlayerName;

            // PERSONAL GRID
            this.PersonalGrid.LoadGrid(new Size(10, 10), BattleShipsDz.Properties.Resources.blankTile);

            foreach(Tile tile in PersonalGrid.Controls)
            {
                tile.MouseDown += PersonalGridMouseDown;
            }

            //OPPONENT GRID
            this.OpponentGrid.LoadGrid(new Size(10, 10), BattleShipsDz.Properties.Resources.opponentTile);
            this.OpponentGridManagement = new OpponentGridManagement(OpponentGrid);

            foreach(Tile tile in OpponentGrid.Controls)
            {
                tile.MouseDown += OpponentGridMouseDown;
            }

            //Battleships GRID
            this.BattleShipsGrid.LoadGrid(new Size(1, 5), BattleShipsDz.Properties.Resources.blankTile, true);

            foreach(Tile tile in BattleShipsGrid.Controls)
            {
                tile.MouseDown += BattleShipGridMouseDown;
            }

            this.PersonalGridManagement = new PersonalGridManagement(PersonalGrid, BattleShipsGrid);

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
            if(e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }

        }

        [DebuggerStepThrough]
        private void GameUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        //
        // TILES Behavior
        //

        private void OpponentGridMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(((Tile)sender).state == TileState.UNTOUCHED){
                    if (!this.OpponentGridManagement.shotAttepmpted)
                    {
                        this.OGEventState = new OGEventState(this.OpponentGrid);
                        this.OpponentGridManagement.Manage((Tile)sender);
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if(this.OpponentGridManagement.shotAttepmpted == true)
                {
                    this.OpponentGrid.inheritGrid(OGEventState.getLastOpponentGrid());
                    this.OpponentGridManagement.shotAttepmpted = false;
                }
            }
        }

        private void PersonalGridMouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(SelectedBoat != null)
                {
                    if ((!SelectedBoat.Equals(Blank)) 
                        && (((Tile)sender).state == TileState.UNTOUCHED))
                    {
                        //this.PGEventState.Push(new PGEventState(PersonalGrid, BattleShipGrid, SelectedBoat, this.PersonalGridManagement.clicked));
                        
                        if (!this.PersonalGridManagement.Manage(this.SelectedBoat, (Tile)sender, this.PGEventState))
                        {
                            this.SelectedBoat = Blank;
                        }
                        
                    }
                }
            }else if(e.Button == MouseButtons.Right)
            {
                if(PGEventState.Count != 0)
                {
                    this.PGtempState = PGEventState.Pop();
                    this.PersonalGridManagement.clicked = PGtempState.Clicked;
                    this.SelectedBoat = PGtempState.GetSelectedBoat();
                    this.PersonalGrid.inheritGrid(PGtempState.getLastPersonalGrid());
                }
            }
            
        }

        private void BattleShipGridMouseDown(object sender, MouseEventArgs e)
        {
            if(((Tile)sender).ships > 0)
                SelectedBoat = (Tile)sender;
            //this.PGEventState.Push(new PGEventState(PersonalGrid, BattleShipGrid, SelectedBoat, this.PersonalGridManagement.clicked));
        }

        private void ShootBtn_Click(object sender, EventArgs e)
        {
            this.OpponentGridManagement.shotAttepmpted = false;
        }
    }
}
