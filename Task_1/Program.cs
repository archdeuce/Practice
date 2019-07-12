using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 1. Leave only one instance of each occurring character in the string.
            //
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            Console.WriteLine("We leave in the string only unique characters:");

            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                bool isExist = false;

                for (int j = 0; j < output.Length; j++)
                {
                    if (input[i] == output[j])
                    {
                        isExist = true;
                        break;
                    }
                }

                if (isExist == false)
                {
                    output += input[i];
                }
            }

            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
