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
            Console.Write("Enter array length N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-50, 51);
                Console.Write($"{arr[i]} ");
            }

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            double mean = sum / (double)arr.Length;

            Console.WriteLine($"\n\nsum = {sum}\nmean = {mean}\n");
            Console.WriteLine("Elements that are larger than the arithmetic mean:");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > mean) Console.Write($"{arr[i]} ");
            }

            Console.ReadKey();
        }
    }
}
