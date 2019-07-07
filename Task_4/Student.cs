using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Student
    {
        private string Name { get; set; }

        private string Surname { get; set; }

        private int Course { get; set; }

        private string Group { get; set; }

        private string Faculty { get; set; }

        public Library bookList;

        public Student(string name, string surname, int course, string group, string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Course = course;
            this.Group = group;
            this.Faculty = faculty;
            this.bookList = new Library();
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Surname} - {this.Course} - {this.Group} - {this.Faculty}";
        }
    }
}
