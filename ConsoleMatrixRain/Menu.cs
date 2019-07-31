using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMatrixRain
{
    public class Menu
    {
        public static void Execute()
        {
            //
            // Configure the console.
            //
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetBufferSize(Config.HPosMax, Config.VPosMax);
            Console.SetWindowSize(Config.HPosMax, Config.VPosMax);

            //
            // Selection menu.
            //
            Console.WriteLine("Console Matrix Rain.");
            Console.WriteLine("1. Matrix Rain 1 chain.");
            Console.WriteLine("2. Matrix Rain 1 chain in column.");
            Console.WriteLine("3. Matrix Rain 2 chain in column.");

            string userSelection = Console.ReadLine();

            Console.Clear();

            switch (userSelection)
            {
                case "1":
                    Rain.MatrixRain(0);
                    break;
                case "2":
                    Rain.MatrixRain(1);
                    break;
                case "3":
                    Rain.MatrixRain(2);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input. Press any key to exit the program.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
