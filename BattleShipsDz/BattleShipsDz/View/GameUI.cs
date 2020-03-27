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
    public partial class GameUI : Form
    {
        public GameUI()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ClientOP clientOP = new ClientOP(txtUserName.Text, txtServerIP.Text, Convert.ToInt32(txtServerPORT.Text));
        }
    }
}
