using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace DailyPurpose
{
    class Menu
    {
        private const string Path = @"c:\Res\dailypurpose.txt";

        public static void MenuExit()
        {
            MaConsole.AppExecBgAll();
            for (int i = 11; i < 50; i+=15)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("Bye Bye".ToUpper());
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(i, 18);
                Console.WriteLine("U wordt uitgeschakeld. Please wait...");
                Thread.Sleep(500);
                MaConsole.AppExecBgAll();
            }
            Environment.Exit(0);
        }
        public static void MenuAjout()
        {
            List<string> lstStrListeTaches = new List<string> { };
            MaConsole.AppExecBg();
            Console.SetCursorPosition(25, 16);
            string strTache = string.Empty;
            Console.Write("Combien de taches: ");
            Console.CursorVisible = true;
            int lstStrListeTaches_Longueur = int.Parse(Console.ReadLine());

                if (lstStrListeTaches_Longueur>0&&lstStrListeTaches_Longueur < 4)
                {
                    for (int i = 1; i < lstStrListeTaches_Longueur + 1; i++)
                    {
                        MaConsole.AppExecBg();
                        MaConsole.AppTitle();
                        MaConsole.AppDesc();
                        MaConsole.AppCopyRight();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.CursorVisible = true;
                        Console.SetCursorPosition(25, 16);
                        Console.Write("{0}: Entrez votre tache: ", i);
                        strTache = Console.ReadLine();
                        lstStrListeTaches.Add(strTache);
                    }
                using (StreamWriter sw = new StreamWriter(File.Create(Path)))
                {
                    sw.Write(DateTime.Now.ToShortDateString() + " ");
                    for (int i = 0; i < lstStrListeTaches.Count; i++)
                    {
                        sw.Write(lstStrListeTaches[i] + " ");
                    }
                    sw.Close();
                }
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("Purpose registered. Please wait...");

            }
                else
                {
                Console.SetCursorPosition(30, 18);

                Console.WriteLine("Choose between 1 and 3");
                }

            Thread.Sleep(1500);
        }
        public static void MenuVoir()
        {
            MaConsole.AppExecBg();
            Console.SetCursorPosition(Program.intLeft - 15, 11 + 2);
            using (StreamReader sr = new StreamReader(File.Open(Path, FileMode.Open)))
            {
                Console.WriteLine(sr.ReadLine());
                sr.Close();
                Thread.Sleep(3000);
            }
            Console.SetCursorPosition(Program.intLeft - 15, 21);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();

        }
        public static void MenuModifier()
        {
            List<string> lstStrListeTaches = new List<string> { };
            MaConsole.AppExecBg();
            Console.SetCursorPosition(25, 16);
            string strTache = string.Empty;
            Console.CursorVisible = true;
            MaConsole.AppExecBg();
            MaConsole.AppTitle();
            MaConsole.AppDesc();
            MaConsole.AppCopyRight();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.CursorVisible = true;
            Console.SetCursorPosition(25, 16);
            //Console.Write("{0}: Entrez votre tache: ", i);
            //strTache = Console.ReadLine();
            lstStrListeTaches.Add(" ");

            using (StreamWriter sw = new StreamWriter(File.Create(Path)))
            {
                sw.Write(DateTime.Now.ToShortDateString() + " ");
                for (int i = 0; i < lstStrListeTaches.Count; i++)
                {
                    sw.Write(lstStrListeTaches[i] + " ");
                }
                sw.Close();
            }
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("Purpose deleted. Please wait...");
            Thread.Sleep(1500);
        }
    }
}
