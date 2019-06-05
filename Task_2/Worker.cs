using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Worker
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public Worker(string name, int age, int salary)
        {
            this.Name = name;

            this.Age = age;

            this.Salary = salary;
        }
    }
}
