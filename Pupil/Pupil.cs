using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupil
{
    public class Pupil
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int BirthYear { get; set; }

        public int NowYear { get; set; }

        public int SchoolNumber { get; set; }

        public string ClassID { get; set; }

        public Pupil() { }

        public Pupil(string name, string surname, int birthYear)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthYear = birthYear;
            this.NowYear = DateTime.Now.Year;
            this.Age = NowYear - BirthYear;
        }
    }
}
