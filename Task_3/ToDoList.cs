using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ToDoList
    {
        private Queue<string> taskList;

        public int Count
        {
            get
            {
                return this.taskList.Count;
            }
        }

        public ToDoList()
        {
            this.taskList = new Queue<string>();
        }

        public void AddTask(string newTask)
        {
            taskList.Enqueue(newTask);
        }

        public string CompleteTask()
        {
            taskList.Dequeue();

            return "Done.";
        }

        public void ViewLastTask(string newTask)
        {
            taskList.Peek();
        }

        public override string ToString()
        {
            string tasks = string.Empty;

            foreach (var task in taskList)
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
