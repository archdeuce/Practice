using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public Employee()
        {
        }

        public Employee(string name, string surname, string gender)
        {
            this.FirstName = name;
            this.LastName = surname;
            this.Gender = gender;
        }
    }
}
