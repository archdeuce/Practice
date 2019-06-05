using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows in the array: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns in the array: ");
            int l = int.Parse(Console.ReadLine());

            int[,] arr = new int[k, l];

            Random rnd = new Random();

            for (int j = 0; j < k; j++)
            {
                Console.WriteLine();

                for (int i = 0; i < l; i++)
                {
                    arr[j, i] = rnd.Next(0, 10);
                    Console.Write($"{arr[j, i]} ");
                }
            }

            Console.Write($"\n\nSpecify in which column to count the sum of the elements [1 - {l}]: ");
            int x = int.Parse(Console.ReadLine()) - 1;

            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += arr[i, x];
            }

            Console.WriteLine($"\nThe sum of the items in the {x + 1} column is {sum}.");

            Console.ReadKey();
        }
    }
}
