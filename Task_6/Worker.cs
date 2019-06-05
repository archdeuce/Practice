using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Worker
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ((value > 0) && (value < 101))
                    age = value;
            }
        }

        public Worker(string name, int age, int salary)
        {
            this.Name = name;

            this.Age = age;

            this.Salary = salary;
        }
    }
}
