using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver ivan = new Driver("Ivan", 50, 1000, 20, DrivingCategory.C);

            Console.WriteLine($"The driver {ivan.Name} has the category {ivan.DriverCategory}.");

            Console.ReadKey();
        }
    }
}
