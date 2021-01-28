using System;
using System.Threading;

namespace Vjezbanje
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Drawing();

        }

        static void Music()
        {
           
        }

        static void Drawing()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Random rnd = new Random();
                int numberX = rnd.Next(0, 100);

                if (numberX > 10 && numberX < 20)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (numberX > 20 && numberX < 30)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (numberX > 30 && numberX < 40)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (numberX > 40 && numberX < 50)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (numberX > 50 && numberX < 60)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (numberX > 60 && numberX < 70)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (numberX > 70 && numberX < 80)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (numberX > 80 && numberX < 90)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if (numberX > 90 && numberX < 100)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                int x = rnd.Next(1, 11);

                int xP = rnd.Next(1, 50);
                int yP = rnd.Next(1, 50);
                Console.SetCursorPosition(xP, yP);


                for (int i = 0; i < x; i++)
                  {
                     Console.Write("o");
                  }
            
                Console.ResetColor();

                Thread.Sleep(10);


            }

        }
    }
}
