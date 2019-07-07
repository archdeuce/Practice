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
            List<Student> students = new List<Student>();

            students.Add(new Student("Vasya", "Pupkin", 1, "PR-115", "Programming"));
            students.Add(new Student("Petya", "Pyatochkin", 4, "PR-415", "Programming"));
            students.Add(new Student("Semen", "Sidorov", 3, "OT-315", "Electronics repair"));

            foreach (var selectedStudent in students)
            {
                Console.WriteLine(selectedStudent.ToString());
            }

            Console.WriteLine($"\nNumber of students: {students.Count}");

            Console.WriteLine("\nRemove student[0].\n");

            students.RemoveAt(0);

            foreach (var selectedStudent in students)
            {
                Console.WriteLine(selectedStudent.ToString());
            }

            Console.WriteLine($"\nNumber of students: {students.Count}");

            Console.ReadKey();
        }
    }
}
