using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 6. Find the word standing in the text under a certain number and print its first letter.
            //
            Console.WriteLine("Enter string of words:");
            string input = Console.ReadLine();

            string[] inputWorlds = input.Split();

            for (int i = 0; i < inputWorlds.Length; i++)
            {
                Console.WriteLine(i + ": " + inputWorlds[i]);
            }

            Console.WriteLine($"Select a word to display its first letter:");
            int selectedWorld = Convert.ToInt32(Console.ReadLine());

            char selectedChar = inputWorlds[selectedWorld][0];

            Console.WriteLine(selectedChar);

            Console.ReadKey();
        }
    }
}
