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
            //Deferedexemple();
            Uneferedexemple();

            Console.ReadKey();
        }

        static void Deferedexemple()
        {
            List<Employee> employees = new List<Employee> {
                new Employee ("Rob1", "Starck1", "M"),
                new Employee ("Rob2", "Starck2", "M"),
                new Employee ("Rob3", "Starck3", "F"),
            };

            var maleEmployees = employees.Where(e => e.Gender == "M");

            Display(maleEmployees);
            Console.WriteLine(new string('-', 30));

            employees.Add(new Employee("Rob4", "Starck4", "M"));

            Display(maleEmployees);
        }

        static void Uneferedexemple()
        {
            List<Employee> employees = new List<Employee> {
                new Employee ("Rob1", "Starck1", "M"),
                new Employee ("Rob2", "Starck2", "M"),
                new Employee ("Rob3", "Starck3", "F"),
            };

            var maleEmployees = employees.Where(e => e.Gender == "M").ToList();

            Display(maleEmployees);
            Console.WriteLine(new string('-', 30));

            employees.Add(new Employee("Rob4", "Starck4", "M"));

            Display(maleEmployees);
        }

        static void Display(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.LastName}, {employee.FirstName}");

            }
        }
    }
}
