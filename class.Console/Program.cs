using System;
using static System.Console;
using static System.ConsoleColor;

namespace classConsole_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = Cyan;
            BackgroundColor = DarkMagenta; // bezieht sich nur auf Text
            WriteLine("The current window width is {0} Chars", Console.WindowWidth);
            ReadLine();
            SetWindowSize(100, 40);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The current window width is {0} Chars", Console.WindowWidth);
            Console.ReadLine();

        }
    }
}