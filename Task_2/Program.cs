using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-5, 6);
                Console.Write($"{arr[i]} ");
            }

            int pos = 0;

            bool isZeroFix = false;

            for (int j = 0; j < n; j++)
            {
                int count = 0;

                if ((arr[j] == 0) && (isZeroFix == false))
                {
                    isZeroFix = true;
                    arr2[pos++] = arr[j];
                }

                for (int i = 0; i < n; i++)
                {
                    if (arr[j] == arr2[i])
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0) arr2[pos++] = arr[j];
            }

            int[] finalArray = new int[pos];

            Console.WriteLine();

            for (int i = 0; i < finalArray.Length; i++)
            {
                finalArray[i] = arr2[i];
                Console.Write($"{finalArray[i]} ");
            }

            Console.ReadKey();
        }
    }
}
