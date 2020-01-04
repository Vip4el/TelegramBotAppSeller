using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBotApp.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; }  = "https://telegrambotappseller.azurewebsites.net:443/{0}";
        public static string Name { get; set; } = "TestSellerFlatBot";
        public static string Key { get; set; }  = "905735818:AAHwGnAVWrk4rlf2zVR2F8t_lQ5x0Ucbbmw";
    }
}