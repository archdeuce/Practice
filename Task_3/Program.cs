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
            Student student = new Student("Vasya", "Pupkin", 4, "PR-415", "Programming");

            student.taskList.AddTask("Oversleep.");
            student.taskList.AddTask("Late to study.");
            student.taskList.AddTask("Drink a beer.");
            student.taskList.AddTask("Play the game Dota 2.");

            int tasks = student.taskList.Count;

            Console.WriteLine($"Student's list of tasks({tasks}):");
            Console.WriteLine(student.taskList.ToString());

            Console.WriteLine("Let's do everything on the list of :)");

            for (int i = 0; i < tasks; i++)
            {
                Console.WriteLine(student.taskList.CompleteTask());
            }

            Console.WriteLine($"Number of tasks remaining: {student.taskList.Count}.");

            Console.ReadKey();
        }
    }
}
