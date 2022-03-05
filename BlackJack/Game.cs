using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Game : Form
    {
        public static Game Instance;
        public Pages.Login login;
        public Pages.Menu menu;
        public Pages.MultiPlayer multiplayer;
        public Pages.SinglePlayer singleplayer;
        public Pages.Lobby lobby;
        public Pages.Admin admin;
        public Game()
        {
            InitializeComponent();
            Instance = this;
            login = loginPage;
            menu = menuPage;
            multiplayer = multiplayerPage;
            singleplayer = singleplayerPage;
            lobby = lobbyPage;
            admin = adminPage;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //Lock The Window//
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            //Lock The Window//


            //lobby.BringToFront();
            //Pages.Lobby.lobby_panel.BringToFront();
            loginPage.BringToFront();
        }
    }
}
