using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the index of the first item: ");
            int startPos = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of items to copy: ");
            int quantity = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int[] arrSub;

            Random rnd = new Random();

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 10);
                Console.Write($"{arr[i]} ");
            }

            arrSub = SubArray(arr, startPos, quantity);

            Console.WriteLine("\n\nSubArray:");

            for (int i = 0; i < arrSub.Length; i++)
            {
                Console.Write($"{arrSub[i]} ");
            }

            int[] SubArray(int[] array, int index, int count)
            {
                int[] arrTmp = new int[count];
                int j = 0,
                length = index + count;

                for (int i = index; i < length; i++)
                {
                    if (i < array.Length)
                    {
                        arrTmp[j++] = array[i];
                    }
                    else
                    {
                        arrTmp[j++] = 1;
                    }
                }

                return arrTmp;
            }

            Console.ReadKey();
        }
    }
}
