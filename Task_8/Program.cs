using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 8. In the line consisting of words separated by spaces, determine the length of the shortest and longest words.
            //
            Console.WriteLine("Enter string of words:");
            string input = Console.ReadLine();

            string[] inputWorlds = input.Split();

            int shortWordLength = inputWorlds[0].Length;
            int longWordLength = inputWorlds[0].Length;

            for (int i = 1; i < inputWorlds.Length; i++)
            {
                int currentWorldLength = inputWorlds[i].Length;

                if (currentWorldLength < shortWordLength)
                    shortWordLength = currentWorldLength;

                if (currentWorldLength > longWordLength)
                    longWordLength = currentWorldLength;
            }

            Console.WriteLine($"The length of the shortest word is equal to {shortWordLength}.");
            Console.WriteLine($"The length of the longest word is equal {longWordLength}.");

            Console.ReadKey();
        }
    }
}
