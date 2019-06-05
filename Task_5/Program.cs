using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
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
                arr[i] = rnd.Next(0, 10);
                Console.Write($"{arr[i]} ");
            }

            arr2 = MyReverse(arr);

            Console.WriteLine("\n\nReverse array output:");

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }

            int[] MyReverse(int[] array)
            {
                int lengthArray = array.Length;
                int[] tmpArr = new int[lengthArray];

                for (int i = 0; i < lengthArray; i++)
                {
                    tmpArr[i] = array[lengthArray - i - 1];
                }

                return tmpArr;
            }

            Console.ReadKey();
        }
    }
}
