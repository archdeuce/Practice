using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation[] operations = new Operation[]
            {
                new Sum(10, 20),
                new Sub(30, 20),
                new Mul(30, 30),
                new Div(40, 5)
            };

            foreach (var item in operations)
            {
                Console.WriteLine(new String('-', 61));

                item.ToString();

                Console.WriteLine($"Result = {item.Calculate()}");
            }

            Console.ReadKey();
        }
    }
}