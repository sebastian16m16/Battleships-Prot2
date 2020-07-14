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
        private PersonalGridManagement OpponentGridManagement { get; set; }
        private PersonalGridManagement PersonalGridManagement { get; set; }
        private bool OneMoveUndo { get; set; }
        private Stack<EventState> EventStack { get; set; }
        private EventState tempState { get; set; }
        private Tile Blank { get; set; }



        public GameUI(string PlayerName, string Host, int Port)
        {
            InitializeComponent();
            this.PlayerName = PlayerName;
            this.Host = Host;
            this.PORT = Port;
            this.EventStack = new Stack<EventState>();
            this.Blank = new Tile();
        }

        private void GameUI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //ClientOP clientOP = new ClientOP(this.PlayerName, this.Host, this.PORT);
            this.lblPlayerName.Text = PlayerName;

            // PERSONAL GRID
            this.PersonalGrid.LoadGrid(new Size(10, 10), BattleShipsDz.Properties.Resources.blankTile);
            this.PersonalGridManagement = new PersonalGridManagement(PersonalGrid);

            foreach(Tile tile in PersonalGrid.Controls)
            {
                tile.MouseDown += PersonalGridMouseDown;
            }

            //OPPONENT GRID
            this.OpponentGrid.LoadGrid(new Size(10, 10), BattleShipsDz.Properties.Resources.opponentTile);
            this.OpponentGridManagement = new PersonalGridManagement(OpponentGrid);

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
            throw new NotImplementedException();
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
                        this.EventStack.Push(new EventState(PersonalGrid, BattleShipGrid, false, SelectedBoat, this.PersonalGridManagement.clicked));
                        if (!this.PersonalGridManagement.Manage(this.SelectedBoat, (Tile)sender))
                        {
                            this.SelectedBoat = Blank;
                        }
                        OneMoveUndo = false;
                    }
                }
            }else if(e.Button == MouseButtons.Right)
            {
                if(EventStack.Count != 0)
                {
                    this.tempState = EventStack.Pop();
                    this.PersonalGridManagement.clicked = tempState.Clicked;
                    this.SelectedBoat = tempState.GetSelectedBoat();
                    this.PersonalGrid.inheritGrid(tempState.getLastPersonalGrid());
                    OneMoveUndo = true;
                }
            }
            
        }

        private void BattleShipGridMouseDown(object sender, MouseEventArgs e)
        {
            if(((Tile)sender).ships > 0)
                SelectedBoat = (Tile)sender;
            this.EventStack.Push(new EventState(PersonalGrid, BattleShipGrid, true, SelectedBoat, this.PersonalGridManagement.clicked));
        }
    }
}
