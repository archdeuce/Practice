using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
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
                Console.Write($"\n{j + 1}: ");

                for (int i = 0; i < l; i++)
                {
                    arr[j, i] = rnd.Next(0, 10);
                    Console.Write($"{arr[j, i]} ");
                }
            }

            Console.WriteLine($"\n\nWhat rows to swap [1 - {k}]?");
            int x = int.Parse(Console.ReadLine()) - 1;
            int y = int.Parse(Console.ReadLine()) - 1;

            for (int i = 0; i < l; i++)
            {
                int tmp = arr[x, i];
                arr[x, i] = arr[y, i];
                arr[y, i] = tmp;
            }

            Console.WriteLine("\nDone.");

            for (int j = 0; j < k; j++)
            {
                Console.Write($"\n{j + 1}: ");

                for (int i = 0; i < l; i++)
                {
                    Console.Write($"{arr[j, i]} ");
                }
            }

            Console.ReadKey();
        }
    }
}
