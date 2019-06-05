using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Worker : User
    {
        private int salary;

        public int Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value > 0)
                    this.salary = value;
            }
        }

        public Worker(string name, int age, int salary) :
            base(name, age)
        {
            this.Salary = salary;
        }
    }
}