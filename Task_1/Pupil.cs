using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Pupil
    {
        public int birthYear { get; set; }
        public int nowYear { get; set; }
        public int Age { get; set; }
        public int BirthYear { get; set; }
        public int NowYear { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SchoolNumber { get; set; }
        public string ClassID { get; set; }

        public Pupil()
        {
        }

        public Pupil(string name, string surname, int birthYear)
        {
            Name = name;
            Surname = surname;
            BirthYear = birthYear;
            NowYear = 2019;
            Age = NowYear - BirthYear;
        }
    }
}
