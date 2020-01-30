using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPurpose
{
    class Program
    {
        public static String strConsoleTitle;
        public static int intHeight = 30;
        public static int intWidth = 90;
        public static int index = 0;
        public static int intLeft = 40; public static int intTop = 0;
        public static string strUserName, Username, Password, strPassword = string.Empty;
        public static string strZmco = "ZM Co";
        public static string strAppDesc = "Cette Application vous permet de plannifier votre journée";
        public static string strAppDesc2 = "Vous pourriez voir et modifier l'objectif";
        public static string strAppDesc3 = "Fixez-vous un but que vous sauriez finir le jour-même";
        public static string strCopyRight = "CopyRight 2019 - ZM Co";
        public static string strAppTitle = "reminder daily purpose";

        static void Main(string[] args)
        {
            //<<console
            MaConsole.AppConsole();
            //console>>
        }
    }
}
