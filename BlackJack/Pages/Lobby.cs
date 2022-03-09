using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using WebSocketSharp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Classes;
using BlackJack.Pages;
namespace BlackJack.Pages
{
    public partial class Lobby : UserControl
    {
        public static Lobby Instant;
        public static Panel lobby_panel;
        public static Panel multiplayer_panel;
        public static RichTextBox chatText;
        public static Label[] slots = new Label[4];
        public static Button startGame;
        bool isHost;
        public Lobby()
        {

            InitializeComponent();
            Instant = this;
            lobby_panel = LobbyPanel;
            multiplayer_panel = MultiPlayerPanel;
            chatText = chatTextLB;
            slots[0] = slot1LB;
            slots[1] = slot2LB;
            slots[2] = slot3LB;
            slots[3] = slot4LB;
            startGame = startGameBtn;
        }

        #region Chat

        private async void messageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                messageTextBox.Enabled = false;
                messageTextBox.Text.Replace(',', '|');
                Pages.MultiPlayer.server.SendRequest($"chat,{colorDialog1.Color.ToArgb()},{Settings.username},{messageTextBox.Text}");
                messageTextBox.Text = "";
                await Task.Delay(3000);
                messageTextBox.Enabled = true;
            }
        }
        private async void SendMessageBtn_Click(object sender, EventArgs e)
        {
            messageTextBox.Enabled = false;
            messageTextBox.Text.Replace(',', '|');
            Pages.MultiPlayer.server.SendRequest($"chat,{colorDialog1.Color.ToArgb()},{Settings.username},{messageTextBox.Text}");
            messageTextBox.Text = "";
            await Task.Delay(3000);
            messageTextBox.Enabled = true;
        }
        #endregion

        private void createServerBtn_Click(object sender, EventArgs e)
        {
            if(!isHost)
            {
                hostServerID.Text = Pages.MultiPlayer.server.CreateNewRoom(tableSizeTrackBar.Value);
                isHost = true;
                createServerBtn.Enabled = false;
            }
            tableSizeTrackBar.Enabled = false;
        }

        private async void joinServerBtn_Click(object sender, EventArgs e)
        {
            joinServerBtn.Enabled = false;
            if(!isHost)
            {
                MultiPlayer.server.Connect(false, joinServerID.Text);
            }
            await Task.Delay(5000);
            joinServerBtn.Enabled = true;
        }

        private void tableSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            int t = tableSizeTrackBar.Value;
            tableSizeLB.Text = "Table Size: " + tableSizeTrackBar.Value;
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void joinServerID_Enter(object sender, EventArgs e)
        {
            joinServerID.Text = "";
        }

        private void joinServerID_Leave(object sender, EventArgs e)
        {
            if (joinServerID.Text == "")
                joinServerID.Text = "Room ID";
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            Classes.MultiPlayerCMD.StartGame_Host();
        }
    }
}
