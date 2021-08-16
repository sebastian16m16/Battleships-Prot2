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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUI));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShootBtn = new System.Windows.Forms.Button();
            this.readyBtn = new System.Windows.Forms.Button();
            this.gameInfoBtn = new System.Windows.Forms.Button();
            this.connectionPBox = new System.Windows.Forms.PictureBox();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.tileInfoBtn = new System.Windows.Forms.Button();
            this.OpponentGrid = new BattleShipsDz.Model.ViewModels.TileGrid();
            this.PersonalGrid = new BattleShipsDz.Model.ViewModels.TileGrid();
            this.BattleShipsGrid = new BattleShipsDz.Model.ViewModels.TileGrid();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPlayerName.Location = new System.Drawing.Point(22, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "label1";
            // 
            // xBtn
            // 
            this.xBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.xBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.xBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.DimGray;
            this.TitleLabel.Location = new System.Drawing.Point(555, 13);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(182, 38);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "BattleShips";
            // 
            // ShootBtn
            // 
            this.ShootBtn.BackColor = System.Drawing.Color.Maroon;
            this.ShootBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShootBtn.ForeColor = System.Drawing.Color.Black;
            this.ShootBtn.Location = new System.Drawing.Point(1101, 591);
            this.ShootBtn.Name = "ShootBtn";
            this.ShootBtn.Size = new System.Drawing.Size(75, 23);
            this.ShootBtn.TabIndex = 10;
            this.ShootBtn.Text = "SHOOT";
            this.ShootBtn.UseVisualStyleBackColor = false;
            this.ShootBtn.Click += new System.EventHandler(this.ShootBtn_Click);
            // 
            // readyBtn
            // 
            this.readyBtn.BackColor = System.Drawing.Color.Red;
            this.readyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readyBtn.ForeColor = System.Drawing.Color.Black;
            this.readyBtn.Location = new System.Drawing.Point(581, 580);
            this.readyBtn.Name = "readyBtn";
            this.readyBtn.Size = new System.Drawing.Size(75, 23);
            this.readyBtn.TabIndex = 11;
            this.readyBtn.Text = "Ready";
            this.readyBtn.UseVisualStyleBackColor = false;
            this.readyBtn.Click += new System.EventHandler(this.readyBtn_Click);
            // 
            // gameInfoBtn
            // 
            this.gameInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gameInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameInfoBtn.Location = new System.Drawing.Point(1052, 9);
            this.gameInfoBtn.Name = "gameInfoBtn";
            this.gameInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.gameInfoBtn.TabIndex = 12;
            this.gameInfoBtn.Text = "Game Info";
            this.gameInfoBtn.UseVisualStyleBackColor = false;
            this.gameInfoBtn.Click += new System.EventHandler(this.gameInfoBtn_Click);
            // 
            // connectionPBox
            // 
            this.connectionPBox.Image = ((System.Drawing.Image)(resources.GetObject("connectionPBox.Image")));
            this.connectionPBox.Location = new System.Drawing.Point(25, 580);
            this.connectionPBox.Name = "connectionPBox";
            this.connectionPBox.Size = new System.Drawing.Size(26, 34);
            this.connectionPBox.TabIndex = 13;
            this.connectionPBox.TabStop = false;
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionLabel.Location = new System.Drawing.Point(58, 589);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(73, 13);
            this.connectionLabel.TabIndex = 14;
            this.connectionLabel.Text = "Disconnected";
            // 
            // tileInfoBtn
            // 
            this.tileInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tileInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileInfoBtn.Location = new System.Drawing.Point(971, 8);
            this.tileInfoBtn.Name = "tileInfoBtn";
            this.tileInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.tileInfoBtn.TabIndex = 15;
            this.tileInfoBtn.Text = "Tile Info";
            this.tileInfoBtn.UseVisualStyleBackColor = false;
            this.tileInfoBtn.Click += new System.EventHandler(this.tileInfoBtn_Click);
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
            // BattleShipsGrid
            // 
            this.BattleShipsGrid.gridSize = new System.Drawing.Size(0, 0);
            this.BattleShipsGrid.Location = new System.Drawing.Point(581, 179);
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
            this.Controls.Add(this.BattleShipsGrid);
            this.Controls.Add(this.tileInfoBtn);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.connectionPBox);
            this.Controls.Add(this.gameInfoBtn);
            this.Controls.Add(this.readyBtn);
            this.Controls.Add(this.ShootBtn);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.OpponentGrid);
            this.Controls.Add(this.PersonalGrid);
            this.Controls.Add(this.lblPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameUI";
            this.Text = "GameUI";
            this.Load += new System.EventHandler(this.GameUI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameUI_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.connectionPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private Model.ViewModels.TileGrid PersonalGrid;
        private Model.ViewModels.TileGrid OpponentGrid;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ShootBtn;
        private System.Windows.Forms.Button readyBtn;
        private System.Windows.Forms.Button gameInfoBtn;
        private System.Windows.Forms.PictureBox connectionPBox;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Button tileInfoBtn;
        private Model.ViewModels.TileGrid BattleShipsGrid;
    }
}