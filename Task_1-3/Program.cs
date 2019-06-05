using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();

            Console.ReadKey();
        }

        public static void Task1()
        {
            Console.WriteLine("Enter many words separated by spaces:");
            string input = Console.ReadLine();

            Console.WriteLine("\nOutput formatted string:");

            Console.Write(Char.ToUpper(input[0]));

            for (int i = 1; i < input.Length; i++)
            {
                if ((input[i - 1] == ' '))
                {
                    Console.Write(Char.ToUpper(input[i]));
                }
                else
                {
                    Console.Write(input[i]);
                }
            }

        }

        public static void Task2()
        {
            Console.WriteLine("Enter a string [a..z].\n");
            string input = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 'm') count++;
            }

            Console.WriteLine($"\nPrint error ratio {count} / {input.Length}.");
        }

        public static void Task3()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Enter a string to count the vowels in it - 'a', 'e', 'i', 'o', 'u'.\n");
            string input = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (input[i] == vowels[j]) count++;
                }
            }

            Console.WriteLine($"\nThe number (count) of vowels in the given string {count}.");
        }
    }
}
