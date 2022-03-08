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
        public static bool connectedToLobby = false;
        public static string[] usernames;
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
        {   //                  [room],[message-action],[userId],[tableSize],[usersConnetedNames]
            //Template message: 349551,join-accept,2,3,test,.or,adi

            string[] message = data.Split(',');
            if(message[message.Length - 1] == Settings.username)
            {
                Pages.Lobby.lobby_panel.Invoke(new Action(() =>
                { Pages.Lobby.lobby_panel.BringToFront(); }));
                connectedToLobby = true;
            }

            //Ignore message[0], message[1],
            if (!Pages.MultiPlayer.server.isHost)
            {
                if (myId != -1)
                    myId = int.Parse(message[2]);
                tableSize = int.Parse(message[3]);
            }
            //Send joined message on chat
            LobbyRoom.JoinMessage(message[message.Length-1]);

            //Setup Usernames arry
            usernames = new string[myId+1];
            for (int i = 0; i <= int.Parse(message[2]); i++)
                usernames[i] = message[4 + i];

            LobbyRoom.LoadNames(usernames);
        }

    }

}
