using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    internal class Settings
    {
        public static readonly string API_URL = "https://adidev.me/blackjack/api/newApi";
        public static readonly string SERVER_URL = "wss://test-ws-server-demo-adi.adialia.repl.co/";

        public static string username { get; set; }
        public static long balance { get; set; }
    }
}
