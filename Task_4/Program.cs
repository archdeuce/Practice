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
            Student student = new Student("Vasya", "Pupkin", 4, "PR-415", "Programming");

            student.bookList.TakeBook("Mathematics.");
            student.bookList.TakeBook("Informatics.");
            student.bookList.TakeBook("English.");

            int books = student.bookList.Count;

            Console.WriteLine($"Student's list of books({books}):");
            Console.WriteLine(student.bookList.ToString());

            Console.WriteLine("Let's bring all the books back before you think of something to read :)");

            for (int i = 0; i < books; i++)
            {
                Console.WriteLine(student.bookList.ReturnBook());
            }

            Console.WriteLine($"Number of books on the shelf: {student.bookList.Count}.");

            Console.ReadKey();
        }
    }
}
