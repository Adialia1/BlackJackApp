using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    internal class MultiPlayerCMD
    {
        //[Host]
        public static void StartGame_Host()
        {
            Game.Instance.multiplayer.BringToFront();
            Pages.MultiPlayer.server.SendRequest("start-game");
        }
        //[Client]
        public static void StartGame_Client()
        {
            Game.Instance.multiplayer.BringToFront();
        }
    }
}
