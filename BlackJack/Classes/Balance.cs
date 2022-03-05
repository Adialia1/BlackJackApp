using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    internal class Balance
    {
        /// <summary>
        /// הפעולה בודקת את היתרה של החשבון
        /// ושמה את היתרה העדכנית בתוך המשתנה balance שנמצא ב Settings
        /// </summary>
        /// <returns>balance number in long</returns>
        public static long RefreshBalance()
        {
            WebClient web = new WebClient();
            string username = Settings.username;
            string url = $"{Settings.API_URL}/checkBalance.php?user={username}";
            string res = web.DownloadString(url);
            if (res != "error")
            {
                Settings.balance = long.Parse(res);
                return long.Parse(res);
            }

            return 0;
        }
    }
}
