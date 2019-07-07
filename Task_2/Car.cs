using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Car
    {
        public string Name { get; private set; }
        public int Year { get; private set; }

        public Car(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }

        public override string ToString()
        {
            return $"{this.Name}({this.Year})\n";
        }

        public override bool Equals(object checkObj)
        {
            var tmp = checkObj as Car;

            if (tmp == null)
                return false;

            return (this.Name == tmp.Name) && (this.Year == tmp.Year);
        }
    }
}