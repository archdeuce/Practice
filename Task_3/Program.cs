using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создать 2 массива Employee. - 
             * Объединить обе коллекции в одну с повторениями. - 
             * Объединить две коллекции в одну без повторений. - 
             * Вывести на консоль только сотрудников, которые есть в обеих коллекциях. - 
             * Переделать массив в список и добавить еще один элемент. 
             */

            Employee[] firstGroup =
            {
                new Employee("Evgenia", "Gladysheva", 32, "F", "Intetics"),
                new Employee("Elena", "Zub", 21, "F", "Intetics"),
                new Employee("Anton", "Isaev", 29, "M", "Epam"),
                new Employee("Alexandr", "Matsegora", 25, "M", "Intetics"),
                new Employee("Kirill", "Novikov", 34, "M", "Sigma"),
                new Employee("Olga", "Pavlenko", 35, "F", "Intetics"),
                new Employee("Vladislav", "Radchenko", 23, "M", "Intetics"),
                new Employee("Tatiana", "Ryzhik", 34, "F", "Epam")
            };

            Employee[] secondGroup =
            {
                new Employee("Evgenia", "Gladysheva", 32, "F", "Intetics"),
                new Employee("Elena", "Zub", 21, "F", "Intetics"),
                new Employee("Anton", "Isaev", 29, "M", "Epam"),
                new Employee("Artem", "Kravchenko", 24, "M", "Intetics"),
                new Employee("Valeriy", "Malinovskiy", 31, "M", "Sigma"),
                new Employee("Alexandr", "Matsegora", 25, "M", "Intetics"),
                new Employee("Kirill", "Novikov", 34, "M", "Sigma"),
                new Employee("Olga", "Pavlenko", 35, "F", "Intetics"),
            };

            Separator();
            var resultConcat = firstGroup.Concat(secondGroup);
            Console.WriteLine($"We combine both collections into one with repetitions({resultConcat.Count()}):");
            Display(resultConcat);

            var resultUnion = firstGroup.Union(secondGroup);
            Console.WriteLine($"We combine two collections into one without repetitions({resultUnion.Count()}):");
            Display(resultUnion);

            var resultIntersect = firstGroup.Intersect(secondGroup);
            Console.WriteLine($"Display on the console only employees who are in both collections({resultIntersect.Count()}):");
            Display(resultIntersect);

            var resultList = resultUnion.ToList();
            resultList.Add(new Employee("Harry", "Potter", 12, "M", "Hogwarts"));
            Console.WriteLine($"We remake an array into the list and add one more element({resultList.Count()}):");
            Display(resultList);

            Console.ReadKey();
        }

        public static void Display(IEnumerable<Employee> employee)
        {
            Separator();

            foreach (var selected in employee)
            {
                Console.WriteLine(selected);
            }

            Separator();
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

        public static void Separator()
        {
            Console.WriteLine(new string('-', 87));
        }
    }
}