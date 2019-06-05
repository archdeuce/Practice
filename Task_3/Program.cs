using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.Write("Enter min value : ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter max value : ");
            int max = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-20, 21);
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine($"\n\nDisplaying indexes of values in a range min = {min}, max = {max}):");

            for (int i = 0; i < n; i++)
            {
                if ((arr[i] > min) && (arr[i] < max)) Console.WriteLine($"i = {i} ");
            }

            Console.ReadKey();
        }
    }
}
