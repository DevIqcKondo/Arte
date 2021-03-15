using System;

namespace Arte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine("Tecle ENTER para ver a AsciiArt");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.ReadKey();
            Console.WriteLine(" ||  ||");
            Console.ReadKey();
            Console.WriteLine(" \\\\()//   ");
            Console.ReadKey();
            Console.WriteLine("//(__)\\\\");
            Console.ReadKey();
            Console.WriteLine("||    ||"); 
            Console.ResetColor();   
        }
    }
}
