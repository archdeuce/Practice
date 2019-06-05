using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_20
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
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            //Task15();
            //Task16();
            //Task17();
            //Task18();
            //Task19();
            Task20();

            Console.ReadKey();
        }

        public static void Task1()
        {
            //
            // Calculate factorial using a cycle.
            //
            Console.WriteLine("input n!");
            int n = Convert.ToInt32(Console.ReadLine());
            long res = 1;

            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }

            Console.WriteLine($"{n}! = {res}");
        }

        public static void Task2()
        {
            //
            // Drawing shapes in the console.
            //
            Console.Write("Select the shape to draw:\n1 - Line.\n2 - Rectangle.\n3 - Right triangle.\n4 - Equilateral triangle.\n5 - Rhomb.\n: ");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    //
                    // Line.
                    //            
                    Console.Write("Enter the length of the line: ");
                    int lengthLine = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < lengthLine; i++)
                    {
                        Console.Write('*');
                    }
                    break;
                case 2:
                    //
                    // Rectangle.
                    //
                    Console.WriteLine("Enter the length of the First and Second side: ");
                    int lengthSide1 = Convert.ToInt32(Console.ReadLine());
                    int lengthSide2 = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < lengthSide2; j++)
                    {
                        for (int i = 0; i < lengthSide1; i++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    //
                    // Right triangle.
                    //
                    Console.Write("Enter the length of the side of the triangle: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                    break;
                case 4:
                    //
                    // Equilateral triangle.
                    //
                    Console.Write("Enter the height of side equilateral triangle: ");
                    int h = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= h; i++)
                    {
                        for (int j = h; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j < 2 * i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    //
                    // Rhomb.
                    //
                    int m = Convert.ToInt32(Console.ReadLine());
                    int z = 1;

                    for (int i = 0; i < m / 2 + 1; i++)
                    {
                        int prob = (m - z) / 2;
                        for (int j = 0; j < prob; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < z; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                        z = z + 2;
                    }
                    z = m - 2;

                    for (int i = m / 2; i > 0; i--)
                    {
                        int prob = (m - z) / 2;
                        for (int j = 0; j < prob; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < z; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        z = z - 2;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid value entered!");
                    break;
            }
        }

        public static void Task3()
        {
            Console.Write("Input the number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            //
            // Check for positive or negative.
            //
            if (number > 0)
            {
                Console.WriteLine("\nA positive number has been entered.");
            }
            else if (number < 0)
            {
                Console.WriteLine("\nA negative number is entered.");
            }
            else
            {
                Console.WriteLine("\nThe number zero is neither positive or negative, and therefore has no sign.");
            }

            //
            // Is the number simple.
            //
            int count = 0;

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0) count++;
            }

            if (count > 0)
            {
                Console.WriteLine("\nThe number entered is not a simple one.");
            }
            else
            {
                Console.WriteLine("\nThe number entered is simple.");
            }

            //
            // Is divided into 2, 3, 5, 6, 9 without a residue.
            //
            string output = "";

            if (number % 2 == 0) output += " 2";
            if (number % 3 == 0) output += " 3";
            if (number % 5 == 0) output += " 5";
            if (number % 6 == 0) output += " 6";
            if (number % 9 == 0) output += " 9";

            if (output != "")
            {
                Console.WriteLine("\nInput the number divided without remainder by" + output + ".");
            }
        }

        public static void Task4()
        {
            //
            // Calculating the number of routes.
            //
            Console.Write("Enter the number of customers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            do
            {
                count *= n--;
            } while (n > 0);

            Console.WriteLine($"There are {count} possible routes.");
        }

        public static void Task5()
        {
            Console.WriteLine("Input A and B (A < B): ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            //
            // The sum of all those between A and B. 
            //
            int sum = 0;

            for (int i = a + 1; i < b; i++)
            {
                sum += i;
            }

            Console.WriteLine($"\nThe sum of the numbers between A and B is equal to {sum}.");

            //
            // Print all odd values вЂ‹вЂ‹between these numbers.
            //
            string output = "";

            for (int i = a + 1; i < b; i++)
            {
                if (i % 2 == 1)
                {
                    output += Convert.ToString(i) + " ";
                }
            }

            if (output != "")
            {
                Console.WriteLine($"\nThe odd values are between A and B: " + output);
            }
        }

        public static void Task6()
        {
            //
            // Given a natural number. Determine the number of even digits in it.
            //
            Console.Write("Input natural number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int quantity = 0;

            while (number > 0)
            {
                if (number % 10 % 2 == 0) quantity++;
                number /= 10;
            }

            Console.WriteLine($"The number of even digits in the given number is equal to {quantity}");
        }

        public static void Task7()
        {
            //
            // We consider the arithmetic average of all integers from a to b (the values вЂ‹вЂ‹of a and b are entered from the keyboard (b> = a).
            //
            Console.WriteLine("Input B and A (b >=a):");
            int b = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0,
                count = 0;

            for (int i = b; i >= a; i--)
            {
                sum += i;
                count++;
            }

            double arithmeticAverage = sum / (double)count;

            Console.WriteLine($"The average arithmetic from A to B is equal to {arithmeticAverage}");
        }

        public static void Task8()
        {
            int countDays = 1;

            double tmp = 0,
                   previousDay = 10,
                   totalMileage = 10;

            while (totalMileage < 100)
            {
                tmp = previousDay + previousDay * 0.1;
                totalMileage += tmp;
                previousDay = tmp;
                countDays++;
            }

            Console.WriteLine($"The skier went his way in {countDays} days.");
        }

        public static void Task9()
        {
            //
            // The program finds the product number without using the multiplication operation.
            //
            Console.WriteLine("Enter the numbers X and Y:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int res = 0;

            Console.Write($"{x} * {y} = ");

            if ((x > 0 && y > 0) || (x < 0 && y > 0))
            {
                while (y != 0)
                {
                    y--;
                    res += x;
                }
            }
            else
            {
                while (y != 0)
                {
                    y++;
                    res -= x;
                }
            }

            Console.WriteLine(res);
        }

        public static void Task10()
        {
            //
            // Squares of positive integers not exceeding a given number N.
            //
            Console.Write("Input the number N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int res = 1,
                i = 2;

            while (res < n)
            {
                Console.Write($"{res} ");
                res = i * i;
                i++;
            }
        }

        public static void Task11()
        {
            //
            // The program displays all Fibonacci numbers up to K.
            //
            Console.Write("Input the number k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int prev = 1,
                next = 1,
                sum = 0;

            Console.Write($"{prev} {next} ");

            while (k > (prev + next))
            {
                sum = prev + next;
                prev = next;
                next = sum;
                Console.Write($"{sum} ");
            }
        }

        public static void Task12()
        {
            //
            // The program displays the entered number of Fibonacci numbers.
            //
            Console.Write("Enter the quantity of Fibonacci numbers to be output k > 0: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int prev = 1,
                next = 1,
                sum = 0;

            if (k == 1)
            {
                Console.Write($"{prev}");
                k = 0;
            }
            else if (k >= 2)
            {
                Console.Write($"{prev} {next} ");
                k -= 2;
            }

            while (k > 0)
            {
                sum = prev + next;
                prev = next;
                next = sum;
                k--;
                Console.Write($"{sum} ");
            }
        }

        public static void Task13()
        {
            //
            // Reverse number.
            //
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int r = 0;

            while (n > 0)
            {
                r *= 10;
                r += n % 10;
                n /= 10;
            }

            Console.Write(r);
        }

        public static void Task14()
        {
            //
            // We display in order all the numbers that are included in the number.
            //
            Console.Write("Enter the number: ");
            long n = Convert.ToInt64(Console.ReadLine()),
                n2 = n,
                k = 1;

            while (n2 >= 10)
            {
                n2 /= 10;
                k *= 10;
            }

            Console.WriteLine("The number consists of such numbers: ");

            while (k > 0)
            {
                long tmp = n / k % 10;
                k /= 10;
                Console.Write($"{tmp} ");
            }
        }

        public static void Task15()
        {
            //
            // Raise the number k to the power n.
            //
            Console.Write("Enter the number K: ");
            double k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number N: ");
            double n = Convert.ToInt32(Console.ReadLine());

            double res = 0;

            if (n == 0)
            {
                res = 1;
            }
            else if (n > 0)
            {
                res = k;

                for (int i = 1; i < n; i++)
                {
                    res *= k;
                }
            }
            else
            {
                res = 1;

                for (int i = 0; i > n; i--)
                {
                    res /= k;
                }

            }

            Console.WriteLine($"{k} ^ {n} = {res}");
        }

        public static void Task16()
        {
            //
            // Remove the specified number from the natural number.
            //

            Console.Write("Enter number: ");
            long n = Convert.ToInt64(Console.ReadLine());

            Console.Write("Numeral to delete: ");
            int m = Convert.ToInt32(Console.ReadLine());

            long n2 = n,
                 k = 1;

            while (n2 >= 10)
            {
                n2 /= 10;
                k *= 10;
            }

            while (k > 0)
            {
                long tmp = n / k % 10;
                k /= 10;

                if (tmp != m)
                {
                    Console.Write(tmp);
                }
            }
        }

        public static void Task17()
        {
            //
            // Find the largest digit of the number.
            //

            Console.Write("Enter number: ");
            long n = Convert.ToInt64(Console.ReadLine()),
                max = 0;

            while (n > 0)
            {
                long tmp = n % 10;
                n /= 10;

                if (max < tmp)
                {
                    max = tmp;
                }
            }
            Console.Write($"Maximum digit {max}.");
        }

        public static void Task18()
        {
            //
            // Testing the Syracuse hypothesis.
            //
            Console.Write("Enter number: ");
            long n = Convert.ToInt64(Console.ReadLine());

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = (n * 3 + 1) / 2;
                }
            }

            Console.Write($"n = {n}");
        }

        public static void Task19()
        {
            //
            // Guess the number with hints.
            //
            Random rndObj = new Random();
            int rndNumber = rndObj.Next(1, 11);

            while (true)
            {
                Console.Write("Guess the number [1-10]: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());

                if (inputNumber != rndNumber)
                {
                    if (inputNumber > rndNumber)
                    {
                        Console.WriteLine("The guess number is less than the entered one.");
                    }
                    else
                    {
                        Console.WriteLine("The guess number is greater than the entered one.");
                    }
                }
                else
                {
                    Console.WriteLine($"Right!");
                    break;
                }
            }
        }

        public static void Task20()
        {
            //
            // The sum of the n-th number of elements in the series:
            // S = 1 / 2 - 2 / 4 + 3 / 8 - 4 / 16 + ... - ...
            //
            Console.Write("Enter the number N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double s = 0,
                   k = 2;

            for (double i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    s += i / k;
                }
                else
                {
                    s -= i / k;
                }

                k *= 2;
            }

            Console.WriteLine($"s = {s}");
        }
    }
}