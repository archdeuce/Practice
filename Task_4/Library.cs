using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Library
    {
        private Stack<string> bookList;

        public int Count
        {
            get
            {
                return this.bookList.Count;
            }
        }

        public Library()
        {
            this.bookList = new Stack<string>();
        }

        public void TakeBook(string newTask)
        {
            bookList.Push(newTask);
        }

        public string ReturnBook()
        {
            bookList.Pop();

            return "Done.";
        }

        public void ViewNameLastBook(string newTask)
        {
            bookList.Peek();
        }

        public override string ToString()
        {
            string tasks = string.Empty;

            foreach (var task in bookList)
            {
                tasks += task + "\n";
            }

            if (tasks == string.Empty)
                return "No tasks.";
            else
                return tasks;
        }
    }
}
