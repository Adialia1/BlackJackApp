using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Classes;

namespace BlackJack.Pages
{
    public partial class MultiPlayer : UserControl
    {
        public static GameServer server = new GameServer();
        public static MultiPlayer Instance;

        public MultiPlayer()
        {
            InitializeComponent();
            Instance = this;
        }

        private void toLoginBtn_Click(object sender, EventArgs e)
        {
            Classes.Admin.AdminValue();
            Game.Instance.menu.BringToFront();
        }
    }
}
