using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ivan = new Student("Ivan", 17, 500, 26.5);

            Console.WriteLine($"Student {ivan.Name} receives a scholarship {ivan.Scholarship / ivan.Rate} $.");

            Console.ReadKey();
        }
    }
}
