using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.Classes
{
    internal class Login
    {

        /// <summary>
        /// הפעולה בודקת האם החשבון תקין או לא
        /// </summary>
        /// <param name="username">שם המשתמש של החשבון</param>
        /// <param name="password">סיסמא של החשבון</param>
        /// <returns>ערך בוליאני האם החשבון עבד או לא</returns>
        public static bool LoginCheck(string username, string password)
        {
            WebClient web = new WebClient();

            if (username.Trim(' ').Length <= 0 || password.Trim(' ').Length <= 0) return false;
            //if(!username.Contains(',') || !password.Contains(',')) return false;

            string url = $"{Settings.API_URL}/login.php?user={username}&pass={password}";
            string res = web.DownloadString(url);
            if (res == "ok")
                return true;

            return false;
        }

        /// <summary>
        /// הפעולה יוצאת חשבון בדאטה בייס של המשחק
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>ערך בוליאני האם החשבון נוצר או שיש בעיה</returns>
        public static bool RegisterCheck(string username, string password)
        {
            WebClient web = new WebClient();

            if (username.Trim(' ').Length <= 0 || password.Trim(' ').Length <= 0) return false;
            //if (!username.Contains(',') || !password.Contains(',')) return false;

            string url = $"{Settings.API_URL}/register.php?user={username}&pass={password}";
            string res = web.DownloadString(url);
            if (res == "ok")
                return true;

            return false;
        }
    }
}
