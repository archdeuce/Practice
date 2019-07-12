using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 7. A string of words is entered. Print the words in reverse order.
            //
            Console.WriteLine("Enter string of words:");
            string input = Console.ReadLine();

            string[] inputWorlds = input.Split();
            string reverse = string.Empty;

            for (int i = inputWorlds.Length - 1; i >= 0; i--)
            {
                reverse += inputWorlds[i] + " ";
            }

            Console.WriteLine($"Print the words in reverse order:");
            Console.WriteLine(reverse);

            Console.ReadKey();
        }
    }
}
