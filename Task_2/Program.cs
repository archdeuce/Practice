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
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            students.Add("Vasya Pupkin", new Student("Vasya", "Pupkin", 1, "PR-115", "Programming"));
            students.Add("Petya Pyatochkin", new Student("Petya", "Pyatochkin", 4, "PR-415", "Programming"));
            students.Add("Semen Sidorov", new Student("Semen", "Sidorov", 3, "OT-315", "Electronics repair"));

            foreach (var selectedStudent in students)
            {
                Console.WriteLine(selectedStudent.ToString());
            }

            Console.WriteLine($"\nNumber of students: {students.Count}");

            Console.WriteLine("\nRemove students[\"Petya Pyatochkin\"].\n");

            students.Remove("Petya Pyatochkin");

            foreach (var selectedStudent in students)
            {
                Console.WriteLine(selectedStudent.ToString());
            }

            Console.WriteLine($"\nNumber of students: {students.Count}");

            Console.WriteLine($"Looking for [\"Petya Pyatochkin\"]: {students.ContainsKey("Petya Pyatochkin")}.");
            Console.WriteLine($"Looking for [\"Vasya Pupkin\"]: {students.ContainsKey("Vasya Pupkin")}.");

            Console.ReadKey();
        }
    }
}
