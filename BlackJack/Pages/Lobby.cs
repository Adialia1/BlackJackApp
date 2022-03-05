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
        private void messageTextBox_Enter(object sender, EventArgs e)
        {
            if (messageTextBox.Text == "Enter Message")
                messageTextBox.Text = "";
            messageTextBox.ForeColor = Color.Black;
        }

        private void messageTextBox_Leave(object sender, EventArgs e)
        {
            if (messageTextBox.Text.Length <= 0)
            {
                messageTextBox.Text = "Enter Message";
                messageTextBox.ForeColor = Color.Gray;
            }
        }

        private void messageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Pages.MultiPlayer.server.SendRequest($"chat,{Settings.username},{messageTextBox.Text}");
                messageTextBox.Text = "";
            }
        }
        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            Pages.MultiPlayer.server.SendRequest($"chat,{Settings.username},{messageTextBox.Text}");
            messageTextBox.Text = "";
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
                MultiPlayer.server.SendRequest($"checkRoomId,{Settings.username}");
            }
            await Task.Delay(100000);
            joinServerBtn.Enabled = true;
        }

        private void tableSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            int t = tableSizeTrackBar.Value;
            tableSizeLB.Text = "Table Size: " + tableSizeTrackBar.Value;
        }
    }
}
