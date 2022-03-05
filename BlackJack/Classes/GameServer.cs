using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace BlackJack.Classes
{
    public class GameServer
    {
        WebSocket wsServer = new WebSocket(Settings.SERVER_URL);
        public bool isHost;
        public string roomId;

        public void Connect(bool host, string room)
        {
            isHost = host;
            roomId = room;
            wsServer.OnMessage += WsServer_OnMessage;
            wsServer.Connect();
        }

        private void WsServer_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Data.Split(',')[0] == roomId.ToString())
            {
                if (isHost)
                    ServerGetData(e.Data);
                else
                    ClientGetData(e.Data);

                BothSidesGetData(e.Data);
            }
        }

        #region Create New Room
        //[Host]
        public string CreateNewRoom(int roomSize)
        {
            Random rnd = new Random();
            string tempRoom = rnd.Next(10000, 999999).ToString();
            Connect(true, tempRoom);
            isHost = true;
            Clipboard.SetText(tempRoom);
            MultiPlayerSetUp.playerConnected++;
            MultiPlayerSetUp.myId++;
            MultiPlayerSetUp.playersIdsCnt++;
            MultiPlayerSetUp.tableSize = roomSize;
            MultiPlayerSetUp.playerNames.Add(Settings.username);
            roomId = tempRoom;
            return roomId;
        }
        #endregion

        #region Server & Client Get Data From Server
        private void ClientGetData(string data)
        {
            string[] message = data.Split(',');
            switch (message[1])
            {
            }

        }
        private void ServerGetData(string data)
        {
            string[] message = data.Split(',');
            switch (message[1])
            {
                case "checkRoomId":
                    MultiPlayerSetUp.CheckRoomId(message[2]);
                    break;
            }

        }
        private void BothSidesGetData(string data)
        {
            string[] message = data.Split(',');
            switch (message[1])
            {
                case "chat":
                    LobbyRoom.AddText(message[2], message[3]);
                    break;

                case "join-accept":
                    MultiPlayerSetUp.JoinAccept(data);
                    break;

            }
        }
        #endregion

        /// <summary>
        /// Send Message to server
        /// </summary>
        /// <param name="msg"></param>
        public void SendRequest(string msg)
        {
            if (wsServer.IsAlive)
                wsServer.Send($"{roomId},{msg}");
        }
    }
}
