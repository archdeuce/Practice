using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 4. In the input line, delete the spaces between the first and second question marks.
            //
            Console.WriteLine("Enter the string. Add two \'?\' between which you want to remove spaces:");
            string input = Console.ReadLine();

            string result = string.Empty;

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '?') count++;

                if (count < 1 || count > 1)
                    result += input[i];
                else if (input[i] != ' ')
                    result += input[i];
            }

            Console.WriteLine("After remove:");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
