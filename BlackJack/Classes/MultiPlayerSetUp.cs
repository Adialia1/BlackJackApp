using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.Classes
{
    internal class MultiPlayerSetUp
    {
        static bool lobbyStarted = false;
        public static int playerConnected, tableSize, playersIdsCnt = 0, myId = 0;
        public static List<string> playerNames = new List<string>();

        //MultiPlayer Setup

        //[Host]
        public static void CheckRoomId(string name)
        {
            if (!lobbyStarted)
            {
                if (playerConnected < tableSize )
                {
                    //Join True
                    //output all users names
                    //Add the username to the list
                    playerNames.Add(name);
                    string usernamesOutputTemp = "";
                    for (int i = 0; i < playerNames.Count; i++)
                    {
                        usernamesOutputTemp += playerNames[i] + ',';
                    }
                    string usernamesOutput = usernamesOutputTemp.Remove(usernamesOutputTemp.Length - 1, 1);
                    string a = usernamesOutput;
                    Pages.MultiPlayer.server.SendRequest($"join-accept,{playersIdsCnt++},{tableSize},{usernamesOutput}");
                    playerConnected++;
                }
                if(playerConnected == tableSize)
                {
                    Pages.Lobby.startGame.Invoke(new Action(() =>
                    {
                        Pages.Lobby.startGame.Visible = true;
                    }));
                }
            }
        }

        //[Both]
        public static void JoinAccept(string data)
        {
            Pages.Lobby.lobby_panel.Invoke(new Action(() =>
            { Pages.Lobby.lobby_panel.BringToFront(); }));
            string[] message = data.Split(',');
            //Ignore message[0], message[1],
            if(!Pages.MultiPlayer.server.isHost)
            {
                if (myId != -1)
                    myId = int.Parse(message[2]);
                tableSize = int.Parse(message[3]);
            }
            
            //Load Usernames in looby room
            for (int i = 0; i <= int.Parse(message[2]); i++)
            {
                //SetUp lb arry
                Pages.Lobby.slots[i].Invoke(new Action(() =>
                {
                    Pages.Lobby.slots[i].Text = message[4 + i];
                    Pages.Lobby.slots[i].Visible = true;
                }));
            }

        }

    }

}
