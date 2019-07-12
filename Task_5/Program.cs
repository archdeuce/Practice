using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 5. Delete all extra spaces in the string. Spaces immediately following spaces are considered redundant. There must always be one space between words.
            //
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            string result = Convert.ToString(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result += input[i];
                    continue;
                }
                else if (input[i] != input[i - 1])
                {
                    result += input[i];
                }
            }

            Console.WriteLine("After removing extra spaces:");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
