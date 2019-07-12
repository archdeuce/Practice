using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 2. Determine how often a certain character is found in a string.
            //
            Console.WriteLine("Enter the string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the desired character in the string:");
            char inputChar = Convert.ToChar(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputChar == inputString[i]) count++;
            }

            Console.WriteLine($"The entered character is found in line {count} times.");

            Console.ReadKey();
        }
    }
}
