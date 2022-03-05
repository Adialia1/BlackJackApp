namespace BlackJack
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.loginPage = new BlackJack.Pages.Login();
            this.menuPage = new BlackJack.Pages.Menu();
            this.lobbyPage = new BlackJack.Pages.Lobby();
            this.singleplayerPage = new BlackJack.Pages.SinglePlayer();
            this.multiplayerPage = new BlackJack.Pages.MultiPlayer();
            this.adminPage = new BlackJack.Pages.Admin();
            this.SuspendLayout();
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.Transparent;
            this.loginPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPage.BackgroundImage")));
            this.loginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPage.Location = new System.Drawing.Point(0, 0);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(1263, 660);
            this.loginPage.TabIndex = 0;
            // 
            // menuPage
            // 
            this.menuPage.BackColor = System.Drawing.Color.Transparent;
            this.menuPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPage.BackgroundImage")));
            this.menuPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPage.Location = new System.Drawing.Point(0, 0);
            this.menuPage.Name = "menuPage";
            this.menuPage.Size = new System.Drawing.Size(1263, 660);
            this.menuPage.TabIndex = 1;
            // 
            // lobbyPage
            // 
            this.lobbyPage.BackColor = System.Drawing.Color.Transparent;
            this.lobbyPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lobbyPage.BackgroundImage")));
            this.lobbyPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lobbyPage.Location = new System.Drawing.Point(0, 0);
            this.lobbyPage.Name = "lobbyPage";
            this.lobbyPage.Size = new System.Drawing.Size(1263, 660);
            this.lobbyPage.TabIndex = 4;
            // 
            // singleplayerPage
            // 
            this.singleplayerPage.BackColor = System.Drawing.Color.Transparent;
            this.singleplayerPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("singleplayerPage.BackgroundImage")));
            this.singleplayerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleplayerPage.Location = new System.Drawing.Point(0, 0);
            this.singleplayerPage.Name = "singleplayerPage";
            this.singleplayerPage.Size = new System.Drawing.Size(1263, 660);
            this.singleplayerPage.TabIndex = 3;
            // 
            // multiplayerPage
            // 
            this.multiplayerPage.BackColor = System.Drawing.Color.Transparent;
            this.multiplayerPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multiplayerPage.BackgroundImage")));
            this.multiplayerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplayerPage.Location = new System.Drawing.Point(0, 0);
            this.multiplayerPage.Name = "multiplayerPage";
            this.multiplayerPage.Size = new System.Drawing.Size(1263, 660);
            this.multiplayerPage.TabIndex = 2;
            // 
            // adminPage
            // 
            this.adminPage.BackColor = System.Drawing.Color.Transparent;
            this.adminPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminPage.BackgroundImage")));
            this.adminPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPage.Location = new System.Drawing.Point(0, 0);
            this.adminPage.Name = "adminPage";
            this.adminPage.Size = new System.Drawing.Size(1263, 660);
            this.adminPage.TabIndex = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 660);
            this.Controls.Add(this.loginPage);
            this.Controls.Add(this.menuPage);
            this.Controls.Add(this.lobbyPage);
            this.Controls.Add(this.singleplayerPage);
            this.Controls.Add(this.multiplayerPage);
            this.Controls.Add(this.adminPage);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Pages.Login loginPage;
        private Pages.Menu menuPage;
        private Pages.MultiPlayer multiplayerPage;
        private Pages.SinglePlayer singleplayerPage;
        private Pages.Lobby lobbyPage;
        private Pages.Admin adminPage;
    }
}