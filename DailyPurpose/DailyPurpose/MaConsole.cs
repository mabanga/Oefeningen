using System;
using System.Collections.Generic;

namespace DailyPurpose
{
    class MaConsole
    {
        public static void AppConsole()
        {
            Program.strConsoleTitle = Program.strZmco + " - " + Program.strAppTitle.ToUpper();
            Console.SetBufferSize(120, 60);
            Console.SetWindowSize(Program.intWidth, Program.intHeight);
            Console.Title = Program.strConsoleTitle;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            AppTitle();
            AppDesc();
            AppCopyRight();
            AppExec();
            AppQuit();
        }
        static string MyMenu(List<string> items)
        {
            int intLeft = 12; int intTop = 11;
            Console.SetCursorPosition(intLeft, intTop);
            for (int i = 0; i < items.Count; i++)
            {
                List<string> menuItemsDescription = new List<string>() { "ici pour voir les taches à faire",
                "ici pour ajouter des taches","ici pour modifier ou supprimer les taches",
                "ici pour quitter l'application"};
                Console.SetCursorPosition(intLeft, intTop += 2);

                if (i == Program.index)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine((items[i]).ToUpper());
                    Console.SetCursorPosition(25, 17);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(menuItemsDescription[Program.index]);
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.WriteLine((items[i]).ToLower());
                }

            }
            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                MaConsole.AppExecBg();
                MaConsole.AppTitle();
                MaConsole.AppDesc();
                MaConsole.AppCopyRight();
                
                if (Program.index == items.Count - 1)
                {
                    Program.index = 0;
                }
                else
                {
                    Program.index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                MaConsole.AppExecBg();
                MaConsole.AppTitle();
                MaConsole.AppDesc();
                MaConsole.AppCopyRight();
                if (Program.index <= 0)
                {
                    Program.index = items.Count - 1;
                }
                else
                {
                    Program.index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[Program.index];
            }
            else
            {
                return "";
            }
            Console.Clear();
            return "";
        }
        public static void AppExec()
        {
            AppExecBg();
            List<string> menuItems = new List<string>() { "voir", "ajouter", "modifier", "exit" };

            Console.CursorVisible = false;

            while (true)
            {
                MaConsole.AppExecBg();
                MaConsole.AppTitle();
                MaConsole.AppDesc();
                MaConsole.AppCopyRight();
                Console.BackgroundColor = ConsoleColor.Blue;
                string strSelectedMenuItem = MyMenu(menuItems);
                Program.intLeft = 40; Program.intTop = 14;
                switch (strSelectedMenuItem)
                {
                    case "voir":
                        Menu.MenuVoir();
                        break;
                    case "ajouter":
                        Menu.MenuAjout();
                        break;
                    case "modifier":
                        Menu.MenuModifier();
                        break;
                    case "exit":
                        Menu.MenuExit();
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }
        public static void AppExecBg()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 11; i < 24; i++)
            {
                Console.SetCursorPosition(10, i);
                Console.Write(new string(' ', 69));
            }

            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 12; i < 23; i++)
            {
                Console.SetCursorPosition(11, i);
                Console.Write(new string(' ', 10));
            }

            Console.BackgroundColor = ConsoleColor.Green;
            for (int i = 12; i < 23; i++)
            {
                Console.SetCursorPosition(22, i);
                Console.Write(new string(' ', 56));
            }
        }
        public static void AppTitle()
        {
            Console.SetBufferSize(120, 60);
            AppTitleBg();
            Console.SetCursorPosition((Program.intWidth / 2) - (Program.strAppTitle.Length / 2), 2);
            for (int i = 0; i < Program.strAppTitle.Length + 4; i++)
            {
                Console.Write("#");
            }
            Console.SetCursorPosition((Program.intWidth / 2) - (Program.strAppTitle.Length / 2), 3);
            Console.WriteLine("# " + Program.strAppTitle.ToUpper() + " #");
            Console.SetCursorPosition((Program.intWidth / 2) - (Program.strAppTitle.Length / 2), 4);
            for (int i = 0; i < Program.strAppTitle.Length + 4; i++)
            {
                Console.Write("#");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
        }
        static void AppTitleBg()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 1; i < 6; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(new string(' ', 86));
            }
        }
        public static void AppDesc()
        {
            AppDescBg();
            Console.SetCursorPosition((Program.intWidth / 2) - (Program.strAppDesc.Length / 2), 7);
            Console.Write(Program.strAppDesc);
            Console.SetCursorPosition((Program.intWidth / 2) - (Program.strAppDesc2.Length / 2),  8);
            Console.Write(Program.strAppDesc2);
            Console.SetCursorPosition((Program.intWidth / 2) - (Program.strAppDesc3.Length / 2), 9);
            Console.WriteLine(Program.strAppDesc3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
        }
        static void AppDescBg()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 7; i < 10; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(new string(' ', 86));
            }
            //Console.ResetColor();
        }
        public static void AppCopyRight()
        {
            AppCopyRightBg();

            Console.SetCursorPosition((Program.intWidth - Program.strCopyRight.Length) - 3, 27);
            Console.WriteLine(Program.strCopyRight + " ");

            Console.SetCursorPosition(2, 27);
            Console.Write(" " + DateTime.Now);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.CursorVisible = false;
        }
        static void AppCopyRightBg()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 26; i < 29; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(new string(' ', 86));
            }
        }
        public static void AppQuit()
        {
            Console.SetCursorPosition(35, 24);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press any key to quit...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ReadKey();
            Environment.Exit(0);
        }
        public static void AppExecBgAll()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 11; i < 24; i++)
            {
                Console.SetCursorPosition(10, i);
                Console.Write(new string(' ', 69));
            }
        }
    }
    
}
