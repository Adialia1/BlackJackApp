using System;
using System.Drawing;

namespace BlackJack.Classes
{
    internal class LobbyRoom
    {
        //Chat
        //[Both]
        public static void AddText(string name, string color, string msg)
        {
            Pages.Lobby.chatText.BeginInvoke((Action)(() =>
            {
                Pages.Lobby.chatText.SelectionColor = Color.FromArgb(int.Parse(color));
                Pages.Lobby.chatText.SelectedText = $"{name}: {msg}" + Environment.NewLine;
            }));
        }

        //[Both]
        public static void JoinMessage(string name)
        {
            
            Pages.Lobby.chatText.BeginInvoke((Action)(() =>
            {
                Pages.Lobby.chatText.SelectionColor = Color.Gray;
                Pages.Lobby.chatText.SelectedText += $"{name} joined" + Environment.NewLine;
            }));
        }

        //[Both]
        public static void LoadNames(string[] usernames)
        {

            for (int i = 0; i < usernames.Length; i++)
            {
                //SetUp lb arry
                Pages.Lobby.slots[i].Invoke(new Action(() =>
                {
                    Pages.Lobby.slots[i].Text = usernames[i];
                    Pages.Lobby.slots[i].Visible = true;
                }));
            }
        }
    }
}
