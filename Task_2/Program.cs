using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ourGroup = new List<Employee>
            {
                new Employee("Evgenia", "Gladysheva", 23, "F", "Intetics"),
                new Employee("Elena", "Zub", 21, "F", "Intetics"),
                new Employee("Anton", "Isaev", 29, "M", "Epam"),
                new Employee("Artem", "Kravchenko", 24, "M", "Intetics"),
                new Employee("Valeriy", "Malinovskiy", 31, "M", "Sigma"),
                new Employee("Oleg", "Reshetilo", 30, "M", "Intetics"),
                new Employee("Kirill", "Novikov", 34, "M", "Sigma"),
                new Employee("Olga", "Pavlenko", 35, "F", "Intetics"),
                new Employee("Vladislav", "Radchenko", 23, "M", "Intetics"),
                new Employee("Tatiana", "Ryzhik", 34, "F", "Epam")
            };

            Display(ourGroup);

            Console.WriteLine("Output to the console a list of all employees in alphabetical order:");
            Display(ourGroup.OrderBy(student => student.FirstName).ToList());

            Console.WriteLine("Conclusion to the console of all employees who are aged > 30 years:");
            Display(ourGroup.Where(student => student.Age >= 30).ToList());

            Console.WriteLine("Conclusion on the console only men:");
            Display(ourGroup.Where(student => student.Gender == "M").ToList());

            Console.WriteLine("Conclusion on the console only women:");
            Display(ourGroup.Where(student => student.Gender == "F").ToList());

            Console.WriteLine("Conclusion to the console the Name and Surname of all employees:");
            var selectNameSurname = ourGroup.Select(student => String.Format("{0, -10} {1, -15}", student.FirstName, student.LastName)).ToList();
            Display(selectNameSurname);

            Console.WriteLine("Conclusion to the console the names of women whose name begins on \'O\' and over 20:");
            Display(ourGroup.Where(student => student.Gender == "F" && student.FirstName.StartsWith("O")).ToList());

            Console.WriteLine("Output to the console the number of employees of each one company:");

            var companyGroup = ourGroup.GroupBy(employee => employee.Company).ToList();
            Display(companyGroup);

            Console.WriteLine($"Output to the console of the first employee:");
            Console.WriteLine(ourGroup.First().ToString());
            Separator();

            Console.WriteLine($"Output to the console of the last employee:");
            Console.WriteLine(ourGroup.Last().ToString());
            Separator();

            Console.WriteLine($"Output to the console of the first employee with an age over 25:");
            Console.WriteLine(ourGroup.Where(student => student.Age >= 30).First().ToString());
            Separator();

            var pupilOleg = ourGroup.Where(student => student.FirstName == "Oleg").Select(student => new Pupil(student.FirstName, student.LastName, 666)).First();

            Console.WriteLine($"Choose from employees the one whose name is Oleg and create a new object of type Pupil:");
            Separator();
            Console.WriteLine(pupilOleg.ToString());
            Separator();

            Console.ReadKey();
        }

        public static void Display(List<Employee> employee)
        {
            Separator();

            foreach (var selected in employee)
            {
                Console.WriteLine(selected);
            }

            Separator();
        }

        public static void Display(List<IGrouping<string, Employee>> company)
        {
            Separator();

            foreach (var selected in company)
            {
                Console.WriteLine(String.Format("{0, -10} {1, -15}", selected.Key, selected.Count()));
            }

            Separator();
        }

        public static void Display(List<string> selectNameSurname)
        {
            Separator();

            foreach (var item in selectNameSurname)
            {
                Console.WriteLine(item);
            }

            Separator();
        }

        public static void Separator()
        {
            Console.WriteLine(new string('-', 87));
        }
    }
}