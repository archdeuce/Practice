using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Student : User
    {
        private int scholarship;

        private double rate;

        public int Scholarship
        {
            get
            {
                return this.scholarship;
            }
            set
            {
                this.scholarship = value;
            }
        }

        public double Rate
        {
            get
            {
                return this.rate;
            }
            set
            {
                this.rate = value;
            }
        }

        public Student(string name, int age, int scholarship, double rate) :
            base(name, age)
        {
            this.Scholarship = scholarship;

            this.Rate = rate;
        }
    }
}
