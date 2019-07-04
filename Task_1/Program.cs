using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public delegate int SomeDelegate(int operand1, int operand2);

    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 1;
            int operand2 = 2;
            int sum = 0;

            SomeDelegate del = delegate (int a, int b)
            {
                sum = a + b;
                return sum;
            };

            sum = del(operand1, operand2);
            operand1 = 5;
            sum = del(operand1, operand2);

            Console.WriteLine($"Operand1 = {operand1}");
            Console.WriteLine($"Operand2 = {operand2}");
            Console.WriteLine($"Sum = {sum}");

            Console.ReadKey();
        }

        //public static void SomeMethod()
        //{
        //    Console.WriteLine("Hello World");
        //}
    }
}
