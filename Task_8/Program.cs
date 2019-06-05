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
            Console.Write("Enter the number of rows in the array: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns in the array: ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Enter the number \"X\" to search: ");
            int x = int.Parse(Console.ReadLine());

            int[,] arr = new int[k, l];

            Random rnd = new Random();

            int count = 0;

            for (int j = 0; j < k; j++)
            {
                Console.WriteLine();

                for (int i = 0; i < l; i++)
                {
                    arr[j, i] = rnd.Next(0, 10);
                    Console.Write($"{arr[j, i]} ");

                    if (arr[j, i] == x) count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"\n\nThe number X occurs in the array {count} times.");
            }
            else
            {
                Console.WriteLine("\n\nThe number X does not occur in the array.");
            }

            Console.ReadKey();
        }
    }
}
