using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.Pages
{
    public partial class Menu : UserControl
    {
        public static Menu Instance;
        public static PictureBox admin;
        public Menu()
        {
            InitializeComponent();
            Instance = this;
            admin = adminBtn;
        }

        private void multiPlayerBtn_Click(object sender, EventArgs e)
        {
            Classes.Balance.RefreshBalance();
            Lobby.multiplayer_panel.BringToFront();
            Game.Instance.lobby.BringToFront();
        }

        private void singlePlayerBtn_Click(object sender, EventArgs e)
        {
            Classes.Balance.RefreshBalance();
            Game.Instance.singleplayer.BringToFront();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Classes.Balance.RefreshBalance();
            Game.Instance.admin.BringToFront();
        }
    }
}
