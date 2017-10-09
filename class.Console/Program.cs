using System;
using static System.Console;
using static System.ConsoleColor;

namespace classConsole_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = DarkMagenta; // bezieht sich nur auf Text
            Clear();
            WriteLine("The current window width is {0} Chars", WindowWidth);
            ReadLine();
            SetWindowSize(LargestWindowWidth/2, 30); // /2, 50% der maximalen Breite
            BackgroundColor = Cyan;
            Clear();
            WriteLine("The current window width is {0} Chars", WindowWidth);
            ReadLine();

        }
    }
}