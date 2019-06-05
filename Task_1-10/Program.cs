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
            //Task7();
            //Task8();
            //Task9();
            Task10();

            Console.ReadKey();
        }

        public static void Task1()
        {
            Console.Write("Seconds = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int h = n / 3600;
            Console.WriteLine($"Hours = {h}");
        }

        public static void Task2()
        {
            Console.Write($"input A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"input B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"input C = ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (((a < b) && (b < c)) || ((a > b) && (b > c)))
            {
                Console.WriteLine("B is between A and C");
            }
            else
            {
                Console.WriteLine("B is not between A and C");
            }
        }

        public static void Task3()
        {
            Console.Write($"enter a positive integer number = ");
            int number = Convert.ToInt32(Console.ReadLine());

            if ((number > 99 && number < 1000) && (number % 2 == 1))
            {
                Console.WriteLine("the number is an odd three-digit number");
            }
            else
            {
                Console.WriteLine("the number is not an odd three-digit number");
            }
        }

        public static void Task4()
        {
            int x = 10,
                y = 12,
                z = 3;

            x += y - x++ * z;
            Console.WriteLine(x);

            z = --x - y * 5;
            Console.WriteLine(z);

            y /= x + 5 % z;
            Console.WriteLine(y);

            z = x++ + y * 5;
            Console.WriteLine(z);

            x = y - x++ * z;
            Console.WriteLine(x);
        }

        public static void Task5()
        {
            int operand1 = 10,
                operand2 = 20;
            Console.WriteLine($"operand1 = {operand1}\noperand2 = {operand2}");
            Console.Write("enter the sign of the arithmetic operation (+ - * /) : ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("cannot divide by zero");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{operand1} / {operand2} = {(double)operand1 / (double)operand2}");
                    }
                    break;
                default:
                    break;
            }
        }

        public static void Task6()
        {
            Console.Write("enter a number between 0 and 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0 || number > 100)
            {
                Console.WriteLine($"number {number} entered is out of range");
            }
            else if (number >= 0 && number <= 14)
            {
                Console.WriteLine($"number {number} is in this range [0-14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine($"number {number} is in this range [15-35]");
            }
            else if (number == 50)
            {
                Console.WriteLine($"number {number} is in this range [36-50] && [50-100]");
            }
            else if (number >= 36 && number < 50)
            {
                Console.WriteLine($"number {number} is in this range [36-50]");
            }
            else if (number > 50 && number <= 100)
            {
                Console.WriteLine($"number {number} is in this range [50-100]");
            }
        }

        public static void Task7()
        {
            Console.WriteLine("Enter the word in Russian on the topic \"weather\":");
            string input = Console.ReadLine();

            switch (input)
            {
                case "СЃРѕР»РЅРµС‡РЅРѕ":
                    Console.WriteLine("sunny");
                    break;
                case "РґРѕР¶РґСЊ":
                    Console.WriteLine("rain");
                    break;
                case "СЃРЅРµРі":
                    Console.WriteLine("snow");
                    break;
                case "Р±РµР·РјРѕСЂРѕР·РЅР°СЏ":
                    Console.WriteLine("frost-free");
                    break;
                case "РјРѕСЂРѕР·РЅР°СЏ":
                    Console.WriteLine("frosty");
                    break;
                case "РѕР±Р»Р°С‡РЅР°СЏ":
                    Console.WriteLine("cloudy");
                    break;
                case "РїР°СЃРјСѓСЂРЅР°СЏ":
                    Console.WriteLine("overcast");
                    break;
                case "РјРµСЂР·РєР°СЏ":
                    Console.WriteLine("nasty");
                    break;
                case "С‡СѓРґРµСЃРЅР°СЏ":
                    Console.WriteLine("wonderful");
                    break;
                case "РЅРµРїСЂРµРґСЃРєР°Р·СѓРµРјР°СЏ":
                    Console.WriteLine("unpredictable");
                    break;
                default:
                    Console.WriteLine("There is no such word in the dictionary.");
                    break;
            }
        }

        public static void Task8()
        {
            Console.WriteLine("Enter employee salary:");
            int salary = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many years does the employee work?");
            int years = Int32.Parse(Console.ReadLine());

            if (years >= 0 && years <= 4)
            {
                Console.WriteLine($"[0 - 4] years - 10% employee bonus = {(double)salary * 0.1}");
            }
            else if (years >= 5 && years <= 9)
            {
                Console.WriteLine($"[5 - 9] years - 15% employee bonus = {(double)salary * 0.15}");
            }
            else if (years >= 10 && years <= 14)
            {
                Console.WriteLine($"[10 - 14] years - 25% employee bonus = {(double)salary * 0.25}");
            }
            else if (years >= 15 && years <= 19)
            {
                Console.WriteLine($"[15 - 19] years - 35% employee bonus = {(double)salary * 0.35}");
            }
            else if (years >= 20 && years <= 24)
            {
                Console.WriteLine($"[20 - 24] years - 45% employee bonus = {(double)salary * 0.45}");
            }
            else
            {
                Console.WriteLine($"[25+] years - 50% employee bonus = {(double)salary * 0.50}");
            }
        }

        public static void Task9()
        {
            while (true)
            {
                Console.Clear();

                int operand1,
                    operand2;

                Console.Write("enter operand1: ");
                if (!Int32.TryParse(Console.ReadLine(), out operand1))
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input!");
                    continue;
                }

                Console.Write("enter operand2: ");
                if (!Int32.TryParse(Console.ReadLine(), out operand2))
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input!");
                    continue;
                }

                Console.Clear();
                Console.WriteLine($"operand1 = {operand1}\noperand2 = {operand2}");

                string sign;

                while (true)
                {
                    Console.WriteLine("input + - * /");
                    sign = Console.ReadLine();

                    if (sign == "+" || sign == "-" || sign == "*" || sign == "/")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong input!");
                    }
                }

                switch (sign)
                {
                    case "+":
                        Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                        break;
                    case "-":
                        Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                        break;
                    case "*":
                        Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                        break;
                    case "/":
                        if (operand2 == 0)
                        {
                            Console.WriteLine("cannot divide by zero");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{operand1} / {operand2} = {(double)operand1 / (double)operand2}");
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine("any key to continue or EXIT to exit the program");
                string tmp = Console.ReadLine();

                if (tmp == "exit" || tmp == "EXIT") break;
            }
        }

        public static void Task10()
        {
            Console.WriteLine("input n!");
            int n = Convert.ToInt32(Console.ReadLine());
            long res = 1;

            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }

            Console.WriteLine($"{n}! = {res}");
        }
    }
}