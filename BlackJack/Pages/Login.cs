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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            LoginPanel.BringToFront();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadingScreenPanel.BringToFront();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool result = Classes.Login.LoginCheck(usernameTextBox.Text, passwordTextBox.Text);
            if (result)
            {
                Classes.Settings.username = usernameTextBox.Text;
                Game.Instance.Text = usernameTextBox.Text;
                Classes.Admin.AdminValue();
                Game.Instance.menu.BringToFront();
            }
            else
                loginOutput.Image = Properties.Resources.incorrectLogin;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool result = Classes.Login.RegisterCheck(usernameTextBox.Text, passwordTextBox.Text);
            if (result)
            {
                Classes.Settings.username = usernameTextBox.Text;
                Game.Instance.menu.BringToFront();
            }
            else
                loginOutput.Image = Properties.Resources.usernameExists;

        }
    }
}
