using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_9
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
            Task9();

            Console.ReadKey();
        }

        static public void Task1()
        {
            int x1 = 1;
            Console.WriteLine(x1);
        }

        static public void Task2()
        {
            string str1;
            Console.WriteLine("Your name?");
            str1 = Console.ReadLine();

            string str2 = "Hello " + str1;
            Console.WriteLine(str2);
        }

        static public void Task3()
        {
            var v1 = 'v';
            v1 = 'w';
            Console.WriteLine(v1);
        }

        static public void Task4()
        {
            Console.WriteLine("Enter the length of the side of the square:");
            string str = Console.ReadLine();
            int x = Int32.Parse(str);
            int p = 4 * x;
            Console.WriteLine($"The perimeter of a square with side {x} is {p}");
        }

        static public void Task5()
        {
            const decimal Pi = 3.14m;
            decimal r1 = 20.3m,
                    R2 = 11.8m,
                    s1, s2, s3;
            s1 = Pi * r1 * r1;
            s2 = Pi * R2 * R2;
            s3 = s1 - s2;

            Console.WriteLine($"Square s1 = {s1}, s2 = {s2}, s3 = {s3}");
        }

        static public void Task6()
        {
            Console.WriteLine("Enter a two-digit number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int pos1 = number / 10;
            int pos2 = number % 10;

            Console.WriteLine($"ten  = {pos1}, one = {pos2}");
        }

        static public void Task7()
        {
            int x = 11, y = 22;
            long z = x + y;
            Console.WriteLine($"x = {x}, y = {y}, z = x + y = {z}");
        }

        static public void Task8()
        {
            long a = 100500, b = 2353246532;
            byte c = (byte)(a * b);

            Console.WriteLine($"a * b = {c}");
        }

        static public void Task9()
        {
            int a = 5,
                b = 7,
                c;
            Console.WriteLine($"Variable values a = {a}, b = {b}");

            //c = a;
            //a = b;
            //b = c;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After exchange a = {a}, b = {b}");
        }
    }
}