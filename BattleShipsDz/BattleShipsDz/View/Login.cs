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

namespace BattleShipsDz.View
{
    public partial class Login : Form
    {
        Point lastPoint;
        public Login()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "" || txtServerIP.Text == "" || txtServerPORT.Text == "")
            {
                MessageBox.Show("Please Fill all Fields to proceed!");
            }
            else
            {
                if (IsDigitsOnly(txtServerPORT.Text))
                {
                    this.Hide();
                    GameUI gameUI = new GameUI(txtUserName.Text, txtServerIP.Text, Convert.ToInt32(txtServerPORT.Text));
                    gameUI.Show();
                }
                else
                {
                    MessageBox.Show("Please enter only digits in the PORT Field!");
                }
                
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.AcceptButton = this.btnStart;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //
        // LOCAL Methods
        //
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
