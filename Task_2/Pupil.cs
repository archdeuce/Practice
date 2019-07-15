using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Pupil
    {
        public string FirstName { get; private set; }

        public string SecondName { get; private set; }

        public int School { get; private set; }

        public Pupil(string firstName, string secondName, int school)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.School = school;
        }

        public override string ToString()
        {
            string head = String.Format("{0, -10} {1, -15} {2, -5}\n", "FirstName", "SecondName", "School");
            string content = String.Format("{0, -10} {1, -15} {2, -5}", this.FirstName, this.SecondName, this.School);

            return head + content;
        }
    }
}
