using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
            //Task5();

            Console.ReadKey();
        }

        public static void Task1()
        {
            Console.Write("Number of array elements: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Enter space separated items: ");
            string input = Console.ReadLine();

            string[] arrStr = input.Split(' ');
            int[] arr = new int[k];

            bool isZero = true;

            for (int i = 0; i < k; i++)
            {
                arr[i] = Int32.Parse(arrStr[i]);

                for (int j = 0; j < arr[i]; j++)
                {
                    if (isZero == false)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }

                isZero = !isZero;
            }
        }

        public static void Task2()
        {
            string[] goods = { "Pears", "Apples", "Cucumbers", "Tomatoes", "Dill", "Parsley", "Chicken", "Cheese", "Butter", "Milk" };
            double[] price = { 40.50, 31.20, 21.80, 35.00, 150.00, 145.00, 200.00, 400.00, 81.40, 53.35 };

            for (int i = 0; i < goods.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {goods[i]} - {price[i]} uah.");
            }

            Console.WriteLine("\nEnter the item number, then the quantity. To exit, press \"0\".\n");

            double sum = 0;

            while (true)
            {
                int choice = 0,
                    quantity = 0;

                Console.Write("Product: ");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 0) break;

                Console.Write("Quantity: ");
                quantity = Int32.Parse(Console.ReadLine());

                sum += price[choice - 1] * quantity;
            }

            Console.WriteLine($"\nAmount to pay {sum} uah.");
        }

        public static void Task3()
        {
            Console.WriteLine("Conclusion of perfect numbers [1 - 1000]\n");

            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) sum += j;
                }

                if (i == sum) Console.Write($"{i} ");
            }
        }

        public static void Task4()
        {
            Console.WriteLine("Enter the message to encrypt:");
            string msg = Console.ReadLine();

            var encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };

            string output = "";

            for (int i = 0; i < msg.Length; i++)
            {
                bool isFind = false;

                for (int j = 0; j < encryptChars.Length; j++)
                {
                    if (msg[i] == encryptChars[j])
                    {
                        output += cipher[j];
                        isFind = true;
                        break;
                    }
                }

                if (isFind == false) output += cipher[10];
            }

            Console.WriteLine($"\nEncryption result:\n{output}");
        }

        public static void Task5()
        {
            Console.WriteLine("Enter the message to decrypt:");
            string msg = Console.ReadLine();

            var encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };

            string output = "";

            for (int i = 0; i < msg.Length; i++)
            {
                for (int j = 0; j < cipher.Length - 1; j++)
                {
                    if (msg[i] == cipher[j])
                    {
                        output += encryptChars[j];
                        break;
                    }
                }
            }

            Console.WriteLine($"\nDecryption result:\n{output}");
        }
    }
}
