using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Pages;
namespace BlackJack.Classes
{
    internal class LobbyRoom
    {
        //Chat
        public static void AddText(string name, string msg)
        {
            Pages.Lobby.chatText.BeginInvoke((Action)(() =>
            {
                Pages.Lobby.chatText.Text += $"{name}: {msg}" + Environment.NewLine;
            }));
        }

        //[Client]
        public void LoadNames(string names)
        { 

        }
    }
}
