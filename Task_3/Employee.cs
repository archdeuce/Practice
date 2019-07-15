using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Employee : IEquatable<Employee>
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public string Gender { get; private set; }

        public string Company { get; private set; }

        public Employee() { }

        public Employee(string firstName, string lastName, int age, string gender, string company)

        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.Company = company;
        }

        public override string ToString()
        {
            return String.Format("{0, -10} {1, -15} {2, -5} {3, -3} {4, -10}", this.FirstName, this.LastName, this.Age, this.Gender, this.Company);
        }

        public bool Equals(Employee obj)
        {
            if (obj == null)
                return false;

            return this.FirstName == obj.FirstName
                && this.LastName == obj.LastName
                && this.Age == obj.Age
                && this.Gender == obj.Gender
                && this.Company == obj.Company;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Employee);
        }

        public override int GetHashCode()
        {
            return (this.FirstName + this.LastName + this.Age + this.Gender + this.Company).GetHashCode();
        }
    }
}
