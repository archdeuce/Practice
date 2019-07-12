using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsEnum
{
    public static class ColorOutput
    {
        public static void Print(string inputText, int myColorNumber)
        {
            //
            // Get the color name from our listing. Then we find it in the system palette :)
            //
            string myColorName = Enum.GetName(typeof(ColorList), myColorNumber);

            string[] consoleColors = Enum.GetNames(typeof(ConsoleColor));

            int systemColorNumber = 0;

            bool isFindColor = false;

            foreach (string systemColor in consoleColors)
            {
                if (systemColor == myColorName)
                {
                    isFindColor = true;
                    break;
                }

                systemColorNumber++;
            }

            if (isFindColor == true)
                Console.ForegroundColor = (ConsoleColor)systemColorNumber;
            else
                Console.WriteLine("This color is not available. The default color is set.");

            Console.WriteLine(inputText);

            Console.ResetColor();
        }

        public static void DisplayColor()
        {
            Console.WriteLine("List of available colors:");

            var stringId = 0;

            foreach (var color in Enum.GetNames(typeof(ColorList)))
            {
                Console.WriteLine(stringId++ + ": " + color);
            }
        }

        public static int GetColor()
        {
            Console.WriteLine("Choose a color:");

            int colorNumber = Convert.ToInt32(Console.ReadLine());

            return colorNumber;
        }

        public static string GetText()
        {
            Console.WriteLine("Enter text:");

            string text = Console.ReadLine();

            return text;
        }

        public static void Execute()
        {
            DisplayColor();
            Print(GetText(), GetColor());
        }
    }
}