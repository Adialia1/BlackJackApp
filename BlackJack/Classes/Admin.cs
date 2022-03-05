using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    internal class Admin
    {
        public static int AdminValue()
        {
            WebClient web = new WebClient();
            string url = $"{Settings.API_URL}/adminValue.php?user={Settings.username}";
            string res = web.DownloadString(url);
            int adminVal = int.Parse(res);

            Pages.Menu.admin.Visible = false;
            if (adminVal > 0)
                Pages.Menu.admin.Visible = true;

            return int.Parse(res);
        }
    }
}
