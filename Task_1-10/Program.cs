using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            Task10();

            Console.ReadKey();
        }

        public static void Task1()
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
        }

        public static void Task2()
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
        }

        public static void Task3()
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

            Console.WriteLine("\n\nDisplaying indexes of values in a range min << arr[i] << max):");

            for (int i = 0; i < n; i++)
            {
                if ((arr[i] > min) && (arr[i] < max)) Console.WriteLine($"i = {i} ");
            }
        }

        public static void Task4()
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
        }

        public static void Task5()
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
        }

        public static void Task6()
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

            Console.WriteLine("\n\nР’С‹РІРѕРґ SubArray:");

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
        }

        public static void Task7()
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
        }

        public static void Task8()
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
        }

        public static void Task9()
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
        }

        public static void Task10()
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
        }
    }
}
