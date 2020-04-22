namespace BattleShipsDz.View
{
    partial class GameUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.PersonalGrid = new BattleShipsDz.Model.ViewModels.TileGrid();
            this.BattleShipGrid = new BattleShipsDz.Model.ViewModels.TileGrid();
            this.OpponentGrid = new BattleShipsDz.Model.ViewModels.TileGrid();
            this.xBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BattleShipsGrid = new BattleShipsDz.Model.ViewModels.TileGrid();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPlayerName.Location = new System.Drawing.Point(22, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(44, 14);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "label1";
            // 
            // PersonalGrid
            // 
            this.PersonalGrid.gridSize = new System.Drawing.Size(0, 0);
            this.PersonalGrid.Location = new System.Drawing.Point(25, 67);
            this.PersonalGrid.Name = "PersonalGrid";
            this.PersonalGrid.Size = new System.Drawing.Size(481, 432);
            this.PersonalGrid.TabIndex = 1;
            this.PersonalGrid.tiles = null;
            this.PersonalGrid.tilesImage = null;
            // 
            // BattleShipGrid
            // 
            this.BattleShipGrid.gridSize = new System.Drawing.Size(0, 0);
            this.BattleShipGrid.Location = new System.Drawing.Point(585, 176);
            this.BattleShipGrid.Name = "BattleShipGrid";
            this.BattleShipGrid.Size = new System.Drawing.Size(59, 258);
            this.BattleShipGrid.TabIndex = 2;
            this.BattleShipGrid.tiles = null;
            this.BattleShipGrid.tilesImage = null;
            // 
            // OpponentGrid
            // 
            this.OpponentGrid.gridSize = new System.Drawing.Size(0, 0);
            this.OpponentGrid.Location = new System.Drawing.Point(689, 67);
            this.OpponentGrid.Name = "OpponentGrid";
            this.OpponentGrid.Size = new System.Drawing.Size(488, 432);
            this.OpponentGrid.TabIndex = 3;
            this.OpponentGrid.tiles = null;
            this.OpponentGrid.tilesImage = null;
            // 
            // xBtn
            // 
            this.xBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.xBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.xBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xBtn.ForeColor = System.Drawing.Color.Maroon;
            this.xBtn.Location = new System.Drawing.Point(1174, 8);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(28, 24);
            this.xBtn.TabIndex = 4;
            this.xBtn.Text = "x";
            this.xBtn.UseVisualStyleBackColor = false;
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minimizeBtn.ForeColor = System.Drawing.Color.Maroon;
            this.minimizeBtn.Location = new System.Drawing.Point(1149, 8);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 24);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Niagara Engraved", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.DimGray;
            this.TitleLabel.Location = new System.Drawing.Point(555, 13);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(101, 35);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "BattleShips";
            // 
            // BattleShipsGrid
            // 
            this.BattleShipsGrid.gridSize = new System.Drawing.Size(0, 0);
            this.BattleShipsGrid.Location = new System.Drawing.Point(585, 176);
            this.BattleShipsGrid.Name = "BattleShipsGrid";
            this.BattleShipsGrid.Size = new System.Drawing.Size(59, 258);
            this.BattleShipsGrid.TabIndex = 2;
            this.BattleShipsGrid.tiles = null;
            this.BattleShipsGrid.tilesImage = null;
            this.BattleShipsGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BattleShipGridMouseDown);
            // 
            // GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1214, 626);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.OpponentGrid);
            this.Controls.Add(this.BattleShipsGrid);
            this.Controls.Add(this.BattleShipGrid);
            this.Controls.Add(this.PersonalGrid);
            this.Controls.Add(this.lblPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameUI";
            this.Text = "GameUI";
            this.Load += new System.EventHandler(this.GameUI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameUI_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private Model.ViewModels.TileGrid PersonalGrid;
        private Model.ViewModels.TileGrid BattleShipGrid;
        private Model.ViewModels.TileGrid OpponentGrid;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Label TitleLabel;
        private Model.ViewModels.TileGrid BattleShipsGrid;
    }
}