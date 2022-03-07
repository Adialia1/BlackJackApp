using System;

namespace BlackJack.Classes
{
    internal class MultiPlayerCMD
    {
        //[Host]
        public static void StartGame_Host()
        {
            Game.Instance.multiplayer.BringToFront();
            Pages.MultiPlayer.server.SendRequest("start-game");
            MultiPlayerFunction.CreateTable();
        }
        //[Client]
        public static void StartGame_Client()
        {
            if (MultiPlayerSetUp.connectedToLobby)
            {
                MultiPlayerFunction.CreateTable();
                Game.Instance.multiplayer.Invoke(new Action(() =>
                {
                    Game.Instance.multiplayer.BringToFront();
                }));
            }
        }
    }
}
