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
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void toLoginBtn_Click(object sender, EventArgs e)
        {
            Classes.Admin.AdminValue();
            Game.Instance.menu.BringToFront();
        }
    }
}
