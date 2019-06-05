using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
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
                arr[i] = rnd.Next(0, 10);
                Console.Write($"{arr[i]} ");
            }

            int[] arrNew1 = new int[n + 1];
            arrNew1 = incArrLength1(arr);

            Console.WriteLine("\n\nNew array (length +1):");

            for (int i = 0; i < arrNew1.Length; i++)
            {
                Console.Write($"{arrNew1[i]} ");
            }

            Console.Write("\n\nEnter value to add in array on [0] position for new array: ");
            int m = int.Parse(Console.ReadLine());

            int[] arrNew2 = new int[n + 1];
            arrNew2 = incArrLength2(arr, m);

            Console.WriteLine("\nNew array + shift:");

            for (int i = 0; i < arrNew2.Length; i++)
            {
                Console.Write($"{arrNew2[i]} ");
            }

            //
            // The function of increasing the length of the array by one. 
            //
            int[] incArrLength1(int[] array)
            {
                int[] arrTmp = new int[array.Length + 1];

                for (int i = 0; i < arr.Length; i++)
                {
                    arrTmp[i] = array[i];
                }

                return arrTmp;
            }

            //
            // The function of increasing the length of the array by one and add elements to the right. 
            //
            int[] incArrLength2(int[] array, int value)
            {
                int[] arrTmp = new int[array.Length + 1];

                arrTmp[0] = value;

                for (int i = 0; i < array.Length; i++)
                {
                    arrTmp[i + 1] = array[i];
                }

                return arrTmp;
            }

            Console.ReadKey();
        }
    }
}
