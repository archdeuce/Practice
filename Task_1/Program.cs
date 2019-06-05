using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker ivan = new Worker("Ivan", 25, 1000);
            Worker vasya = new Worker("Vasya", 26, 2000);

            int sumSalary = ivan.salary + vasya.salary;
            int sumAge = ivan.age + vasya.age;

            Console.WriteLine($"The amount of salaries of Ivan and Vasya {sumSalary}.");
            Console.WriteLine($"The sum of the ages of Ivan and Vasya {sumAge}.");

            Console.ReadKey();
        }
    }
}
