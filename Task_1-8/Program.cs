using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_8
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
            Task8();

            Console.ReadKey();
        }

        public static void Task1()
        {
            int uberflu = 1;
            int _Identifier = 2;
            int u006Identifier = 3;
            int myVar = 4;
            int myVariab1le = 5;
        }

        public static void Task2()
        {
            decimal pi = 3.141592653m;
            decimal e = 2.7182818284590452m;

            Console.WriteLine($"pi = {pi}");
            Console.WriteLine($"e = {e}");
        }

        public static void Task3()
        {
            string first = "\nмоя строка 1",
                    second = "\tмоя строка 2",
                    third = "\aмоя строка 3";

            Console.WriteLine($"first = {first}");
            Console.WriteLine($"second = {second}");
            Console.WriteLine($"third = {third}");
        }

        public static void Task4()
        {
            short num1 = 10;
            short num2 = 15;

            Console.WriteLine($"{num1} + {num2} = {Program.Sum((int)num1, (int)num2)}");

            Console.ReadKey();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        public static void Task5()
        {
            int i1 = 455;
            int i2 = 84500;
            decimal dec = 7.98845m;

            //
            // From int to short .
            //
            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);

            //
            // From decimal to int.
            //
            Console.WriteLine((int)dec);
        }

        public static void Task6()
        {
            int a = 10,
                b = 15,
                c = 33;

            double res = (a + b + c) / 3;

            Console.WriteLine($"({a} + {b} + {c}) / 3 = {res}");
        }

        public static void Task7()
        {
            const double Pi = 3.14;
            int r = 10;
            double res = Pi * r * r;

            Console.WriteLine($"{Pi} * {r}^2 = {res}");
        }

        public static void Task8()
        {
            const double Pi = 3.14;
            int h = 10,
                r = 3;
            double v = Pi * r * 2 * h;

            Console.WriteLine($"V = {v}");
        }
    }
}