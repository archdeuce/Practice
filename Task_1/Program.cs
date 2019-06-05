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
            Console.Write("Enter array length N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-50, 51);
                Console.Write($"{arr[i]} ");
            }

            int max = arr[0],
                min = arr[0],
                sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i]) max = arr[i];
                if (min > arr[i]) min = arr[i];

                if (arr[i] % 2 != 0) Console.Write($"\nOdd item {arr[i]}");

                sum += arr[i];
            }

            double mean = sum / (double)arr.Length;

            Console.WriteLine($"\n\nmax = {max}\nmin = {min}\nsum = {sum}\nmean = {mean}");

            Console.ReadKey();
        }
    }
}
